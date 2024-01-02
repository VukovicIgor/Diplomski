using Diplomski.cls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplomski.frm.pitanja
{
    public partial class frmMigracije : Form
    {
        BazaDiplomskog bd = new BazaDiplomskog();
        BazaDiplomskogTableAdapters.NASELJETableAdapter naseljeAdapter = new BazaDiplomskogTableAdapters.NASELJETableAdapter();
        BazaDiplomskogTableAdapters.OPSTINATableAdapter opstinaAdapter = new BazaDiplomskogTableAdapters.OPSTINATableAdapter();
        BazaDiplomskogTableAdapters.DRZAVETableAdapter drzaveAdapter = new BazaDiplomskogTableAdapters.DRZAVETableAdapter();
        BazaDiplomskogTableAdapters.tmp_MIGRACIJETableAdapter tmp_migracijeAdapter = new BazaDiplomskogTableAdapters.tmp_MIGRACIJETableAdapter();
        BazaDiplomskogTableAdapters.NSTJ2TableAdapter nstj2Adapter = new BazaDiplomskogTableAdapters.NSTJ2TableAdapter();
        BazaDiplomskogTableAdapters.UPRAVNI_OKRUGTableAdapter upravniOkrugAdapter = new BazaDiplomskogTableAdapters.UPRAVNI_OKRUGTableAdapter();
        BazaDiplomskogTableAdapters.QueriesTableAdapter brisanje = new BazaDiplomskogTableAdapters.QueriesTableAdapter();

        int id;
        int id_popisivaca;
        List<string> listaOpstina = new List<string>();
        List<string> listaOpstinaKIM = new List<string>();
        List<string> listaDrzava = new List<string>();
        string drzavljanstvo;
        public frmMigracije(int id, int id_popisivaca)
        {
            InitializeComponent();
            brisanje.brisanje_tmp_migracije(id_popisivaca);
            naseljeAdapter.Fill(bd.NASELJE);
            opstinaAdapter.Fill(bd.OPSTINA);
            drzaveAdapter.Fill(bd.DRZAVE);
            tmp_migracijeAdapter.Fill(bd.tmp_MIGRACIJE);
            nstj2Adapter.Fill(bd.NSTJ2);
            upravniOkrugAdapter.Fill(bd.UPRAVNI_OKRUG);

            MessageBoxManager.Yes = "Da";
            MessageBoxManager.No = "Ne";
            MessageBoxManager.Register();
            this.id = id;
            this.id_popisivaca = id_popisivaca;
            dtp5_2.CustomFormat = " ";
            dtp6_2.CustomFormat = " ";
            dtp7_2od.CustomFormat = " ";
            dtp7_2do.CustomFormat = " ";
            dtp5_2.MaxDate = DateTime.Today;
            dtp6_2.MaxDate = DateTime.Today;
            dtp7_2do.MaxDate = DateTime.Today;
            dtp7_2od.MaxDate = DateTime.Today.AddYears(-1);
            dtp7_2do.MinDate = dtp7_2od.Value.AddYears(1);

            Dodaj_opstine();
            Ucitavanje_drzava();
            foreach(string o in listaOpstina)
            {
                cmb3Opstina.Items.Add(o);
                cmb4Opstina.Items.Add(o);
                cmb5_1Opstina.Items.Add(o);
            }
            foreach (string o in listaOpstinaKIM)
            {
                cmb6_1Opstina.Items.Add(o);
            }
            foreach(string d in listaDrzava)
            {
                cmb3Drzava.Items.Add(d);
                cmb4Drzava.Items.Add(d);
                cmb5_1Drzava.Items.Add(d);
                cmb7_1Drzava.Items.Add(d);
                cmb8Drzava.Items.Add(d);
            }

        }
        private void cb3Srbija_CheckedChanged(object sender, EventArgs e)
        {
            if (cb3Srbija.Checked)
            {
                cb3Drzava.Checked = false;
                cmb3Opstina.Enabled = true;
                cmb3Naselje.Enabled = true;
                cmb3Opstina.SelectedIndex = 0;
                cmb3Naselje.SelectedIndex = 0;
                lb4.Enabled = true;
            }
            else
            {
                cmb3Opstina.Enabled = false;
                cmb3Naselje.Enabled = false;
                cmb3Opstina.Text = null;
                cmb3Naselje.Text = null;
                lb4.Enabled = false;
            }
        }
        private void cb3Drzava_CheckedChanged(object sender, EventArgs e)
        {
            if (cb3Drzava.Checked)
            {
                cb3Srbija.Checked = false;
                cmb3Drzava.Enabled = true;
                cmb3Drzava.SelectedIndex = 0;
                lb4.Enabled = true;
            }
            else
            {
                cmb3Drzava.Enabled = false;
                cmb3Drzava.Text = null;
                lb4.Enabled = false;
            }
        }
        private void cmb3Opstina_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ucitavanje_naselja(cmb3Opstina, cmb3Naselje);
        }
        private void lb4_EnabledChanged(object sender, EventArgs e)
        {
            if (lb4.Enabled)
            {
                cb4Drzava.Enabled = true;
                cb4Srbija.Enabled = true;
            }
            else
            {
                cb4Drzava.Checked = false;
                cb4Srbija.Checked = false;
                cb4Drzava.Enabled = false;
                cb4Srbija.Enabled = false;
            }
        }
        private void cb4Srbija_CheckedChanged(object sender, EventArgs e)
        {
            if (cb4Srbija.Checked)
            {
                cb4Drzava.Checked = false;
                cmb4Opstina.Enabled = true;
                cmb4Naselje.Enabled = true;
                cmb4Opstina.SelectedIndex = 0;
                cmb4Naselje.SelectedIndex = 0;
                lb5.Enabled = true;
            }
            else
            {
                cmb4Opstina.Enabled = false;
                cmb4Naselje.Enabled = false;
                cmb4Opstina.Text = null;
                cmb4Naselje.Text = null;
                lb5.Enabled = false;
            }
        }
        private void cmb4Opstina_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ucitavanje_naselja(cmb4Opstina, cmb4Naselje);
        }
        private void cb4Drzava_CheckedChanged(object sender, EventArgs e)
        {
            if (cb4Drzava.Checked)
            {
                cb4Srbija.Checked = false;
                cmb4Drzava.Enabled = true;
                cmb4Drzava.SelectedIndex = 0;
                lb5.Enabled = true;
            }
            else
            {
                cmb4Drzava.Enabled = false;
                cmb4Drzava.Text = null;
                lb5.Enabled = false;
            }
        }
        private void lb5_EnabledChanged(object sender, EventArgs e)
        {
            if (lb5.Enabled)
            {
                cb5Da.Enabled = true;
                cb5Ne.Enabled = true;
            }
            else
            {
                cb5Da.Checked = false;
                cb5Ne.Checked = false;
                cb5Da.Enabled = false;
                cb5Ne.Enabled = false;
            }
        }
        private void cb5Da_CheckedChanged(object sender, EventArgs e)
        {
            if (cb5Da.Checked)
            {
                cb5Ne.Checked = false;
                lb7.Enabled = true;
                lb7opis.Enabled = true;
                lb5_2.Enabled = false;
            }
            else
            {
                lb7.Enabled = false;
                lb7opis.Enabled = false;
            }
        }
        private void cb5Ne_CheckedChanged(object sender, EventArgs e)
        {
            if (cb5Ne.Checked)
            {
                cb5Da.Checked = false;
                lb5_1.Enabled = true;
            }
            else
            {
                lb5_1.Enabled = false;
            }
        }
        private void lb5_1_EnabledChanged(object sender, EventArgs e)
        {
            if(lb5_1.Enabled)
            {
                cb5_1Ne.Enabled = true;
                cb5_1Srbija.Enabled = true;
                cb5_1Drzava.Enabled = true;
            }
            else
            {
                cb5_1Ne.Enabled = false;
                cb5_1Ne.Checked = false;
                cb5_1Srbija.Enabled = false;
                cb5_1Srbija.Checked = false;
                cb5_1Drzava.Enabled = false;
                cb5_1Drzava.Checked = false;
            }
        }

        private void cb5_1Ne_CheckedChanged(object sender, EventArgs e)
        {
            if (cb5_1Ne.Checked)
            {
                lb7.Enabled = true;
                cb5_1Drzava.Checked = false;
                cb5_1Srbija.Checked = false;
            }
            else
            {
                lb7.Enabled = false;
            }
        }

        private void cb5_1Srbija_CheckedChanged(object sender, EventArgs e)
        {
            if (cb5_1Srbija.Checked)
            {
                cb5_1Ne.Checked = false;
                cb5_1Drzava.Checked = false;
                cmb5_1Opstina.Enabled = true;
                cmb5_1Naselje.Enabled = true;
                cmb5_1Opstina.SelectedIndex = 0;
                cmb5_1Naselje.SelectedIndex = 0;
                lb5_2.Enabled = true;
            }
            else
            {
                cmb5_1Opstina.Enabled = false;
                cmb5_1Naselje.Enabled = false;
                cmb5_1Opstina.Text = null;
                cmb5_1Naselje.Text = null;
                lb5_2.Enabled = false;
            }
        }
        private void cmb5_1Opstina_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ucitavanje_naselja(cmb5_1Opstina, cmb5_1Naselje);
        }

        private void cb5_1Drzava_Click(object sender, EventArgs e)
        {
            if(cb5_1Drzava.Checked)
            {
                cb5_1Ne.Checked = false;
                cb5_1Srbija.Checked = false;
                lb5_2.Enabled = true;
            }
            else
            {
                lb5_2.Enabled = false;
            }
        }
        private void cb5_1Drzava_CheckedChanged(object sender, EventArgs e)
        {
            if (cb5_1Drzava.Checked)
            {
                cb5_1Ne.Checked = false;
                cb5_1Srbija.Checked = false;
                cmb5_1Drzava.Enabled = true;
                cmb5_1Drzava.SelectedIndex = 0;
                lb5_2.Enabled = true;
            }
            else
            {
                cmb5_1Drzava.Enabled = false;
                cmb5_1Drzava.Text = null;
                lb5_2.Enabled = false;
            }
        }

        private void lb5_2_EnabledChanged(object sender, EventArgs e)
        {
            if(lb5_2.Enabled)
            {
                dtp5_2.Enabled = true;
                dtp5_2.Format = DateTimePickerFormat.Short;
                lb5_3.Enabled = true;
            }
            else
            {
                dtp5_2.Enabled = false;
                dtp5_2.Format = DateTimePickerFormat.Custom;
                lb5_3.Enabled = false;
            }
        }
        private void lb5_3_EnabledChanged(object sender, EventArgs e)
        {
            if (lb5_3.Enabled)
            {
                clb5_3.Enabled = true;
            }
            else
            {
                clb5_3.Enabled = false;
                for (int i = 0; i < clb5_3.Items.Count; i++)
                {
                    clb5_3.SetItemCheckState(i, CheckState.Unchecked);
                    clb5_3.SetSelected(i, false);
                }
            }
        }
        private void clb5_3_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int brojac = 0;
            for (int i = 0; i < clb5_3.Items.Count; i++)
            {
                if (i != e.Index) clb5_3.SetItemChecked(i, false);
                if (clb5_3.GetItemChecked(i) == false)
                    brojac++;
            }
            if (brojac == 5)
                lb6.Enabled = false;
            else
                lb6.Enabled = true;

        }

        private void lb6_EnabledChanged(object sender, EventArgs e)
        {
            if(lb6.Enabled)
            {
                cb6Da.Enabled = true;
                cb6Ne.Enabled = true;
            }
            else
            {
                cb6Da.Enabled = false;
                cb6Ne.Enabled = false;
                cb6Da.Checked = false;
                cb6Ne.Checked = false;
                lb6_1.Enabled = false;
            }
        }
        private void cb6Da_CheckedChanged(object sender, EventArgs e)
        {
            if(cb6Da.Checked)
            {
                cb6Ne.Checked = false;
                lb6_1.Enabled = true;
            }
            else
            {
                lb6_1.Enabled = false;
            }
        }
        private void lb6_1_EnabledChanged(object sender, EventArgs e)
        {
            if(lb6_1.Enabled)
            {
                cmb6_1Opstina.Enabled = true;
                cmb6_1Naselje.Enabled = true;
                cmb6_1Opstina.SelectedIndex = 0;
                cmb6_1Naselje.SelectedIndex = 0;
                lb6_2.Enabled = true;
            }
            else
            {
                cmb6_1Opstina.SelectedIndex = -1;
                cmb6_1Naselje.SelectedIndex = -1;
                cmb6_1Opstina.Enabled = false;
                cmb6_1Naselje.Enabled = false;
                lb6_2.Enabled = false;
            }
        }
        private void cmb6_1Opstina_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ucitavanje_naselja(cmb6_1Opstina, cmb6_1Naselje);
        }

        private void lb6_2_EnabledChanged(object sender, EventArgs e)
        {
            if(lb6_2.Enabled)
            {
                dtp6_2.Enabled = true;
                dtp6_2.Format = DateTimePickerFormat.Short;
                lb7.Enabled = true;
            }
            else
            {
                dtp6_2.Enabled = false;
                dtp6_2.Format = DateTimePickerFormat.Custom;
                lb7.Enabled = false;
            }
        }
        private void cb6Ne_CheckedChanged(object sender, EventArgs e)
        {
            if (cb6Ne.Checked)
            {
                cb6Da.Checked = false;
                lb7.Enabled = true;
            }
            else
            {
                lb7.Enabled = false;
            }
        }

        private void lb7_EnabledChanged(object sender, EventArgs e)
        {
            if (lb7.Enabled)
            {
                lb7opis.Enabled = true;
                clb7.Enabled = true;
            }
            else
            {
                lb7opis.Enabled = false;
                clb7.Enabled = false;
                for (int i = 0; i < clb7.Items.Count; i++)
                {
                    clb7.SetItemCheckState(i, CheckState.Unchecked);
                    clb7.SetSelected(i, false);
                }
            }
        }

        private void clb7_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int i = 0; i < clb7.Items.Count; i++)
            {
                if (i != e.Index)
                {
                    clb7.SetItemChecked(i, false);
                }
            }
            if ((clb7.GetItemChecked(e.Index) == false && e.Index == 1) || (clb7.GetItemChecked(e.Index) == false && e.Index == 2))
            {
                lb8.Enabled = true;
            }
            else if ((clb7.GetItemChecked(e.Index) == true && e.Index == 1) || (clb7.GetItemChecked(e.Index) == true && e.Index == 2))
            {
                lb8.Enabled = false;
            }
            else if (clb7.GetItemChecked(e.Index) == false && e.Index == 0)
            {
                lb7_1.Enabled = true;
            }
            else if (clb7.GetItemChecked(e.Index) == true && e.Index == 0)
            {
                lb7_1.Enabled = false;
            }
        }

        private void lb7_1_EnabledChanged(object sender, EventArgs e)
        {
            if (lb7_1.Enabled)
            {
                cmb7_1Drzava.Enabled = true;
                cmb7_1Drzava.SelectedIndex = 0;
                lb7_2.Enabled = true;
            }
            else
            {
                cmb7_1Drzava.SelectedIndex = -1;
                cmb7_1Drzava.Enabled = false;
                lb7_2.Enabled = false;
            }
        }
        private void lb7_2_EnabledChanged(object sender, EventArgs e)
        {
            if(lb7_2.Enabled)
            {
                lb7_2Od.Enabled = true;
                lb7_2Do.Enabled = true;
                dtp7_2od.Enabled = true;
                dtp7_2od.Format = DateTimePickerFormat.Short;
                dtp7_2do.Enabled = true;
                dtp7_2do.Format = DateTimePickerFormat.Short;
                lb7_3.Enabled = true;
            }
            else
            {
                lb7_2Od.Enabled = false;
                lb7_2Do.Enabled = false;
                dtp7_2od.Enabled = false;
                dtp7_2od.Format = DateTimePickerFormat.Custom;
                dtp7_2do.Enabled = false;
                dtp7_2do.Format = DateTimePickerFormat.Custom;
                lb7_3.Enabled = false;
            }
        }
        private void dtp7_2od_ValueChanged(object sender, EventArgs e)
        {
            dtp7_2do.MinDate = dtp7_2od.Value.AddYears(1);
        }

        private void lb7_3_EnabledChanged(object sender, EventArgs e)
        {
            if (lb7_3.Enabled)
            {
                clb7_3.Enabled = true;
            }
            else
            {
                clb7_3.Enabled = false;
                for (int i = 0; i < clb7_3.Items.Count; i++)
                {
                    clb7_3.SetItemCheckState(i, CheckState.Unchecked);
                    clb7_3.SetSelected(i, false);
                }
            }
        }
        private void clb7_3_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int i = 0; i < clb7_3.Items.Count; ++i)
            {
                if (i != e.Index)
                {
                    clb7_3.SetItemChecked(i, false);
                }
                if (clb7_3.GetItemChecked(e.Index) == false)
                {
                    lb8.Enabled = true;
                }
                else
                {
                    lb8.Enabled = false;
                }
            }
        }
        private void lb8_EnabledChanged(object sender, EventArgs e)
        {
            if(lb8.Enabled)
            {
                clb8.Enabled = true;
            }
            else
            {
                clb8.Enabled = false;
                for (int i = 0; i < clb8.Items.Count; i++)
                {
                    clb8.SetItemCheckState(i, CheckState.Unchecked);
                    clb8.SetSelected(i, false);
                }
            }
        }
        private void clb8_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            drzavljanstvo = string.Empty;
            for (int i = 0; i < clb8.Items.Count; i++)
            {
                if (i != e.Index)
                {
                    clb8.SetItemChecked(i, false);
                }
            }
            if (clb8.GetItemChecked(e.Index) == false)
            {
                if (e.Index == 0)
                {
                    drzavljanstvo = "Republika Srbija";
                    cmb8Drzava.Enabled = false;
                    btnDalje.Enabled = true;
                }
                else if (e.Index == 1)
                {
                    drzavljanstvo = "Republika Srbija/" + cmb8Drzava.Text;
                    cmb8Drzava.Enabled = true;
                    btnDalje.Enabled = true;
                }
                else if (e.Index == 2)
                {
                    drzavljanstvo = cmb8Drzava.Text;
                    cmb8Drzava.Enabled = true;
                    btnDalje.Enabled = true;
                }
                else if (e.Index == 3)
                {
                    drzavljanstvo = clb8.Items[e.Index].ToString();
                    cmb8Drzava.Enabled = false;
                    btnDalje.Enabled = true;
                }
            }
            else
            {
                drzavljanstvo = string.Empty;
                cmb8Drzava.Enabled = false;
                btnDalje.Enabled = false;
            }
        }
        private void cmb8Drzava_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb8Drzava.Enabled)
            {
                if (drzavljanstvo.Contains("Srbija"))
                    drzavljanstvo = "Republika Srbija/" + cmb8Drzava.Text;
                else
                    drzavljanstvo = cmb8Drzava.Text;
            }
        }
        private void cmb8Drzava_EnabledChanged(object sender, EventArgs e)
        {
            if (cmb8Drzava.Enabled)
            {
                cmb8Drzava.SelectedIndex = 0;
            }
            else
            {
                cmb8Drzava.SelectedIndex = -1;
            }

        }
        private void btnDalje_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Da li ste sigurni?", "Unos", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                BazaDiplomskog.tmp_MIGRACIJERow red = bd.tmp_MIGRACIJE.Newtmp_MIGRACIJERow();
                red.id_popisivac = id_popisivaca;
                red.id_osobe = id;
                if(cb3Srbija.Checked)
                {
                    red.pitanje3_mesto = cmb3Opstina.Text;
                    red.pitanje3_naselje = cmb3Naselje.Text;
                }
                if (cb3Drzava.Checked)
                    red.pitanje3_drzava = cmb3Drzava.Text;
                if (cb4Srbija.Checked)
                    red.pitanje4 = cmb4Opstina.Text;
                if (cb4Drzava.Checked)
                    red.pitanje4 = cmb4Drzava.Text;
                if (cb5Da.Checked)
                    red.pitanje5 = "Da";
                if (cb5Ne.Checked)
                    red.pitanje5 = "Ne";
                if (cb5_1Ne.Checked)
                    red.pitanje5_1 = "Ne";
                if (cb5_1Srbija.Checked)
                    red.pitanje5_1 = cmb5_1Opstina.Text + "/" + cmb5_1Naselje.Text;
                if (cb5_1Drzava.Checked)
                    red.pitanje5_1 = cmb5_1Drzava.Text;
                if (dtp5_2.Enabled)
                    red.pitanje5_2 = dtp5_2.Value.ToString("dd/MM/yyyy");
                if (clb5_3.Enabled)
                    red.pitanje5_3 = clb5_3.SelectedItem.ToString();
                if (cb6Da.Checked)
                    red.pitanje6 = "Da";
                if(cb6Ne.Checked)
                    red.pitanje6 = "Ne";
                if (cmb6_1Opstina.Enabled)
                    red.pitanje6_1 = cmb6_1Opstina.Text + "/" + cmb6_1Naselje.Text;
                if(dtp6_2.Enabled)
                    red.pitanje6_2 = dtp6_2.Value.ToString("dd/MM/yyyy");
                if (clb7.Enabled)
                    red.pitanje7 = clb7.SelectedItem.ToString();
                if (cmb7_1Drzava.Enabled)
                    red.pitanje7_1 = cmb7_1Drzava.Text;
                if (dtp7_2od.Enabled && dtp7_2do.Enabled)
                    red.pitanje7_2 = dtp7_2od.Value.ToString("dd/MM/yyyy") + "-" + dtp7_2do.Value.ToString("dd/MM/yyyy");
                if (clb8.Enabled)
                    red.pitanje8 = drzavljanstvo;
                bd.tmp_MIGRACIJE.Addtmp_MIGRACIJERow(red);
                tmp_migracijeAdapter.Update(bd.tmp_MIGRACIJE);
                MessageBoxManager.Unregister();
                frmBracniStatusFertilitet forma = new frmBracniStatusFertilitet(id, id_popisivaca);
                this.Hide();
                forma.ShowDialog();
                this.Close();
            }
        }

        private void svaPitanjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPitanja frm = new frmPitanja();
            frm.ShowDialog();
        }

        private void početnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Da li želite da se vratite na početnu stranu?", "Početna", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MessageBoxManager.Unregister();
                frmPocetna frm = new frmPocetna(id_popisivaca);
                this.Hide();
                frm.ShowDialog();
                this.Close();
            }
        }
        private void Dodaj_opstine()
        {
            listaOpstinaKIM = (from o in bd.OPSTINA
                               where (from uo in bd.UPRAVNI_OKRUG
                                      where uo.sifra_nstj2.Equals((from ns in bd.NSTJ2
                                                                   where ns.id_nstj2 == 4
                                                                   select ns.sifra_oblasti).FirstOrDefault())
                                      select uo.sifra_okruga).Contains(o.sifra_okruga)
                               select o.naziv).ToList();

            listaOpstina = (from o in bd.OPSTINA
                            select o.naziv
                            ).ToList();

        }
        private void Ucitavanje_naselja(ComboBox opstina, ComboBox naselje)
        {
            var sifra_opstine = (from o in bd.OPSTINA
                                 where o.naziv.Contains(opstina.Text)
                                 select o.sifra_opstine).FirstOrDefault();

            var naselja = (from n in bd.NASELJE
                           where n.sifra_opstine == sifra_opstine
                           select n);

            if (naselja.Any())
            {
                naselje.DataSource = naselja.CopyToDataTable();
                naselje.DisplayMember = "naziv";
            }
        }
        private void Ucitavanje_drzava()
        {
            listaDrzava = (from n in bd.DRZAVE
                           select n.naziv).ToList();
        }


    }
}

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
    public partial class frmObrazovanje : Form
    {
        int id;
        int id_popisivaca;
        BazaDiplomskog bd = new BazaDiplomskog();
        BazaDiplomskogTableAdapters.tmp_OBRAZOVANJETableAdapter tmp_obrazovanjeAdapter = new BazaDiplomskogTableAdapters.tmp_OBRAZOVANJETableAdapter();
        BazaDiplomskogTableAdapters.OPSTINATableAdapter opstinaAdapter = new BazaDiplomskogTableAdapters.OPSTINATableAdapter();
        BazaDiplomskogTableAdapters.NASELJETableAdapter naseljeAdapter = new BazaDiplomskogTableAdapters.NASELJETableAdapter();
        BazaDiplomskogTableAdapters.DRZAVETableAdapter drzavaAdapter = new BazaDiplomskogTableAdapters.DRZAVETableAdapter();
        BazaDiplomskogTableAdapters.QueriesTableAdapter brisanje = new BazaDiplomskogTableAdapters.QueriesTableAdapter();
        List<string> pitanje18 = new List<string>();
        string tmp;
        public frmObrazovanje(int id, int id_popisivaca)
        {
            InitializeComponent();
            this.id = id;
            this.id_popisivaca = id_popisivaca;
            MessageBoxManager.Yes = "Da";
            MessageBoxManager.No = "Ne";
            MessageBoxManager.Register();
            opstinaAdapter.Fill(bd.OPSTINA);
            naseljeAdapter.Fill(bd.NASELJE);
            drzavaAdapter.Fill(bd.DRZAVE);
            brisanje.brisanje_tmp_obrazovanje(id_popisivaca);
        }
        private void clb15_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            UncheckAll(clb16);
            Uncheck(clb15, e);
            if ((clb15.SelectedIndex == 0 || clb15.SelectedIndex == 1) && clb16.SelectedIndex == 0)
            {
                lb17.Enabled = true;
            }
            else
            {
                lb17.Enabled = false;
            }
        }

        private void clb16_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            Uncheck(clb16, e);
            if ((clb15.SelectedIndex == 0 || clb15.SelectedIndex == 1) && clb16.SelectedIndex == 0)
            {
                lb17.Enabled = true;
            }
            else
            {
                lb17.Enabled = false;
            }
            if (!clb16.GetItemChecked(e.Index) && e.Index != 0)
            {
                lb16_1.Enabled = true;
            }
            else
            {
                lb16_1.Enabled = false;
            }
        }

        private void lb16_1_EnabledChanged(object sender, EventArgs e)
        {
            if(lb16_1.Enabled)
            {
                cb16_1Srbija.Enabled = true;
                cb16_1Drzava.Enabled = true;
            }
            else
            {
                cb16_1Srbija.Enabled = false;
                cb16_1Drzava.Enabled = false;
            }
        }

        private void cb16_1Srbija_CheckedChanged(object sender, EventArgs e)
        {
            if (cb16_1Srbija.Checked)
            {
                cb16_1Drzava.Checked = false;
                cmb16_1Opstina.Enabled = true;
                cmb16_1Naselje.Enabled = true;
                txt16_1Naziv.Enabled = true;
                txt16_1Ulica.Enabled = true;
                txt16_1Broj.Enabled = true;
                lb16_1Naziv.Enabled = true;
                lb16_1Adresa.Enabled = true;
            }
            else
            {
                cmb16_1Opstina.Enabled = false;
                cmb16_1Naselje.Enabled = false;
                txt16_1Naziv.Enabled = false;
                txt16_1Naziv.Text = " ";
                txt16_1Ulica.Enabled = false;
                txt16_1Ulica.Text = " ";
                txt16_1Broj.Enabled = false;
                txt16_1Broj.Text = " ";
                lb16_1Naziv.Enabled = false;
                lb16_1Adresa.Enabled = false;
            }
        }
        private void txt16_1_TextChanged(object sender, EventArgs e)
        {
            if (txt16_1Broj.Text == string.Empty || txt16_1Naziv.Text == string.Empty || txt16_1Ulica.Text == string.Empty)
                lb16_2.Enabled = false;
            else
                lb16_2.Enabled = true;
        }

        private void cmb16_1Opstina_EnabledChanged(object sender, EventArgs e)
        {
            if (cmb16_1Opstina.Enabled)
            {
                cmb16_1Opstina.DisplayMember = "naziv";
                cmb16_1Opstina.SelectedIndex = 0;
            }
            else
            {
                cmb16_1Opstina.SelectedIndex = -1;
                cmb16_1Naselje.SelectedIndex = -1;
            }
        }

        private void cmb16_1Opstina_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sifra_opstine = (from o in bd.OPSTINA
                                 where o.naziv.Contains(cmb16_1Opstina.Text)
                                 select o.sifra_opstine).FirstOrDefault();

            var naselja = (from n in bd.NASELJE
                           where n.sifra_opstine == sifra_opstine
                           select n);

            if (naselja.Any())
            {
                cmb16_1Naselje.DataSource = naselja.CopyToDataTable();
                cmb16_1Naselje.DisplayMember = "naziv";
            }
        }

        private void frmObrazovanje_Load(object sender, EventArgs e)
        {
            var opstina =
                    (
                        from o in bd.OPSTINA
                        select o
                    );
            cmb16_1Opstina.DataSource = opstina.CopyToDataTable();
            cmb16_1Drzava.DataSource = bd.DRZAVE.CopyToDataTable();
        }

        private void cb16_1Drzava_CheckedChanged(object sender, EventArgs e)
        {
            if (cb16_1Drzava.Checked)
            {
                cb16_1Srbija.Checked = false;
                cmb16_1Drzava.Enabled = true;
                cmb16_1Drzava.DisplayMember = "naziv";
                cmb16_1Drzava.SelectedIndex = 0;
                lb16_1Drzava.Enabled = true;
                lb16_2.Enabled = true;
            }
            else
            {
                cmb16_1Drzava.Enabled = false;
                lb16_1Drzava.Enabled = false;
                lb16_2.Enabled = false;
                cmb16_1Drzava.SelectedIndex = -1;
            }
        }

        private void lb16_2_EnabledChanged(object sender, EventArgs e)
        {
            if (lb16_2.Enabled)
                clb16_2.Enabled = true;
            else
                UncheckAll(clb16_2);
        }

        private void clb16_2_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            Uncheck(clb16_2, e);
            if (!clb16_2.GetItemChecked(e.Index))
                lb18.Enabled = true;
            else
                lb18.Enabled = false;
        }

        private void lb18_EnabledChanged(object sender, EventArgs e)
        {
            if (lb18.Enabled)
                clb18.Enabled = true;
            else
            {
                UncheckAll(clb18);
                pitanje18.Clear();
            }
        }

        private void clb18_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.Index == 3)
            {
                for (int i = 0; i < clb18.Items.Count; ++i)
                    if (i != e.Index) clb18.SetItemChecked(i, false);
            }
            else
            {
                clb18.SetItemChecked(3, false);
            }
            if (!clb18.GetItemChecked(e.Index))
            {
                pitanje18.Add(clb18.Items[e.Index].ToString());
            }
            else
            {
                pitanje18.Remove(clb18.Items[e.Index].ToString());
            }
        }

        private void lb17_EnabledChanged(object sender, EventArgs e)
        {
            if (lb17.Enabled)
                clb17.Enabled = true;
            else
                clb17.Enabled = false;
        }

        private void clb17_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            Uncheck(clb17, e);
            if (!clb17.GetItemChecked(e.Index))
                lb18.Enabled = true;
            else
                lb18.Enabled = false;
        }

        private void btnDalje_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Da li ste sigurni?", "Unos", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                BazaDiplomskog.tmp_OBRAZOVANJERow red = bd.tmp_OBRAZOVANJE.Newtmp_OBRAZOVANJERow();
                red.id_osobe = id;
                red.id_popisivac = id_popisivaca;
                if (clb15.SelectedItem != null)
                    red.pitanje_15 = clb15.SelectedItem.ToString();
                if (clb16.SelectedItem != null)
                    red.pitanje_16 = clb16.SelectedItem.ToString();
                if (cb16_1Srbija.Checked)
                {
                    red.pitanje_16_1opstina = cmb16_1Opstina.Text;
                    red.pitanje_16_1naselje = cmb16_1Naselje.Text;
                    red.pitanje_16_1naziv = txt16_1Naziv.Text;
                    red.pitanje_16_1ulica = txt16_1Ulica.Text;
                    red.pitanje_16_1broj = txt16_1Broj.Text;
                }
                if (cb16_1Drzava.Checked)
                    red.pitanje_16_1drzava = cmb16_1Drzava.Text;
                if (clb16_2.Enabled)
                    red.pitanje_16_2 = clb16_2.SelectedItem.ToString();
                if (clb17.Enabled)
                    red.pitanje_17 = clb17.SelectedItem.ToString();
                if (clb18.Enabled)
                {
                    foreach (string s in pitanje18)
                        if (pitanje18.Count != 1)
                            tmp += s + ", ";
                        else
                            tmp = s;
                    red.pitanje_18 = tmp;
                }
                bd.tmp_OBRAZOVANJE.Addtmp_OBRAZOVANJERow(red);
                tmp_obrazovanjeAdapter.Update(bd.tmp_OBRAZOVANJE);
                MessageBoxManager.Unregister();
                frmEkonomskaAktivnost frm = new frmEkonomskaAktivnost(id, id_popisivaca);
                this.Hide();
                frm.ShowDialog();
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

        private void Uncheck(CheckedListBox clb, ItemCheckEventArgs e)
        {
            for (int i = 0; i < clb.Items.Count; ++i)
                if (i != e.Index) clb.SetItemChecked(i, false);
        }
        private void UncheckAll(CheckedListBox clb)
        {
            clb.ClearSelected();
            for (int i = 0; i < clb.Items.Count; ++i)
                clb.SetItemChecked(i, false);
            if (clb.Name!= "clb16")
            {
                clb.Enabled = false;
            }
        }
    }
}

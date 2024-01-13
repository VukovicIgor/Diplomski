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
    public partial class frmEkonomskaAktivnost : Form
    {
        int id;
        int id_popisivaca;
        BazaDiplomskog bd = new BazaDiplomskog();
        BazaDiplomskogTableAdapters.NASELJETableAdapter naseljeAdapter = new BazaDiplomskogTableAdapters.NASELJETableAdapter();
        BazaDiplomskogTableAdapters.OPSTINATableAdapter opstinaAdapter = new BazaDiplomskogTableAdapters.OPSTINATableAdapter();
        BazaDiplomskogTableAdapters.DRZAVETableAdapter drzaveAdapter = new BazaDiplomskogTableAdapters.DRZAVETableAdapter();
        BazaDiplomskogTableAdapters.tmp_EKONOMSKA_AKTIVNOSTTableAdapter tmp_ekonomAdapter = new BazaDiplomskogTableAdapters.tmp_EKONOMSKA_AKTIVNOSTTableAdapter();
        BazaDiplomskogTableAdapters.QueriesTableAdapter brisanje = new BazaDiplomskogTableAdapters.QueriesTableAdapter();
        //int brojac = 0;
        string odgovor26 = "";
        public frmEkonomskaAktivnost(int id, int id_popisivaca)
        {
            InitializeComponent();
            foreach (Control c in Controls)
            {
                if (!c.Name.Contains("19") && !c.Name.Contains("menuStrip1"))
                    c.Enabled = false;
            }
            brisanje.brisanje_tmp_eko_aktivnost(id_popisivaca);
            btnDalje.Enabled = true;
            tv26.ExpandAll();
            MessageBoxManager.Yes = "Da";
            MessageBoxManager.No = "Ne";
            MessageBoxManager.Register();
            naseljeAdapter.Fill(bd.NASELJE);
            opstinaAdapter.Fill(bd.OPSTINA);
            drzaveAdapter.Fill(bd.DRZAVE);
            tmp_ekonomAdapter.Fill(bd.tmp_EKONOMSKA_AKTIVNOST);
            this.id = id;
            this.id_popisivaca = id_popisivaca;
            
        }
        private void cb19Ne_CheckedChanged(object sender, EventArgs e)
        {
            if(cb19Ne.Checked)
            {
                cb19Da.Checked = false;
                lb20.Enabled = true;
                cb20Da.Enabled = true;
                cb20Ne.Enabled = true;
            }
            else
            {
                lb20.Enabled = false;
                cb20Da.Enabled = false;
                cb20Ne.Enabled = false;
            }
        }
        private void cb19Da_CheckedChanged(object sender, EventArgs e)
        {
            if(cb19Da.Checked)
            {
                cb19Ne.Checked = false;
                lb24.Enabled = true;
                lb24opis.Enabled = true;
                txt24.Enabled = true;
            }
            else
            {
                lb24.Enabled = false;
                lb24opis.Enabled = false;
                txt24.Enabled = false;
            }
        }
        private void cb20Ne_CheckedChanged(object sender, EventArgs e)
        {
            if (cb20Ne.Checked)
            {
                cb20Da.Checked = false;
                lb21.Enabled = true;
                cb21Da.Enabled = true;
                cb21Ne.Enabled = true;
            }
            else
            {
                lb21.Enabled = false;
                cb21Da.Enabled = false;
                cb21Ne.Enabled = false;
            }
        }
        private void cb20Da_CheckedChanged(object sender, EventArgs e)
        {
            if (cb20Da.Checked)
            {
                cb20Ne.Checked = false;
                lb24.Enabled = true;
                lb24opis.Enabled = true;
                txt24.Enabled = true;
            }
            else
            {
                lb24.Enabled = false;
                lb24opis.Enabled = false;
                txt24.Enabled = false;
            }
        }
        private void lb20_EnabledChanged(object sender, EventArgs e)
        {
            if (lb20.Enabled == false)
            {
                cb20Da.Checked = false;
                cb20Ne.Checked = false;
                cb21Da.Checked = false;
                cb21Ne.Checked = false;
                cb22Da.Checked = false;
                cb22Ne.Checked = false;
            }
        }
        private void cb21Ne_CheckedChanged(object sender, EventArgs e)
        {
            if (cb21Ne.Checked)
            {
                cb21Da.Checked = false;
                lb23.Enabled = true;
                clb23.Enabled = true;
            }
            else
            {
                lb23.Enabled = false;
                clb23.Enabled = false;
            }
        }
        private void cb21Da_CheckedChanged(object sender, EventArgs e)
        {
            if (cb21Da.Checked)
            {
                cb21Ne.Checked = false;
                lb22.Enabled = true;
                cb22Da.Enabled = true;
                cb22Ne.Enabled = true;
            }
            else
            {
                lb22.Enabled = false;
                cb22Da.Enabled = false;
                cb22Ne.Enabled = false;
            }
        }
        private void lb21_EnabledChanged(object sender, EventArgs e)
        {
            cb21Da.Checked = false;
            cb21Ne.Checked = false;
            cb22Da.Checked = false;
            cb22Ne.Checked = false;
        }
        private void lb22_EnabledChanged(object sender, EventArgs e)
        {
            cb22Da.Checked = false;
            cb22Ne.Checked = false;
        }
        private void cb22Ne_CheckedChanged(object sender, EventArgs e)
        {
            if (cb22Ne.Checked)
            {
                cb22Da.Checked = false;
                lb23.Enabled = true;
                clb23.Enabled = true;
            }
            else
            {
                lb23.Enabled = false;
                clb23.Enabled = false;
            }
        }
        private void cb22Da_CheckedChanged(object sender, EventArgs e)
        {
            if (cb22Da.Checked)
            {
                cb22Ne.Checked = false;
            }
        }
        private void lb23_EnabledChanged(object sender, EventArgs e)
        {
            if (!lb23.Enabled)
            {
                for (int i = 0; i < clb23.Items.Count; ++i)
                    clb23.SetItemChecked(i, false);
            }
        }
        private void clb23_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int i = 0; i < clb23.Items.Count; ++i)
                if (i != e.Index) clb23.SetItemChecked(i, false);
            clb23.ClearSelected();
        }
        private void txt24_TextChanged(object sender, EventArgs e)
        {
            if (txt24.Text != string.Empty)
            {
                lb25.Enabled = true;
                clb25.Enabled = true;
            }
            else
            {
                lb25.Enabled = false;
                clb25.Enabled = false;
            }
        }
        private void lb24_EnabledChanged(object sender, EventArgs e)
        {
            txt24.Text = string.Empty;
        }
        private void clb25_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int i = 0; i < clb25.Items.Count; ++i)
                if (i != e.Index) clb25.SetItemChecked(i, false);
            if (clb25.CheckedItems.Count == 0)
            {
                lb26.Enabled = true;
                tv26.Enabled = true;
            }
            else
            {
                lb26.Enabled = false;
                tv26.Enabled = false;
            }
        }
        private void lb25_EnabledChanged(object sender, EventArgs e)
        {
            if(!lb25.Enabled)
            {
                for (int i = 0; i < clb25.Items.Count; ++i)
                    clb25.SetItemChecked(i, false);
            }
            clb25.ClearSelected();
        }
        private void tv26_BeforeCheck(object sender, TreeViewCancelEventArgs e)
        {
            for (int i = 0; i < tv26.Nodes.Count; i++)
            {
                if (tv26.Nodes[i].Name != e.Node.Name && tv26.Nodes[i].Checked == true && e.Node.Parent == null)
                {
                    tv26.Nodes[i].Checked = false;
                }
                for (int j = 0; j < tv26.Nodes[i].GetNodeCount(true); j++)
                {
                    if (tv26.Nodes[i].Nodes[j].Name != e.Node.Name && tv26.Nodes[i].Nodes[j].Checked == true)
                    {
                        tv26.Nodes[i].Nodes[j].Checked = false;
                    }
                    if (tv26.Nodes[i].Nodes[j].Name == e.Node.Name && tv26.Nodes[i].Checked != true)
                    {
                        tv26.Nodes[i].Checked = true;
                    }
                }
            }
        }
        private void tv26_AfterCheck(object sender, TreeViewEventArgs e)
        {
            for (int i = 0; i < tv26.Nodes.Count; i++)
            {
                if (tv26.Nodes[i].Checked)
                    odgovor26 = tv26.Nodes[i].Text;
                for (int j = 0; j < tv26.Nodes[i].GetNodeCount(true); j++)
                {
                    if (tv26.Nodes[i].Nodes[j].Checked)
                    {
                        odgovor26 += ": " + tv26.Nodes[i].Nodes[j].Text;
                    }
                }
            }
            for (int i = 0; i < tv26.Nodes.Count; i++)
            {
                for (int j = 0; j < tv26.Nodes[i].GetNodeCount(true); j++)
                {
                    switch(e.Node.Name)
                    {
                        case "grana1_1":
                            if (e.Node.Checked)
                            {
                                foreach (Control c in Controls)
                                {
                                    if (c.Name.Contains("27") || c.Name.Contains("29") || c.Name.Contains("32"))
                                    {
                                        c.Enabled = true;
                                    }
                                }
                            }
                            else
                            {
                                foreach (Control c in Controls)
                                {
                                    if (c.Name.Contains("27") || c.Name.Contains("29") || c.Name.Contains("32"))
                                    {
                                        c.Enabled = false;
                                    }
                                }
                            }
                            break;
                        case "grana1_2":
                            if (e.Node.Checked)
                            {
                                foreach (Control c in Controls)
                                {
                                    if (c.Name.Contains("29") || c.Name.Contains("32"))
                                    {
                                        c.Enabled = true;
                                    }
                                }
                            }
                            else
                            {
                                foreach (Control c in Controls)
                                {
                                    if (c.Name.Contains("29") || c.Name.Contains("32"))
                                    {
                                        c.Enabled = false;
                                    }
                                }
                            }
                            break;
                        case "grana1_3":
                            if (e.Node.Checked)
                            {
                                foreach (Control c in Controls)
                                {
                                    if (c.Name.Contains("27") || c.Name.Contains("28") || c.Name.Contains("29") || c.Name.Contains("30") ||  c.Name.Contains("32"))
                                    {
                                        c.Enabled = true;
                                    }
                                }
                            }
                            else
                            {
                                foreach (Control c in Controls)
                                {
                                    if (c.Name.Contains("27") || c.Name.Contains("28") || c.Name.Contains("29") || c.Name.Contains("30") || c.Name.Contains("32"))
                                    {
                                        c.Enabled = false;
                                    }

                                }
                            }
                            break;
                        case "grana1_4":
                            if (e.Node.Checked)
                            {
                                foreach (Control c in Controls)
                                {
                                    if (c.Name.Contains("29") || c.Name.Contains("30") || c.Name.Contains("32"))
                                    {
                                        c.Enabled = true;
                                    }
                                }
                            }
                            else
                            {
                                foreach (Control c in Controls)
                                {
                                    if (c.Name.Contains("29") || c.Name.Contains("30") || c.Name.Contains("32"))
                                    {
                                        c.Enabled = false;
                                    }
                                }
                            }
                            break;
                        case "grana2":
                            if (e.Node.Checked)
                            {
                                foreach (Control c in Controls)
                                {
                                    if (c.Name.Contains("27") || c.Name.Contains("28") || c.Name.Contains("29") || c.Name.Contains("30"))
                                    {
                                        c.Enabled = true;
                                    }
                                }
                            }
                            else
                            {
                                foreach (Control c in Controls)
                                {
                                    if (c.Name.Contains("27") || c.Name.Contains("28") || c.Name.Contains("29") || c.Name.Contains("30"))
                                    {
                                        c.Enabled = false;
                                    }
                                }
                            }
                            break;
                        case "grana3_1":
                            if (e.Node.Checked)
                            {
                                foreach (Control c in Controls)
                                {
                                    if (c.Name.Contains("29") || c.Name.Contains("30"))
                                    {
                                        c.Enabled = true;
                                    }
                                }
                            }
                            else
                            {
                                foreach (Control c in Controls)
                                {
                                    if (c.Name.Contains("29") || c.Name.Contains("30"))
                                    {
                                        c.Enabled = false;
                                    }
                                }
                            }
                            break;
                        case "grana3_2":
                            if (e.Node.Checked)
                            {
                                foreach (Control c in Controls)
                                {
                                    if (c.Name.Contains("28") || c.Name.Contains("30"))
                                    {
                                        c.Enabled = true;
                                    }
                                }
                            }
                            else
                            {
                                foreach (Control c in Controls)
                                {
                                    if (c.Name.Contains("28") || c.Name.Contains("30"))
                                    {
                                        c.Enabled = false;
                                    }
                                }
                            }
                            break;
                        case "grana4":
                            if (e.Node.Checked)
                            {
                                foreach (Control c in Controls)
                                {
                                    if (c.Name.Contains("29") || c.Name.Contains("30"))
                                    {
                                        c.Enabled = true;
                                        cmb26Drzava.Enabled = true;
                                        lb26drzava.Enabled = true;
                                    }
                                }
                            }
                            else
                            {
                                foreach (Control c in Controls)
                                {
                                    if (c.Name.Contains("29") || c.Name.Contains("30"))
                                    {
                                        c.Enabled = false;
                                        cmb26Drzava.Enabled = false;
                                        lb26drzava.Enabled = false;
                                    }
                                }
                            }
                            break;
                        case "grana5":
                            if (e.Node.Checked)
                            {
                                foreach (Control c in Controls)
                                {
                                    if (c.Name.Contains("29") || c.Name.Contains("30"))
                                    {
                                        c.Enabled = true;
                                    }
                                }
                            }
                            else
                            {
                                foreach (Control c in Controls)
                                {
                                    if (c.Name.Contains("29") || c.Name.Contains("30"))
                                    {
                                        c.Enabled = false;
                                    }
                                }
                            }
                            break;
                    }
                }
            }
        }
        private void cmb26Drzava_EnabledChanged(object sender, EventArgs e)
        {
            if (cmb26Drzava.Enabled)
            {
                cmb26Drzava.DataSource = bd.DRZAVE.CopyToDataTable();
                cmb26Drzava.DisplayMember = "naziv";
            }
            else
                cmb26Drzava.Text = string.Empty;
        }
        private void cmb28Opstina_EnabledChanged(object sender, EventArgs e)
        {
            if(cmb28Opstina.Enabled)
            {
                cmb28Opstina.DataSource = bd.OPSTINA.CopyToDataTable();
                cmb28Opstina.DisplayMember = "naziv";
                var sifra_opstine = (from o in bd.OPSTINA
                                     where o.naziv.Contains(cmb28Opstina.Text)
                                     select o.sifra_opstine).FirstOrDefault();
            }
            else
            {
                cmb28Opstina.Text = string.Empty;
            }
        }
        private void cmb28Naselje_EnabledChanged(object sender, EventArgs e)
        {
            if (cmb28Naselje.Enabled)
            {
                var sifra_opstine = (from o in bd.OPSTINA
                                     where o.naziv.Contains(cmb28Opstina.Text)
                                     select o.sifra_opstine).FirstOrDefault();

                var naselja = (from n in bd.NASELJE
                               where n.sifra_opstine == sifra_opstine
                               select n);

                if (naselja.Any())
                {
                    cmb28Naselje.DataSource = naselja.CopyToDataTable();
                    cmb28Naselje.DisplayMember = "naziv";
                }
            }
            else
                cmb28Naselje.Text = string.Empty;
        }
        private void cmb28Opstina_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb28Naselje.Enabled)
            {
                var sifra_opstine = (from o in bd.OPSTINA
                                     where o.naziv.Contains(cmb28Opstina.Text)
                                     select o.sifra_opstine).FirstOrDefault();

                var naselja = (from n in bd.NASELJE
                               where n.sifra_opstine == sifra_opstine
                               select n);

                if (naselja.Any())
                {
                    cmb28Naselje.DataSource = naselja.CopyToDataTable();
                    cmb28Naselje.DisplayMember = "naziv";
                }
            }
        }
        private void btnDalje_Click(object sender, EventArgs e)
        {
            //if (lb19.Enabled && (!cb19Da.Checked && !cb19Ne.Checked))
            //    MessageBox.Show("Nedostaje odgovor za pitanje 19!!!");
            //else if (lb20.Enabled && !cb20Da.Checked && !cb20Ne.Checked)
            //    MessageBox.Show("Nedostaje odgovor za pitanje 20!!!");
            //else if (lb21.Enabled && (!cb21Da.Checked && !cb21Ne.Checked))
            //    MessageBox.Show("Nedostaje odgovor za pitanje 21!!!");
            //else if (lb22.Enabled && (!cb22Da.Checked && !cb22Ne.Checked))
            //    MessageBox.Show("Nedostaje odgovor za pitanje 22!!!");
            //else if (lb23.Enabled && clb23.CheckedItems.Count == 0)
            //    MessageBox.Show("Nedostaje odgovor za pitanje 23!!!");
            //else if (lb24.Enabled && txt24.Text == string.Empty)
            //    MessageBox.Show("Nedostaje odgovor za pitanje 24!!!");
            //else if (lb25.Enabled && clb25.CheckedItems.Count == 0)
            //    MessageBox.Show("Nedostaje odgovor za pitanje 25!!!");
            //else if (lb26.Enabled && brojac <= 0)
            //    MessageBox.Show("Nedostaje odgovor za pitanje 26!!!");
            //else if (lb27.Enabled && txt27.Text == string.Empty)
            //    MessageBox.Show("Nedostaje odgovor za pitanje 27!!!");
            //else if (lb28.Enabled && (txt28Broj.Text == string.Empty || txt28Ulica.Text == string.Empty))
            //    MessageBox.Show("Nedostaje odgovor za pitanje 28!!!");
            //else if (lb29.Enabled && txt29.Text == string.Empty)
            //    MessageBox.Show("Nedostaje odgovor za pitanje 29!!!");
            //else if (lb30.Enabled && (!cb30Jednom.Checked && !cb30Svakidan.Checked))
            //    MessageBox.Show("Nedostaje odgovor za pitanje 30!!!");
            //else
            //{
            DialogResult pitanje = MessageBox.Show("Da li ste sigurni?", "Unos", MessageBoxButtons.YesNo);
            if (pitanje == DialogResult.Yes)
            {
                BazaDiplomskog.tmp_EKONOMSKA_AKTIVNOSTRow red = bd.tmp_EKONOMSKA_AKTIVNOST.Newtmp_EKONOMSKA_AKTIVNOSTRow();
                red.id_popisivac = id_popisivaca;
                red.id_osobe = id;
                if (cb19Da.Checked)
                    red.pitanje19 = "Da";
                else
                    red.pitanje19 = "Ne";
                if (cb20Da.Checked)
                    red.pitanje20 = "Da";
                else if (cb20Ne.Checked)
                    red.pitanje20 = "Ne";
                if (cb21Da.Checked)
                    red.pitanje21 = "Da";
                else if (cb21Ne.Checked)
                    red.pitanje21 = "Ne";
                if (cb22Da.Checked)
                    red.pitanje22 = "Da";
                else if (cb22Ne.Checked)
                    red.pitanje22 = "Ne";
                if (clb23.Enabled)
                    red.pitanje23 = clb23.CheckedItems[0].ToString();
                if (txt24.Enabled)
                    red.pitanje24 = txt24.Text;
                if (clb25.Enabled)
                    red.pitanje25 = clb25.CheckedItems[0].ToString();
                if (cmb26Drzava.Enabled)
                    odgovor26 += ":" + cmb26Drzava.Text;
                if (tv26.Enabled)
                    red.pitanje26 = odgovor26;
                if (txt27.Enabled)
                    red.pitanje27 = txt27.Text;
                if (lb28.Enabled)
                {
                    red.pitanje28_opstina = cmb28Opstina.Text;
                    red.pitanje28_naselje = cmb28Naselje.Text;
                    red.pitanje28_ulica = txt28Ulica.Text;
                    red.pitanje28_broj = txt28Broj.Text;
                }
                if (lb29.Enabled)
                    red.pitanje29 = txt29.Text;
                if (cb30Jednom.Checked)
                    red.pitanje30 = cb30Jednom.Text;
                if (cb30Svakidan.Checked)
                    red.pitanje30 = cb30Svakidan.Text;
                bd.tmp_EKONOMSKA_AKTIVNOST.Addtmp_EKONOMSKA_AKTIVNOSTRow(red);
                tmp_ekonomAdapter.Update(bd.tmp_EKONOMSKA_AKTIVNOST);
                MessageBoxManager.Unregister();
                frmPrevoz forma = new frmPrevoz(id, id_popisivaca);
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
    }
}

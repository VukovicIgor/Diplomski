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
    public partial class frmODomacinstvu : Form
    {
        BazaDiplomskog bd = new BazaDiplomskog();
        BazaDiplomskogTableAdapters.tmp_O_DOMACINSTVUTableAdapter tmp_domacinstvoAdapter = new BazaDiplomskogTableAdapters.tmp_O_DOMACINSTVUTableAdapter();
        BazaDiplomskogTableAdapters.QueriesTableAdapter brisanje = new BazaDiplomskogTableAdapters.QueriesTableAdapter();
        BazaDiplomskogTableAdapters.QueriesTableAdapter upis = new BazaDiplomskogTableAdapters.QueriesTableAdapter();

        string odgovor24_3;
        int id_objekta;
        int id_popisivaca;
        public frmODomacinstvu(int id_objekta, int id_popisivaca)
        {
            InitializeComponent();
            MessageBoxManager.Yes = "Da";
            MessageBoxManager.No = "Ne";
            MessageBoxManager.Register();
            this.id_objekta = id_objekta;
            this.id_popisivaca = id_popisivaca;
            brisanje.brisanje_tmp_domacinstvo(id_popisivaca);
            tmp_domacinstvoAdapter.Fill(bd.tmp_O_DOMACINSTVU);
        }
        private void clb23_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int i = 0; i < clb23.Items.Count; ++i)
            {
                if (i != e.Index)
                    clb23.SetItemChecked(i, false);
            }
            if(!clb23.GetItemChecked(e.Index))
                lb24.Enabled = true;
            else
                lb24.Enabled = false;
        }
        private void lb24_EnabledChanged(object sender, EventArgs e)
        {
            if (lb24.Enabled)
                clb24.Enabled = true;
            else
            {
                clb24.Enabled = false;
                UncheckAll(clb24);
            }
                
        }
        private void clb24_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            Uncheck(clb24, e);
            if (!clb24.GetItemChecked(e.Index) && clb24.SelectedIndex == 0)
                lb24_1.Enabled = true;
            else if (!clb24.GetItemChecked(e.Index) && clb24.SelectedIndex == 1)
                btnKraj.Enabled = true;
            else
            {
                lb24_1.Enabled = false;
                btnKraj.Enabled = false;
            }
                
        }
        private void lb24_1_EnabledChanged(object sender, EventArgs e)
        {
            if (lb24_1.Enabled)
                clb24_1.Enabled = true;
            else
            {
                clb24_1.Enabled = false;
                UncheckAll(clb24_1);
            }
        }
        private void clb24_1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            Uncheck(clb24_1, e);
            if (!clb24_1.GetItemChecked(e.Index) && clb24_1.SelectedIndex == 1)
                lb24_2.Enabled = true;
            else if (!clb24_1.GetItemChecked(e.Index) && clb24_1.SelectedIndex == 0)
                btnKraj.Enabled = true;
            else
            {
                lb24_2.Enabled = false;
                btnKraj.Enabled = false;
            }
        }
        private void lb24_2_EnabledChanged(object sender, EventArgs e)
        {
            if (lb24_2.Enabled)
                clb24_2.Enabled = true;
            else
            {
                clb24_2.Enabled = false;
                UncheckAll(clb24_2);
            }
        }
        private void clb24_2_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            Uncheck(clb24_2, e);
            if (!clb24_2.GetItemChecked(e.Index) && clb24_2.SelectedIndex == 1)
                lb24_3.Enabled = true;
            else if (!clb24_2.GetItemChecked(e.Index) && clb24_2.SelectedIndex == 0)
                btnKraj.Enabled = true;
            else
                lb24_3.Enabled = false;
        }
        private void lb24_3_EnabledChanged(object sender, EventArgs e)
        {
            if (lb24_3.Enabled)
                lb24_3_1.Enabled = true;
            else
                lb24_3_1.Enabled = false;
        }
        private void lb24_3_1_EnabledChanged(object sender, EventArgs e)
        {
            if (lb24_3_1.Enabled)
                clb24_3_1.Enabled = true;
            else
            {
                clb24_3_1.Enabled = false;
                UncheckAll(clb24_3_1);
            }
        }
        private void clb24_3_1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            Uncheck(clb24_3_1, e);
            if (!clb24_3_1.GetItemChecked(e.Index) && clb24_3_1.SelectedIndex == 1)
                lb24_3_2.Enabled = true;
            else if (!clb24_3_1.GetItemChecked(e.Index) && clb24_3_1.SelectedIndex == 0)
            {
                odgovor24_3 = lb24_3_1.Text;
                btnKraj.Enabled = true;
            }
            else
            {
                lb24_3_2.Enabled = false;
                btnKraj.Enabled = false;
            }
        }
        private void lb24_3_2_EnabledChanged(object sender, EventArgs e)
        {
            if (lb24_3_2.Enabled)
                clb24_3_2.Enabled = true;
            else
            {
                clb24_3_2.Enabled = false;
                UncheckAll(clb24_3_2);
            }
        }
        private void clb24_3_2_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            Uncheck(clb24_3_2, e);
            if (!clb24_3_2.GetItemChecked(e.Index) && clb24_3_2.SelectedIndex == 1)
                lb24_3_3.Enabled = true;
            else if (!clb24_3_2.GetItemChecked(e.Index) && clb24_3_2.SelectedIndex == 0)
            {
                odgovor24_3 = lb24_3_2.Text;
                btnKraj.Enabled = true;
            }
            else
            {
                lb24_3_3.Enabled = false;
                btnKraj.Enabled = false;
            }
        }
        private void lb24_3_3_EnabledChanged(object sender, EventArgs e)
        {
            if (lb24_3_3.Enabled)
                clb24_3_3.Enabled = true;
            else
            {
                clb24_3_3.Enabled = false;
                UncheckAll(clb24_3_3);
            }
        }
        private void clb24_3_3_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            Uncheck(clb24_3_3, e);
            if (!clb24_3_3.GetItemChecked(e.Index) && clb24_3_3.SelectedIndex == 1)
                lb24_3_4.Enabled = true;
            else if (!clb24_3_3.GetItemChecked(e.Index) && clb24_3_3.SelectedIndex == 0)
            {
                odgovor24_3 = lb24_3_3.Text;
                btnKraj.Enabled = true;
            }
            else
            {
                lb24_3_4.Enabled = false;
                btnKraj.Enabled = false;
            }
        }
        private void lb24_3_4_EnabledChanged(object sender, EventArgs e)
        {
            if (lb24_3_4.Enabled)
                clb24_3_4.Enabled = true;
            else
            {
                clb24_3_4.Enabled = false;
                UncheckAll(clb24_3_4);
            }
        }
        private void clb24_3_4_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            Uncheck(clb24_3_4, e);
            if (!clb24_3_4.GetItemChecked(e.Index) && clb24_3_4.SelectedIndex == 1)
                lb24_3_5.Enabled = true;
            else if (!clb24_3_4.GetItemChecked(e.Index) && clb24_3_4.SelectedIndex == 0)
            {
                odgovor24_3 = lb24_3_4.Text;
                btnKraj.Enabled = true;
            }
            else
            { 
                lb24_3_5.Enabled = false;
                btnKraj.Enabled = false;
            }
        }
        private void lb24_3_5_EnabledChanged(object sender, EventArgs e)
        {
            if (lb24_3_5.Enabled)
                clb24_3_5.Enabled = true;
            else
            {
                clb24_3_5.Enabled = false;
                UncheckAll(clb24_3_5);
            }
        }
        private void clb24_3_5_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            Uncheck(clb24_3_5, e);
            if (!clb24_3_5.GetItemChecked(e.Index) && clb24_3_5.SelectedIndex == 1)
                lb24_3_6.Enabled = true;
            else if (!clb24_3_5.GetItemChecked(e.Index) && clb24_3_5.SelectedIndex == 0)
            {
                odgovor24_3 = lb24_3_5.Text;
                btnKraj.Enabled = true;
            }
            else
            {
                lb24_3_6.Enabled = false;
                btnKraj.Enabled = false;
            }
        }
        private void lb24_3_6_EnabledChanged(object sender, EventArgs e)
        {
            if (lb24_3_6.Enabled)
                clb24_3_6.Enabled = true;
            else
            {
                clb24_3_6.Enabled = false;
                UncheckAll(clb24_3_6);
            }
        }
        private void clb24_3_6_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            Uncheck(clb24_3_6, e);
            if (!clb24_3_6.GetItemChecked(e.Index) && clb24_3_6.SelectedIndex == 1)
                lb24_3_7.Enabled = true;
            else if (!clb24_3_6.GetItemChecked(e.Index) && clb24_3_6.SelectedIndex == 0)
            {
                odgovor24_3 = lb24_3_6.Text;
                btnKraj.Enabled = true;
            }
            else
            {
                lb24_3_7.Enabled = false;
                btnKraj.Enabled = false;
            }
        }
        private void lb24_3_7_EnabledChanged(object sender, EventArgs e)
        {
            if (lb24_3_7.Enabled)
                clb24_3_7.Enabled = true;
            else
            {
                clb24_3_7.Enabled = false;
                UncheckAll(clb24_3_7);
            }
        }
        private void clb24_3_7_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            Uncheck(clb24_3_7, e);
            if (!clb24_3_7.GetItemChecked(e.Index))
            {
                btnKraj.Enabled = true;
                odgovor24_3 = "Domaćinstvo nije gajilo ništa od ponuđenog";
            }
            else
            {
                lb24_3_7.Enabled = false;
                btnKraj.Enabled = false;
            }
        }
        private void btnKraj_Click(object sender, EventArgs e)
        {
            DialogResult pitanje = MessageBox.Show("Da li ste sigurni?", "Unos", MessageBoxButtons.YesNo);
            if (pitanje == DialogResult.Yes)
            {
                BazaDiplomskog.tmp_O_DOMACINSTVURow red = bd.tmp_O_DOMACINSTVU.Newtmp_O_DOMACINSTVURow();
                red.id_objekta = id_objekta;
                red.id_popisivac = id_popisivaca;
                red.pitanje23 = clb23.SelectedItem.ToString();
                red.pitanje24 = clb24.SelectedItem.ToString();
                if(lb24_1.Enabled)
                    red.pitanje24_1 = clb24_1.SelectedItem.ToString();
                if (lb24_2.Enabled)
                    red.pitanje24_2 = clb24_2.SelectedItem.ToString();
                if (lb24_3.Enabled)
                {
                    red.pitanje24_3 = odgovor24_3;
                }
                bd.tmp_O_DOMACINSTVU.Addtmp_O_DOMACINSTVURow(red);
                tmp_domacinstvoAdapter.Update(bd.tmp_O_DOMACINSTVU);
                upisTabela();
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
            clb.Enabled = false;
        }

        private void upisTabela()
        {
            upis.upis_reda_osoba(id_popisivaca);
            upis.upis_reda_objekat(id_popisivaca);
            upis.upis_reda_bracni_status(id_popisivaca);
            upis.upis_reda_eko_akt(id_popisivaca);
            upis.upis_reda_etno(id_popisivaca);
            upis.upis_reda_migracije(id_popisivaca);
            upis.upis_reda_obrazovanje(id_popisivaca);
            upis.upis_reda_prevoz(id_popisivaca);
            upis.upis_reda_soc_int(id_popisivaca);
            upis.upis_reda_zgrada(id_popisivaca);
            upis.upis_reda_domacinstvo(id_popisivaca);
            upis.upis_reda_stan(id_popisivaca);
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

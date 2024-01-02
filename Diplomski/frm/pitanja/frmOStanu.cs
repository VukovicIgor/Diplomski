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
    public partial class frmOStanu : Form
    {
        BazaDiplomskog bd = new BazaDiplomskog();
        BazaDiplomskogTableAdapters.tmp_O_STANUTableAdapter tmp_o_stanuAdapter = new BazaDiplomskogTableAdapters.tmp_O_STANUTableAdapter();
        BazaDiplomskogTableAdapters.QueriesTableAdapter brisanje = new BazaDiplomskogTableAdapters.QueriesTableAdapter();
        BazaDiplomskogTableAdapters.QueriesTableAdapter upis = new BazaDiplomskogTableAdapters.QueriesTableAdapter();

        int id_objekta;
        int id_popisivaca;

        public frmOStanu(int id_objekta, int id_popisivaca)
        {
            InitializeComponent();
            MessageBoxManager.Yes = "Da";
            MessageBoxManager.No = "Ne";
            MessageBoxManager.Register();
            this.id_objekta = id_objekta;
            this.id_popisivaca = id_popisivaca;
            brisanje.brisanje_tmp_stan(id_popisivaca);
            tmp_o_stanuAdapter.Fill(bd.tmp_O_STANU);
        }

        private void clb8_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            Uncheck(clb8, e);
            switch(e.Index)
            {
                case 0:
                    if(!clb8.GetItemChecked(e.Index))
                    {
                        lb8_1.Enabled = true;
                        foreach (Control c in Controls)
                        {
                            if (c is Label)
                                if (c.Name != lb8_1.Name && c.Name != lb8.Name)
                                {
                                    c.Enabled = false;
                                }
                                    
                        }
                    }
                    else
                    {
                        foreach (Control c in Controls)
                        {
                            if (c is Label)
                                if (c.Name != lb8.Name)
                                    c.Enabled = false;
                        }
                    }
                    break;
                case 1:
                    if (!clb8.GetItemChecked(e.Index))
                    {
                        lb9.Enabled = true;
                        foreach (Control c in Controls)
                        {
                            if (c is Label)
                                if (c.Name != lb9.Name && c.Name != lb8.Name)
                                    c.Enabled = false;
                        }
                    }
                    else
                    {
                        foreach (Control c in Controls)
                        {
                            if (c is Label)
                                if (c.Name != lb8.Name)
                                    c.Enabled = false;
                        }
                    }
                    break;
                case 2:
                    if (!clb8.GetItemChecked(e.Index))
                    {
                        lb9.Enabled = true;
                        foreach (Control c in Controls)
                        {
                            if (c is Label)
                                if (c.Name != lb9.Name && c.Name != lb8.Name)
                                    c.Enabled = false;
                        }
                    }
                    else
                    {
                        foreach (Control c in Controls)
                        {
                            if (c is Label)
                                if (c.Name != lb8.Name)
                                    c.Enabled = false;
                        }
                    }
                    break;
                case 3:
                    if (!clb8.GetItemChecked(e.Index))
                    {
                        lb21.Enabled = true;
                        foreach (Control c in Controls)
                        {
                            if (c is Label)
                                if (c.Name != lb21.Name && c.Name != lb8.Name)
                                    c.Enabled = false;
                        }
                    }
                    else
                    {
                        foreach (Control c in Controls)
                        {
                            if (c is Label)
                                if (c.Name != lb8.Name)
                                    c.Enabled = false;
                        }
                    }
                    break;
            }
        }
        private void lb8_1_EnabledChanged(object sender, EventArgs e)
        {
            EnableChange(lb8_1,txt8_1);
        }
        private void lb9_EnabledChanged(object sender, EventArgs e)
        {
            EnableChange(lb9, txt9);
        }
        private void lb21_EnabledChanged(object sender, EventArgs e)
        {
            EnableChange(lb21, clb21);
        }
        private void clb21_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            Uncheck(clb21, e);
            switch(e.Index)
            {
                case 0:
                    if(!clb21.GetItemChecked(e.Index))
                        lb22.Enabled = true;
                    else
                        lb22.Enabled = false;
                    break;
                case 1:
                    if (!clb21.GetItemChecked(e.Index))
                        lb23.Enabled = true;
                    else
                        lb23.Enabled = false;
                    break;
                case 2:
                    if (!clb21.GetItemChecked(e.Index))
                        lb22.Enabled = true;
                    else
                        lb22.Enabled = false;
                    break;
                default:
                    if (!clb21.GetItemChecked(e.Index))
                        btnKraj2.Enabled = true;
                    else
                        btnKraj2.Enabled = false;
                    break;
            }
        }
        private void lb22_EnabledChanged(object sender, EventArgs e)
        {
            EnableChange(lb22, txt22);
        }
        private void lb23_EnabledChanged(object sender, EventArgs e)
        {
            EnableChange(lb23, txt23);
        }
        private void txt8_1_TextChanged(object sender, EventArgs e)
        {
            if (txt8_1.Text != string.Empty)
                lb9.Enabled = true;
            else
                lb9.Enabled = false;
        }
        private void txt9_TextChanged(object sender, EventArgs e)
        {
            if (txt9.Text != string.Empty)
                lb10.Enabled = true;
            else
                lb10.Enabled = false;
        }
        private void lb10_EnabledChanged(object sender, EventArgs e)
        {
            EnableChange(lb10, txt10);
        }
        private void txt10_TextChanged(object sender, EventArgs e)
        {
            if (txt10.Text != string.Empty)
                lb11.Enabled = true;
            else
                lb11.Enabled = false;
        }
        private void lb11_EnabledChanged(object sender, EventArgs e)
        {
            EnableChange(lb11, clb11);
        }
        private void clb11_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            Uncheck(clb11, e);
            if (!clb11.GetItemChecked(e.Index))
                lb12.Enabled = true;
            else
                lb12.Enabled = false;
        }
        private void lb12_EnabledChanged(object sender, EventArgs e)
        {
            EnableChange(lb12, clb12);
        }
        private void clb12_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            Uncheck(clb12, e);
            if (!clb12.GetItemChecked(e.Index))
                lb13.Enabled = true;
            else
                lb13.Enabled = false;
        }
        private void lb13_EnabledChanged(object sender, EventArgs e)
        {
            EnableChange(lb13, clb13);
        }
        private void clb13_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            Uncheck(clb13, e);
            if (!clb13.GetItemChecked(e.Index))
                lb14.Enabled = true;
            else
                lb14.Enabled = false;
        }
        private void lb14_EnabledChanged(object sender, EventArgs e)
        {
            if (lb14.Enabled)
                lb14_1.Enabled = true;
            else
                lb14_1.Enabled = false;
        }
        private void lb14_1_EnabledChanged(object sender, EventArgs e)
        {
            EnableChange(lb14_1, clb14_1);
        }
        private void clb14_1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            Uncheck(clb14_1, e);
            if (!clb14_1.GetItemChecked(e.Index))
                lb14_2.Enabled = true;
            else
                lb14_2.Enabled = false;
        }
        private void lb14_2_EnabledChanged(object sender, EventArgs e)
        {
            EnableChange(lb14_2, clb14_2);
        }
        private void clb14_2_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            Uncheck(clb14_2, e);
            if (!clb14_2.GetItemChecked(e.Index))
                lb14_3.Enabled = true;
            else
                lb14_3.Enabled = false;
        }
        private void lb14_3_EnabledChanged(object sender, EventArgs e)
        {
            EnableChange(lb14_3, clb14_3);
        }
        private void clb14_3_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            Uncheck(clb14_3, e);
            if (!clb14_3.GetItemChecked(e.Index))
                lb14_4.Enabled = true;
            else
                lb14_4.Enabled = false;
        }
        private void lb14_4_EnabledChanged(object sender, EventArgs e)
        {
            EnableChange(lb14_4, clb14_4);
        }
        private void clb14_4_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            Uncheck(clb14_4, e);
            if (!clb14_4.GetItemChecked(e.Index))
                lb14_5.Enabled = true;
            else
                lb14_5.Enabled = false;
        }
        private void lb14_5_EnabledChanged(object sender, EventArgs e)
        {
            EnableChange(lb14_5, clb14_5);
        }
        private void clb14_5_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            Uncheck(clb14_5, e);
            switch(e.Index)
            {
                case 0:
                    if (!clb14_5.GetItemChecked(e.Index))
                        lb16.Enabled = true;
                    else
                        lb16.Enabled = false;
                    break;
                default:
                    if (!clb14_5.GetItemChecked(e.Index))
                        lb15.Enabled = true;
                    else
                        lb15.Enabled = false;
                    break;
            }
        }
        private void lb16_EnabledChanged(object sender, EventArgs e)
        {
            if (lb16.Enabled)
            {
                lb16_1.Enabled = true;
                txt16.Enabled = true;
            }
            else
            {
                txt16.Text = null;
                lb16_1.Enabled = false;
                txt16.Enabled = false;
            }
        }
        private void lb15_EnabledChanged(object sender, EventArgs e)
        {
            EnableChange(lb15, clb15);
        }
        private void clb15_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            Uncheck(clb15, e);
            if (!clb15.GetItemChecked(e.Index))
                lb16.Enabled = true;
            else
                lb16.Enabled = false;
        }
        private void txt16_TextChanged(object sender, EventArgs e)
        {
            if (txt16.Text != string.Empty)
                lb17.Enabled = true;
            else
                lb17.Enabled = false;
        }
        private void lb17_EnabledChanged(object sender, EventArgs e)
        {
            EnableChange(lb17, clb17);
        }
        private void clb17_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            Uncheck(clb17, e);
            if (!clb17.GetItemChecked(e.Index))
                lb18.Enabled = true;
            else
                lb18.Enabled = false;
        }
        private void lb18_EnabledChanged(object sender, EventArgs e)
        {
            EnableChange(lb18, txt18);
        }
        private void txt18_TextChanged(object sender, EventArgs e)
        {
            if (txt18.Text != string.Empty)
                lb19.Enabled = true;
            else
                lb19.Enabled = false;
        }
        private void lb19_EnabledChanged(object sender, EventArgs e)
        {
            EnableChange(lb19, clb19);
        }
        private void clb19_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            Uncheck(clb19, e);
            if (!clb19.GetItemChecked(e.Index))
                lb20.Enabled = true;
            else
                lb20.Enabled = false;
        }
        private void lb20_EnabledChanged(object sender, EventArgs e)
        {
            EnableChange(lb20, clb20);
        }
        private void clb20_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            Uncheck(clb20, e);
            switch (e.Index)
            {
                case 0:
                    if (!clb20.GetItemChecked(e.Index))
                        lb21.Enabled = true;
                    else
                        lb21.Enabled = false;
                    break;
                default:
                    if (!clb20.GetItemChecked(e.Index))
                        btnKraj1.Enabled = true;
                    else
                        btnKraj1.Enabled = false;
                    break;
            }
        }
        private void txt22_TextChanged(object sender, EventArgs e)
        {
            if (txt22.Text != string.Empty)
                lb23.Enabled = true;
            else
                lb23.Enabled = false;
        }
        private void txt23_TextChanged(object sender, EventArgs e)
        {
            if (txt23.Text != string.Empty)
                btnDalje.Enabled = true;
            else
                btnDalje.Enabled = false;
        }
        private void EnableChange(Label lb, Control c)
        {
            if (lb.Enabled)
                c.Enabled = true;
            else
            {
                if (c is TextBox)
                {
                    TextBox txt = (TextBox)c;
                    txt.Text = null;
                    txt.Enabled = false;
                }
                else if (c is CheckedListBox)
                {
                    CheckedListBox clb = (CheckedListBox)c;
                    UncheckAll(clb);
                    clb.Enabled = false;
                }
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
        private void Upis(object sender)
        {
            DialogResult pitanje = MessageBox.Show("Da li ste sigurni?", "Unos", MessageBoxButtons.YesNo);
            if (pitanje == DialogResult.Yes)
            {
                BazaDiplomskog.tmp_O_STANURow red = bd.tmp_O_STANU.Newtmp_O_STANURow();
                red.pitanje8 = clb8.SelectedItem.ToString();
                red.id_popisivac = id_popisivaca;
                red.id_objekta = id_objekta;
                if (lb8_1.Enabled)
                    red.pitanje8_1 = txt8_1.Text;
                if (lb9.Enabled)
                    red.pitanje9 = txt9.Text;
                if (lb10.Enabled)
                    red.pitanje10 = txt10.Text;
                if (lb11.Enabled)
                    red.pitanje11 = clb11.SelectedItem.ToString();
                if (lb12.Enabled)
                    red.pitanje12 = clb12.SelectedItem.ToString();
                if (lb13.Enabled)
                    red.pitanje13 = clb13.SelectedItem.ToString();
                if (lb14_1.Enabled)
                    red.pitanje14_1 = clb14_1.SelectedItem.ToString();
                if (lb14_2.Enabled)
                    red.pitanje14_2 = clb14_2.SelectedItem.ToString();
                if (lb14_3.Enabled)
                    red.pitanje14_3 = clb14_3.SelectedItem.ToString();
                if (lb14_4.Enabled)
                    red.pitanje14_4 = clb14_4.SelectedItem.ToString();
                if (lb14_5.Enabled)
                    red.pitanje14_5 = clb14_5.SelectedItem.ToString();
                if (lb15.Enabled)
                    red.pitanje15 = clb15.SelectedItem.ToString();
                if (lb16.Enabled)
                    red.pitanje16 = txt16.Text;
                if (lb17.Enabled)
                    red.pitanje17 = clb17.SelectedItem.ToString();
                if (lb18.Enabled)
                    red.pitanje18 = txt18.Text;
                if (lb19.Enabled)
                    red.pitanje19 = clb19.SelectedItem.ToString();
                if (lb20.Enabled)
                    red.pitanje20 = clb20.SelectedItem.ToString();
                if (lb21.Enabled)
                    red.pitanje21 = clb21.SelectedItem.ToString();
                if (lb22.Enabled)
                    red.pitanje22 = txt22.Text;
                if (lb23.Enabled)
                    red.pitanje23 = txt23.Text;
                bd.tmp_O_STANU.Addtmp_O_STANURow(red);
                tmp_o_stanuAdapter.Update(bd.tmp_O_STANU);
                MessageBoxManager.Unregister();
                Button btn = (Button)sender;
                if (btn.Name == "btnDalje")
                {
                    frmODomacinstvu frm = new frmODomacinstvu(id_objekta, id_popisivaca);
                    this.Hide();
                    frm.ShowDialog();
                    this.Close();
                }
                else
                {
                    upisTabela();
                    frmPocetna forma = new frmPocetna(id_popisivaca);
                    this.Hide();
                    forma.ShowDialog();
                    this.Close();
                }
            }
        }
        private void btnUpis_Click(object sender, EventArgs e)
        {
            Upis(sender);
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

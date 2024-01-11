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
    public partial class frmOZgradi : Form
    {
        int id_objekta;
        int id_popisivaca;
        BazaDiplomskog bd = new BazaDiplomskog();
        BazaDiplomskogTableAdapters.tmp_O_ZGRADITableAdapter tmp_o_zgradiAdapter = new BazaDiplomskogTableAdapters.tmp_O_ZGRADITableAdapter();
        BazaDiplomskogTableAdapters.tmp_OBJEKATTableAdapter tmp_objekatAdapter = new BazaDiplomskogTableAdapters.tmp_OBJEKATTableAdapter();
        BazaDiplomskogTableAdapters.QueriesTableAdapter brisanje = new BazaDiplomskogTableAdapters.QueriesTableAdapter();
        BazaDiplomskogTableAdapters.QueriesTableAdapter upis = new BazaDiplomskogTableAdapters.QueriesTableAdapter();

        public frmOZgradi(int id_objekta, int id_popisivaca)
        {
            InitializeComponent();
            brisanje.brisanje_tmp_zgrada(id_popisivaca);
            MessageBoxManager.Yes = "Da";
            MessageBoxManager.No = "Ne";
            MessageBoxManager.Register();
            tmp_o_zgradiAdapter.Fill(bd.tmp_O_ZGRADI);
            tmp_objekatAdapter.Fill(bd.tmp_OBJEKAT);
            this.id_objekta = id_objekta;
            this.id_popisivaca = id_popisivaca;
        }

        private void clb1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            Uncheck(clb1, e);
            btnDalje.Enabled = true;
            btnKraj1.Enabled = false;
            switch (e.Index)
            {
                case 0:
                    if (!clb1.GetItemChecked(e.Index))
                    {
                        lb2.Enabled = true;
                        foreach (Control c in Controls)
                        {
                            if (c is Label)
                                if (c.Name != lb2.Name && c.Name != lb1.Name)
                                    c.Enabled = false;
                        }
                    }
                    else
                    {
                        foreach (Control c in Controls)
                        {
                            if (c is Label)
                                if (c.Name != lb1.Name)
                                    c.Enabled = false;
                        }
                    }
                    break;
                case 1:
                    if (!clb1.GetItemChecked(e.Index))
                    {
                        lb3.Enabled = true;
                        foreach (Control c in Controls)
                        {
                            if (c is Label)
                                if (c.Name != lb3.Name && c.Name != lb1.Name)
                                    c.Enabled = false;
                        }
                    }
                    else
                    {
                        foreach (Control c in Controls)
                        {
                            if (c is Label)
                                if (c.Name != lb1.Name)
                                    c.Enabled = false;
                        }
                    }
                    break;
                case 2:
                    if (!clb1.GetItemChecked(e.Index))
                    {
                        cmb5.Items.Clear();
                        for (int i = 0; i <= 294; i++)
                            cmb5.Items.Add(i);
                        lb5.Enabled = true;
                        foreach (Control c in Controls)
                        {
                            if (c is Label)
                                if (!c.Name.Contains("2") && !c.Name.Contains("5") && c.Name != lb1.Name)
                                    c.Enabled = false;
                        }
                    }
                    else
                    {
                        foreach (Control c in Controls)
                        {
                            if (c is Label)
                                if (c.Name != lb1.Name)
                                    c.Enabled = false;
                        }
                    }
                    break;
                case 3:
                    if (!clb1.GetItemChecked(e.Index))
                    {
                        lb4.Enabled = true;
                        foreach (Control c in Controls)
                        {
                            if (c is Label)
                                if (c.Name != lb4.Name && c.Name != lb1.Name)
                                    c.Enabled = false;
                        }
                    }
                    else
                    {
                        foreach (Control c in Controls)
                        {
                            if (c is Label)
                                if (c.Name != lb1.Name)
                                    c.Enabled = false;
                        }
                    }
                    break;
                case 4:
                    if (!clb1.GetItemChecked(e.Index))
                    {
                        btnKraj1.Enabled = true;
                        btnDalje.Enabled = false;
                        foreach (Control c in Controls)
                        {
                            if (c is Label)
                                if (c.Name != lb1.Name)
                                    c.Enabled = false;
                            if (c.Name.Contains("6") || c.Name.Contains("7"))
                                c.Enabled = false;

                        }
                    }
                    else
                    {
                        btnKraj1.Enabled = false;
                    }
                    break;
                case 5:
                    if (!clb1.GetItemChecked(e.Index))
                    {
                        btnDalje.Enabled = false;
                        btnKraj1.Enabled = true;
                        foreach (Control c in Controls)
                        {
                            if (c is Label)
                                if (c.Name != lb1.Name)
                                    c.Enabled = false;
                            if (c.Name.Contains("6") || c.Name.Contains("7"))
                                c.Enabled = false;
                        }
                    }
                    else
                    {
                        btnKraj1.Enabled = false;
                    }
                    break;
                default:
                    break;
            }
        }
        private void lb2_EnabledChanged(object sender, EventArgs e)
        {
            if (lb2.Enabled)
                clb2.Enabled = true;
            else
            {
                UncheckAll(clb2);
            }
        }
        private void lb3_EnabledChanged(object sender, EventArgs e)
        {
            if (lb3.Enabled)
                clb3.Enabled = true;
            else
            {
                UncheckAll(clb3);
            }
        }
        private void lb4_EnabledChanged(object sender, EventArgs e)
        {
            if (lb4.Enabled)
                txt4.Enabled = true;
            else
                txt4.Enabled = false;
        }
        private void lb5_EnabledChanged(object sender, EventArgs e)
        {
            if (lb5.Enabled)
            {
                foreach (Control c in Controls)
                {
                    if (c.Name.Contains("5") && c.Name != lb1.Name)
                        c.Enabled = true;
                    cmb5.SelectedIndex = 0;
                }
            }
            else
            {
                foreach (Control c in Controls)
                {
                    cmb5.Text = " ";
                    cmb5.SelectedItem = null;
                    if (c.Name.Contains("5") && c.Name != lb1.Name)
                        c.Enabled = false;
                }
            }
        }
        private void cmb5_TextChanged(object sender, EventArgs e)
        {
            if (lb5.Enabled)
            {
                if (cmb5.Text == "0")
                {
                    foreach (Control c in Controls)
                    {
                        if (!c.Name.Contains("2") && !c.Name.Contains("5") && !c.Name.Contains("1"))
                            c.Enabled = false;
                    }
                    btnKraj2.Enabled = true;
                    btnDalje.Enabled = false;
                }
                else
                {
                    foreach (Control c in Controls)
                    {
                        if (c.Name.Contains("6") || c.Name.Contains("7"))
                            c.Enabled = true;
                    }
                    btnKraj2.Enabled = false;
                    btnDalje.Enabled = true;
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
        private void clb2_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            Uncheck(clb2, e);
            cmb5.Items.Clear();
            switch(clb2.SelectedIndex)
            {
                case 0:
                    cmb5.Items.Add(1);
                    break;
                case 1:
                    cmb5.Items.Add(2);
                    break;
                case 2:
                    cmb5.Items.Add(2);
                    break;
                case 3:
                    for (int i=1;i<=3;i++)
                        cmb5.Items.Add(i);
                    break;
                case 4:
                    for (int i = 3; i <= 9; i++)
                        cmb5.Items.Add(i);
                    break;
                case 5:
                    for (int i = 10; i <= 294; i++)
                        cmb5.Items.Add(i);
                    break;
            }
            if (!clb2.GetItemChecked(e.Index))
            {
                foreach (Control c in Controls)
                    if (c.Name.Contains("5"))
                        c.Enabled = true;
            }
            else
            {
                foreach (Control c in Controls)
                    if (c.Name.Contains("5") || c.Name.Contains("6") || c.Name.Contains("7"))
                        c.Enabled = false;
            }
        }
        private void clb3_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            Uncheck(clb3, e);
            if (!clb3.GetItemChecked(e.Index))
            {
                foreach (Control c in Controls)
                    if (c.Name.Contains("6") || c.Name.Contains("7"))
                        c.Enabled = true;
            }
            else
            {
                foreach (Control c in Controls)
                    if (c.Name.Contains("6") || c.Name.Contains("7"))
                        c.Enabled = false;
            }
        }
        private void txt4_TextChanged(object sender, EventArgs e)
        {
            if (txt4.Text.Length > 0)
            {
                foreach (Control c in Controls)
                {
                    if (c.Name.Contains("6") || c.Name.Contains("7"))
                        c.Enabled = true;
                }
            }
            else
            {
                foreach (Control c in Controls)
                {
                    if (c.Name.Contains("6") || c.Name.Contains("7"))
                        c.Enabled = false;
                }
            }
        }
        private void lb6_EnabledChanged(object sender, EventArgs e)
        {
            if (lb6.Enabled)
                clb6.Enabled = true;
            else
            {
                UncheckAll(clb6);
            }
        }
        private void lb7_EnabledChanged(object sender, EventArgs e)
        {
            if (lb7.Enabled)
                clb7.Enabled = true;
            else
                UncheckAll(clb7);
        }
        private void clb6_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            Uncheck(clb6,e);
        }
        private void clb7_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            Uncheck(clb7, e);
        }
        private void btnKraj1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Da li ste sigurni?", "Unos", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                BazaDiplomskog.tmp_O_ZGRADIRow red = bd.tmp_O_ZGRADI.Newtmp_O_ZGRADIRow();
                red.id_objekta = id_objekta;
                red.id_popisivac = id_popisivaca;
                red.pitanje_1 = clb1.SelectedItem.ToString();
                bd.tmp_O_ZGRADI.Addtmp_O_ZGRADIRow(red);
                tmp_o_zgradiAdapter.Update(bd.tmp_O_ZGRADI);
                upisTabela();
                MessageBoxManager.Unregister();
                frmPocetna forma = new frmPocetna(id_popisivaca);
                this.Hide();
                forma.ShowDialog();
                this.Close();
            }
        }
        private void btnKraj2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Da li ste sigurni?", "Unos", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                BazaDiplomskog.tmp_O_ZGRADIRow red = bd.tmp_O_ZGRADI.Newtmp_O_ZGRADIRow();
                red.id_objekta = id_objekta;
                red.id_popisivac = id_popisivaca;
                red.pitanje_1 = clb1.SelectedItem.ToString();
                if (clb2.SelectedItem != null)
                    red.pitanje_2 = clb2.SelectedItem.ToString();
                if (cmb5.SelectedItem != null)
                    red.pitanje_5 = cmb5.SelectedItem.ToString();
                bd.tmp_O_ZGRADI.Addtmp_O_ZGRADIRow(red);
                tmp_o_zgradiAdapter.Update(bd.tmp_O_ZGRADI);
                upisTabela();
                MessageBoxManager.Unregister();
                frmPocetna forma = new frmPocetna(id_popisivaca);
                this.Hide();
                forma.ShowDialog();
                this.Close();
                
            }
        }

        private void btnDalje_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Da li ste sigurni?", "Unos", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                BazaDiplomskog.tmp_O_ZGRADIRow red = bd.tmp_O_ZGRADI.Newtmp_O_ZGRADIRow();
                red.id_objekta = id_objekta;
                red.id_popisivac = id_popisivaca;
                red.pitanje_1 = clb1.SelectedItem.ToString();
                if(clb2.SelectedItem!=null)
                    red.pitanje_2 = clb2.SelectedItem.ToString();
                if (clb3.SelectedItem != null)
                    red.pitanje_3 = clb3.SelectedItem.ToString();
                if (txt4.Text != string.Empty)
                    red.pitanje_4 = txt4.Text;
                if (cmb5.SelectedItem != null)
                    red.pitanje_5 = cmb5.SelectedItem.ToString();
                if (clb6.SelectedItem != null)
                    red.pitanje_6 = clb6.SelectedItem.ToString();
                if (clb7.SelectedItem != null)
                    red.pitanje_7 = clb7.SelectedItem.ToString();
                bd.tmp_O_ZGRADI.Addtmp_O_ZGRADIRow(red);
                tmp_o_zgradiAdapter.Update(bd.tmp_O_ZGRADI);
                MessageBoxManager.Unregister();
                frmOStanu forma = new frmOStanu(id_objekta, id_popisivaca);
                this.Hide();
                forma.ShowDialog();
                this.Close();
            }
        }
        //private int vrati_objekat(int id_osobe)
        //{
        //    var tmp = (from o in bd.tmp_OBJEKAT
        //               where o.id_osobe == id
        //               select o.id_objekta).First();
        //    int id_objekta = tmp;

        //    return id_objekta;
        //}

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

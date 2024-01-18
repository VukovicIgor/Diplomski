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

    public partial class frmBracniStatusFertilitet : Form
    {
        int id;
        int id_popisivaca;
        BazaDiplomskog bd = new BazaDiplomskog();
        //BazaDiplomskogTableAdapters.BRACNI_STATUS_FERTILITETTableAdapter bracniAdapter = new BazaDiplomskogTableAdapters.BRACNI_STATUS_FERTILITETTableAdapter();
        BazaDiplomskogTableAdapters.tmp_BRACNI_STATUS_FERTILITETTableAdapter tmp_bracniAdapter = new BazaDiplomskogTableAdapters.tmp_BRACNI_STATUS_FERTILITETTableAdapter();
        BazaDiplomskogTableAdapters.QueriesTableAdapter brisanje = new BazaDiplomskogTableAdapters.QueriesTableAdapter();

        public frmBracniStatusFertilitet(int id, int id_popisivaca)
        {
            InitializeComponent();
            brisanje.brisanje_tmp_bracni_status(id_popisivaca);
            foreach (Control c in Controls)
            {
                if (c is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)c;
                    dtp.MaxDate = DateTime.Now;
                    dtp.MinDate = new DateTime(1900, 1, 1);
                    dtp.CustomFormat = " ";
                    dtp.Format = DateTimePickerFormat.Custom;
                    if (dtp.Name.Contains("11"))
                    {
                        dtp.Enabled = false;
                    }
                }
            }
            MessageBoxManager.Yes = "Da";
            MessageBoxManager.No = "Ne";
            MessageBoxManager.Register();
            dtp11_1vise.Enabled = false;
            this.id = id;
            this.id_popisivaca = id_popisivaca;
            tmp_bracniAdapter.Fill(bd.tmp_BRACNI_STATUS_FERTILITET);
        }

        private void clb9_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int i = 0; i < clb9.Items.Count; ++i)
                if (i != e.Index) clb9.SetItemChecked(i, false);

            //if(clb9.SelectedIndex==0 || clb9.SelectedIndex == 3 || clb9.SelectedIndex == 4 )
            if ((!clb9.GetItemChecked(e.Index) && e.Index==0) || (!clb9.GetItemChecked(e.Index) && e.Index == 3) || (!clb9.GetItemChecked(e.Index) && e.Index == 4))
            {
                lb10.Enabled = true;
                lb11.Enabled = false;
            }
            else if ((!clb9.GetItemChecked(e.Index) && e.Index == 1) || (!clb9.GetItemChecked(e.Index) && e.Index == 2))
            {
                lb10.Enabled = false;
                lb11.Enabled = true;
            }
            else
            {
                lb10.Enabled = false;
                lb11.Enabled = false;
            }
        }
        private void cmb11_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb11.SelectedIndex == 0)
            {
                foreach (Control c in Controls)
                {
                    if (c is DateTimePicker)
                    {
                        DateTimePicker dtp = (DateTimePicker)c;
                        dtp.Enabled = false;
                        dtp.CustomFormat = " ";
                        dtp.Format = DateTimePickerFormat.Custom;
                    }
                }
            }
            else if (cmb11.SelectedIndex == 1)
            {
                dtp11_1prvo.Enabled = true;
                dtp11_1drugo.Enabled = false;
                dtp11_1vise.Enabled = false;
            }
            else if (cmb11.SelectedIndex == 2)
            {
                dtp11_1prvo.Enabled = true;
                dtp11_1drugo.Enabled = true;
                dtp11_1trece.Enabled = false;
                dtp11_1vise.Enabled = false;
            }
            else if (cmb11.SelectedIndex == 3)
            {
                dtp11_1prvo.Enabled = true;
                dtp11_1drugo.Enabled = true;
                dtp11_1trece.Enabled = true;
                dtp11_1vise.Enabled = false;
            }
            else if (cmb11.SelectedIndex > 3)
            {
                dtp11_1prvo.Enabled = false;
                dtp11_1prvo.CustomFormat = " ";
                dtp11_1prvo.Format = DateTimePickerFormat.Custom;
                dtp11_1drugo.Enabled = false;
                dtp11_1drugo.CustomFormat = " ";
                dtp11_1drugo.Format = DateTimePickerFormat.Custom;
                dtp11_1trece.Enabled = false;
                dtp11_1trece.CustomFormat = " ";
                dtp11_1trece.Format = DateTimePickerFormat.Custom;
                dtp11_1vise.Enabled = true;
                dtp11_1vise.CustomFormat = "yyyy";
                dtp11_1vise.Format = DateTimePickerFormat.Custom;
            }
        }
        private void btnDalje_Click(object sender, EventArgs e)
        {
            if (clb9.CheckedItems.Count == 0 && cmb11.Text == string.Empty)
            {
                DialogResult result = MessageBox.Show("Da li lice ima manje više od 12 godina?", "Unos", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    {
                        BazaDiplomskog.tmp_BRACNI_STATUS_FERTILITETRow red = bd.tmp_BRACNI_STATUS_FERTILITET.Newtmp_BRACNI_STATUS_FERTILITETRow();
                        red.id_osobe = id;
                        red.id_popisivac = id_popisivaca;
                        red.pitanje9 = null;
                        red.pitanje10 = null;
                        red.pitanje11 = null;
                        red.pitanje11_dete1 = null;
                        red.pitanje11_dete2 = null;
                        red.pitanje11_dete3 = null;
                        red.pitanje11_najmladje = null;
                        bd.tmp_BRACNI_STATUS_FERTILITET.Addtmp_BRACNI_STATUS_FERTILITETRow(red);
                        tmp_bracniAdapter.Update(bd.tmp_BRACNI_STATUS_FERTILITET);
                        MessageBox.Show("DODATO");
                    }
                }
                else
                {
                    MessageBox.Show("Nedostaje odgovor za pitanje 9!!!");
                }
            }
            else if ((clb9.SelectedIndex == 1 || clb9.SelectedIndex == 2) && cmb11.Text == string.Empty)
            {
                MessageBox.Show("Nedostaje odgovor za pitanje 11!!!");
            }
            else if (!cb10Da.Checked && !cb10Ne.Checked && clb9.SelectedIndex != 1 && clb9.SelectedIndex != 2)
            {
                MessageBox.Show("Nedostaje odgovor za pitanje 10!!!");
            }
            else if (cmb11.Text == string.Empty)
            {
                MessageBox.Show("Nedostaje odgovor za pitanje 11!!!");
            }
            else if (cmb11.SelectedIndex < 0)
            {
                MessageBox.Show("Nedostaje odgovor za pitanje 11.1!!!");
            }
            else
            {
                DialogResult pitanje = MessageBox.Show("Da li ste sigurni?", "Unos", MessageBoxButtons.YesNo);
                if (pitanje == DialogResult.Yes)
                {
                    BazaDiplomskog.tmp_BRACNI_STATUS_FERTILITETRow red = bd.tmp_BRACNI_STATUS_FERTILITET.Newtmp_BRACNI_STATUS_FERTILITETRow();
                    red.id_osobe = id;
                    red.id_popisivac = id_popisivaca;
                    red.pitanje9 = clb9.SelectedItem.ToString();
                    if (cb10Da.Checked)
                    {
                        red.pitanje10 = cb10Da.Text;
                    }
                    else if (cb10Ne.Checked)
                    {
                        red.pitanje10 = cb10Ne.Text;
                    }
                    red.pitanje11 = cmb11.Text;
                    if (dtp11_1prvo.Text == " ") { red.pitanje11_dete1 = null; }
                    else { red.pitanje11_dete1 = dtp11_1prvo.Text; }
                    if (dtp11_1drugo.Text == " ") { red.pitanje11_dete2 = null; }
                    else { red.pitanje11_dete2 = dtp11_1drugo.Text; }
                    if (dtp11_1trece.Text == " ") { red.pitanje11_dete3 = null; }
                    else { red.pitanje11_dete3 = dtp11_1trece.Text; }
                    if (dtp11_1vise.Text == " ") { red.pitanje11_najmladje = null; }
                    else { red.pitanje11_najmladje = dtp11_1vise.Text; }
                    bd.tmp_BRACNI_STATUS_FERTILITET.Addtmp_BRACNI_STATUS_FERTILITETRow(red);
                    tmp_bracniAdapter.Update(bd.tmp_BRACNI_STATUS_FERTILITET);
                    MessageBoxManager.Unregister();
                    frmEtnokultura forma = new frmEtnokultura(id, id_popisivaca);
                    this.Hide();
                    forma.ShowDialog();
                    this.Close();
                }
            }
        }

        private void dtp11_1prvo_EnabledChanged(object sender, EventArgs e)
        {
            if(dtp11_1prvo.Enabled)
            {
                dtp11_1prvo.CustomFormat = "yyyy";
                dtp11_1prvo.Format = DateTimePickerFormat.Custom;
            }
            else
            {
                dtp11_1prvo.CustomFormat = " ";
                dtp11_1prvo.Format = DateTimePickerFormat.Custom;
            }
        }

        private void dtp11_1drugo_EnabledChanged(object sender, EventArgs e)
        {
            if (dtp11_1drugo.Enabled)
            {
                dtp11_1drugo.CustomFormat = "yyyy";
                dtp11_1drugo.Format = DateTimePickerFormat.Custom;
            }
            else
            {
                dtp11_1drugo.CustomFormat = " ";
                dtp11_1drugo.Format = DateTimePickerFormat.Custom;
            }
        }

        private void dtp11_1trece_EnabledChanged(object sender, EventArgs e)
        {
            if (dtp11_1trece.Enabled)
            {
                dtp11_1trece.CustomFormat = "yyyy";
                dtp11_1trece.Format = DateTimePickerFormat.Custom;
            }
            else
            {
                dtp11_1trece.CustomFormat = " ";
                dtp11_1trece.Format = DateTimePickerFormat.Custom;
            }
        }

        private void dtp11_1vise_EnabledChanged(object sender, EventArgs e)
        {
            if (dtp11_1vise.Enabled)
            {
                dtp11_1vise.CustomFormat = "yyyy";
                dtp11_1vise.Format = DateTimePickerFormat.Custom;
            }
            else
            {
                dtp11_1vise.CustomFormat = " ";
                dtp11_1vise.Format = DateTimePickerFormat.Custom;
            }
        }

        private void cb10Da_CheckedChanged(object sender, EventArgs e)
        {
            if (cb10Da.Checked)
            {
                cb10Ne.Checked = false;
                lb11.Enabled = true;
            }
            else
            {
                lb11.Enabled = false;
            }
        }

        private void cb10Ne_CheckedChanged(object sender, EventArgs e)
        {
            if (cb10Ne.Checked)
            {
                cb10Da.Checked = false;
                lb11.Enabled = true;
            }
            else
            {
                lb11.Enabled = false;
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

        private void lb10_EnabledChanged(object sender, EventArgs e)
        {
            if(lb10.Enabled)
            {
                cb10Da.Enabled = true;
                cb10Ne.Enabled = true;
            }
            else
            {
                cb10Da.Checked = false;
                cb10Ne.Checked = false;
                cb10Da.Enabled = false;
                cb10Ne.Enabled = false;
            }
        }

        private void lb11_EnabledChanged(object sender, EventArgs e)
        {
            if(lb11.Enabled)
            {
                cmb11.Enabled = true;
            }
            else
            {
                cmb11.SelectedIndex = -1; ;
                cmb11.Enabled = false;
            }
        }

        private void cmb11_EnabledChanged(object sender, EventArgs e)
        {
            if (!cmb11.Enabled)
            {
                dtp11_1prvo.Enabled = false;
                dtp11_1prvo.CustomFormat = " ";
                dtp11_1prvo.Format = DateTimePickerFormat.Custom;
                dtp11_1drugo.Enabled = false;
                dtp11_1drugo.CustomFormat = " ";
                dtp11_1drugo.Format = DateTimePickerFormat.Custom;
                dtp11_1trece.Enabled = false;
                dtp11_1trece.CustomFormat = " ";
                dtp11_1trece.Format = DateTimePickerFormat.Custom;
                dtp11_1vise.Enabled = false;
                dtp11_1vise.CustomFormat = " ";
                dtp11_1vise.Format = DateTimePickerFormat.Custom;
            }
        }
    }
}

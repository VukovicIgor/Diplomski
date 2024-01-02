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
    public partial class frmEtnokultura : Form
    {
        int id;
        int id_popisivaca;
        BazaDiplomskog bd = new BazaDiplomskog();
        BazaDiplomskogTableAdapters.tmp_ETNO_KULTURATableAdapter tmp_etnoAdapter = new BazaDiplomskogTableAdapters.tmp_ETNO_KULTURATableAdapter();
        BazaDiplomskogTableAdapters.QueriesTableAdapter brisanje = new BazaDiplomskogTableAdapters.QueriesTableAdapter();
        public frmEtnokultura(int id, int id_popisivaca)
        {
            InitializeComponent();
            this.id = id;
            this.id_popisivaca = id_popisivaca;
            MessageBoxManager.Yes = "Da";
            MessageBoxManager.No = "Ne";
            MessageBoxManager.Register();
            brisanje.brisanje_tmp_etno(id_popisivaca);
            tmp_etnoAdapter.Fill(bd.tmp_ETNO_KULTURA);
        }

        private void btnDalje_Click(object sender, EventArgs e)
        {
            if(cmb13.Text==string.Empty)
            {
                MessageBox.Show("Nedostaje odgovor za pitanje 13!!!");
            }
            else
            {
                DialogResult result = MessageBox.Show("Da li ste sigurni?", "Unos", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    BazaDiplomskog.tmp_ETNO_KULTURARow red = bd.tmp_ETNO_KULTURA.Newtmp_ETNO_KULTURARow();
                    red.id_osobe = id;
                    red.id_popisivac = id_popisivaca;
                    if (cmb12.Text == string.Empty) { red.pitanje_12 = null; } else { red.pitanje_12 = cmb12.Text; }
                    red.pitanje_13 = cmb13.Text;
                    if (cmb14.Text == string.Empty) { red.pitanje_14 = null; } else { red.pitanje_14 = cmb14.Text; }
                    bd.tmp_ETNO_KULTURA.Addtmp_ETNO_KULTURARow(red);
                    tmp_etnoAdapter.Update(bd.tmp_ETNO_KULTURA);
                    MessageBoxManager.Unregister();
                    frmObrazovanje forma = new frmObrazovanje(id, id_popisivaca);
                    this.Hide();
                    forma.ShowDialog();
                    this.Close();
                }
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

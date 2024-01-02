using Diplomski.frm;
using Diplomski.frm.pitanja;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplomski
{
    public partial class frmPocetna : Form
    {
        int id_popisivaca;
        public frmPocetna(int id_popisivaca)
        {
            InitializeComponent();
            this.id_popisivaca = id_popisivaca;
            MessageBoxManager.Yes = "Da";
            MessageBoxManager.No = "Ne";
            MessageBoxManager.Register();
        }

        private void btnAdministracija_Click(object sender, EventArgs e)
        {
            MessageBoxManager.Unregister();
            frmAdministracija adm = new frmAdministracija(id_popisivaca);
            this.Hide();
            adm.ShowDialog();
            this.Close();
        }

        private void btnPopis_Click(object sender, EventArgs e)
        {
            MessageBoxManager.Unregister();
            frmOsoba os = new frmOsoba(id_popisivaca);
            this.Hide();
            os.ShowDialog();
            this.Close();
        }

        private void početnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Da li želite da se odjavite?", "Unos", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MessageBoxManager.Unregister();
                frmPrijava frm = new frmPrijava();
                this.Hide();
                frm.ShowDialog();
                this.Close();
            }
        }

        private void svaPitanjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxManager.Unregister();
            frmPitanja frm = new frmPitanja();
            frm.ShowDialog();
        }
    }
}

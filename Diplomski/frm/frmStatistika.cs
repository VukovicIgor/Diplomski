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

namespace Diplomski.frm
{
    public partial class frmStatistika : Form
    {
        int id_popisivaca;
        public frmStatistika(int id_popisivaca)
        {
            InitializeComponent();
            tv1.ExpandAll();
            MessageBoxManager.Yes = "Da";
            MessageBoxManager.No = "Ne";
            MessageBoxManager.Register();
            this.id_popisivaca = id_popisivaca;
        }

        private void svaPitanjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPitanja frm = new frmPitanja();
            frm.ShowDialog();
        }

        private void početnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Da li želite da se vratite na početnu stranu?", "Unos", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MessageBoxManager.Unregister();
                frmPocetna frm = new frmPocetna(id_popisivaca);
                this.Hide();
                frm.ShowDialog();
                this.Close();
            }
        }

        private void tv1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Name.Contains("_"))
            {
                frmUpit frm = new frmUpit(e.Node.Text, e.Node.Name);
                frm.ShowDialog();
            }
        }
    }
}

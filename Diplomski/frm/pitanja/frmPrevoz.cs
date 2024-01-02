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
    public partial class frmPrevoz : Form
    {
        BazaDiplomskog bd = new BazaDiplomskog();
        BazaDiplomskogTableAdapters.tmp_PREVOZTableAdapter tmp_prevozAdapter = new BazaDiplomskogTableAdapters.tmp_PREVOZTableAdapter();
        BazaDiplomskogTableAdapters.QueriesTableAdapter brisanje = new BazaDiplomskogTableAdapters.QueriesTableAdapter();
        int id;
        int id_popisivaca;
        string odgovor31 = "";
        public frmPrevoz(int id, int id_popisivaca)
        {
            InitializeComponent();
            tv31.ExpandAll();
            this.id = id;
            this.id_popisivaca = id_popisivaca;
            MessageBoxManager.Yes = "Da";
            MessageBoxManager.No = "Ne";
            MessageBoxManager.Register();
            brisanje.brisanje_tmp_prevoz(id_popisivaca);
            tmp_prevozAdapter.Fill(bd.tmp_PREVOZ);
        }

        private void tv31_BeforeCheck(object sender, TreeViewCancelEventArgs e)
        {
            for (int i = 0; i < tv31.Nodes.Count; i++)
            {
                if (tv31.Nodes[i].Name != e.Node.Name && tv31.Nodes[i].Checked == true && e.Node.Parent == null)
                {
                    tv31.Nodes[i].Checked = false;
                }
                for (int j = 0; j < tv31.Nodes[i].GetNodeCount(true); j++)
                {
                    if (tv31.Nodes[i].Nodes[j].Name != e.Node.Name && tv31.Nodes[i].Nodes[j].Checked == true)
                    {
                        tv31.Nodes[i].Nodes[j].Checked = false;
                    }
                    if (tv31.Nodes[i].Nodes[j].Name == e.Node.Name && tv31.Nodes[i].Checked != true)
                    {
                        tv31.Nodes[i].Checked = true;
                    }
                }
            }
        }
        private void tv31_AfterCheck(object sender, TreeViewEventArgs e)
        {

            for (int i = 0; i < tv31.Nodes.Count; i++)
            {
                for (int j = 0; j < tv31.Nodes[i].GetNodeCount(true); j++)
                {
                    if (tv31.Nodes[i].Nodes[j].Checked)
                    {
                        odgovor31=tv31.Nodes[i].Text + ": " + tv31.Nodes[i].Nodes[j].Text;
                    }
                }
            }
            
        }
        private void btnDalje_Click(object sender, System.EventArgs e)
        {
            DialogResult result = MessageBox.Show("Da li ste sigurni?", "Unos", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                BazaDiplomskog.tmp_PREVOZRow red = bd.tmp_PREVOZ.Newtmp_PREVOZRow();
                red.id_osobe = id;
                red.id_popisivac = id_popisivaca;
                red.pitanje31 = odgovor31;
                MessageBoxManager.Unregister();
                bd.tmp_PREVOZ.Addtmp_PREVOZRow(red);
                tmp_prevozAdapter.Update(bd.tmp_PREVOZ);
                frmFunkcionisanje forma = new frmFunkcionisanje(id, id_popisivaca);
                this.Hide();
                forma.ShowDialog();
                this.Close();
            }
        }

        private void svaPitanjaToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            frmPitanja frm = new frmPitanja();
            frm.ShowDialog();
        }

        private void početnaToolStripMenuItem_Click(object sender, System.EventArgs e)
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

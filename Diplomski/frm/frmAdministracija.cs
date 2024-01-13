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
    public partial class frmAdministracija : Form
    {
        BazaDiplomskog bd = new BazaDiplomskog();
        BazaDiplomskogTableAdapters.POPISIVACTableAdapter popisivacAdapter = new BazaDiplomskogTableAdapters.POPISIVACTableAdapter();

        int id_popisivaca;
        string korIme;
        public frmAdministracija(int id_popisivaca)
        {
            InitializeComponent();
            this.id_popisivaca=id_popisivaca;
            MessageBoxManager.Yes = "Da";
            MessageBoxManager.No = "Ne";
            MessageBoxManager.Register();
            popisivacAdapter.Fill(bd.POPISIVAC);

            korIme =
                (
                    from p in bd.POPISIVAC
                    where p.id_popisivaca==id_popisivaca
                    select p.email
                 ).FirstOrDefault();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (korIme == "supervizor")
            {
                MessageBoxManager.Unregister();
                frmUnosPopisivaca frm = new frmUnosPopisivaca(id_popisivaca);
                this.Hide();
                frm.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("Samo supervizor može dodati popisivača.");
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

        private void btnPopis_Click(object sender, EventArgs e)
        {
            MessageBoxManager.Unregister();
            frmStatistika frm = new frmStatistika(id_popisivaca);
            this.Hide();
            frm.ShowDialog();
            this.Hide();
        }
    }
}

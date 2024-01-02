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
    public partial class frmOsoba : Form
    {
        BazaDiplomskog bd = new BazaDiplomskog();
        BazaDiplomskogTableAdapters.tmp_OSOBATableAdapter tmp_osobaAdapter = new BazaDiplomskogTableAdapters.tmp_OSOBATableAdapter();
        BazaDiplomskogTableAdapters.OSOBATableAdapter osobaAdapter = new BazaDiplomskogTableAdapters.OSOBATableAdapter();
        BazaDiplomskogTableAdapters.QueriesTableAdapter brisanje = new BazaDiplomskogTableAdapters.QueriesTableAdapter();

        int id_popisivaca;
        public frmOsoba(int id_popisivaca)
        {
            InitializeComponent();
            brisanje.brisanje_tmp_osoba(id_popisivaca);
            tmp_osobaAdapter.Fill(bd.tmp_OSOBA);
            osobaAdapter.Fill(bd.OSOBA);
            dtpDatumRodjenja.MinDate = new DateTime(1850, 1, 1);
            dtpDatumRodjenja.MaxDate = DateTime.Now;
            cmbPol.SelectedIndex = 0;
            txtJMBG.MaxLength = 13;
            this.id_popisivaca = id_popisivaca;
            MessageBoxManager.Yes = "Da";
            MessageBoxManager.No = "Ne";
            MessageBoxManager.Register();

        }
        private void btnDalje_Click(object sender, EventArgs e)
        {
            int tmp_id = 
                (
                    from n in bd.tmp_OSOBA
                    select n.id_osobe
                ).LastOrDefault();

            int pravi_id =
                (
                    from n in bd.OSOBA
                    select n.id_osobe
                ).LastOrDefault();

            if (tmp_id<pravi_id)
            {
                tmp_id = pravi_id;
            }

            var tmp = from n in bd.OSOBA
                      where n.maticni_broj == txtJMBG.Text
                      select n.maticni_broj;

            int tmp_maticni = tmp.Count();

            if (tmp_maticni > 0)
            {
                MessageBox.Show("Zadati matični broj već postoji.");
            }
            else if (txtIme.Text.Length == 0)
            {
                MessageBox.Show("Potrebno je uneti ime.");
            }
            else if (txtPrezime.Text.Length == 0)
            {
                MessageBox.Show("Potrebno je uneti prezime.");
            }
            else if (txtJMBG.Text.Length != 13 || !txtJMBG.Text.All(char.IsDigit))
            {
                MessageBox.Show("Potrebno je uneti pravilno JMBG.");
            }
            else
            {
                DialogResult result = MessageBox.Show("Da li ste sigurni?", "Unos", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    BazaDiplomskog.tmp_OSOBARow red = bd.tmp_OSOBA.Newtmp_OSOBARow();
                    int id = tmp_id + 1;
                    red.id_popisivac = id_popisivaca;
                    red.id_osobe = id;
                    red.ime = txtIme.Text;
                    red.prezime = txtPrezime.Text;
                    red.pol = cmbPol.SelectedItem.ToString();
                    red.datum_rodjenja = dtpDatumRodjenja.Value;
                    red.maticni_broj = txtJMBG.Text;
                    bd.tmp_OSOBA.Addtmp_OSOBARow(red);
                    tmp_osobaAdapter.Update(bd.tmp_OSOBA);
                    MessageBoxManager.Unregister();

                    frmMigracije forma = new frmMigracije(id, id_popisivaca);
                    this.Hide();
                    forma.ShowDialog();
                    this.Close();
                }
            }
        }

        private void svaPitanjažToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPitanja frm = new frmPitanja();
            frm.ShowDialog();
        }

        private void početnaToolStripMenuItem_Click_1(object sender, EventArgs e)
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

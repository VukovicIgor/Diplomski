using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using Diplomski.frm.pitanja;
using System.Security.Cryptography;

namespace Diplomski
{
    public partial class frmUnosPopisivaca : Form
    {
        BazaDiplomskog bd = new BazaDiplomskog();
        BazaDiplomskogTableAdapters.POPISIVACTableAdapter popisivacAdapter = new BazaDiplomskogTableAdapters.POPISIVACTableAdapter();
        BazaDiplomskogTableAdapters.OSOBATableAdapter osobaAdapter = new BazaDiplomskogTableAdapters.OSOBATableAdapter();
        int id_popisivaca;
        public frmUnosPopisivaca(int id_popisivaca)
        {
            InitializeComponent();
            popisivacAdapter.Fill(bd.POPISIVAC);
            osobaAdapter.Fill(bd.OSOBA);
            this.id_popisivaca = id_popisivaca;
            MessageBoxManager.Yes = "Da";
            MessageBoxManager.No = "Ne";
            MessageBoxManager.Register();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            BazaDiplomskog.POPISIVACRow red = bd.POPISIVAC.NewPOPISIVACRow();
            if (txtJMBG.Text.Length < 13 || txtJMBG.Text.Length > 13 || txtJMBG.Text.All(char.IsLetter))
            {
                MessageBox.Show("Potrebno je uneti pravilno JMBG.");
            }
            else if (txtLK.Text.Length < 0 || txtLK.Text.Length > 9 || txtLK.Text.All(char.IsLetter))
            {
                MessageBox.Show("Potrebno je uneti pravilno broj lične karte.");
            }
            else if (!Validiranje(txtEmail.Text))
            {
                MessageBox.Show("Potrebno je pravilno uneti email.");
            }
            else if (txtSifra.Text.Length < 8)
            {
                MessageBox.Show("Šifra mora imati više od 8 karaktera.");
            }
            else if (!txtSifra.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Šifra mora imati broj.");
            }
            else if (!txtSifra.Text.Any(char.IsPunctuation))
            {
                MessageBox.Show("Šifra mora imati specijalni karakter.");
            }
            else if (txtPonSifra.Text != txtSifra.Text)
            {
                MessageBox.Show("Šifre moraju biti iste.");
            }
            else
            {
                var tmp =
                    from n in bd.OSOBA
                    where n.maticni_broj == txtJMBG.Text
                    select n.id_osobe;

                var tmp1 =
                    from n in bd.POPISIVAC
                    where n.maticni_broj == txtJMBG.Text
                    select n.id_popisivaca;

                int postojiOsoba = tmp.Count();
                int postojiPopisivac = tmp1.Count();
                if (postojiOsoba == 0)
                {
                    MessageBox.Show("Prvo treba uraditi popis za zadatu osobu.");
                }
                else if (postojiPopisivac > 0)
                {
                    MessageBox.Show("Postoji popisivač sa zadatim matičnim brojem.");
                }
                else
                {
                    var tmp_id =
                        (
                            from n in bd.POPISIVAC
                            select n.id_popisivaca
                        ).LastOrDefault();
                    red.id_popisivaca = tmp_id + 1;
                    red.maticni_broj = txtJMBG.Text;
                    red.licna_karta = txtLK.Text;
                    red.email = txtEmail.Text;
                    red.sifra = Kodiranje(txtSifra.Text);
                    bd.POPISIVAC.AddPOPISIVACRow(red);
                    popisivacAdapter.Update(bd.POPISIVAC);
                    MessageBoxManager.Unregister();
                    frmPocetna frm = new frmPocetna(id_popisivaca);
                    this.Hide();
                    frm.ShowDialog();
                    this.Close();
                }
            }
        }
        static string Kodiranje(string password)
        {
            var hash = new SHA1Managed().ComputeHash(Encoding.UTF8.GetBytes(password));
            return string.Concat(hash.Select(b => b.ToString("x2")));
        }
        private static bool Validiranje(string email)
        {
            var validno = true;

            try
            {
                var emailAddress = new MailAddress(email);
            }
            catch
            {
                validno = false;
            }

            return validno;
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
    }

}

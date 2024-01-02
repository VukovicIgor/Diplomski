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
    public partial class frmPrijava : Form
    {
        BazaDiplomskog bd = new BazaDiplomskog();
        BazaDiplomskogTableAdapters.POPISIVACTableAdapter popisivacAdapter = new BazaDiplomskogTableAdapters.POPISIVACTableAdapter();
        string psw;
        public frmPrijava()
        {
            InitializeComponent();
            popisivacAdapter.Fill(bd.POPISIVAC);
        }

        private void frmPrijava_Load(object sender, EventArgs e)
        {

        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            Prijava();
        }

        private void txtKorIme_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Prijava();
            }
        }

        private void txtSifra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Prijava();
            }
        }

        private void Prijava()
        {
            var korIme =
                (
                    from p in bd.POPISIVAC
                    where p.email == txtKorIme.Text
                    select p.email
                 ).FirstOrDefault();

            var sifra =
                (
                    from p in bd.POPISIVAC
                    where p.email == txtKorIme.Text
                    select p.sifra
                ).FirstOrDefault();

            if (sifra!=null)
                psw = Dekodiranje(sifra);

            int id_popisivaca;
            if (korIme==txtKorIme.Text && psw == txtSifra.Text)
            {
                id_popisivaca =
                (
                    from p in bd.POPISIVAC
                    where p.email == txtKorIme.Text
                    select p.id_popisivaca
                ).FirstOrDefault();

                frmPocetna pocetna = new frmPocetna(id_popisivaca);
                this.Hide();
                pocetna.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Niste uneli dobro korisničko ime ili šifru!!!");
            }
        }
        public string Dekodiranje(string sifra)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(sifra);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }
    }
}

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
    public partial class frmObjekat : Form
    {
        BazaDiplomskog bd = new BazaDiplomskog();
        BazaDiplomskogTableAdapters.NASELJETableAdapter naseljeAdapter = new BazaDiplomskogTableAdapters.NASELJETableAdapter();
        BazaDiplomskogTableAdapters.OPSTINATableAdapter opstinaAdapter = new BazaDiplomskogTableAdapters.OPSTINATableAdapter();
        BazaDiplomskogTableAdapters.tmp_OBJEKATTableAdapter tmp_objekatAdapter = new BazaDiplomskogTableAdapters.tmp_OBJEKATTableAdapter();
        BazaDiplomskogTableAdapters.OBJEKATTableAdapter objekatAdapter = new BazaDiplomskogTableAdapters.OBJEKATTableAdapter();
        BazaDiplomskogTableAdapters.QueriesTableAdapter brisanje = new BazaDiplomskogTableAdapters.QueriesTableAdapter();
        BazaDiplomskogTableAdapters.QueriesTableAdapter upis = new BazaDiplomskogTableAdapters.QueriesTableAdapter();
        int id;
        int id_popisivaca;
        public frmObjekat(int id, int id_popisivaca)
        {
            InitializeComponent();
            this.id = id;
            this.id_popisivaca = id_popisivaca;
            brisanje.brisanje_tmp_objekat(id_popisivaca);
            naseljeAdapter.Fill(bd.NASELJE);
            opstinaAdapter.Fill(bd.OPSTINA);
            objekatAdapter.Fill(bd.OBJEKAT);
            tmp_objekatAdapter.Fill(bd.tmp_OBJEKAT);
            MessageBoxManager.Yes = "Da";
            MessageBoxManager.No = "Ne";
            MessageBoxManager.Register();
        }

        private void frmAdresa_Load(object sender, EventArgs e)
        {

            cmbOpstina.DataSource = bd.OPSTINA.CopyToDataTable();
            cmbOpstina.DisplayMember = "naziv";
            var sifra_opstine = (from o in bd.OPSTINA
                                 where o.naziv.Contains(cmbOpstina.Text)
                                 select o.sifra_opstine).FirstOrDefault();

            var naselja = (from n in bd.NASELJE
                           where n.sifra_opstine == sifra_opstine
                           select n);

            if (naselja.Any())
            {
                cmbNaselje.DataSource = naselja.CopyToDataTable();
                cmbNaselje.DisplayMember = "naziv";
            }
        }

        private void cmbOpstina_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sifra_opstine = (from o in bd.OPSTINA
                                 where o.naziv.Contains(cmbOpstina.Text)
                                 select o.sifra_opstine).FirstOrDefault();

            var naselja = (from n in bd.NASELJE
                           where n.sifra_opstine == sifra_opstine
                           select n);

            if (naselja.Any())
            {
                cmbNaselje.DataSource = naselja.CopyToDataTable();
                cmbNaselje.DisplayMember = "naziv";
            }
        }

        private void btnDalje_Click(object sender, EventArgs e)
        {
            if (txtUlica.Text == string.Empty)
                MessageBox.Show("Niste uneli adresu!!!");
            else if (txtBrojObjekta.Text == string.Empty)
                MessageBox.Show("Niste uneli broj objekta!!!");
            else
            {
                DialogResult pitanje = MessageBox.Show("Da li ste sigurni?", "Unos", MessageBoxButtons.YesNo);
                if (pitanje == DialogResult.Yes)
                {
                    var tmp_id = (from n in bd.tmp_OBJEKAT
                                  select n.id_objekta).LastOrDefault();

                    var pravi_id = (from n in bd.OBJEKAT
                                  select n.id_objekta).LastOrDefault();

                    if (tmp_id<pravi_id)
                    {
                        tmp_id = pravi_id;
                    }
                    MessageBoxManager.Unregister();
                    BazaDiplomskog.tmp_OBJEKATRow red = bd.tmp_OBJEKAT.Newtmp_OBJEKATRow();
                    red.id_osobe = id;
                    red.id_objekta = tmp_id+1;
                    red.id_popisivac = id_popisivaca;
                    red.opstina = cmbOpstina.Text;
                    red.naselje = cmbNaselje.Text;
                    red.ulica = txtUlica.Text;
                    red.broj_objekta = txtBrojObjekta.Text;
                    if (txtBrojStana.Text != string.Empty)
                        red.broj_stana = txtBrojStana.Text;
                    bd.tmp_OBJEKAT.Addtmp_OBJEKATRow(red);
                    tmp_objekatAdapter.Update(bd.tmp_OBJEKAT);
                    var postoji = (from o in bd.OBJEKAT
                                   where o.opstina == cmbOpstina.Text && o.naselje == cmbNaselje.Text && o.ulica == txtUlica.Text 
                                   && o.broj_objekta == txtBrojObjekta.Text && o.broj_stana == txtBrojStana.Text
                                   select o).Count();

                    if(postoji>0)
                    {
                        upisTabela();
                        frmPocetna forma = new frmPocetna(id_popisivaca);
                        this.Hide();
                        forma.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        frmOZgradi forma = new frmOZgradi(id, id_popisivaca);
                        this.Hide();
                        forma.ShowDialog();
                        this.Close();
                    }
                }
            }
        }

        private void svaPitanjaToolStripMenuItem_Click_1(object sender, EventArgs e)
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
        }
    }
}

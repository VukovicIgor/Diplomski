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
    public partial class frmUpit : Form
    {
        BazaDiplomskog bd = new BazaDiplomskog();
        BazaDiplomskogTableAdapters.BRACNI_STATUS_FERTILITETTableAdapter bracniStatus = new BazaDiplomskogTableAdapters.BRACNI_STATUS_FERTILITETTableAdapter();
        BazaDiplomskogTableAdapters.DRZAVETableAdapter drzave = new BazaDiplomskogTableAdapters.DRZAVETableAdapter();
        BazaDiplomskogTableAdapters.EKONOMSKA_AKTIVNOSTTableAdapter ekoAktivnost = new BazaDiplomskogTableAdapters.EKONOMSKA_AKTIVNOSTTableAdapter();
        BazaDiplomskogTableAdapters.ETNO_KULTURATableAdapter etnoKultura = new BazaDiplomskogTableAdapters.ETNO_KULTURATableAdapter();
        BazaDiplomskogTableAdapters.FUNKCIONISANJE_SOCIJALNA_INTEGRISANOSTTableAdapter socIntegrisanost = new BazaDiplomskogTableAdapters.FUNKCIONISANJE_SOCIJALNA_INTEGRISANOSTTableAdapter();
        BazaDiplomskogTableAdapters.GRADTableAdapter grad = new BazaDiplomskogTableAdapters.GRADTableAdapter();
        BazaDiplomskogTableAdapters.MIGRACIJETableAdapter migracije = new BazaDiplomskogTableAdapters.MIGRACIJETableAdapter();
        BazaDiplomskogTableAdapters.NASELJETableAdapter naselje = new BazaDiplomskogTableAdapters.NASELJETableAdapter();
        BazaDiplomskogTableAdapters.NSTJ1TableAdapter nstj1 = new BazaDiplomskogTableAdapters.NSTJ1TableAdapter();
        BazaDiplomskogTableAdapters.NSTJ2TableAdapter nstj2 = new BazaDiplomskogTableAdapters.NSTJ2TableAdapter();
        BazaDiplomskogTableAdapters.NSTJ3TableAdapter nstj3 = new BazaDiplomskogTableAdapters.NSTJ3TableAdapter();
        BazaDiplomskogTableAdapters.OBJEKATTableAdapter objekat = new BazaDiplomskogTableAdapters.OBJEKATTableAdapter();
        BazaDiplomskogTableAdapters.OBRAZOVANJETableAdapter obrazovanje = new BazaDiplomskogTableAdapters.OBRAZOVANJETableAdapter();
        BazaDiplomskogTableAdapters.OPSTINATableAdapter opstina = new BazaDiplomskogTableAdapters.OPSTINATableAdapter();
        BazaDiplomskogTableAdapters.OSOBATableAdapter osoba = new BazaDiplomskogTableAdapters.OSOBATableAdapter();
        BazaDiplomskogTableAdapters.O_DOMACINSTVUTableAdapter domacinstvo = new BazaDiplomskogTableAdapters.O_DOMACINSTVUTableAdapter();
        BazaDiplomskogTableAdapters.O_STANUTableAdapter stan = new BazaDiplomskogTableAdapters.O_STANUTableAdapter();
        BazaDiplomskogTableAdapters.O_ZGRADITableAdapter zgrada = new BazaDiplomskogTableAdapters.O_ZGRADITableAdapter();
        BazaDiplomskogTableAdapters.PREVOZTableAdapter prevoz = new BazaDiplomskogTableAdapters.PREVOZTableAdapter();
        BazaDiplomskogTableAdapters.UPRAVNI_OKRUGTableAdapter okrug = new BazaDiplomskogTableAdapters.UPRAVNI_OKRUGTableAdapter();

        List<string> PolLista = new List<string>();


        string tekst;
        string naziv;
        public frmUpit(string tekst, string naziv)
        {
            InitializeComponent();
            bracniStatus.Fill(bd.BRACNI_STATUS_FERTILITET);
            drzave.Fill(bd.DRZAVE);
            ekoAktivnost.Fill(bd.EKONOMSKA_AKTIVNOST);
            etnoKultura.Fill(bd.ETNO_KULTURA);
            socIntegrisanost.Fill(bd.FUNKCIONISANJE_SOCIJALNA_INTEGRISANOST);
            grad.Fill(bd.GRAD);
            migracije.Fill(bd.MIGRACIJE);
            naselje.Fill(bd.NASELJE);
            nstj1.Fill(bd.NSTJ1);
            nstj2.Fill(bd.NSTJ2);
            nstj3.Fill(bd.NSTJ3);
            objekat.Fill(bd.OBJEKAT);
            obrazovanje.Fill(bd.OBRAZOVANJE);
            opstina.Fill(bd.OPSTINA);
            osoba.Fill(bd.OSOBA);
            domacinstvo.Fill(bd.O_DOMACINSTVU);
            stan.Fill(bd.O_STANU);
            zgrada.Fill(bd.O_ZGRADI);
            prevoz.Fill(bd.PREVOZ);
            okrug.Fill(bd.UPRAVNI_OKRUG);
            this.tekst = tekst;
            this.naziv = naziv;
            PolLista.Add("Muško i Žensko");
            PolLista.Add("Muško");
            PolLista.Add("Žensko");
            for (int i = 0; i < dgv1.Columns.Count; i++)
            {
                this.dgv1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void frmUpit_Load(object sender, EventArgs e)
        {
            this.Text = tekst;
            List<string> lista = new List<string>();
            DataTable dt = new DataTable();
            switch (naziv)
            {
                case "stanovnistvo1_1":
                    dt = new DataTable();

                    dt.Columns.Add(" ", typeof(string));
                    dt.Columns.Add("Ukupno", typeof(string));
                    dt.Columns.Add("Ukupno muškaraca", typeof(string));
                    dt.Columns.Add("Ukupno žena", typeof(string));
                    dt.Columns.Add("Ukupno Srba", typeof(string));
                    dt.Columns.Add("Ukupno Srba (muškaraca)", typeof(string));
                    dt.Columns.Add("Ukupno Srba (žena)", typeof(string));
                    dt.Columns.Add("Ukupno - ostale nacije", typeof(string));
                    dt.Columns.Add("Ukupno - ostale nacije (muškaraca)", typeof(string));
                    dt.Columns.Add("Ukupno - ostale nacije (žena)", typeof(string));

                    pripadnost_pol(dt);
                    dgv1.DataSource = dt;
                    break;

                case "stanovnistvo1_2":
                    dt = new DataTable();

                    dt.Columns.Add("Nacionalnost", typeof(string));
                    dt.Columns.Add("Republika Srbija", typeof(string));
                    lista = new List<string>();
                    lista.Add("Ukupno");
                    var tmp1 =
                    (
                        from ek in bd.ETNO_KULTURA
                        select ek.id_osobe
                    ).Count();
                    lista.Add(tmp1.ToString());
                    dt.Rows.Add(lista.ToArray());

                    lista = new List<string>();
                    lista.Add("Srbi");
                    tmp1 =
                    (
                        from ek in bd.ETNO_KULTURA
                        where ek.pitanje_12 == "Srbin/Srpkinja"
                        select ek.id_osobe
                    ).Count();
                    lista.Add(tmp1.ToString());
                    dt.Rows.Add(lista.ToArray());

                    lista = new List<string>();
                    lista.Add("Bošnjaci");
                    tmp1 =
                    (
                        from ek in bd.ETNO_KULTURA
                        where ek.pitanje_12 == "Bošnjak/Bošnjakinja"
                        select ek.id_osobe
                    ).Count();
                    lista.Add(tmp1.ToString());
                    dt.Rows.Add(lista.ToArray());
                    
                    lista = new List<string>();
                    lista.Add("Romi");
                    tmp1 =
                    (
                        from ek in bd.ETNO_KULTURA
                        where ek.pitanje_12 == "Rom/Romkinja"
                        select ek.id_osobe
                    ).Count();
                    lista.Add(tmp1.ToString());
                    dt.Rows.Add(lista.ToArray());

                    lista = new List<string>();
                    lista.Add("Crnogorci");
                    tmp1 =
                    (
                        from ek in bd.ETNO_KULTURA
                        where ek.pitanje_12 == "Crnogorac/Crnogorka"
                        select ek.id_osobe
                    ).Count();
                    lista.Add(tmp1.ToString());
                    dt.Rows.Add(lista.ToArray());

                    lista = new List<string>();
                    lista.Add("Slovaci");
                    tmp1 =
                    (
                        from ek in bd.ETNO_KULTURA
                        where ek.pitanje_12 == "Slovak/Slovakinja"
                        select ek.id_osobe
                    ).Count();
                    lista.Add(tmp1.ToString());
                    dt.Rows.Add(lista.ToArray()); 

                    lista = new List<string>();
                    lista.Add("Makedonci");
                    tmp1 =
                    (
                        from ek in bd.ETNO_KULTURA
                        where ek.pitanje_12 == "Makedonac/Makedonka"
                        select ek.id_osobe
                    ).Count();
                    lista.Add(tmp1.ToString());
                    dt.Rows.Add(lista.ToArray());

                    dgv1.DataSource = dt;
                    break;
                case "stanovnistvo2_1":
                    dt = new DataTable();
                    dt.Columns.Add(" ", typeof(string));
                    dt.Columns.Add("  ", typeof(string));
                    dt.Columns.Add("Ukupno", typeof(string));
                    dgv1.DataSource = dt;
                    nacionalna_pripadnost(dt);
                    break;
                case "stanovnistvo2_2":
                    dt = new DataTable();
                    dt.Columns.Add(" ", typeof(string));
                    dt.Columns.Add("Ukupno", typeof(string));
                    dt.Columns.Add("Muško", typeof(string));
                    dt.Columns.Add("Žensko", typeof(string));

                    lista = new List<string>();

                    double tmp;
                    tmp =
                        (
                        from o in bd.OSOBA
                        select DateTime.Today.Year - o.datum_rodjenja.Year
                        ).DefaultIfEmpty().Average();
                    lista.Add("Republika Srbija");
                    lista.Add(tmp.ToString());

                    tmp =
                        (
                        from o in bd.OSOBA
                        where o.pol == "Muško"
                        select DateTime.Today.Year - o.datum_rodjenja.Year

                        ).DefaultIfEmpty().Average();
                    lista.Add(tmp.ToString());

                    tmp =
                        (
                        from o in bd.OSOBA
                        where o.pol == "Žensko"
                        select DateTime.Today.Year - o.datum_rodjenja.Year
                        ).DefaultIfEmpty().Average();
                    lista.Add(tmp.ToString());
                    dt.Rows.Add(lista.ToArray());
                    prosek_godina(dt);
                    dgv1.DataSource = dt;
                    break;

                case "stanovnistvo3_1":
                    dt = new DataTable();
                    dt.Columns.Add("Veroispovest", typeof(string));
                    dt.Columns.Add("Ukupno", typeof(string));
                    dt.Columns.Add("Svega hrišćanska", typeof(string));
                    dt.Columns.Add("Pravoslavna", typeof(string));
                    dt.Columns.Add("Katolička", typeof(string));
                    dt.Columns.Add("Protestantska", typeof(string));
                    dt.Columns.Add("Ostale hrišćanske", typeof(string));
                    dt.Columns.Add("Islamska", typeof(string));
                    dt.Columns.Add("Judeistička", typeof(string));
                    dt.Columns.Add("Istočnjačke veroispovesti", typeof(string));
                    dt.Columns.Add("Ostale veroispovesti", typeof(string));
                    dt.Columns.Add("Agnostici", typeof(string));
                    dt.Columns.Add("Ateisti", typeof(string));
                    dt.Columns.Add("Nisu se izjasnili", typeof(string));
                    veroispovest(dt);
                    dgv1.DataSource = dt;
                    break;

                case "stanovnistvo3_2":
                    dt = new DataTable();
                    dt.Columns.Add(" ", typeof(string));
                    dt.Columns.Add("Ukupno", typeof(string));
                    dt.Columns.Add("Ukupno - muško", typeof(string));
                    dt.Columns.Add("Ukupno - žensko", typeof(string));
                    dt.Columns.Add("Srpski - ukupno", typeof(string));
                    dt.Columns.Add("Srpski - muško", typeof(string));
                    dt.Columns.Add("Srpski - žensko", typeof(string));
                    dt.Columns.Add("Crnogorski - ukupno", typeof(string));
                    dt.Columns.Add("Crnogorski - muško", typeof(string));
                    dt.Columns.Add("Crnogorski - žensko", typeof(string));
                    dt.Columns.Add("Makedonski - ukupno", typeof(string));
                    dt.Columns.Add("Makedonski - muško", typeof(string));
                    dt.Columns.Add("Makedonski - žensko", typeof(string));
                    dt.Columns.Add("Ostali jezici - ukupno", typeof(string));
                    dt.Columns.Add("Ostali jezici - muško", typeof(string));
                    dt.Columns.Add("Ostali jezici - žensko", typeof(string));
                    dgv1.DataSource = dt;
                    maternji_jezik(dt);
                    break;
                case "porodice_1":
                    dt = new DataTable();
                    dt.Columns.Add("Teritorija", typeof(string));
                    dt.Columns.Add("Tip naselja", typeof(string));
                    dt.Columns.Add("Ukupno", typeof(string));
                    dt.Columns.Add("Bračni par bez dece", typeof(string));
                    dt.Columns.Add("Vanbračni par bez dece", typeof(string));
                    dt.Columns.Add("Bračni par sa decom", typeof(string));
                    dt.Columns.Add("Vanbračni par sa decom", typeof(string));
                    dgv1.DataSource = dt;
                    porodica_tip(dt);
                    break;

                case "stanovi_1":
                    dt = new DataTable();
                    dt.Columns.Add("Teritorija", typeof(string));
                    dt.Columns.Add("Tip naselja", typeof(string));
                    dt.Columns.Add("Ukupno", typeof(string));
                    dt.Columns.Add("do 30m²", typeof(string));
                    dt.Columns.Add("31m² - 40m²", typeof(string));
                    dt.Columns.Add("41m² - 50m²", typeof(string));
                    dt.Columns.Add("51m² - 60m²", typeof(string));
                    dt.Columns.Add("61m² - 80m²", typeof(string));
                    dt.Columns.Add("81m² - 100m²", typeof(string));
                    dt.Columns.Add("101m² - 120m²", typeof(string));
                    dt.Columns.Add("121m² - 150m²", typeof(string));
                    dt.Columns.Add("151m² i više", typeof(string));
                    dgv1.DataSource = dt;

                    povrsina(dt);
                    break;

                case "stanovi_2":
                    dt = new DataTable();
                    dt.Columns.Add("Teritorija", typeof(string));
                    dt.Columns.Add("Tip naselja", typeof(string));
                    dt.Columns.Add("Ukupno", typeof(string));
                    dt.Columns.Add("Ugalj", typeof(string));
                    dt.Columns.Add("Drvo i sl.", typeof(string));
                    dt.Columns.Add("Mazut i ulje za loženje", typeof(string));
                    dt.Columns.Add("Plinsko/gasno gorivo", typeof(string));
                    dt.Columns.Add("Električna energija", typeof(string));
                    dt.Columns.Add("Druga vrsta energije", typeof(string));
                    dgv1.DataSource = dt;

                    grejanje(dt);
                    break;
            }
        }
        private void pripadnost_pol(DataTable dt)
        {
            var ukupno =
             (
                 from o in bd.OSOBA
                 select o.id_osobe
             ).Count();

            var ukupno_muskaraca =
                (
                    from o in bd.OSOBA
                    where o.pol == "Muško"
                    select o.id_osobe
                ).Count();

            var ukupno_zena =
                (
                    from o in bd.OSOBA
                    where o.pol == "Žensko"
                    select o.id_osobe
                ).Count();

            var ukupno_srba =
                (
                    from ek in bd.ETNO_KULTURA
                    where ek.pitanje_12 == "Srbin/Srpkinja"
                    select ek.id_osobe
                ).Count();

            var ukupno_srba_muskaraca =
                (
                    from ek in bd.ETNO_KULTURA
                    join o in bd.OSOBA on ek.id_osobe equals o.id_osobe
                    where o.pol == "Muško" && ek.pitanje_12 == "Srbin/Srpkinja"
                    select ek.id_osobe
                ).Count();

            var ukupno_srba_zena =
                (
                    from ek in bd.ETNO_KULTURA
                    join o in bd.OSOBA on ek.id_osobe equals o.id_osobe
                    where o.pol == "Žensko" && ek.pitanje_12 == "Srbin/Srpkinja"
                    select ek.id_osobe
                ).Count();

            var ukupno_ostalih =
                (
                    from ek in bd.ETNO_KULTURA
                    where ek.pitanje_12 != "Srbin/Srpkinja"
                    select ek.id_osobe
                ).Count();

            var ukupno_ostalih_muskaraca =
                (
                    from ek in bd.ETNO_KULTURA
                    join o in bd.OSOBA on ek.id_osobe equals o.id_osobe
                    where o.pol == "Muško" && ek.pitanje_12 != "Srbin/Srpkinja"
                    select ek.id_osobe
                ).Count();

            var ukupno_ostalih_zena =
                (
                    from ek in bd.ETNO_KULTURA
                    join o in bd.OSOBA on ek.id_osobe equals o.id_osobe
                    where o.pol == "Žensko" && ek.pitanje_12 != "Srbin/Srpkinja"
                    select ek.id_osobe
                ).Count();

            dt.Rows.Add("Republika Srbija", ukupno, ukupno_muskaraca, ukupno_zena, ukupno_srba, ukupno_srba_muskaraca, ukupno_srba_zena, ukupno_ostalih, ukupno_ostalih_muskaraca, ukupno_ostalih_zena);

            foreach (DataRow red in bd.UPRAVNI_OKRUG.Rows)
            {
                foreach (DataColumn dc in bd.UPRAVNI_OKRUG.Columns)
                {
                    List<string> tmp = new List<string>();
                    if (dc.ColumnName == "naziv")
                    {
                        tmp.Add(red["naziv"].ToString());
                        ukupno =
                        (
                            from o in bd.OSOBA
                            join ob in bd.OBJEKAT on o.id_osobe equals ob.id_osobe
                            join op in bd.OPSTINA on ob.opstina equals op.naziv
                            join uo in bd.UPRAVNI_OKRUG on op.sifra_okruga equals uo.sifra_okruga
                            where uo.naziv == red["naziv"].ToString()
                            select o.id_osobe
                        ).Count();
                        tmp.Add(ukupno.ToString());

                        ukupno_muskaraca =
                            (
                                from o in bd.OSOBA
                                join ob in bd.OBJEKAT on o.id_osobe equals ob.id_osobe
                                join op in bd.OPSTINA on ob.opstina equals op.naziv
                                join uo in bd.UPRAVNI_OKRUG on op.sifra_okruga equals uo.sifra_okruga
                                where uo.naziv == red["naziv"].ToString() && o.pol == "Muško"
                                select o.id_osobe
                            ).Count();
                        tmp.Add(ukupno_muskaraca.ToString());

                        ukupno_zena =
                        (
                            from o in bd.OSOBA
                            join ob in bd.OBJEKAT on o.id_osobe equals ob.id_osobe
                            join op in bd.OPSTINA on ob.opstina equals op.naziv
                            join uo in bd.UPRAVNI_OKRUG on op.sifra_okruga equals uo.sifra_okruga
                            where uo.naziv == red["naziv"].ToString() && o.pol == "Žensko"
                            select o.id_osobe
                        ).Count();
                        tmp.Add(ukupno_zena.ToString());

                        ukupno_srba =
                            (
                                from o in bd.OSOBA
                                join ek in bd.ETNO_KULTURA on o.id_osobe equals ek.id_osobe
                                join ob in bd.OBJEKAT on o.id_osobe equals ob.id_osobe
                                join op in bd.OPSTINA on ob.opstina equals op.naziv
                                join uo in bd.UPRAVNI_OKRUG on op.sifra_okruga equals uo.sifra_okruga
                                where uo.naziv == red["naziv"].ToString() && ek.pitanje_12 == "Srbin/Srpkinja"
                                select o.id_osobe
                            ).Count();
                        tmp.Add(ukupno_srba.ToString());

                        ukupno_srba_muskaraca =
                            (
                                from o in bd.OSOBA
                                join ek in bd.ETNO_KULTURA on o.id_osobe equals ek.id_osobe
                                join ob in bd.OBJEKAT on o.id_osobe equals ob.id_osobe
                                join op in bd.OPSTINA on ob.opstina equals op.naziv
                                join uo in bd.UPRAVNI_OKRUG on op.sifra_okruga equals uo.sifra_okruga
                                where uo.naziv == red["naziv"].ToString() && ek.pitanje_12 == "Srbin/Srpkinja" && o.pol == "Muško"
                                select o.id_osobe
                            ).Count();
                        tmp.Add(ukupno_srba_muskaraca.ToString());

                        ukupno_srba_zena =
                            (
                                from o in bd.OSOBA
                                join ek in bd.ETNO_KULTURA on o.id_osobe equals ek.id_osobe
                                join ob in bd.OBJEKAT on o.id_osobe equals ob.id_osobe
                                join op in bd.OPSTINA on ob.opstina equals op.naziv
                                join uo in bd.UPRAVNI_OKRUG on op.sifra_okruga equals uo.sifra_okruga
                                where uo.naziv == red["naziv"].ToString() && ek.pitanje_12 == "Srbin/Srpkinja" && o.pol == "Žensko"
                                select o.id_osobe
                            ).Count();
                        tmp.Add(ukupno_srba_zena.ToString());

                        ukupno_ostalih =
                            (
                                from o in bd.OSOBA
                                join ek in bd.ETNO_KULTURA on o.id_osobe equals ek.id_osobe
                                join ob in bd.OBJEKAT on o.id_osobe equals ob.id_osobe
                                join op in bd.OPSTINA on ob.opstina equals op.naziv
                                join uo in bd.UPRAVNI_OKRUG on op.sifra_okruga equals uo.sifra_okruga
                                where uo.naziv == red["naziv"].ToString() && ek.pitanje_12 != "Srbin/Srpkinja"
                                select o.id_osobe
                            ).Count();
                        tmp.Add(ukupno_ostalih.ToString());

                        ukupno_ostalih_muskaraca =
                            (
                                from o in bd.OSOBA
                                join ek in bd.ETNO_KULTURA on o.id_osobe equals ek.id_osobe
                                join ob in bd.OBJEKAT on o.id_osobe equals ob.id_osobe
                                join op in bd.OPSTINA on ob.opstina equals op.naziv
                                join uo in bd.UPRAVNI_OKRUG on op.sifra_okruga equals uo.sifra_okruga
                                where uo.naziv == red["naziv"].ToString() && ek.pitanje_12 != "Srbin/Srpkinja" && o.pol == "Muško"
                                select o.id_osobe
                            ).Count();
                        tmp.Add(ukupno_ostalih_muskaraca.ToString());

                        ukupno_ostalih_zena =
                            (
                                from o in bd.OSOBA
                                join ek in bd.ETNO_KULTURA on o.id_osobe equals ek.id_osobe
                                join ob in bd.OBJEKAT on o.id_osobe equals ob.id_osobe
                                join op in bd.OPSTINA on ob.opstina equals op.naziv
                                join uo in bd.UPRAVNI_OKRUG on op.sifra_okruga equals uo.sifra_okruga
                                where uo.naziv == red["naziv"].ToString() && ek.pitanje_12 != "Srbin/Srpkinja" && o.pol == "Žensko"
                                select o.id_osobe
                            ).Count();
                        tmp.Add(ukupno_ostalih_zena.ToString());

                        dt.Rows.Add(tmp.ToArray());
                    }
                }
            }
        }
        private void starost_pol(DataTable dt)
        {
            List<string> godine = new List<string>();
            int tmp;
            godine.Add("Ukupno");

            tmp =
                    (
                    from o in bd.OSOBA
                    select o
                    ).Count();
            godine.Add(tmp.ToString());

            for (int i = 0; i <= 86; i++)
            {
                if (i % 5 == 0)
                {
                    tmp =
                    (
                    from o in bd.OSOBA
                    where DateTime.Today.Year - o.datum_rodjenja.Year >= i && DateTime.Today.Year - o.datum_rodjenja.Year <= i + 4
                    select o
                    ).Count();

                    godine.Add(tmp.ToString());
                }
            }
            tmp =
                    (
                    from o in bd.OSOBA
                    where DateTime.Today.Year - o.datum_rodjenja.Year >= 18
                    select o
                    ).Count();
            godine.Add(tmp.ToString());
            dt.Rows.Add(godine.ToArray());


            godine = new List<string>();
            godine.Add("Gradska naselja");
            tmp =
                    (
                    from o in bd.OSOBA
                    join ob in bd.OBJEKAT on o.id_osobe equals ob.id_osobe
                    join n in bd.NASELJE on ob.naselje equals n.naziv
                    join op in bd.OPSTINA on ob.opstina equals op.naziv
                    where n.tip_naselja == "G"
                    select o
                    ).Count();
            godine.Add(tmp.ToString());
            for (int i = 0; i <= 86; i++)
            {
                if (i % 5 == 0)
                {
                    tmp =
                    (
                    from o in bd.OSOBA
                    join ob in bd.OBJEKAT on o.id_osobe equals ob.id_osobe
                    join n in bd.NASELJE on ob.naselje equals n.naziv
                    join op in bd.OPSTINA on ob.opstina equals op.naziv
                    where DateTime.Today.Year - o.datum_rodjenja.Year >= i && DateTime.Today.Year - o.datum_rodjenja.Year <= i + 4 && n.tip_naselja == "G"
                    select o
                    ).Count();

                    godine.Add(tmp.ToString());
                }
            }
            tmp =
                    (
                    from o in bd.OSOBA
                    join ob in bd.OBJEKAT on o.id_osobe equals ob.id_osobe
                    join n in bd.NASELJE on ob.naselje equals n.naziv
                    join op in bd.OPSTINA on ob.opstina equals op.naziv
                    where DateTime.Today.Year - o.datum_rodjenja.Year >= 18 && n.tip_naselja == "G"
                    select o
                    ).Count();
            godine.Add(tmp.ToString());
            dt.Rows.Add(godine.ToArray());

            godine = new List<string>();
            godine.Add("Ostala");
            tmp =
                    (
                    from o in bd.OSOBA
                    join ob in bd.OBJEKAT on o.id_osobe equals ob.id_osobe
                    join n in bd.NASELJE on ob.naselje equals n.naziv
                    join op in bd.OPSTINA on ob.opstina equals op.naziv
                    where n.tip_naselja == "O"
                    select o
                    ).Count();
            godine.Add(tmp.ToString());
            for (int i = 0; i <= 86; i++)
            {
                if (i % 5 == 0)
                {
                    tmp =
                    (
                    from o in bd.OSOBA
                    join ob in bd.OBJEKAT on o.id_osobe equals ob.id_osobe
                    join n in bd.NASELJE on ob.naselje equals n.naziv
                    join op in bd.OPSTINA on ob.opstina equals op.naziv
                    where DateTime.Today.Year - o.datum_rodjenja.Year >= i && DateTime.Today.Year - o.datum_rodjenja.Year <= i + 4 && n.tip_naselja == "O"
                    select o
                    ).Count();

                    godine.Add(tmp.ToString());
                }
            }
            tmp =
                    (
                    from o in bd.OSOBA
                    join ob in bd.OBJEKAT on o.id_osobe equals ob.id_osobe
                    join n in bd.NASELJE on ob.naselje equals n.naziv
                    join op in bd.OPSTINA on ob.opstina equals op.naziv
                    where DateTime.Today.Year - o.datum_rodjenja.Year >= 18 && n.tip_naselja == "O"
                    select o
                    ).Count();
            godine.Add(tmp.ToString());
            dt.Rows.Add(godine.ToArray());
        }
        private void prosek_godina(DataTable dt)
        {
            List<string> lista = new List<string>();

            double tmp;

            foreach (DataRow red in bd.NSTJ1.Rows)
            {
                foreach (DataColumn dc in bd.NSTJ1.Columns)
                {
                    if (dc.ColumnName == "naziv")
                    {

                        lista = new List<string>();
                        lista.Add(red["naziv"].ToString());
                        tmp =
                        (
                            from o in bd.OSOBA
                            join ob in bd.OBJEKAT on o.id_osobe equals ob.id_osobe
                            join op in bd.OPSTINA on ob.opstina equals op.naziv
                            join uo in bd.UPRAVNI_OKRUG on op.sifra_okruga equals uo.sifra_okruga
                            join ns2 in bd.NSTJ2 on uo.sifra_nstj2 equals ns2.sifra_oblasti
                            join ns1 in bd.NSTJ1 on ns2.sifra_nstj1 equals ns1.sifra_oblasti
                            where ns1.naziv == red["naziv"].ToString()
                            select DateTime.Today.Year - o.datum_rodjenja.Year
                        ).DefaultIfEmpty().Average();
                        lista.Add(tmp.ToString());

                        tmp =
                        (
                            from o in bd.OSOBA
                            join ob in bd.OBJEKAT on o.id_osobe equals ob.id_osobe
                            join op in bd.OPSTINA on ob.opstina equals op.naziv
                            join uo in bd.UPRAVNI_OKRUG on op.sifra_okruga equals uo.sifra_okruga
                            join ns2 in bd.NSTJ2 on uo.sifra_nstj2 equals ns2.sifra_oblasti
                            join ns1 in bd.NSTJ1 on ns2.sifra_nstj1 equals ns1.sifra_oblasti
                            where ns1.naziv == red["naziv"].ToString() && o.pol == "Muško"
                            select DateTime.Today.Year - o.datum_rodjenja.Year
                        ).DefaultIfEmpty().Average();
                        lista.Add(tmp.ToString());

                        tmp =
                        (
                            from o in bd.OSOBA
                            join ob in bd.OBJEKAT on o.id_osobe equals ob.id_osobe
                            join op in bd.OPSTINA on ob.opstina equals op.naziv
                            join uo in bd.UPRAVNI_OKRUG on op.sifra_okruga equals uo.sifra_okruga
                            join ns2 in bd.NSTJ2 on uo.sifra_nstj2 equals ns2.sifra_oblasti
                            join ns1 in bd.NSTJ1 on ns2.sifra_nstj1 equals ns1.sifra_oblasti
                            where ns1.naziv == red["naziv"].ToString() && o.pol == "Žensko"
                            select DateTime.Today.Year - o.datum_rodjenja.Year
                        ).DefaultIfEmpty().Average();

                        lista.Add(tmp.ToString());
                        dt.Rows.Add(lista.ToArray());
                    }
                }
            }

        }
        private void veroispovest(DataTable dt)
        {
            List<string> listaVera = new List<string>();
            listaVera.Add("Ukupno");
            listaVera.Add("Svega hrišćanska");
            listaVera.Add("Pravoslavna");
            listaVera.Add("Katolička");
            listaVera.Add("Protestantska");
            listaVera.Add("Ostale hrišćanske");
            listaVera.Add("Islamska");
            listaVera.Add("Judeistička");
            listaVera.Add("Istočnjačke veroispovesti");
            listaVera.Add("Ostale veroispovesti");
            listaVera.Add("Agnostici");
            listaVera.Add("Ateisti");
            listaVera.Add("Nisu se izjasnili");


            List<string> lista = new List<string>();
            foreach (string pol in PolLista)
            {
                lista = new List<string>();
                if (pol == "Muško i Žensko")
                    lista.Add("Ukupno");
                else
                    lista.Add(pol);
                foreach (string vera in listaVera)
                {
                    int tmp;
                    if (vera == "Ukupno")
                    {
                        tmp =
                        (
                            from ek in bd.ETNO_KULTURA
                            join o in bd.OSOBA on ek.id_osobe equals o.id_osobe
                            where pol.Contains(o.pol)
                            select ek.id_osobe
                        ).Count();
                        lista.Add(tmp.ToString());
                    }
                    else if (vera == "Svega hrišćanska")
                    {
                        tmp =
                        (
                            from ek in bd.ETNO_KULTURA
                            join o in bd.OSOBA on ek.id_osobe equals o.id_osobe
                            where (ek.pitanje_14 == "Pravoslavna" || ek.pitanje_14 == "Katolička" || ek.pitanje_14 == "Ostale hrišćanske") && pol.Contains(o.pol)
                            select ek.id_osobe
                        ).Count();
                        lista.Add(tmp.ToString());
                    }
                    else if (vera == "Nisu se izjasnili")
                    {
                        tmp =
                        (
                            from ek in bd.ETNO_KULTURA
                            join o in bd.OSOBA on ek.id_osobe equals o.id_osobe
                            where ek.pitanje_14 == System.DBNull.Value.ToString() && pol.Contains(o.pol)
                            select ek.id_osobe
                        ).Count();
                        lista.Add(tmp.ToString());
                    }
                    else
                    {
                        tmp =
                        (
                            from ek in bd.ETNO_KULTURA
                            join o in bd.OSOBA on ek.id_osobe equals o.id_osobe
                            where ek.pitanje_14 == vera && pol.Contains(o.pol)
                            select ek.id_osobe
                        ).Count();
                        lista.Add(tmp.ToString());
                    }

                }
                dt.Rows.Add(lista.ToArray());
            }
        }
        private void maternji_jezik(DataTable dt)
        {
            List<string> listaJezika = new List<string>();
            listaJezika.Add("Srpski");
            listaJezika.Add("Crnogorski");
            listaJezika.Add("Makedonski");
            List<string> lista = new List<string>();
            int tmp;
            lista.Add("Republika Srbija");

            tmp =
            (
                from ek in bd.ETNO_KULTURA
                select ek.id_osobe
            ).Count();
            lista.Add(tmp.ToString());

            tmp =
            (
                from ek in bd.ETNO_KULTURA
                join o in bd.OSOBA on ek.id_osobe equals o.id_osobe
                where o.pol == "Muško"
                select ek.id_osobe
            ).Count();
            lista.Add(tmp.ToString());

            tmp =
            (
                from ek in bd.ETNO_KULTURA
                join o in bd.OSOBA on ek.id_osobe equals o.id_osobe
                where o.pol == "Žensko"
                select ek.id_osobe
            ).Count();
            lista.Add(tmp.ToString());


            foreach (string jezik in listaJezika)
            {
                foreach (string pol in PolLista)
                {
                    if (pol == "Muško i Žensko")
                    {
                        tmp =
                        (
                            from ek in bd.ETNO_KULTURA
                            join o in bd.OSOBA on ek.id_osobe equals o.id_osobe
                            where ek.pitanje_13 == jezik
                            select ek.id_osobe
                        ).Count();
                        lista.Add(tmp.ToString());
                    }
                    else
                    {
                        tmp =
                        (
                            from ek in bd.ETNO_KULTURA
                            join o in bd.OSOBA on ek.id_osobe equals o.id_osobe
                            where ek.pitanje_13 == jezik && o.pol == pol
                            select ek.id_osobe
                        ).Count();
                        lista.Add(tmp.ToString());
                    }
                }
            }
            tmp =
            (
                from ek in bd.ETNO_KULTURA
                where !listaJezika.Contains(ek.pitanje_13)
                select ek.id_osobe
            ).Count();
            lista.Add(tmp.ToString());

            tmp =
            (
                from ek in bd.ETNO_KULTURA
                join o in bd.OSOBA on ek.id_osobe equals o.id_osobe
                where o.pol == "Muško" && !listaJezika.Contains(ek.pitanje_13)
                select ek.id_osobe
            ).Count();
            lista.Add(tmp.ToString());

            tmp =
            (
                from ek in bd.ETNO_KULTURA
                join o in bd.OSOBA on ek.id_osobe equals o.id_osobe
                where o.pol == "Žensko" && !listaJezika.Contains(ek.pitanje_13)
                select ek.id_osobe
            ).Count();
            lista.Add(tmp.ToString());
            dt.Rows.Add(lista.ToArray());


            foreach (DataRow red in bd.UPRAVNI_OKRUG.Rows)
            {
                foreach (DataColumn dc in bd.UPRAVNI_OKRUG.Columns)
                {

                    lista = new List<string>();


                    if (dc.ColumnName == "naziv")
                    {
                        lista.Add(red["naziv"].ToString());
                        tmp =
                        (
                        from o in bd.OSOBA
                        join ek in bd.ETNO_KULTURA on o.id_osobe equals ek.id_osobe
                        join ob in bd.OBJEKAT on o.id_osobe equals ob.id_osobe
                        join op in bd.OPSTINA on ob.opstina equals op.naziv
                        join uo in bd.UPRAVNI_OKRUG on op.sifra_okruga equals uo.sifra_okruga
                        where uo.naziv == red["naziv"].ToString()
                        select ek.id_osobe
                        ).Count();
                        lista.Add(tmp.ToString());

                        tmp =
                        (
                        from o in bd.OSOBA
                        join ek in bd.ETNO_KULTURA on o.id_osobe equals ek.id_osobe
                        join ob in bd.OBJEKAT on o.id_osobe equals ob.id_osobe
                        join op in bd.OPSTINA on ob.opstina equals op.naziv
                        join uo in bd.UPRAVNI_OKRUG on op.sifra_okruga equals uo.sifra_okruga
                        where o.pol == "Muško" && uo.naziv == red["naziv"].ToString()
                        select ek.id_osobe
                        ).Count();
                        lista.Add(tmp.ToString());

                        tmp =
                        (
                        from o in bd.OSOBA
                        join ek in bd.ETNO_KULTURA on o.id_osobe equals ek.id_osobe
                        join ob in bd.OBJEKAT on o.id_osobe equals ob.id_osobe
                        join op in bd.OPSTINA on ob.opstina equals op.naziv
                        join uo in bd.UPRAVNI_OKRUG on op.sifra_okruga equals uo.sifra_okruga
                        where o.pol == "Žensko" && uo.naziv == red["naziv"].ToString()
                        select ek.id_osobe
                        ).Count();
                        lista.Add(tmp.ToString());
                        foreach (string jezik in listaJezika)
                        {
                            foreach (string pol in PolLista)
                            {
                                if (pol == "Muško i Žensko")
                                {
                                    tmp =
                                    (
                                    from o in bd.OSOBA
                                    join ek in bd.ETNO_KULTURA on o.id_osobe equals ek.id_osobe
                                    join ob in bd.OBJEKAT on o.id_osobe equals ob.id_osobe
                                    join op in bd.OPSTINA on ob.opstina equals op.naziv
                                    join uo in bd.UPRAVNI_OKRUG on op.sifra_okruga equals uo.sifra_okruga
                                    where ek.pitanje_13 == jezik && uo.naziv == red["naziv"].ToString()
                                    select o.id_osobe
                                    ).Count();
                                    lista.Add(tmp.ToString());
                                }
                                else
                                {
                                    tmp =
                                    (
                                    from o in bd.OSOBA
                                    join ek in bd.ETNO_KULTURA on o.id_osobe equals ek.id_osobe
                                    join ob in bd.OBJEKAT on o.id_osobe equals ob.id_osobe
                                    join op in bd.OPSTINA on ob.opstina equals op.naziv
                                    join uo in bd.UPRAVNI_OKRUG on op.sifra_okruga equals uo.sifra_okruga
                                    where ek.pitanje_13 == jezik && o.pol == pol && uo.naziv == red["naziv"].ToString()
                                    select o.id_osobe
                                    ).Count();
                                    lista.Add(tmp.ToString());
                                }
                            }
                        }
                        tmp =
                        (
                            from ek in bd.ETNO_KULTURA
                            where !listaJezika.Contains(ek.pitanje_13)
                            select ek.id_osobe
                        ).Count();
                        lista.Add(tmp.ToString());

                        tmp =
                        (
                            from ek in bd.ETNO_KULTURA
                            join o in bd.OSOBA on ek.id_osobe equals o.id_osobe
                            where o.pol == "Muško" && !listaJezika.Contains(ek.pitanje_13)
                            select ek.id_osobe
                        ).Count();
                        lista.Add(tmp.ToString());

                        tmp =
                        (
                            from ek in bd.ETNO_KULTURA
                            join o in bd.OSOBA on ek.id_osobe equals o.id_osobe
                            where o.pol == "Žensko" && !listaJezika.Contains(ek.pitanje_13)
                            select ek.id_osobe
                        ).Count();
                        lista.Add(tmp.ToString());
                        dt.Rows.Add(lista.ToArray());
                    }
                }
            }
        }
        private void nacionalna_pripadnost(DataTable dt)
        {
            int tmp;
            List<string> listaNacija = new List<string>();
            listaNacija.Add("Srpski");
            listaNacija.Add("Crnogorski");
            listaNacija.Add("Makedonski");

            foreach (string pol in PolLista)
            {
                for (int i = 0; i < 8; i++)
                {
                    List<string> lista = new List<string>();
                    if (pol == "Muško i Žensko")
                    {
                        lista.Add("Ukupno");
                        switch (i)
                        {
                            case 0:
                                lista.Add("Ukupno");
                                tmp =
                                (
                                    from ek in bd.ETNO_KULTURA
                                    select ek.id_osobe
                                ).Count();
                                lista.Add(tmp.ToString());
                                dt.Rows.Add(lista.ToArray());
                                break;
                            case 1:
                                lista.Add("0–14 godina");
                                tmp =
                                (
                                    from ek in bd.ETNO_KULTURA
                                    join o in bd.OSOBA on ek.id_osobe equals o.id_osobe
                                    where DateTime.Today.Year - o.datum_rodjenja.Year > 0 && DateTime.Today.Year - o.datum_rodjenja.Year < 15
                                    select ek.id_osobe
                                ).Count();
                                lista.Add(tmp.ToString());
                                dt.Rows.Add(lista.ToArray());
                                break;
                            case 2:
                                lista.Add("15–29 godina");
                                tmp =
                                (
                                    from ek in bd.ETNO_KULTURA
                                    join o in bd.OSOBA on ek.id_osobe equals o.id_osobe
                                    where DateTime.Today.Year - o.datum_rodjenja.Year > 14 && DateTime.Today.Year - o.datum_rodjenja.Year < 30
                                    select ek.id_osobe
                                ).Count();
                                lista.Add(tmp.ToString());
                                dt.Rows.Add(lista.ToArray());
                                break;
                            case 3:
                                lista.Add("30–49 godina");
                                tmp =
                                (
                                    from ek in bd.ETNO_KULTURA
                                    join o in bd.OSOBA on ek.id_osobe equals o.id_osobe
                                    where DateTime.Today.Year - o.datum_rodjenja.Year > 29 && DateTime.Today.Year - o.datum_rodjenja.Year < 50
                                    select ek.id_osobe
                                ).Count();
                                lista.Add(tmp.ToString());
                                dt.Rows.Add(lista.ToArray());
                                break;
                            case 4:
                                lista.Add("50–64 godina");
                                tmp =
                                (
                                    from ek in bd.ETNO_KULTURA
                                    join o in bd.OSOBA on ek.id_osobe equals o.id_osobe
                                    where DateTime.Today.Year - o.datum_rodjenja.Year > 49 && DateTime.Today.Year - o.datum_rodjenja.Year < 65
                                    select ek.id_osobe
                                ).Count();
                                lista.Add(tmp.ToString());
                                dt.Rows.Add(lista.ToArray());
                                break;
                            case 5:
                                lista.Add("65–84 godina");
                                tmp =
                                (
                                    from ek in bd.ETNO_KULTURA
                                    join o in bd.OSOBA on ek.id_osobe equals o.id_osobe
                                    where DateTime.Today.Year - o.datum_rodjenja.Year > 64 && DateTime.Today.Year - o.datum_rodjenja.Year < 85
                                    select ek.id_osobe
                                ).Count();
                                lista.Add(tmp.ToString());
                                dt.Rows.Add(lista.ToArray());
                                break;
                            case 6:
                                lista.Add("85 i više godina");
                                tmp =
                                (
                                    from ek in bd.ETNO_KULTURA
                                    join o in bd.OSOBA on ek.id_osobe equals o.id_osobe
                                    where DateTime.Today.Year - o.datum_rodjenja.Year > 84
                                    select ek.id_osobe
                                ).Count();
                                lista.Add(tmp.ToString());
                                dt.Rows.Add(lista.ToArray());
                                break;
                        }
                    }
                    else
                    {
                        lista.Add(pol);
                        switch (i)
                        {
                            case 0:
                                lista.Add("Ukupno");
                                tmp =
                                (
                                    from ek in bd.ETNO_KULTURA
                                    join o in bd.OSOBA on ek.id_osobe equals o.id_osobe
                                    where o.pol == pol
                                    select ek.id_osobe
                                ).Count();
                                lista.Add(tmp.ToString());
                                dt.Rows.Add(lista.ToArray());
                                break;
                            case 1:
                                lista.Add("0–14 godina");
                                tmp =
                                (
                                    from ek in bd.ETNO_KULTURA
                                    join o in bd.OSOBA on ek.id_osobe equals o.id_osobe
                                    where DateTime.Today.Year - o.datum_rodjenja.Year > 0 && DateTime.Today.Year - o.datum_rodjenja.Year < 15 && o.pol == pol
                                    select ek.id_osobe
                                ).Count();
                                lista.Add(tmp.ToString());
                                dt.Rows.Add(lista.ToArray());
                                break;
                            case 2:
                                lista.Add("15–29 godina");
                                tmp =
                                (
                                    from ek in bd.ETNO_KULTURA
                                    join o in bd.OSOBA on ek.id_osobe equals o.id_osobe
                                    where DateTime.Today.Year - o.datum_rodjenja.Year > 14 && DateTime.Today.Year - o.datum_rodjenja.Year < 30 && o.pol == pol
                                    select ek.id_osobe
                                ).Count();
                                lista.Add(tmp.ToString());
                                dt.Rows.Add(lista.ToArray());
                                break;
                            case 3:
                                lista.Add("30–49 godina");
                                tmp =
                                (
                                    from ek in bd.ETNO_KULTURA
                                    join o in bd.OSOBA on ek.id_osobe equals o.id_osobe
                                    where DateTime.Today.Year - o.datum_rodjenja.Year > 29 && DateTime.Today.Year - o.datum_rodjenja.Year < 50 && o.pol == pol
                                    select ek.id_osobe
                                ).Count();
                                lista.Add(tmp.ToString());
                                dt.Rows.Add(lista.ToArray());
                                break;
                            case 4:
                                lista.Add("50–64 godina");
                                tmp =
                                (
                                    from ek in bd.ETNO_KULTURA
                                    join o in bd.OSOBA on ek.id_osobe equals o.id_osobe 
                                    where DateTime.Today.Year - o.datum_rodjenja.Year > 49 && DateTime.Today.Year - o.datum_rodjenja.Year < 65 && o.pol == pol
                                    select ek.id_osobe
                                ).Count();
                                lista.Add(tmp.ToString());
                                dt.Rows.Add(lista.ToArray());
                                break;
                            case 5:
                                lista.Add("65–84 godina");
                                tmp =
                                (
                                    from ek in bd.ETNO_KULTURA
                                    join o in bd.OSOBA on ek.id_osobe equals o.id_osobe
                                    where DateTime.Today.Year - o.datum_rodjenja.Year > 64 && DateTime.Today.Year - o.datum_rodjenja.Year < 85 && o.pol == pol
                                    select ek.id_osobe
                                ).Count();
                                lista.Add(tmp.ToString());
                                dt.Rows.Add(lista.ToArray());
                                break;
                            case 6:
                                lista.Add("85 i više godina");
                                tmp =
                                (
                                    from ek in bd.ETNO_KULTURA
                                    join o in bd.OSOBA on ek.id_osobe equals o.id_osobe
                                    where DateTime.Today.Year - o.datum_rodjenja.Year > 84 && o.pol == pol
                                    select ek.id_osobe
                                ).Count();
                                lista.Add(tmp.ToString());
                                dt.Rows.Add(lista.ToArray());
                                break;
                        }
                    }
                }
            }
        }
        private void porodica_tip(DataTable dt)
        {
            List<string> lista = new List<string>();

            int sum = 0;

            List<string> tipNaselja = new List<string>();
            tipNaselja.Add("Ukupno");
            tipNaselja.Add("G");
            tipNaselja.Add("O");


            foreach (string tip in tipNaselja)
            {
                lista = new List<string>();
                lista.Add("Republika Srbija");
                if (tip == "Ukupno")
                    lista.Add("Ukupno");
                else if (tip=="G")
                    lista.Add("Gradska naselja");
                else
                    lista.Add("Ostala");
                if(tip == "Ukupno")
                {
                    int tmp1 =
                    (
                        from bs in bd.BRACNI_STATUS_FERTILITET
                        where bs.pitanje9.Contains("Oženjen/udata") && int.Parse(bs.pitanje11) == 0
                        select bs.id_osobe
                    ).Count();
                    sum += tmp1;

                    int tmp2 =
                    (
                        from bs in bd.BRACNI_STATUS_FERTILITET
                        where bs.pitanje10 == "Da" && int.Parse(bs.pitanje11) == 0
                        select bs.id_osobe
                    ).Count();
                    sum += tmp2;

                    int tmp3 =
                    (
                        from bs in bd.BRACNI_STATUS_FERTILITET
                        where bs.pitanje9.Contains("Oženjen/udata") && int.Parse(bs.pitanje11) > 0
                        select bs.id_osobe
                    ).Count();
                    sum += tmp3;

                    int tmp4 =
                    (
                        from bs in bd.BRACNI_STATUS_FERTILITET
                        where bs.pitanje10 == "Da" && int.Parse(bs.pitanje11) > 0
                        select bs.id_osobe
                    ).Count();
                    sum += tmp4;

                    lista.Add(sum.ToString());
                    lista.Add(tmp1.ToString());
                    lista.Add(tmp2.ToString());
                    lista.Add(tmp3.ToString());
                    lista.Add(tmp4.ToString());

                    dt.Rows.Add(lista.ToArray());
                }
                else
                {
                    int tmp1 =
                    (
                        from bs in bd.BRACNI_STATUS_FERTILITET
                        join ob in bd.OBJEKAT on bs.id_osobe equals ob.id_osobe
                        join n in bd.NASELJE on ob.naselje equals n.naziv
                        where bs.pitanje9.Contains("Oženjen/udata") && int.Parse(bs.pitanje11) == 0 && n.tip_naselja == tip
                        select bs.id_osobe
                    ).Count();
                    sum += tmp1;

                    int tmp2 =
                    (
                        from bs in bd.BRACNI_STATUS_FERTILITET
                        join ob in bd.OBJEKAT on bs.id_osobe equals ob.id_osobe
                        join n in bd.NASELJE on ob.naselje equals n.naziv
                        where bs.pitanje10 == "Da" && int.Parse(bs.pitanje11) == 0 && n.tip_naselja == tip
                        select bs.id_osobe
                    ).Count();
                    sum += tmp2;

                    int tmp3 =
                    (
                        from bs in bd.BRACNI_STATUS_FERTILITET
                        join ob in bd.OBJEKAT on bs.id_osobe equals ob.id_osobe
                        join n in bd.NASELJE on ob.naselje equals n.naziv
                        where bs.pitanje9.Contains("Oženjen/udata") && int.Parse(bs.pitanje11) > 0 && n.tip_naselja == tip
                        select bs.id_osobe
                    ).Count();
                    sum += tmp3;

                    int tmp4 =
                    (
                        from bs in bd.BRACNI_STATUS_FERTILITET
                        join ob in bd.OBJEKAT on bs.id_osobe equals ob.id_osobe
                        join n in bd.NASELJE on ob.naselje equals n.naziv
                        where bs.pitanje10 == "Da" && int.Parse(bs.pitanje11) > 0 && n.tip_naselja == tip
                        select bs.id_osobe
                    ).Count();
                    sum += tmp4;

                    lista.Add(sum.ToString());
                    lista.Add(tmp1.ToString());
                    lista.Add(tmp2.ToString());
                    lista.Add(tmp3.ToString());
                    lista.Add(tmp4.ToString());

                    dt.Rows.Add(lista.ToArray());

                }
            }
            foreach (DataRow red in bd.UPRAVNI_OKRUG.Rows)
            {
                foreach (DataColumn dc in bd.UPRAVNI_OKRUG.Columns)
                {

                    lista = new List<string>();


                    if (dc.ColumnName == "naziv")
                    {
                        foreach (string tip in tipNaselja)
                        {
                            lista = new List<string>();
                            lista.Add(red["naziv"].ToString());
                            if (tip == "Ukupno")
                                lista.Add("Ukupno");
                            else if (tip == "G")
                                lista.Add("Gradska naselja");
                            else
                                lista.Add("Ostala");
                            if (tip == "Ukupno")
                            {
                                int tmp1 =
                                (
                                    from bs in bd.BRACNI_STATUS_FERTILITET
                                    join ob in bd.OBJEKAT on bs.id_osobe equals ob.id_osobe
                                    join op in bd.OPSTINA on ob.opstina equals op.naziv
                                    join n in bd.NASELJE on ob.naselje equals n.naziv
                                    join uo in bd.UPRAVNI_OKRUG on op.sifra_okruga equals uo.sifra_okruga
                                    where bs.pitanje9.Contains("Oženjen/udata") && int.Parse(bs.pitanje11) == 0 && red["naziv"].ToString() == uo.naziv
                                    select bs.id_osobe
                                ).Count();
                                sum += tmp1;

                                int tmp2 =
                                (
                                    from bs in bd.BRACNI_STATUS_FERTILITET
                                    join ob in bd.OBJEKAT on bs.id_osobe equals ob.id_osobe
                                    join op in bd.OPSTINA on ob.opstina equals op.naziv
                                    join n in bd.NASELJE on ob.naselje equals n.naziv
                                    join uo in bd.UPRAVNI_OKRUG on op.sifra_okruga equals uo.sifra_okruga
                                    where bs.pitanje10 == "Da" && int.Parse(bs.pitanje11) == 0 && red["naziv"].ToString() == uo.naziv
                                    select bs.id_osobe
                                ).Count();
                                sum += tmp2;

                                int tmp3 =
                                (
                                    from bs in bd.BRACNI_STATUS_FERTILITET
                                    join ob in bd.OBJEKAT on bs.id_osobe equals ob.id_osobe
                                    join op in bd.OPSTINA on ob.opstina equals op.naziv
                                    join n in bd.NASELJE on ob.naselje equals n.naziv
                                    join uo in bd.UPRAVNI_OKRUG on op.sifra_okruga equals uo.sifra_okruga
                                    where bs.pitanje9.Contains("Oženjen/udata") && int.Parse(bs.pitanje11) > 0 && red["naziv"].ToString() == uo.naziv
                                    select bs.id_osobe
                                ).Count();
                                sum += tmp3;

                                int tmp4 =
                                (
                                    from bs in bd.BRACNI_STATUS_FERTILITET
                                    join ob in bd.OBJEKAT on bs.id_osobe equals ob.id_osobe
                                    join op in bd.OPSTINA on ob.opstina equals op.naziv
                                    join n in bd.NASELJE on ob.naselje equals n.naziv
                                    join uo in bd.UPRAVNI_OKRUG on op.sifra_okruga equals uo.sifra_okruga
                                    where bs.pitanje10 == "Da" && int.Parse(bs.pitanje11) > 0 && red["naziv"].ToString() == uo.naziv
                                    select bs.id_osobe
                                ).Count();
                                sum += tmp4;

                                lista.Add(sum.ToString());
                                lista.Add(tmp1.ToString());
                                lista.Add(tmp2.ToString());
                                lista.Add(tmp3.ToString());
                                lista.Add(tmp4.ToString());

                                dt.Rows.Add(lista.ToArray());
                            }
                            else
                            {
                                int tmp1 =
                                (
                                    from bs in bd.BRACNI_STATUS_FERTILITET
                                    join ob in bd.OBJEKAT on bs.id_osobe equals ob.id_osobe
                                    join op in bd.OPSTINA on ob.opstina equals op.naziv
                                    join n in bd.NASELJE on ob.naselje equals n.naziv
                                    join uo in bd.UPRAVNI_OKRUG on op.sifra_okruga equals uo.sifra_okruga
                                    where bs.pitanje9.Contains("Oženjen/udata") && int.Parse(bs.pitanje11) == 0 && n.tip_naselja == tip && red["naziv"].ToString() == uo.naziv
                                    select bs.id_osobe
                                ).Count();
                                sum += tmp1;

                                int tmp2 =
                                (
                                    from bs in bd.BRACNI_STATUS_FERTILITET
                                    join ob in bd.OBJEKAT on bs.id_osobe equals ob.id_osobe
                                    join op in bd.OPSTINA on ob.opstina equals op.naziv
                                    join n in bd.NASELJE on ob.naselje equals n.naziv
                                    join uo in bd.UPRAVNI_OKRUG on op.sifra_okruga equals uo.sifra_okruga
                                    where bs.pitanje10 == "Da" && int.Parse(bs.pitanje11) == 0 && n.tip_naselja == tip && red["naziv"].ToString() == uo.naziv
                                    select bs.id_osobe
                                ).Count();
                                sum += tmp2;

                                int tmp3 =
                                (
                                    from bs in bd.BRACNI_STATUS_FERTILITET
                                    join ob in bd.OBJEKAT on bs.id_osobe equals ob.id_osobe
                                    join op in bd.OPSTINA on ob.opstina equals op.naziv
                                    join n in bd.NASELJE on ob.naselje equals n.naziv
                                    join uo in bd.UPRAVNI_OKRUG on op.sifra_okruga equals uo.sifra_okruga
                                    where bs.pitanje9.Contains("Oženjen/udata") && int.Parse(bs.pitanje11) > 0 && n.tip_naselja == tip && red["naziv"].ToString() == uo.naziv
                                    select bs.id_osobe
                                ).Count();
                                sum += tmp3;

                                int tmp4 =
                                (
                                    from bs in bd.BRACNI_STATUS_FERTILITET
                                    join ob in bd.OBJEKAT on bs.id_osobe equals ob.id_osobe
                                    join op in bd.OPSTINA on ob.opstina equals op.naziv
                                    join n in bd.NASELJE on ob.naselje equals n.naziv
                                    join uo in bd.UPRAVNI_OKRUG on op.sifra_okruga equals uo.sifra_okruga
                                    where bs.pitanje10 == "Da" && int.Parse(bs.pitanje11) > 0 && n.tip_naselja == tip && red["naziv"].ToString() == uo.naziv
                                    select bs.id_osobe
                                ).Count();
                                sum += tmp4;

                                lista.Add(sum.ToString());
                                lista.Add(tmp1.ToString());
                                lista.Add(tmp2.ToString());
                                lista.Add(tmp3.ToString());
                                lista.Add(tmp4.ToString());

                                dt.Rows.Add(lista.ToArray());

                            }
                        }
                    }
                }
            }
        }
        private void povrsina(DataTable dt)
        {
            List<string> lista = new List<string>();
            List<string> tipNaselja = new List<string>();
            tipNaselja.Add("Ukupno");
            tipNaselja.Add("G");
            tipNaselja.Add("O");
            int tmp;

            foreach (string tip in tipNaselja)
            {
                lista = new List<string>();
                lista.Add("Republika Srbija");

                if (tip == "G")
                    lista.Add("Gradska naselja");
                else if (tip == "O")
                    lista.Add("Ostala");
                else
                    lista.Add(tip);
                
                if (tip == "Ukupno")
                {
                    tmp =
                    (
                        from os in bd.O_STANU
                        select os.pitanje9
                    ).Count();
                    lista.Add(tmp.ToString());

                    tmp =
                    (
                        from os in bd.O_STANU
                        where int.Parse(os.pitanje9) < 31
                        select os.pitanje9
                    ).Count();
                    lista.Add(tmp.ToString());

                    tmp =
                    (
                        from os in bd.O_STANU
                        where int.Parse(os.pitanje9) > 30 && int.Parse(os.pitanje9) < 41
                        select os.pitanje9
                    ).Count();
                    lista.Add(tmp.ToString());

                    tmp =
                    (
                        from os in bd.O_STANU
                        where int.Parse(os.pitanje9) > 40 && int.Parse(os.pitanje9) < 51
                        select os.pitanje9
                    ).Count();
                    lista.Add(tmp.ToString());

                    tmp =
                    (
                        from os in bd.O_STANU
                        where int.Parse(os.pitanje9) > 50 && int.Parse(os.pitanje9) < 61
                        select os.pitanje9
                    ).Count();
                    lista.Add(tmp.ToString());

                    tmp =
                    (
                        from os in bd.O_STANU
                        where int.Parse(os.pitanje9) > 60 && int.Parse(os.pitanje9) < 81
                        select os.pitanje9
                    ).Count();
                    lista.Add(tmp.ToString());

                    tmp =
                    (
                        from os in bd.O_STANU
                        where int.Parse(os.pitanje9) > 80 && int.Parse(os.pitanje9) < 101
                        select os.pitanje9
                    ).Count();
                    lista.Add(tmp.ToString());

                    tmp =
                    (
                        from os in bd.O_STANU
                        where int.Parse(os.pitanje9) > 100 && int.Parse(os.pitanje9) < 121
                        select os.pitanje9
                    ).Count();
                    lista.Add(tmp.ToString());

                    tmp =
                    (
                        from os in bd.O_STANU
                        where int.Parse(os.pitanje9) > 120 && int.Parse(os.pitanje9) < 151
                        select os.pitanje9
                    ).Count();
                    lista.Add(tmp.ToString());

                    tmp =
                    (
                        from os in bd.O_STANU
                        where int.Parse(os.pitanje9) > 150
                        select os.pitanje9
                    ).Count();
                    lista.Add(tmp.ToString());

                    dt.Rows.Add(lista.ToArray());
                }
                else
                {
                    tmp =
                    (
                        from os in bd.O_STANU
                        join ob in bd.OBJEKAT on os.id_objekta equals ob.id_objekta
                        join op in bd.OPSTINA on ob.opstina equals op.naziv
                        join n in bd.NASELJE on new {a=op.sifra_opstine, b=ob.naselje } equals new {a=n.sifra_opstine, b=n.naziv }
                        where n.tip_naselja == tip
                        select os.pitanje9
                    ).Count();
                    lista.Add(tmp.ToString());

                    tmp =
                    (
                        from os in bd.O_STANU
                        join ob in bd.OBJEKAT on os.id_objekta equals ob.id_objekta
                        join op in bd.OPSTINA on ob.opstina equals op.naziv
                        join n in bd.NASELJE on new { a = op.sifra_opstine, b = ob.naselje } equals new { a = n.sifra_opstine, b = n.naziv }
                        where int.Parse(os.pitanje9) < 31 && n.tip_naselja == tip
                        select os.pitanje9
                    ).Count();
                    lista.Add(tmp.ToString());

                    tmp =
                    (
                        from os in bd.O_STANU
                        join ob in bd.OBJEKAT on os.id_objekta equals ob.id_objekta
                        join op in bd.OPSTINA on ob.opstina equals op.naziv
                        join n in bd.NASELJE on new { a = op.sifra_opstine, b = ob.naselje } equals new { a = n.sifra_opstine, b = n.naziv }
                        where int.Parse(os.pitanje9) > 30 && int.Parse(os.pitanje9) < 41 && n.tip_naselja == tip
                        select os.pitanje9
                    ).Count();
                    lista.Add(tmp.ToString());

                    tmp =
                    (
                        from os in bd.O_STANU
                        join ob in bd.OBJEKAT on os.id_objekta equals ob.id_objekta
                        join op in bd.OPSTINA on ob.opstina equals op.naziv
                        join n in bd.NASELJE on new { a = op.sifra_opstine, b = ob.naselje } equals new { a = n.sifra_opstine, b = n.naziv }
                        where int.Parse(os.pitanje9) > 40 && int.Parse(os.pitanje9) < 51 && n.tip_naselja == tip
                        select os.pitanje9
                    ).Count();
                    lista.Add(tmp.ToString());

                    tmp =
                    (
                        from os in bd.O_STANU
                        join ob in bd.OBJEKAT on os.id_objekta equals ob.id_objekta
                        join op in bd.OPSTINA on ob.opstina equals op.naziv
                        join n in bd.NASELJE on new { a = op.sifra_opstine, b = ob.naselje } equals new { a = n.sifra_opstine, b = n.naziv }
                        where int.Parse(os.pitanje9) > 50 && int.Parse(os.pitanje9) < 61 && n.tip_naselja == tip
                        select os.pitanje9
                    ).Count();
                    lista.Add(tmp.ToString());

                    tmp =
                    (
                        from os in bd.O_STANU
                        join ob in bd.OBJEKAT on os.id_objekta equals ob.id_objekta
                        join op in bd.OPSTINA on ob.opstina equals op.naziv
                        join n in bd.NASELJE on new { a = op.sifra_opstine, b = ob.naselje } equals new { a = n.sifra_opstine, b = n.naziv }
                        where int.Parse(os.pitanje9) > 60 && int.Parse(os.pitanje9) < 81 && n.tip_naselja == tip
                        select os.pitanje9
                    ).Count();
                    lista.Add(tmp.ToString());

                    tmp =
                    (
                        from os in bd.O_STANU
                        join ob in bd.OBJEKAT on os.id_objekta equals ob.id_objekta
                        join op in bd.OPSTINA on ob.opstina equals op.naziv
                        join n in bd.NASELJE on new { a = op.sifra_opstine, b = ob.naselje } equals new { a = n.sifra_opstine, b = n.naziv }
                        where int.Parse(os.pitanje9) > 80 && int.Parse(os.pitanje9) < 101 && n.tip_naselja == tip
                        select os.pitanje9
                    ).Count();
                    lista.Add(tmp.ToString());

                    tmp =
                    (
                        from os in bd.O_STANU
                        join ob in bd.OBJEKAT on os.id_objekta equals ob.id_objekta
                        join op in bd.OPSTINA on ob.opstina equals op.naziv
                        join n in bd.NASELJE on new { a = op.sifra_opstine, b = ob.naselje } equals new { a = n.sifra_opstine, b = n.naziv }
                        where int.Parse(os.pitanje9) > 100 && int.Parse(os.pitanje9) < 121 && n.tip_naselja == tip
                        select os.pitanje9
                    ).Count();
                    lista.Add(tmp.ToString());

                    tmp =
                    (
                        from os in bd.O_STANU
                        join ob in bd.OBJEKAT on os.id_objekta equals ob.id_objekta
                        join op in bd.OPSTINA on ob.opstina equals op.naziv
                        join n in bd.NASELJE on new { a = op.sifra_opstine, b = ob.naselje } equals new { a = n.sifra_opstine, b = n.naziv }
                        where int.Parse(os.pitanje9) > 120 && int.Parse(os.pitanje9) < 151 && n.tip_naselja == tip
                        select os.pitanje9
                    ).Count();
                    lista.Add(tmp.ToString());

                    tmp =
                    (
                        from os in bd.O_STANU
                        join ob in bd.OBJEKAT on os.id_objekta equals ob.id_objekta
                        join op in bd.OPSTINA on ob.opstina equals op.naziv
                        join n in bd.NASELJE on new { a = op.sifra_opstine, b = ob.naselje } equals new { a = n.sifra_opstine, b = n.naziv }
                        where int.Parse(os.pitanje9) > 150 && n.tip_naselja == tip
                        select os.pitanje9
                    ).Count();
                    lista.Add(tmp.ToString());

                    dt.Rows.Add(lista.ToArray());
                }
            }
            foreach (DataRow red in bd.UPRAVNI_OKRUG.Rows)
            {
                foreach (DataColumn dc in bd.UPRAVNI_OKRUG.Columns)
                {
                    lista = new List<string>();
                    if (dc.ColumnName == "naziv")
                    {
                        foreach (string tip in tipNaselja)
                        {
                            lista = new List<string>();
                            lista.Add(red["naziv"].ToString());
                            if (tip == "G")
                                lista.Add("Gradska naselja");
                            else if (tip == "O")
                                lista.Add("Ostala");
                            else
                                lista.Add(tip);
                            if (tip == "Ukupno")
                            {
                                tmp =
                                (
                                    from os in bd.O_STANU
                                    join ob in bd.OBJEKAT on os.id_objekta equals ob.id_objekta
                                    join op in bd.OPSTINA on ob.opstina equals op.naziv
                                    join n in bd.NASELJE on new { a = op.sifra_opstine, b = ob.naselje } equals new { a = n.sifra_opstine, b = n.naziv }
                                    join uo in bd.UPRAVNI_OKRUG on op.sifra_okruga equals uo.sifra_okruga
                                    where red["naziv"].ToString() == uo.naziv
                                    select os.pitanje9
                                ).Count();
                                lista.Add(tmp.ToString());

                                tmp =
                                (
                                    from os in bd.O_STANU
                                    join ob in bd.OBJEKAT on os.id_objekta equals ob.id_objekta
                                    join op in bd.OPSTINA on ob.opstina equals op.naziv
                                    join n in bd.NASELJE on new { a = op.sifra_opstine, b = ob.naselje } equals new { a = n.sifra_opstine, b = n.naziv }
                                    join uo in bd.UPRAVNI_OKRUG on op.sifra_okruga equals uo.sifra_okruga
                                    where int.Parse(os.pitanje9) < 31 && red["naziv"].ToString() == uo.naziv
                                    select os.pitanje9
                                ).Count();
                                lista.Add(tmp.ToString());

                                tmp =
                                (
                                    from os in bd.O_STANU
                                    join ob in bd.OBJEKAT on os.id_objekta equals ob.id_objekta
                                    join op in bd.OPSTINA on ob.opstina equals op.naziv
                                    join n in bd.NASELJE on new { a = op.sifra_opstine, b = ob.naselje } equals new { a = n.sifra_opstine, b = n.naziv }
                                    join uo in bd.UPRAVNI_OKRUG on op.sifra_okruga equals uo.sifra_okruga
                                    where int.Parse(os.pitanje9) > 30 && int.Parse(os.pitanje9) < 41 && red["naziv"].ToString() == uo.naziv
                                    select os.pitanje9
                                ).Count();
                                lista.Add(tmp.ToString());

                                tmp =
                                (
                                    from os in bd.O_STANU
                                    join ob in bd.OBJEKAT on os.id_objekta equals ob.id_objekta
                                    join op in bd.OPSTINA on ob.opstina equals op.naziv
                                    join n in bd.NASELJE on new { a = op.sifra_opstine, b = ob.naselje } equals new { a = n.sifra_opstine, b = n.naziv }
                                    join uo in bd.UPRAVNI_OKRUG on op.sifra_okruga equals uo.sifra_okruga
                                    where int.Parse(os.pitanje9) > 40 && int.Parse(os.pitanje9) < 51 && red["naziv"].ToString() == uo.naziv
                                    select os.pitanje9
                                ).Count();
                                lista.Add(tmp.ToString());

                                tmp =
                                (
                                    from os in bd.O_STANU
                                    join ob in bd.OBJEKAT on os.id_objekta equals ob.id_objekta
                                    join op in bd.OPSTINA on ob.opstina equals op.naziv
                                    join n in bd.NASELJE on new { a = op.sifra_opstine, b = ob.naselje } equals new { a = n.sifra_opstine, b = n.naziv }
                                    join uo in bd.UPRAVNI_OKRUG on op.sifra_okruga equals uo.sifra_okruga
                                    where int.Parse(os.pitanje9) > 50 && int.Parse(os.pitanje9) < 61 && red["naziv"].ToString() == uo.naziv
                                    select os.pitanje9
                                ).Count();
                                lista.Add(tmp.ToString());

                                tmp =
                                (
                                    from os in bd.O_STANU
                                    join ob in bd.OBJEKAT on os.id_objekta equals ob.id_objekta
                                    join op in bd.OPSTINA on ob.opstina equals op.naziv
                                    join n in bd.NASELJE on new { a = op.sifra_opstine, b = ob.naselje } equals new { a = n.sifra_opstine, b = n.naziv }
                                    join uo in bd.UPRAVNI_OKRUG on op.sifra_okruga equals uo.sifra_okruga
                                    where int.Parse(os.pitanje9) > 60 && int.Parse(os.pitanje9) < 81 && red["naziv"].ToString() == uo.naziv
                                    select os.pitanje9
                                ).Count();
                                lista.Add(tmp.ToString());

                                tmp =
                                (
                                    from os in bd.O_STANU
                                    join ob in bd.OBJEKAT on os.id_objekta equals ob.id_objekta
                                    join op in bd.OPSTINA on ob.opstina equals op.naziv
                                    join n in bd.NASELJE on new { a = op.sifra_opstine, b = ob.naselje } equals new { a = n.sifra_opstine, b = n.naziv }
                                    join uo in bd.UPRAVNI_OKRUG on op.sifra_okruga equals uo.sifra_okruga
                                    where int.Parse(os.pitanje9) > 80 && int.Parse(os.pitanje9) < 101 && red["naziv"].ToString() == uo.naziv
                                    select os.pitanje9
                                ).Count();
                                lista.Add(tmp.ToString());

                                tmp =
                                (
                                    from os in bd.O_STANU
                                    join ob in bd.OBJEKAT on os.id_objekta equals ob.id_objekta
                                    join op in bd.OPSTINA on ob.opstina equals op.naziv
                                    join n in bd.NASELJE on new { a = op.sifra_opstine, b = ob.naselje } equals new { a = n.sifra_opstine, b = n.naziv }
                                    join uo in bd.UPRAVNI_OKRUG on op.sifra_okruga equals uo.sifra_okruga
                                    where int.Parse(os.pitanje9) > 100 && int.Parse(os.pitanje9) < 121 && red["naziv"].ToString() == uo.naziv
                                    select os.pitanje9
                                ).Count();
                                lista.Add(tmp.ToString());

                                tmp =
                                (
                                    from os in bd.O_STANU
                                    join ob in bd.OBJEKAT on os.id_objekta equals ob.id_objekta
                                    join op in bd.OPSTINA on ob.opstina equals op.naziv
                                    join n in bd.NASELJE on new { a = op.sifra_opstine, b = ob.naselje } equals new { a = n.sifra_opstine, b = n.naziv }
                                    join uo in bd.UPRAVNI_OKRUG on op.sifra_okruga equals uo.sifra_okruga
                                    where int.Parse(os.pitanje9) > 120 && int.Parse(os.pitanje9) < 151 && red["naziv"].ToString() == uo.naziv
                                    select os.pitanje9
                                ).Count();
                                lista.Add(tmp.ToString());

                                tmp =
                                (
                                    from os in bd.O_STANU
                                    join ob in bd.OBJEKAT on os.id_objekta equals ob.id_objekta
                                    join op in bd.OPSTINA on ob.opstina equals op.naziv
                                    join n in bd.NASELJE on new { a = op.sifra_opstine, b = ob.naselje } equals new { a = n.sifra_opstine, b = n.naziv }
                                    join uo in bd.UPRAVNI_OKRUG on op.sifra_okruga equals uo.sifra_okruga
                                    where int.Parse(os.pitanje9) > 150 && red["naziv"].ToString() == uo.naziv
                                    select os.pitanje9
                                ).Count();
                                lista.Add(tmp.ToString());

                                dt.Rows.Add(lista.ToArray());
                            }
                            else
                            {
                                tmp =
                                (
                                    from os in bd.O_STANU
                                    join ob in bd.OBJEKAT on os.id_objekta equals ob.id_objekta
                                    join op in bd.OPSTINA on ob.opstina equals op.naziv
                                    join n in bd.NASELJE on new { a = op.sifra_opstine, b = ob.naselje } equals new { a = n.sifra_opstine, b = n.naziv }
                                    join uo in bd.UPRAVNI_OKRUG on op.sifra_okruga equals uo.sifra_okruga
                                    where n.tip_naselja == tip && red["naziv"].ToString() == uo.naziv
                                    select os.pitanje9
                                ).Count();
                                lista.Add(tmp.ToString());

                                tmp =
                                (
                                    from os in bd.O_STANU
                                    join ob in bd.OBJEKAT on os.id_objekta equals ob.id_objekta
                                    join op in bd.OPSTINA on ob.opstina equals op.naziv
                                    join n in bd.NASELJE on new { a = op.sifra_opstine, b = ob.naselje } equals new { a = n.sifra_opstine, b = n.naziv }
                                    join uo in bd.UPRAVNI_OKRUG on op.sifra_okruga equals uo.sifra_okruga
                                    where int.Parse(os.pitanje9) < 31 && n.tip_naselja == tip && red["naziv"].ToString() == uo.naziv
                                    select os.pitanje9
                                ).Count();
                                lista.Add(tmp.ToString());

                                tmp =
                                (
                                    from os in bd.O_STANU
                                    join ob in bd.OBJEKAT on os.id_objekta equals ob.id_objekta
                                    join op in bd.OPSTINA on ob.opstina equals op.naziv
                                    join n in bd.NASELJE on new { a = op.sifra_opstine, b = ob.naselje } equals new { a = n.sifra_opstine, b = n.naziv }
                                    join uo in bd.UPRAVNI_OKRUG on op.sifra_okruga equals uo.sifra_okruga
                                    where int.Parse(os.pitanje9) > 30 && int.Parse(os.pitanje9) < 41 && n.tip_naselja == tip && red["naziv"].ToString() == uo.naziv
                                    select os.pitanje9
                                ).Count();
                                lista.Add(tmp.ToString());

                                tmp =
                                (
                                    from os in bd.O_STANU
                                    join ob in bd.OBJEKAT on os.id_objekta equals ob.id_objekta
                                    join op in bd.OPSTINA on ob.opstina equals op.naziv
                                    join n in bd.NASELJE on new { a = op.sifra_opstine, b = ob.naselje } equals new { a = n.sifra_opstine, b = n.naziv }
                                    join uo in bd.UPRAVNI_OKRUG on op.sifra_okruga equals uo.sifra_okruga
                                    where int.Parse(os.pitanje9) > 40 && int.Parse(os.pitanje9) < 51 && n.tip_naselja == tip && red["naziv"].ToString() == uo.naziv
                                    select os.pitanje9
                                ).Count();
                                lista.Add(tmp.ToString());

                                tmp =
                                (
                                    from os in bd.O_STANU
                                    join ob in bd.OBJEKAT on os.id_objekta equals ob.id_objekta
                                    join op in bd.OPSTINA on ob.opstina equals op.naziv
                                    join n in bd.NASELJE on new { a = op.sifra_opstine, b = ob.naselje } equals new { a = n.sifra_opstine, b = n.naziv }
                                    join uo in bd.UPRAVNI_OKRUG on op.sifra_okruga equals uo.sifra_okruga
                                    where int.Parse(os.pitanje9) > 50 && int.Parse(os.pitanje9) < 61 && n.tip_naselja == tip && red["naziv"].ToString() == uo.naziv
                                    select os.pitanje9
                                ).Count();
                                lista.Add(tmp.ToString());

                                tmp =
                                (
                                    from os in bd.O_STANU
                                    join ob in bd.OBJEKAT on os.id_objekta equals ob.id_objekta
                                    join op in bd.OPSTINA on ob.opstina equals op.naziv
                                    join n in bd.NASELJE on new { a = op.sifra_opstine, b = ob.naselje } equals new { a = n.sifra_opstine, b = n.naziv }
                                    join uo in bd.UPRAVNI_OKRUG on op.sifra_okruga equals uo.sifra_okruga
                                    where int.Parse(os.pitanje9) > 60 && int.Parse(os.pitanje9) < 81 && n.tip_naselja == tip && red["naziv"].ToString() == uo.naziv
                                    select os.pitanje9
                                ).Count();
                                lista.Add(tmp.ToString());

                                tmp =
                                (
                                    from os in bd.O_STANU
                                    join ob in bd.OBJEKAT on os.id_objekta equals ob.id_objekta
                                    join op in bd.OPSTINA on ob.opstina equals op.naziv
                                    join n in bd.NASELJE on new { a = op.sifra_opstine, b = ob.naselje } equals new { a = n.sifra_opstine, b = n.naziv }
                                    join uo in bd.UPRAVNI_OKRUG on op.sifra_okruga equals uo.sifra_okruga
                                    where int.Parse(os.pitanje9) > 80 && int.Parse(os.pitanje9) < 101 && n.tip_naselja == tip && red["naziv"].ToString() == uo.naziv
                                    select os.pitanje9
                                ).Count();
                                lista.Add(tmp.ToString());

                                tmp =
                                (
                                    from os in bd.O_STANU
                                    join ob in bd.OBJEKAT on os.id_objekta equals ob.id_objekta
                                    join op in bd.OPSTINA on ob.opstina equals op.naziv
                                    join n in bd.NASELJE on new { a = op.sifra_opstine, b = ob.naselje } equals new { a = n.sifra_opstine, b = n.naziv }
                                    join uo in bd.UPRAVNI_OKRUG on op.sifra_okruga equals uo.sifra_okruga
                                    where int.Parse(os.pitanje9) > 100 && int.Parse(os.pitanje9) < 121 && n.tip_naselja == tip && red["naziv"].ToString() == uo.naziv
                                    select os.pitanje9
                                ).Count();
                                lista.Add(tmp.ToString());

                                tmp =
                                (
                                    from os in bd.O_STANU
                                    join ob in bd.OBJEKAT on os.id_objekta equals ob.id_objekta
                                    join op in bd.OPSTINA on ob.opstina equals op.naziv
                                    join n in bd.NASELJE on new { a = op.sifra_opstine, b = ob.naselje } equals new { a = n.sifra_opstine, b = n.naziv }
                                    join uo in bd.UPRAVNI_OKRUG on op.sifra_okruga equals uo.sifra_okruga
                                    where int.Parse(os.pitanje9) > 120 && int.Parse(os.pitanje9) < 151 && n.tip_naselja == tip && red["naziv"].ToString() == uo.naziv
                                    select os.pitanje9
                                ).Count();
                                lista.Add(tmp.ToString());

                                tmp =
                                (
                                    from os in bd.O_STANU
                                    join ob in bd.OBJEKAT on os.id_objekta equals ob.id_objekta
                                    join op in bd.OPSTINA on ob.opstina equals op.naziv
                                    join n in bd.NASELJE on new { a = op.sifra_opstine, b = ob.naselje } equals new { a = n.sifra_opstine, b = n.naziv }
                                    join uo in bd.UPRAVNI_OKRUG on op.sifra_okruga equals uo.sifra_okruga
                                    where int.Parse(os.pitanje9) > 150 && n.tip_naselja == tip && red["naziv"].ToString() == uo.naziv
                                    select os.pitanje9
                                ).Count();
                                lista.Add(tmp.ToString());

                                dt.Rows.Add(lista.ToArray());
                            }
                        }
                    }
                }
            }
        }
        private void grejanje(DataTable dt)
        {
            List<string> lista = new List<string>();
            List<string> tipNaselja = new List<string>();
            List<string> tipGrejanja = new List<string>();
            tipNaselja.Add("Ukupno");
            tipNaselja.Add("G");
            tipNaselja.Add("O");

            //tipGrejanja.Add("Ukupno");
            tipGrejanja.Add("Ugalj");
            tipGrejanja.Add("Drvo, pelet i slični proizvodi od drveta");
            tipGrejanja.Add("Mazut i ulje za loženje");
            tipGrejanja.Add("Plinsko/gasno gorivo");
            tipGrejanja.Add("Eletrična energija (struja)");
            tipGrejanja.Add("Druga vrsta energije");
            int tmp;

            foreach (string tip in tipNaselja)
            {
                lista = new List<string>();
                lista.Add("Republika Srbija");
                if (tip == "Ukupno")
                    lista.Add("Ukupno");
                else if (tip == "G")
                    lista.Add("Gradska naselja");
                else
                    lista.Add("Ostala");
                if (tip == "Ukupno")
                {
                    tmp =
                    (
                        from os in bd.O_STANU
                        where !os.pitanje14_5.Contains("Daljinsko")
                        select os.id_objekta
                    ).Count();
                    lista.Add(tmp.ToString());

                    foreach (string grejanje in tipGrejanja)
                    {
                        tmp =
                        (
                            from os in bd.O_STANU
                            where os.pitanje15.Contains(grejanje) && !os.pitanje14_5.Contains("Daljinsko")
                            select os.id_objekta
                        ).Count();
                        lista.Add(tmp.ToString());
                    }
                }
                else
                {
                    tmp =
                    (
                        from os in bd.O_STANU
                        join ob in bd.OBJEKAT on os.id_objekta equals ob.id_objekta
                        join op in bd.OPSTINA on ob.opstina equals op.naziv
                        join n in bd.NASELJE on new { a = op.sifra_opstine, b = ob.naselje } equals new { a = n.sifra_opstine, b = n.naziv }
                        where n.tip_naselja == tip && !os.pitanje14_5.Contains("Daljinsko")
                        select os.id_objekta
                    ).Count();
                    lista.Add(tmp.ToString());
                    foreach (string grejanje in tipGrejanja)
                    {
                        tmp =
                        (
                            from os in bd.O_STANU
                            join ob in bd.OBJEKAT on os.id_objekta equals ob.id_objekta
                            join op in bd.OPSTINA on ob.opstina equals op.naziv
                            join n in bd.NASELJE on new { a = op.sifra_opstine, b = ob.naselje } equals new { a = n.sifra_opstine, b = n.naziv }
                            where os.pitanje15.Contains(grejanje) && n.tip_naselja == tip && !os.pitanje14_5.Contains("Daljinsko")
                            select os.id_objekta
                        ).Count();
                        lista.Add(tmp.ToString());

                    }
                }
                dt.Rows.Add(lista.ToArray());
            }

            foreach (DataRow red in bd.NSTJ2.Rows)
            {
                foreach (DataColumn dc in bd.NSTJ2.Columns)
                {
                    
                    if (dc.ColumnName == "naziv")
                    {
                        foreach(string tip in tipNaselja)
                        {
                            lista = new List<string>();
                            lista.Add(red["naziv"].ToString());

                            if (tip == "Ukupno")
                            {
                                lista.Add("Ukupno");
                                tmp =
                                (
                                    from os in bd.O_STANU
                                    join ob in bd.OBJEKAT on os.id_objekta equals ob.id_objekta
                                    join op in bd.OPSTINA on ob.opstina equals op.naziv
                                    join n in bd.NASELJE on new { a = op.sifra_opstine, b = ob.naselje } equals new { a = n.sifra_opstine, b = n.naziv }
                                    join uo in bd.UPRAVNI_OKRUG on op.sifra_okruga equals uo.sifra_okruga
                                    join nstj2 in bd.NSTJ2 on uo.sifra_nstj2 equals nstj2.sifra_oblasti
                                    where nstj2.naziv == red["naziv"].ToString() && !os.pitanje14_5.Contains("Daljinsko")
                                    select os.id_objekta 
                                ).Count();
                                lista.Add(tmp.ToString());

                                foreach (string grejanje in tipGrejanja)
                                {
                                    tmp =
                                    (
                                        from os in bd.O_STANU
                                        join ob in bd.OBJEKAT on os.id_objekta equals ob.id_objekta
                                        join op in bd.OPSTINA on ob.opstina equals op.naziv
                                        join n in bd.NASELJE on new { a = op.sifra_opstine, b = ob.naselje } equals new { a = n.sifra_opstine, b = n.naziv }
                                        join uo in bd.UPRAVNI_OKRUG on op.sifra_okruga equals uo.sifra_okruga
                                        join nstj2 in bd.NSTJ2 on uo.sifra_nstj2 equals nstj2.sifra_oblasti
                                        where os.pitanje15.Contains(grejanje) && nstj2.naziv == red["naziv"].ToString() && !os.pitanje14_5.Contains("Daljinsko")
                                        select os.id_objekta
                                    ).Count();
                                    lista.Add(tmp.ToString());
                                }
                                dt.Rows.Add(lista.ToArray());
                            }
                            else
                            {
                                if (tip == "G")
                                    lista.Add("Gradska naselja");
                                else if (tip == "O")
                                    lista.Add("Ostala");
                                tmp =
                                (
                                    from os in bd.O_STANU
                                    join ob in bd.OBJEKAT on os.id_objekta equals ob.id_objekta
                                    join op in bd.OPSTINA on ob.opstina equals op.naziv
                                    join n in bd.NASELJE on new { a = op.sifra_opstine, b = ob.naselje } equals new { a = n.sifra_opstine, b = n.naziv }
                                    join uo in bd.UPRAVNI_OKRUG on op.sifra_okruga equals uo.sifra_okruga
                                    join nstj2 in bd.NSTJ2 on uo.sifra_nstj2 equals nstj2.sifra_oblasti
                                    where n.tip_naselja == tip && nstj2.naziv == red["naziv"].ToString() && !os.pitanje14_5.Contains("Daljinsko")
                                    select os.id_objekta
                                ).Count();
                                lista.Add(tmp.ToString());
                                foreach (string grejanje in tipGrejanja)
                                {
                                    tmp =
                                    (
                                        from os in bd.O_STANU
                                        join ob in bd.OBJEKAT on os.id_objekta equals ob.id_objekta
                                        join op in bd.OPSTINA on ob.opstina equals op.naziv
                                        join n in bd.NASELJE on new { a = op.sifra_opstine, b = ob.naselje } equals new { a = n.sifra_opstine, b = n.naziv }
                                        join uo in bd.UPRAVNI_OKRUG on op.sifra_okruga equals uo.sifra_okruga
                                        join nstj2 in bd.NSTJ2 on uo.sifra_nstj2 equals nstj2.sifra_oblasti
                                        where os.pitanje15 == grejanje && n.tip_naselja == tip && nstj2.naziv == red["naziv"].ToString() && !os.pitanje14_5.Contains("Daljinsko")
                                        select os.id_objekta
                                    ).Count();
                                    lista.Add(tmp.ToString());

                                }
                                dt.Rows.Add(lista.ToArray());
                            }
                        }
                    }
                }
            }
        }
    }
}

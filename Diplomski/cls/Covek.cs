using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplomski
{
    class Covek
    {
        private string ime;
        private string prezime;
        private string JMBG;
        private string brojLk;
        private string datum_rodjenja;

        public Covek(string ime, string prezime, string jMBG, string brojLk, string datum_rodjenja)
        {
            this.ime = ime;
            this.prezime = prezime;
            JMBG = jMBG;
            this.brojLk = brojLk;
            this.datum_rodjenja = datum_rodjenja;
        }

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string JMBG1 { get => JMBG; set => JMBG = value; }
        public string BrojLk { get => brojLk; set => brojLk = value; }
        public string Datum_rodjenja { get => datum_rodjenja; set => datum_rodjenja = value; }
    }
}

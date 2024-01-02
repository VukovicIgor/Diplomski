using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplomski.cls
{
    class Migracije
    {
        string pitanj3;
        string pitanje4;
        string pitanje5;
        string pitanje5_1;
        string pitanje5_2;
        string pitanje5_3;
        string pitanje6;
        string pitanje6_1;
        string pitanje6_2;
        string pitanje7;
        string pitanje7_1;
        string pitanje7_2;
        string pitanje7_3;
        string pitanje8;

        public Migracije(string pitanj3, string pitanje4, string pitanje5, string pitanje5_1, string pitanje5_2, string pitanje5_3, string pitanje6, string pitanje6_1, string pitanje6_2, string pitanje7, string pitanje7_1, string pitanje7_2, string pitanje7_3, string pitanje8)
        {
            this.Pitanj3 = pitanj3;
            this.Pitanje4 = pitanje4;
            this.Pitanje5 = pitanje5;
            this.Pitanje5_1 = pitanje5_1;
            this.Pitanje5_2 = pitanje5_2;
            this.Pitanje5_3 = pitanje5_3;
            this.Pitanje6 = pitanje6;
            this.Pitanje6_1 = pitanje6_1;
            this.Pitanje6_2 = pitanje6_2;
            this.Pitanje7 = pitanje7;
            this.Pitanje7_1 = pitanje7_1;
            this.Pitanje7_2 = pitanje7_2;
            this.Pitanje7_3 = pitanje7_3;
            this.Pitanje8 = pitanje8;
        }

        public string Pitanj3 { get => pitanj3; set => pitanj3 = value; }
        public string Pitanje4 { get => pitanje4; set => pitanje4 = value; }
        public string Pitanje5 { get => pitanje5; set => pitanje5 = value; }
        public string Pitanje5_1 { get => pitanje5_1; set => pitanje5_1 = value; }
        public string Pitanje5_2 { get => pitanje5_2; set => pitanje5_2 = value; }
        public string Pitanje5_3 { get => pitanje5_3; set => pitanje5_3 = value; }
        public string Pitanje6 { get => pitanje6; set => pitanje6 = value; }
        public string Pitanje6_1 { get => pitanje6_1; set => pitanje6_1 = value; }
        public string Pitanje6_2 { get => pitanje6_2; set => pitanje6_2 = value; }
        public string Pitanje7 { get => pitanje7; set => pitanje7 = value; }
        public string Pitanje7_1 { get => pitanje7_1; set => pitanje7_1 = value; }
        public string Pitanje7_2 { get => pitanje7_2; set => pitanje7_2 = value; }
        public string Pitanje7_3 { get => pitanje7_3; set => pitanje7_3 = value; }
        public string Pitanje8 { get => pitanje8; set => pitanje8 = value; }
    }
}

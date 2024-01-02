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

    public partial class frmPrikaz : Form
    {
        BazaDiplomskog ds = new BazaDiplomskog();
        BazaDiplomskogTableAdapters.NASELJETableAdapter naseljeAdapter = new BazaDiplomskogTableAdapters.NASELJETableAdapter();

        public frmPrikaz()
        {
            InitializeComponent();

        }

        private void frmPrikaz_Load(object sender, EventArgs e)
        {
            btnAdministracija.Size = new Size(this.Width / 2, this.Height / 2);
            btnPrijava.Size = new Size(this.Width / 2, this.Height / 2);
        }


        private void frmPrikaz_Resize(object sender, EventArgs e)
        {
            btnAdministracija.Size = new Size(this.Width / 2, this.Height / 2);
            btnPrijava.Size = new Size(this.Width / 2, this.Height / 2);
        }
    }
}

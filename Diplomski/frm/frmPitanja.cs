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
    public partial class frmPitanja : Form
    {
        public frmPitanja()
        {
            InitializeComponent();
        }

        private void frmPitanja_Load(object sender, EventArgs e)
        {
            axAcroPDF1.src = "C:\\Users\\RVeVe\\source\\repos\\Diplomski\\Diplomski\\pitanja.pdf";
        }
    }
}

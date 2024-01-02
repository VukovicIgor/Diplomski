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
    public partial class frmFunkcionisanje : Form
    {
        int id;
        int id_popisivaca;
        BazaDiplomskog bd = new BazaDiplomskog();
        BazaDiplomskogTableAdapters.tmp_FUNKCIONISANJE_SOCIJALNA_INTEGRISANOSTTableAdapter tmp_funkcionisanjeAdapter = new BazaDiplomskogTableAdapters.tmp_FUNKCIONISANJE_SOCIJALNA_INTEGRISANOSTTableAdapter();
        BazaDiplomskogTableAdapters.QueriesTableAdapter brisanje = new BazaDiplomskogTableAdapters.QueriesTableAdapter();
        BazaDiplomskogTableAdapters.OBJEKATTableAdapter objekatAdapter = new BazaDiplomskogTableAdapters.OBJEKATTableAdapter();
        BazaDiplomskogTableAdapters.tmp_OBJEKATTableAdapter tmp_objekatAdapter = new BazaDiplomskogTableAdapters.tmp_OBJEKATTableAdapter();

        string pitanje32_1;
        string pitanje32_2;
        string pitanje32_3;
        string pitanje32_4;
        string pitanje32_5;
        string pitanje32_6;
        public frmFunkcionisanje(int id, int id_popisivaca)
        {
            InitializeComponent();
            this.id = id;
            this.id_popisivaca = id_popisivaca;
            MessageBoxManager.Yes = "Da";
            MessageBoxManager.No = "Ne";
            MessageBoxManager.Register();
            brisanje.brisanje_tmp_soc_inte(id_popisivaca);
            tmp_funkcionisanjeAdapter.Fill(bd.tmp_FUNKCIONISANJE_SOCIJALNA_INTEGRISANOST);
        }

        private void cb32_1_Nema_CheckedChanged(object sender, EventArgs e)
        {
            if(cb32_1_Nema.Checked)
            {
                pitanje32_1 = "Nema poteškoća";
                foreach (Control c in Controls)
                {
                    if (c.Name.Contains("32_1") && c.Name != "cb32_1_Nema")
                    {
                        CheckBox cb = (CheckBox)c;
                        cb.Checked = false;
                    }
                }
            }
        }
        private void cb32_1_Malo_CheckedChanged(object sender, EventArgs e)
        {
            pitanje32_1 = "Malo poteškoća";
            if (cb32_1_Malo.Checked)
            {
                foreach (Control c in Controls)
                {
                    if (c.Name.Contains("32_1") && c.Name != "cb32_1_Malo")
                    {
                        CheckBox cb = (CheckBox)c;
                        cb.Checked = false;
                    }
                }
            }
        }
        private void cb32_1_Mnogo_CheckedChanged(object sender, EventArgs e)
        {
            pitanje32_1 = "Mnogo poteškoća";
            if (cb32_1_Mnogo.Checked)
            {
                foreach (Control c in Controls)
                {
                    if (c.Name.Contains("32_1") && c.Name != "cb32_1_Mnogo")
                    {
                        CheckBox cb = (CheckBox)c;
                        cb.Checked = false;
                    }
                }
            }
        }
        private void cb32_1_Potpuno_CheckedChanged(object sender, EventArgs e)
        {
            pitanje32_1 = "Potpuno onemogućeno";
            if (cb32_1_Potpuno.Checked)
            {
                foreach (Control c in Controls)
                {
                    if (c.Name.Contains("32_1") && c.Name != "cb32_1_Potpuno")
                    {
                        CheckBox cb = (CheckBox)c;
                        cb.Checked = false;
                    }
                }
            }
        }
        private void cb32_1_BezOdgovora_CheckedChanged(object sender, EventArgs e)
        {
            pitanje32_1 = "Ne želi da da odgovor";
            if (cb32_1_BezOdgovora.Checked)
            {
                foreach (Control c in Controls)
                {
                    if (c.Name.Contains("32_1") && c.Name != "cb32_1_BezOdgovora")
                    {
                        CheckBox cb = (CheckBox)c;
                        cb.Checked = false;
                    }
                }
            }
        }
        private void cb32_2_Nema_CheckedChanged(object sender, EventArgs e)
        {
            pitanje32_2 = "Nema poteškoća";
            if (cb32_2_Nema.Checked)
            {
                foreach (Control c in Controls)
                {
                    if (c.Name.Contains("32_2") && c.Name != "cb32_2_Nema")
                    {
                        CheckBox cb = (CheckBox)c;
                        cb.Checked = false;
                    }
                }
            }
        }
        private void cb32_2_Malo_CheckedChanged(object sender, EventArgs e)
        {
            pitanje32_2 = "Malo poteškoća";
            if (cb32_2_Malo.Checked)
            {
                foreach (Control c in Controls)
                {
                    if (c.Name.Contains("32_2") && c.Name != "cb32_2_Malo")
                    {
                        CheckBox cb = (CheckBox)c;
                        cb.Checked = false;
                    }
                }
            }
        }
        private void cb32_2_Mnogo_CheckedChanged(object sender, EventArgs e)
        {
            pitanje32_2 = "Mnogo poteškoća";
            if (cb32_2_Mnogo.Checked)
            {
                foreach (Control c in Controls)
                {
                    if (c.Name.Contains("32_2") && c.Name != "cb32_2_Mnogo")
                    {
                        CheckBox cb = (CheckBox)c;
                        cb.Checked = false;
                    }
                }
            }
        }
        private void cb32_2_Potpuno_CheckedChanged(object sender, EventArgs e)
        {
            pitanje32_2 = "Potpuno onemogućeno";
            if (cb32_2_Potpuno.Checked)
            {
                foreach (Control c in Controls)
                {
                    if (c.Name.Contains("32_2") && c.Name != "cb32_2_Potpuno")
                    {
                        CheckBox cb = (CheckBox)c;
                        cb.Checked = false;
                    }
                }
            }
        }
        private void cb32_2_BezOdgovora_CheckedChanged(object sender, EventArgs e)
        {
            pitanje32_2 = "Ne želi da da odgovor";
            if (cb32_2_BezOdgovora.Checked)
            {
                foreach (Control c in Controls)
                {
                    if (c.Name.Contains("32_2") && c.Name != "cb32_2_BezOdgovora")
                    {
                        CheckBox cb = (CheckBox)c;
                        cb.Checked = false;
                    }
                }
            }
        }
        private void cb32_3_Nema_CheckedChanged(object sender, EventArgs e)
        {
            pitanje32_3 = "Nema poteškoća";
            if (cb32_3_Nema.Checked)
            {
                foreach (Control c in Controls)
                {
                    if (c.Name.Contains("32_3") && c.Name != "cb32_3_Nema")
                    {
                        CheckBox cb = (CheckBox)c;
                        cb.Checked = false;
                    }
                }
            }
        }
        private void cb32_3_Malo_CheckedChanged(object sender, EventArgs e)
        {
            pitanje32_3 = "Malo poteškoća";
            if (cb32_3_Malo.Checked)
            {
                foreach (Control c in Controls)
                {
                    if (c.Name.Contains("32_3") && c.Name != "cb32_3_Malo")
                    {
                        CheckBox cb = (CheckBox)c;
                        cb.Checked = false;
                    }
                }
            }
        }
        private void cb32_3_Mnogo_CheckedChanged(object sender, EventArgs e)
        {
            pitanje32_3 = "Mnogo poteškoća";
            if (cb32_3_Mnogo.Checked)
            {
                foreach (Control c in Controls)
                {
                    if (c.Name.Contains("32_3") && c.Name != "cb32_3_Mnogo")
                    {
                        CheckBox cb = (CheckBox)c;
                        cb.Checked = false;
                    }
                }
            }
        }
        private void cb32_3_Potpuno_CheckedChanged(object sender, EventArgs e)
        {
            pitanje32_3 = "Potpuno onemogućeno";
            if (cb32_3_Potpuno.Checked)
            {
                foreach (Control c in Controls)
                {
                    if (c.Name.Contains("32_3") && c.Name != "cb32_3_Potpuno")
                    {
                        CheckBox cb = (CheckBox)c;
                        cb.Checked = false;
                    }
                }
            }
        }
        private void cb32_3_BezOdgovora_CheckedChanged(object sender, EventArgs e)
        {
            pitanje32_3 = "Ne želi da da odgovor";
            if (cb32_3_BezOdgovora.Checked)
            {
                foreach (Control c in Controls)
                {
                    if (c.Name.Contains("32_3") && c.Name != "cb32_3_BezOdgovora")
                    {
                        CheckBox cb = (CheckBox)c;
                        cb.Checked = false;
                    }
                }
            }
        }
        private void cb32_4_Nema_CheckedChanged(object sender, EventArgs e)
        {
            pitanje32_4 = "Nema poteškoća";
            if (cb32_4_Nema.Checked)
            {
                foreach (Control c in Controls)
                {
                    if (c.Name.Contains("32_4") && c.Name != "cb32_4_Nema")
                    {
                        CheckBox cb = (CheckBox)c;
                        cb.Checked = false;
                    }
                }
            }
        }
        private void cb32_4_Malo_CheckedChanged(object sender, EventArgs e)
        {
            pitanje32_4 = "Malo poteškoća";
            if (cb32_4_Malo.Checked)
            {
                foreach (Control c in Controls)
                {
                    if (c.Name.Contains("32_4") && c.Name != "cb32_4_Malo")
                    {
                        CheckBox cb = (CheckBox)c;
                        cb.Checked = false;
                    }
                }
            }
        }
        private void cb32_4_Mnogo_CheckedChanged(object sender, EventArgs e)
        {
            pitanje32_4 = "Mnogo poteškoća";
            if (cb32_4_Mnogo.Checked)
            {
                foreach (Control c in Controls)
                {
                    if (c.Name.Contains("32_4") && c.Name != "cb32_4_Mnogo")
                    {
                        CheckBox cb = (CheckBox)c;
                        cb.Checked = false;
                    }
                }
            }
        }
        private void cb32_4_Potpuno_CheckedChanged(object sender, EventArgs e)
        {
            pitanje32_4 = "Potpuno onemogućeno";
            if (cb32_4_Potpuno.Checked)
            {
                foreach (Control c in Controls)
                {
                    if (c.Name.Contains("32_4") && c.Name != "cb32_4_Potpuno")
                    {
                        CheckBox cb = (CheckBox)c;
                        cb.Checked = false;
                    }
                }
            }
        }
        private void cb32_4_BezOdgovora_CheckedChanged(object sender, EventArgs e)
        {
            pitanje32_4 = "Ne želi da da odgovor";
            if (cb32_4_BezOdgovora.Checked)
            {
                foreach (Control c in Controls)
                {
                    if (c.Name.Contains("32_4") && c.Name != "cb32_4_BezOdgovora")
                    {
                        CheckBox cb = (CheckBox)c;
                        cb.Checked = false;
                    }
                }
            }
        }
        private void cb32_5_Nema_CheckedChanged(object sender, EventArgs e)
        {
            pitanje32_5 = "Nema poteškoća";
            if (cb32_5_Nema.Checked)
            {
                foreach (Control c in Controls)
                {
                    if (c.Name.Contains("32_5") && c.Name != "cb32_5_Nema")
                    {
                        CheckBox cb = (CheckBox)c;
                        cb.Checked = false;
                    }
                }
            }
        }
        private void cb32_5_Malo_CheckedChanged(object sender, EventArgs e)
        {
            pitanje32_5 = "Malo poteškoća";
            if (cb32_5_Malo.Checked)
            {
                foreach (Control c in Controls)
                {
                    if (c.Name.Contains("32_5") && c.Name != "cb32_5_Malo")
                    {
                        CheckBox cb = (CheckBox)c;
                        cb.Checked = false;
                    }
                }
            }
        }
        private void cb32_5_Mnogo_CheckedChanged(object sender, EventArgs e)
        {
            pitanje32_5 = "Mnogo poteškoća";
            if (cb32_5_Mnogo.Checked)
            {
                foreach (Control c in Controls)
                {
                    if (c.Name.Contains("32_5") && c.Name != "cb32_5_Mnogo")
                    {
                        CheckBox cb = (CheckBox)c;
                        cb.Checked = false;
                    }
                }
            }
        }
        private void cb32_5_Potpuno_CheckedChanged(object sender, EventArgs e)
        {
            pitanje32_5 = "Potpuno onemogućeno";
            if (cb32_5_Potpuno.Checked)
            {
                foreach (Control c in Controls)
                {
                    if (c.Name.Contains("32_5") && c.Name != "cb32_5_Potpuno")
                    {
                        CheckBox cb = (CheckBox)c;
                        cb.Checked = false;
                    }
                }
            }
        }
        private void cb32_5_BezOdgovora_CheckedChanged(object sender, EventArgs e)
        {
            pitanje32_5 = "Ne želi da da odgovor";
            if (cb32_5_BezOdgovora.Checked)
            {
                foreach (Control c in Controls)
                {
                    if (c.Name.Contains("32_5") && c.Name != "cb32_5_BezOdgovora")
                    {
                        CheckBox cb = (CheckBox)c;
                        cb.Checked = false;
                    }
                }
            }
        }
        private void cb32_6_Nema_CheckedChanged(object sender, EventArgs e)
        {
            pitanje32_6 = "Nema poteškoća";
            if (cb32_6_Nema.Checked)
            {
                foreach (Control c in Controls)
                {
                    if (c.Name.Contains("32_6") && c.Name != "cb32_6_Nema")
                    {
                        CheckBox cb = (CheckBox)c;
                        cb.Checked = false;
                    }
                }
            }
        }
        private void cb32_6_Malo_CheckedChanged(object sender, EventArgs e)
        {
            pitanje32_6 = "Malo poteškoća";
            if (cb32_6_Malo.Checked)
            {
                foreach (Control c in Controls)
                {
                    if (c.Name.Contains("32_6") && c.Name != "cb32_6_Malo")
                    {
                        CheckBox cb = (CheckBox)c;
                        cb.Checked = false;
                    }
                }
            }
        }
        private void cb32_6_Mnogo_CheckedChanged(object sender, EventArgs e)
        {
            pitanje32_6 = "Mnogo poteškoća";
            if (cb32_6_Mnogo.Checked)
            {
                foreach (Control c in Controls)
                {
                    if (c.Name.Contains("32_6") && c.Name != "cb32_6_Mnogo")
                    {
                        CheckBox cb = (CheckBox)c;
                        cb.Checked = false;
                    }
                }
            }
        }
        private void cb32_6_Potpuno_CheckedChanged(object sender, EventArgs e)
        {
            pitanje32_6 = "Potpuno onemogućeno";
            if (cb32_6_Potpuno.Checked)
            {
                foreach (Control c in Controls)
                {
                    if (c.Name.Contains("32_6") && c.Name != "cb32_6_Potpuno")
                    {
                        CheckBox cb = (CheckBox)c;
                        cb.Checked = false;
                    }
                }
            }
        }
        private void cb32_6_BezOdgovora_CheckedChanged(object sender, EventArgs e)
        {
            pitanje32_6 = "Ne želi da da odgovor";
            if (cb32_6_BezOdgovora.Checked)
            {
                foreach (Control c in Controls)
                {
                    if (c.Name.Contains("32_6") && c.Name != "cb32_6_BezOdgovora")
                    {
                        CheckBox cb = (CheckBox)c;
                        cb.Checked = false;
                    }
                }
            }
        }
        private void btnDalje_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Da li ste sigurni?", "Unos", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                BazaDiplomskog.tmp_FUNKCIONISANJE_SOCIJALNA_INTEGRISANOSTRow red = bd.tmp_FUNKCIONISANJE_SOCIJALNA_INTEGRISANOST.Newtmp_FUNKCIONISANJE_SOCIJALNA_INTEGRISANOSTRow();
                red.id_osobe = id;
                red.id_popisivac = id_popisivaca;
                if (pitanje32_1 != string.Empty)
                    red.pitanje32_1 = pitanje32_1;
                if (pitanje32_2 != string.Empty)
                    red.pitanje32_2 = pitanje32_2;
                if (pitanje32_3 != string.Empty)
                    red.pitanje32_3 = pitanje32_3;
                if (pitanje32_4 != string.Empty)
                    red.pitanje32_4 = pitanje32_4;
                if (pitanje32_5 != string.Empty)
                    red.pitanje32_5 = pitanje32_5;
                if (pitanje32_6 != string.Empty)
                    red.pitanje32_6 = pitanje32_6;

                bd.tmp_FUNKCIONISANJE_SOCIJALNA_INTEGRISANOST.Addtmp_FUNKCIONISANJE_SOCIJALNA_INTEGRISANOSTRow(red);
                tmp_funkcionisanjeAdapter.Update(bd.tmp_FUNKCIONISANJE_SOCIJALNA_INTEGRISANOST);
                MessageBoxManager.Unregister();
                frmObjekat forma=new frmObjekat(id, id_popisivaca);
                this.Hide();
                forma.ShowDialog();
                this.Close();
            }
        }

        private void svaPitanjaToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}
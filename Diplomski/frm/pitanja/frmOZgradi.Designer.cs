namespace Diplomski.frm.pitanja
{
    partial class frmOZgradi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.clb1 = new System.Windows.Forms.CheckedListBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.clb2 = new System.Windows.Forms.CheckedListBox();
            this.clb3 = new System.Windows.Forms.CheckedListBox();
            this.lb3 = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.lb5 = new System.Windows.Forms.Label();
            this.lb5_1 = new System.Windows.Forms.Label();
            this.cmb5 = new System.Windows.Forms.ComboBox();
            this.lb5_2 = new System.Windows.Forms.Label();
            this.btnKraj2 = new System.Windows.Forms.Button();
            this.lb6 = new System.Windows.Forms.Label();
            this.clb6 = new System.Windows.Forms.CheckedListBox();
            this.clb7 = new System.Windows.Forms.CheckedListBox();
            this.lb7 = new System.Windows.Forms.Label();
            this.btnDalje = new System.Windows.Forms.Button();
            this.btnKraj1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.svaPitanjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.početnaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clb1
            // 
            this.clb1.BackColor = System.Drawing.SystemColors.Control;
            this.clb1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clb1.CheckOnClick = true;
            this.clb1.FormattingEnabled = true;
            this.clb1.Items.AddRange(new object[] {
            "Stambena zgrada/kuća",
            "Zgrada za kolektivni smeštaj",
            "Zgrada/objekat nastanjen iz nužde (garaža, šupa i sl.)",
            "Nestambena zgrada (škola, hotel, fabrika i sl.)",
            "Pomoćna zgrada koja se ne popisuje",
            "Zgrada u izgradnji koja se ne popisuje"});
            this.clb1.Location = new System.Drawing.Point(12, 65);
            this.clb1.Name = "clb1";
            this.clb1.Size = new System.Drawing.Size(278, 90);
            this.clb1.TabIndex = 0;
            this.clb1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clb1_ItemCheck);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(9, 35);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(122, 16);
            this.lb1.TabIndex = 86;
            this.lb1.Text = "1. VRSTA ZGRADE";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Enabled = false;
            this.lb2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.Location = new System.Drawing.Point(9, 194);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(196, 16);
            this.lb2.TabIndex = 87;
            this.lb2.Text = "2. VRSTA STAMBENE ZGRADE";
            this.lb2.EnabledChanged += new System.EventHandler(this.lb2_EnabledChanged);
            // 
            // clb2
            // 
            this.clb2.BackColor = System.Drawing.SystemColors.Control;
            this.clb2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clb2.CheckOnClick = true;
            this.clb2.Enabled = false;
            this.clb2.FormattingEnabled = true;
            this.clb2.Items.AddRange(new object[] {
            "Porodična kuća sa jednim stanom",
            "Porodična kuća sa dva stana, jedan iznad drugog",
            "Porodična kuća sa dva propojena stana",
            "Stambena zgrada u nizu (s najmanje tri pripojena stana, svaki stan ima svoj ulaz)" +
                "",
            "Stambena zgrada sa 3-9 stanova",
            "Stambena zgrada sa 10 i više stanova"});
            this.clb2.Location = new System.Drawing.Point(12, 222);
            this.clb2.Name = "clb2";
            this.clb2.Size = new System.Drawing.Size(399, 90);
            this.clb2.TabIndex = 88;
            this.clb2.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clb2_ItemCheck);
            // 
            // clb3
            // 
            this.clb3.BackColor = System.Drawing.SystemColors.Control;
            this.clb3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clb3.CheckOnClick = true;
            this.clb3.Enabled = false;
            this.clb3.FormattingEnabled = true;
            this.clb3.Items.AddRange(new object[] {
            "Studentski/đački dom, internat",
            "Ustanova socijalne zaštite (dom za stare, dom za nezbrinutu decu)",
            "Specijalna bolnica za psihijatrijske bolesti",
            "Prihvatilište za beskućnike",
            "Verska ustanova",
            "Kolketivni centar za izbeglice i raseljena lica",
            "Prihvatni centar, centar za azil",
            "Ustanova za izvršenje krivičnih sankcija",
            "Objekat za privremeni smeštaj radnika",
            "Drugo (samački hoteli, objekti vojske/policije i sl.)"});
            this.clb3.Location = new System.Drawing.Point(12, 373);
            this.clb3.Name = "clb3";
            this.clb3.Size = new System.Drawing.Size(338, 150);
            this.clb3.TabIndex = 90;
            this.clb3.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clb3_ItemCheck);
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Enabled = false;
            this.lb3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb3.Location = new System.Drawing.Point(9, 345);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(237, 16);
            this.lb3.TabIndex = 89;
            this.lb3.Text = "3. VRSTA KOLEKTIVNOG SMEŠTAJA";
            this.lb3.EnabledChanged += new System.EventHandler(this.lb3_EnabledChanged);
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Enabled = false;
            this.lb4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb4.Location = new System.Drawing.Point(492, 35);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(210, 16);
            this.lb4.TabIndex = 91;
            this.lb4.Text = "4. UPISATI PUN NAZIV OBJEKTA";
            this.lb4.EnabledChanged += new System.EventHandler(this.lb4_EnabledChanged);
            // 
            // txt4
            // 
            this.txt4.Enabled = false;
            this.txt4.Location = new System.Drawing.Point(495, 65);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(335, 20);
            this.txt4.TabIndex = 92;
            this.txt4.TextChanged += new System.EventHandler(this.txt4_TextChanged);
            // 
            // lb5
            // 
            this.lb5.AutoSize = true;
            this.lb5.Enabled = false;
            this.lb5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb5.Location = new System.Drawing.Point(492, 139);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(361, 16);
            this.lb5.TabIndex = 93;
            this.lb5.Text = "5. UKUPAN BROJ STANOVA NA DATOM KUĆNOM BROJU";
            this.lb5.EnabledChanged += new System.EventHandler(this.lb5_EnabledChanged);
            // 
            // lb5_1
            // 
            this.lb5_1.AutoSize = true;
            this.lb5_1.BackColor = System.Drawing.SystemColors.Control;
            this.lb5_1.Enabled = false;
            this.lb5_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb5_1.Location = new System.Drawing.Point(493, 165);
            this.lb5_1.Name = "lb5_1";
            this.lb5_1.Size = new System.Drawing.Size(177, 36);
            this.lb5_1.TabIndex = 94;
            this.lb5_1.Text = "(upisati ukupan broj stanova, nastanjenih\r\nposlovnih prostorija, prostorija nasta" +
    "njenih\r\niz nužde i kolektivnih stanova)";
            // 
            // cmb5
            // 
            this.cmb5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb5.Enabled = false;
            this.cmb5.FormattingEnabled = true;
            this.cmb5.Location = new System.Drawing.Point(495, 222);
            this.cmb5.Name = "cmb5";
            this.cmb5.Size = new System.Drawing.Size(151, 21);
            this.cmb5.TabIndex = 95;
            this.cmb5.TextChanged += new System.EventHandler(this.cmb5_TextChanged);
            // 
            // lb5_2
            // 
            this.lb5_2.AutoSize = true;
            this.lb5_2.BackColor = System.Drawing.SystemColors.Control;
            this.lb5_2.Enabled = false;
            this.lb5_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb5_2.Location = new System.Drawing.Point(656, 263);
            this.lb5_2.Name = "lb5_2";
            this.lb5_2.Size = new System.Drawing.Size(116, 13);
            this.lb5_2.TabIndex = 96;
            this.lb5_2.Text = "Ako je broj stanova = 0";
            // 
            // btnKraj2
            // 
            this.btnKraj2.Enabled = false;
            this.btnKraj2.Location = new System.Drawing.Point(778, 258);
            this.btnKraj2.Name = "btnKraj2";
            this.btnKraj2.Size = new System.Drawing.Size(75, 23);
            this.btnKraj2.TabIndex = 97;
            this.btnKraj2.Text = "KRAJ";
            this.btnKraj2.UseVisualStyleBackColor = true;
            this.btnKraj2.Click += new System.EventHandler(this.btnKraj2_Click);
            // 
            // lb6
            // 
            this.lb6.AutoSize = true;
            this.lb6.Enabled = false;
            this.lb6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb6.Location = new System.Drawing.Point(492, 305);
            this.lb6.Name = "lb6";
            this.lb6.Size = new System.Drawing.Size(215, 16);
            this.lb6.TabIndex = 98;
            this.lb6.Text = "6. MATERIJAL SPOLJNIH ZIDOVA";
            this.lb6.EnabledChanged += new System.EventHandler(this.lb6_EnabledChanged);
            // 
            // clb6
            // 
            this.clb6.BackColor = System.Drawing.SystemColors.Control;
            this.clb6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clb6.CheckOnClick = true;
            this.clb6.Enabled = false;
            this.clb6.FormattingEnabled = true;
            this.clb6.Items.AddRange(new object[] {
            "Opeka/cigla, beton, kamen",
            "Drvo",
            "Čerpić",
            "Naboj, pleter, daska i drugi materijali"});
            this.clb6.Location = new System.Drawing.Point(494, 336);
            this.clb6.Name = "clb6";
            this.clb6.Size = new System.Drawing.Size(278, 90);
            this.clb6.TabIndex = 99;
            this.clb6.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clb6_ItemCheck);
            // 
            // clb7
            // 
            this.clb7.BackColor = System.Drawing.SystemColors.Control;
            this.clb7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clb7.CheckOnClick = true;
            this.clb7.Enabled = false;
            this.clb7.FormattingEnabled = true;
            this.clb7.Items.AddRange(new object[] {
            "Ima",
            "Nema"});
            this.clb7.Location = new System.Drawing.Point(494, 451);
            this.clb7.Name = "clb7";
            this.clb7.Size = new System.Drawing.Size(50, 30);
            this.clb7.TabIndex = 101;
            this.clb7.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clb7_ItemCheck);
            // 
            // lb7
            // 
            this.lb7.AutoSize = true;
            this.lb7.Enabled = false;
            this.lb7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb7.Location = new System.Drawing.Point(492, 420);
            this.lb7.Name = "lb7";
            this.lb7.Size = new System.Drawing.Size(116, 16);
            this.lb7.TabIndex = 100;
            this.lb7.Text = "7. LIFT U ZGRADI";
            this.lb7.EnabledChanged += new System.EventHandler(this.lb7_EnabledChanged);
            // 
            // btnDalje
            // 
            this.btnDalje.Location = new System.Drawing.Point(777, 514);
            this.btnDalje.Name = "btnDalje";
            this.btnDalje.Size = new System.Drawing.Size(75, 23);
            this.btnDalje.TabIndex = 102;
            this.btnDalje.Text = "DALJE";
            this.btnDalje.UseVisualStyleBackColor = true;
            this.btnDalje.Click += new System.EventHandler(this.btnDalje_Click);
            // 
            // btnKraj1
            // 
            this.btnKraj1.Enabled = false;
            this.btnKraj1.Location = new System.Drawing.Point(307, 132);
            this.btnKraj1.Name = "btnKraj1";
            this.btnKraj1.Size = new System.Drawing.Size(75, 23);
            this.btnKraj1.TabIndex = 103;
            this.btnKraj1.Text = "KRAJ";
            this.btnKraj1.UseVisualStyleBackColor = true;
            this.btnKraj1.Click += new System.EventHandler(this.btnKraj1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.svaPitanjaToolStripMenuItem,
            this.početnaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(864, 24);
            this.menuStrip1.TabIndex = 153;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // svaPitanjaToolStripMenuItem
            // 
            this.svaPitanjaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.svaPitanjaToolStripMenuItem.Name = "svaPitanjaToolStripMenuItem";
            this.svaPitanjaToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.svaPitanjaToolStripMenuItem.Text = "Sva pitanja";
            this.svaPitanjaToolStripMenuItem.Click += new System.EventHandler(this.svaPitanjaToolStripMenuItem_Click);
            // 
            // početnaToolStripMenuItem
            // 
            this.početnaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.početnaToolStripMenuItem.Name = "početnaToolStripMenuItem";
            this.početnaToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.početnaToolStripMenuItem.Text = "Početna";
            this.početnaToolStripMenuItem.Click += new System.EventHandler(this.početnaToolStripMenuItem_Click);
            // 
            // frmOZgradi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 549);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnKraj1);
            this.Controls.Add(this.btnDalje);
            this.Controls.Add(this.clb7);
            this.Controls.Add(this.lb7);
            this.Controls.Add(this.clb6);
            this.Controls.Add(this.lb6);
            this.Controls.Add(this.btnKraj2);
            this.Controls.Add(this.lb5_2);
            this.Controls.Add(this.cmb5);
            this.Controls.Add(this.lb5_1);
            this.Controls.Add(this.lb5);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.lb4);
            this.Controls.Add(this.clb3);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.clb2);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.clb1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmOZgradi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Podaci o zgradi";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clb1;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.CheckedListBox clb2;
        private System.Windows.Forms.CheckedListBox clb3;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.Label lb5_1;
        private System.Windows.Forms.ComboBox cmb5;
        private System.Windows.Forms.Label lb5_2;
        private System.Windows.Forms.Button btnKraj2;
        private System.Windows.Forms.Label lb6;
        private System.Windows.Forms.CheckedListBox clb6;
        private System.Windows.Forms.CheckedListBox clb7;
        private System.Windows.Forms.Label lb7;
        private System.Windows.Forms.Button btnDalje;
        private System.Windows.Forms.Button btnKraj1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem svaPitanjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem početnaToolStripMenuItem;
    }
}
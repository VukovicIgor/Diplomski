namespace Diplomski.frm.pitanja
{
    partial class frmEkonomskaAktivnost
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEkonomskaAktivnost));
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("na kućnoj adresi je registrovan poslovni subjekat(STR,SYR, preduzeće i sl.)");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("na kućnoj adresi nije registrovan poslovni subjekat");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("radi od kuće za poslovni subjekat koji je registrovan na drugoj adresi u Republic" +
        "i Srbiji");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("radi od kuće za stranog poslodavca (registrovan u inostranstvu)");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Na adresi na kojoj se popisuje", new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Na drugoj adresi u Republici Srbiji (u preduzeću, radnji, ustanovi)");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("u mestu popisa");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("u drugom mestu u Republici Srbiji");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Na poljoprivrednom imanju", new System.Windows.Forms.TreeNode[] {
            treeNode18,
            treeNode19});
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("U inostranstvu");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Bez stalnog mesta rada");
            this.lb19 = new System.Windows.Forms.Label();
            this.lb19naslov = new System.Windows.Forms.Label();
            this.cb19Da = new System.Windows.Forms.CheckBox();
            this.cb19Ne = new System.Windows.Forms.CheckBox();
            this.lb20 = new System.Windows.Forms.Label();
            this.cb20Ne = new System.Windows.Forms.CheckBox();
            this.cb20Da = new System.Windows.Forms.CheckBox();
            this.lb21 = new System.Windows.Forms.Label();
            this.cb21Ne = new System.Windows.Forms.CheckBox();
            this.cb21Da = new System.Windows.Forms.CheckBox();
            this.lb22 = new System.Windows.Forms.Label();
            this.cb22Ne = new System.Windows.Forms.CheckBox();
            this.cb22Da = new System.Windows.Forms.CheckBox();
            this.lb23 = new System.Windows.Forms.Label();
            this.clb23 = new System.Windows.Forms.CheckedListBox();
            this.lb24 = new System.Windows.Forms.Label();
            this.txt24 = new System.Windows.Forms.TextBox();
            this.lb24opis = new System.Windows.Forms.Label();
            this.lb25 = new System.Windows.Forms.Label();
            this.clb25 = new System.Windows.Forms.CheckedListBox();
            this.tv26 = new System.Windows.Forms.TreeView();
            this.lb26 = new System.Windows.Forms.Label();
            this.lb26drzava = new System.Windows.Forms.Label();
            this.cmb26Drzava = new System.Windows.Forms.ComboBox();
            this.txt27 = new System.Windows.Forms.TextBox();
            this.lb27 = new System.Windows.Forms.Label();
            this.lb28 = new System.Windows.Forms.Label();
            this.lb28naselje = new System.Windows.Forms.Label();
            this.cmb28Naselje = new System.Windows.Forms.ComboBox();
            this.lb28opstina = new System.Windows.Forms.Label();
            this.cmb28Opstina = new System.Windows.Forms.ComboBox();
            this.lb28Broj = new System.Windows.Forms.Label();
            this.txt28Broj = new System.Windows.Forms.TextBox();
            this.lb28ulica = new System.Windows.Forms.Label();
            this.lb28Adresa = new System.Windows.Forms.Label();
            this.txt28Ulica = new System.Windows.Forms.TextBox();
            this.txt29 = new System.Windows.Forms.TextBox();
            this.lb29 = new System.Windows.Forms.Label();
            this.lb30 = new System.Windows.Forms.Label();
            this.cb30Svakidan = new System.Windows.Forms.CheckBox();
            this.cb30Jednom = new System.Windows.Forms.CheckBox();
            this.btnDalje = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.svaPitanjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.početnaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb19
            // 
            this.lb19.AutoSize = true;
            this.lb19.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb19.Location = new System.Drawing.Point(12, 73);
            this.lb19.Name = "lb19";
            this.lb19.Size = new System.Drawing.Size(337, 75);
            this.lb19.TabIndex = 86;
            this.lb19.Text = resources.GetString("lb19.Text");
            // 
            // lb19naslov
            // 
            this.lb19naslov.AutoSize = true;
            this.lb19naslov.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lb19naslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb19naslov.Location = new System.Drawing.Point(366, 38);
            this.lb19naslov.Name = "lb19naslov";
            this.lb19naslov.Size = new System.Drawing.Size(152, 24);
            this.lb19naslov.TabIndex = 87;
            this.lb19naslov.Text = "Pitanja od 19 do 30 se postavljaju za\r\nlice staro 15 ili više godina";
            this.lb19naslov.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb19Da
            // 
            this.cb19Da.AutoSize = true;
            this.cb19Da.Location = new System.Drawing.Point(130, 164);
            this.cb19Da.Name = "cb19Da";
            this.cb19Da.Size = new System.Drawing.Size(40, 17);
            this.cb19Da.TabIndex = 88;
            this.cb19Da.Text = "Da";
            this.cb19Da.UseVisualStyleBackColor = true;
            this.cb19Da.CheckedChanged += new System.EventHandler(this.cb19Da_CheckedChanged);
            // 
            // cb19Ne
            // 
            this.cb19Ne.AutoSize = true;
            this.cb19Ne.Location = new System.Drawing.Point(216, 164);
            this.cb19Ne.Name = "cb19Ne";
            this.cb19Ne.Size = new System.Drawing.Size(40, 17);
            this.cb19Ne.TabIndex = 89;
            this.cb19Ne.Text = "Ne";
            this.cb19Ne.UseVisualStyleBackColor = true;
            this.cb19Ne.CheckedChanged += new System.EventHandler(this.cb19Ne_CheckedChanged);
            // 
            // lb20
            // 
            this.lb20.AutoSize = true;
            this.lb20.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb20.Location = new System.Drawing.Point(12, 194);
            this.lb20.Name = "lb20";
            this.lb20.Size = new System.Drawing.Size(379, 60);
            this.lb20.TabIndex = 90;
            this.lb20.Text = resources.GetString("lb20.Text");
            this.lb20.EnabledChanged += new System.EventHandler(this.lb20_EnabledChanged);
            // 
            // cb20Ne
            // 
            this.cb20Ne.AutoSize = true;
            this.cb20Ne.Location = new System.Drawing.Point(216, 268);
            this.cb20Ne.Name = "cb20Ne";
            this.cb20Ne.Size = new System.Drawing.Size(40, 17);
            this.cb20Ne.TabIndex = 92;
            this.cb20Ne.Text = "Ne";
            this.cb20Ne.UseVisualStyleBackColor = true;
            this.cb20Ne.CheckedChanged += new System.EventHandler(this.cb20Ne_CheckedChanged);
            // 
            // cb20Da
            // 
            this.cb20Da.AutoSize = true;
            this.cb20Da.Location = new System.Drawing.Point(130, 268);
            this.cb20Da.Name = "cb20Da";
            this.cb20Da.Size = new System.Drawing.Size(40, 17);
            this.cb20Da.TabIndex = 91;
            this.cb20Da.Text = "Da";
            this.cb20Da.UseVisualStyleBackColor = true;
            this.cb20Da.CheckedChanged += new System.EventHandler(this.cb20Da_CheckedChanged);
            // 
            // lb21
            // 
            this.lb21.AutoSize = true;
            this.lb21.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb21.Location = new System.Drawing.Point(12, 315);
            this.lb21.Name = "lb21";
            this.lb21.Size = new System.Drawing.Size(320, 45);
            this.lb21.TabIndex = 93;
            this.lb21.Text = "21. DA LI JE LICE TOKOM ČETIRI SEDMICE KOJE SU\r\n      PRETHODILE POPISU AKTIVNO T" +
    "RAŽILO POSAO \r\n      ILI POKUŠAVALO DA ZAPOČNE SAMOSTALNI POSAO";
            this.lb21.EnabledChanged += new System.EventHandler(this.lb21_EnabledChanged);
            // 
            // cb21Ne
            // 
            this.cb21Ne.AutoSize = true;
            this.cb21Ne.Location = new System.Drawing.Point(216, 373);
            this.cb21Ne.Name = "cb21Ne";
            this.cb21Ne.Size = new System.Drawing.Size(40, 17);
            this.cb21Ne.TabIndex = 95;
            this.cb21Ne.Text = "Ne";
            this.cb21Ne.UseVisualStyleBackColor = true;
            this.cb21Ne.CheckedChanged += new System.EventHandler(this.cb21Ne_CheckedChanged);
            // 
            // cb21Da
            // 
            this.cb21Da.AutoSize = true;
            this.cb21Da.Location = new System.Drawing.Point(130, 373);
            this.cb21Da.Name = "cb21Da";
            this.cb21Da.Size = new System.Drawing.Size(40, 17);
            this.cb21Da.TabIndex = 94;
            this.cb21Da.Text = "Da";
            this.cb21Da.UseVisualStyleBackColor = true;
            this.cb21Da.CheckedChanged += new System.EventHandler(this.cb21Da_CheckedChanged);
            // 
            // lb22
            // 
            this.lb22.AutoSize = true;
            this.lb22.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb22.Location = new System.Drawing.Point(12, 429);
            this.lb22.Name = "lb22";
            this.lb22.Size = new System.Drawing.Size(323, 30);
            this.lb22.TabIndex = 96;
            this.lb22.Text = "22. DA LI BI LICE MOGLO DA POČNE DA RADI U NAREDNE\r\n      DVE SEDMICE AKO BI MU B" +
    "IO PONUĐEN POSAO";
            this.lb22.EnabledChanged += new System.EventHandler(this.lb22_EnabledChanged);
            // 
            // cb22Ne
            // 
            this.cb22Ne.AutoSize = true;
            this.cb22Ne.Location = new System.Drawing.Point(216, 472);
            this.cb22Ne.Name = "cb22Ne";
            this.cb22Ne.Size = new System.Drawing.Size(40, 17);
            this.cb22Ne.TabIndex = 98;
            this.cb22Ne.Text = "Ne";
            this.cb22Ne.UseVisualStyleBackColor = true;
            this.cb22Ne.CheckedChanged += new System.EventHandler(this.cb22Ne_CheckedChanged);
            // 
            // cb22Da
            // 
            this.cb22Da.AutoSize = true;
            this.cb22Da.Location = new System.Drawing.Point(130, 472);
            this.cb22Da.Name = "cb22Da";
            this.cb22Da.Size = new System.Drawing.Size(40, 17);
            this.cb22Da.TabIndex = 97;
            this.cb22Da.Text = "Da";
            this.cb22Da.UseVisualStyleBackColor = true;
            this.cb22Da.CheckedChanged += new System.EventHandler(this.cb22Da_CheckedChanged);
            // 
            // lb23
            // 
            this.lb23.AutoSize = true;
            this.lb23.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb23.Location = new System.Drawing.Point(12, 525);
            this.lb23.Name = "lb23";
            this.lb23.Size = new System.Drawing.Size(328, 15);
            this.lb23.TabIndex = 99;
            this.lb23.Text = "23. KOJOJ GRUPI EKONOMSKI NEAKTIVNO LICE PRIPADA";
            this.lb23.EnabledChanged += new System.EventHandler(this.lb23_EnabledChanged);
            // 
            // clb23
            // 
            this.clb23.BackColor = System.Drawing.SystemColors.Control;
            this.clb23.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clb23.CheckOnClick = true;
            this.clb23.FormattingEnabled = true;
            this.clb23.Items.AddRange(new object[] {
            "Učenici/studenti",
            "Penzioneri",
            "Lica sa prihodima od imovine ili investicija",
            "Lica kioja se bave proizvodnjoim dobara za potrebe svog domaćinstva",
            "Lica koja obavljaju neplaćene kućne poslove u svom domaćinstvu",
            "Ostala lica"});
            this.clb23.Location = new System.Drawing.Point(15, 543);
            this.clb23.Name = "clb23";
            this.clb23.Size = new System.Drawing.Size(356, 90);
            this.clb23.TabIndex = 100;
            this.clb23.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clb23_ItemCheck);
            // 
            // lb24
            // 
            this.lb24.AutoSize = true;
            this.lb24.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb24.Location = new System.Drawing.Point(12, 673);
            this.lb24.Name = "lb24";
            this.lb24.Size = new System.Drawing.Size(93, 15);
            this.lb24.TabIndex = 101;
            this.lb24.Text = "24. ZANIMANJE";
            this.lb24.EnabledChanged += new System.EventHandler(this.lb24_EnabledChanged);
            // 
            // txt24
            // 
            this.txt24.Location = new System.Drawing.Point(29, 703);
            this.txt24.Name = "txt24";
            this.txt24.Size = new System.Drawing.Size(273, 20);
            this.txt24.TabIndex = 102;
            this.txt24.TextChanged += new System.EventHandler(this.txt24_TextChanged);
            // 
            // lb24opis
            // 
            this.lb24opis.AutoSize = true;
            this.lb24opis.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb24opis.Location = new System.Drawing.Point(27, 688);
            this.lb24opis.Name = "lb24opis";
            this.lb24opis.Size = new System.Drawing.Size(127, 12);
            this.lb24opis.TabIndex = 103;
            this.lb24opis.Text = "(glavni posao koji lice obavlja)";
            // 
            // lb25
            // 
            this.lb25.AutoSize = true;
            this.lb25.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb25.Location = new System.Drawing.Point(466, 73);
            this.lb25.Name = "lb25";
            this.lb25.Size = new System.Drawing.Size(240, 15);
            this.lb25.TabIndex = 105;
            this.lb25.Text = "25. POLOŽAJ/STATUS ZAPOSLENOG LICA";
            this.lb25.EnabledChanged += new System.EventHandler(this.lb25_EnabledChanged);
            // 
            // clb25
            // 
            this.clb25.BackColor = System.Drawing.SystemColors.Control;
            this.clb25.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clb25.CheckOnClick = true;
            this.clb25.FormattingEnabled = true;
            this.clb25.Items.AddRange(new object[] {
            "Zaposleno lice kod poslodavca",
            "Poslodavac (zapošljava najmanje jedno lice)",
            "Samostalno obavlja delatnost (ne zapošljava druge)",
            "Individualni poljoprivrednik",
            "Pomažući član u porodičnom poslu koji donosi prihod",
            "Radi na osnovu ugovora o delu, autorskog ugovora i sl.",
            "Ostalo"});
            this.clb25.Location = new System.Drawing.Point(469, 91);
            this.clb25.Name = "clb25";
            this.clb25.Size = new System.Drawing.Size(298, 105);
            this.clb25.TabIndex = 106;
            this.clb25.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clb25_ItemCheck);
            // 
            // tv26
            // 
            this.tv26.BackColor = System.Drawing.SystemColors.Control;
            this.tv26.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tv26.CheckBoxes = true;
            this.tv26.HideSelection = false;
            this.tv26.Location = new System.Drawing.Point(469, 226);
            this.tv26.Name = "tv26";
            treeNode12.Name = "grana1_1";
            treeNode12.Text = "na kućnoj adresi je registrovan poslovni subjekat(STR,SYR, preduzeće i sl.)";
            treeNode13.Name = "grana1_2";
            treeNode13.Text = "na kućnoj adresi nije registrovan poslovni subjekat";
            treeNode14.Name = "grana1_3";
            treeNode14.Text = "radi od kuće za poslovni subjekat koji je registrovan na drugoj adresi u Republic" +
    "i Srbiji";
            treeNode15.Name = "grana1_4";
            treeNode15.Text = "radi od kuće za stranog poslodavca (registrovan u inostranstvu)";
            treeNode16.Name = "grana1";
            treeNode16.Text = "Na adresi na kojoj se popisuje";
            treeNode17.Name = "grana2";
            treeNode17.Text = "Na drugoj adresi u Republici Srbiji (u preduzeću, radnji, ustanovi)";
            treeNode18.Name = "grana3_1";
            treeNode18.Text = "u mestu popisa";
            treeNode19.Name = "grana3_2";
            treeNode19.Text = "u drugom mestu u Republici Srbiji";
            treeNode20.Name = "grana3";
            treeNode20.Text = "Na poljoprivrednom imanju";
            treeNode21.Name = "grana4";
            treeNode21.Text = "U inostranstvu";
            treeNode22.Name = "grana5";
            treeNode22.Text = "Bez stalnog mesta rada";
            this.tv26.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode17,
            treeNode20,
            treeNode21,
            treeNode22});
            this.tv26.ShowLines = false;
            this.tv26.ShowPlusMinus = false;
            this.tv26.ShowRootLines = false;
            this.tv26.Size = new System.Drawing.Size(460, 185);
            this.tv26.TabIndex = 107;
            this.tv26.BeforeCheck += new System.Windows.Forms.TreeViewCancelEventHandler(this.tv26_BeforeCheck);
            this.tv26.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tv26_AfterCheck);
            // 
            // lb26
            // 
            this.lb26.AutoSize = true;
            this.lb26.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb26.Location = new System.Drawing.Point(466, 208);
            this.lb26.Name = "lb26";
            this.lb26.Size = new System.Drawing.Size(108, 15);
            this.lb26.TabIndex = 108;
            this.lb26.Text = "26. GDE LICE RADI";
            // 
            // lb26drzava
            // 
            this.lb26drzava.AutoSize = true;
            this.lb26drzava.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb26drzava.Location = new System.Drawing.Point(750, 399);
            this.lb26drzava.Name = "lb26drzava";
            this.lb26drzava.Size = new System.Drawing.Size(40, 12);
            this.lb26drzava.TabIndex = 110;
            this.lb26drzava.Text = "(država)";
            // 
            // cmb26Drzava
            // 
            this.cmb26Drzava.FormattingEnabled = true;
            this.cmb26Drzava.Location = new System.Drawing.Point(710, 375);
            this.cmb26Drzava.Name = "cmb26Drzava";
            this.cmb26Drzava.Size = new System.Drawing.Size(121, 21);
            this.cmb26Drzava.Sorted = true;
            this.cmb26Drzava.TabIndex = 109;
            this.cmb26Drzava.EnabledChanged += new System.EventHandler(this.cmb26Drzava_EnabledChanged);
            // 
            // txt27
            // 
            this.txt27.Location = new System.Drawing.Point(485, 454);
            this.txt27.Name = "txt27";
            this.txt27.Size = new System.Drawing.Size(346, 20);
            this.txt27.TabIndex = 112;
            // 
            // lb27
            // 
            this.lb27.AutoSize = true;
            this.lb27.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb27.Location = new System.Drawing.Point(466, 421);
            this.lb27.Name = "lb27";
            this.lb27.Size = new System.Drawing.Size(228, 30);
            this.lb27.TabIndex = 111;
            this.lb27.Text = "27. PUN NAZIV POSLOVNOG SUBJEKTA\r\n      (PREDUZEĆA, RADNJE, USTANOVE)";
            // 
            // lb28
            // 
            this.lb28.AutoSize = true;
            this.lb28.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb28.Location = new System.Drawing.Point(466, 491);
            this.lb28.Name = "lb28";
            this.lb28.Size = new System.Drawing.Size(302, 15);
            this.lb28.TabIndex = 113;
            this.lb28.Text = "28. LOKACIJA MESTA RADA/POSLOVNOG SUBJEKTA";
            // 
            // lb28naselje
            // 
            this.lb28naselje.AutoSize = true;
            this.lb28naselje.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb28naselje.Location = new System.Drawing.Point(616, 572);
            this.lb28naselje.Name = "lb28naselje";
            this.lb28naselje.Size = new System.Drawing.Size(78, 12);
            this.lb28naselje.TabIndex = 117;
            this.lb28naselje.Text = "(naseljeno mesto)";
            // 
            // cmb28Naselje
            // 
            this.cmb28Naselje.FormattingEnabled = true;
            this.cmb28Naselje.Location = new System.Drawing.Point(485, 548);
            this.cmb28Naselje.Name = "cmb28Naselje";
            this.cmb28Naselje.Size = new System.Drawing.Size(346, 21);
            this.cmb28Naselje.Sorted = true;
            this.cmb28Naselje.TabIndex = 116;
            this.cmb28Naselje.EnabledChanged += new System.EventHandler(this.cmb28Naselje_EnabledChanged);
            // 
            // lb28opstina
            // 
            this.lb28opstina.AutoSize = true;
            this.lb28opstina.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb28opstina.Location = new System.Drawing.Point(634, 533);
            this.lb28opstina.Name = "lb28opstina";
            this.lb28opstina.Size = new System.Drawing.Size(41, 12);
            this.lb28opstina.TabIndex = 115;
            this.lb28opstina.Text = "(opština)";
            // 
            // cmb28Opstina
            // 
            this.cmb28Opstina.FormattingEnabled = true;
            this.cmb28Opstina.Location = new System.Drawing.Point(485, 509);
            this.cmb28Opstina.Name = "cmb28Opstina";
            this.cmb28Opstina.Size = new System.Drawing.Size(346, 21);
            this.cmb28Opstina.Sorted = true;
            this.cmb28Opstina.TabIndex = 114;
            this.cmb28Opstina.SelectedIndexChanged += new System.EventHandler(this.cmb28Opstina_SelectedIndexChanged);
            this.cmb28Opstina.EnabledChanged += new System.EventHandler(this.cmb28Opstina_EnabledChanged);
            // 
            // lb28Broj
            // 
            this.lb28Broj.AutoSize = true;
            this.lb28Broj.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb28Broj.Location = new System.Drawing.Point(768, 628);
            this.lb28Broj.Name = "lb28Broj";
            this.lb28Broj.Size = new System.Drawing.Size(50, 12);
            this.lb28Broj.TabIndex = 122;
            this.lb28Broj.Text = "(kućni broj)";
            // 
            // txt28Broj
            // 
            this.txt28Broj.Location = new System.Drawing.Point(757, 605);
            this.txt28Broj.Name = "txt28Broj";
            this.txt28Broj.Size = new System.Drawing.Size(74, 20);
            this.txt28Broj.TabIndex = 121;
            // 
            // lb28ulica
            // 
            this.lb28ulica.AutoSize = true;
            this.lb28ulica.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb28ulica.Location = new System.Drawing.Point(603, 628);
            this.lb28ulica.Name = "lb28ulica";
            this.lb28ulica.Size = new System.Drawing.Size(30, 12);
            this.lb28ulica.TabIndex = 120;
            this.lb28ulica.Text = "(ulica)";
            // 
            // lb28Adresa
            // 
            this.lb28Adresa.AutoSize = true;
            this.lb28Adresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb28Adresa.Location = new System.Drawing.Point(483, 590);
            this.lb28Adresa.Name = "lb28Adresa";
            this.lb28Adresa.Size = new System.Drawing.Size(35, 12);
            this.lb28Adresa.TabIndex = 119;
            this.lb28Adresa.Text = "Adresa";
            // 
            // txt28Ulica
            // 
            this.txt28Ulica.Location = new System.Drawing.Point(485, 605);
            this.txt28Ulica.Name = "txt28Ulica";
            this.txt28Ulica.Size = new System.Drawing.Size(266, 20);
            this.txt28Ulica.TabIndex = 118;
            // 
            // txt29
            // 
            this.txt29.Location = new System.Drawing.Point(485, 668);
            this.txt29.Name = "txt29";
            this.txt29.Size = new System.Drawing.Size(346, 20);
            this.txt29.TabIndex = 124;
            // 
            // lb29
            // 
            this.lb29.AutoSize = true;
            this.lb29.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb29.Location = new System.Drawing.Point(466, 650);
            this.lb29.Name = "lb29";
            this.lb29.Size = new System.Drawing.Size(95, 15);
            this.lb29.TabIndex = 123;
            this.lb29.Text = "29. DELATNOST";
            // 
            // lb30
            // 
            this.lb30.AutoSize = true;
            this.lb30.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb30.Location = new System.Drawing.Point(466, 708);
            this.lb30.Name = "lb30";
            this.lb30.Size = new System.Drawing.Size(279, 30);
            this.lb30.TabIndex = 125;
            this.lb30.Text = "30. KOLIKO ČESTO LICE PUTUJE SA ADRESE NA \r\n      KOJOJ SE POPISUJE DO POSLA I NA" +
    "ZAD";
            // 
            // cb30Svakidan
            // 
            this.cb30Svakidan.AutoSize = true;
            this.cb30Svakidan.Location = new System.Drawing.Point(485, 741);
            this.cb30Svakidan.Name = "cb30Svakidan";
            this.cb30Svakidan.Size = new System.Drawing.Size(196, 17);
            this.cb30Svakidan.TabIndex = 126;
            this.cb30Svakidan.Text = "Svakodnevno ili više puta sedmično";
            this.cb30Svakidan.UseVisualStyleBackColor = true;
            // 
            // cb30Jednom
            // 
            this.cb30Jednom.AutoSize = true;
            this.cb30Jednom.Location = new System.Drawing.Point(485, 764);
            this.cb30Jednom.Name = "cb30Jednom";
            this.cb30Jednom.Size = new System.Drawing.Size(145, 17);
            this.cb30Jednom.TabIndex = 127;
            this.cb30Jednom.Text = "Jednom sedmično ili ređe";
            this.cb30Jednom.UseVisualStyleBackColor = true;
            // 
            // btnDalje
            // 
            this.btnDalje.Location = new System.Drawing.Point(833, 760);
            this.btnDalje.Name = "btnDalje";
            this.btnDalje.Size = new System.Drawing.Size(75, 23);
            this.btnDalje.TabIndex = 128;
            this.btnDalje.Text = "Dalje";
            this.btnDalje.UseVisualStyleBackColor = true;
            this.btnDalje.Click += new System.EventHandler(this.btnDalje_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.svaPitanjaToolStripMenuItem,
            this.početnaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(920, 24);
            this.menuStrip1.TabIndex = 129;
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
            // frmEkonomskaAktivnost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 795);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnDalje);
            this.Controls.Add(this.cb30Jednom);
            this.Controls.Add(this.cb30Svakidan);
            this.Controls.Add(this.lb30);
            this.Controls.Add(this.txt29);
            this.Controls.Add(this.lb29);
            this.Controls.Add(this.lb28Broj);
            this.Controls.Add(this.txt28Broj);
            this.Controls.Add(this.lb28ulica);
            this.Controls.Add(this.lb28Adresa);
            this.Controls.Add(this.txt28Ulica);
            this.Controls.Add(this.lb28naselje);
            this.Controls.Add(this.cmb28Naselje);
            this.Controls.Add(this.lb28opstina);
            this.Controls.Add(this.cmb28Opstina);
            this.Controls.Add(this.lb28);
            this.Controls.Add(this.txt27);
            this.Controls.Add(this.lb27);
            this.Controls.Add(this.lb26drzava);
            this.Controls.Add(this.cmb26Drzava);
            this.Controls.Add(this.lb26);
            this.Controls.Add(this.tv26);
            this.Controls.Add(this.clb25);
            this.Controls.Add(this.lb25);
            this.Controls.Add(this.lb24opis);
            this.Controls.Add(this.txt24);
            this.Controls.Add(this.lb24);
            this.Controls.Add(this.clb23);
            this.Controls.Add(this.lb23);
            this.Controls.Add(this.cb22Ne);
            this.Controls.Add(this.cb22Da);
            this.Controls.Add(this.lb22);
            this.Controls.Add(this.cb21Ne);
            this.Controls.Add(this.cb21Da);
            this.Controls.Add(this.lb21);
            this.Controls.Add(this.cb20Ne);
            this.Controls.Add(this.cb20Da);
            this.Controls.Add(this.lb20);
            this.Controls.Add(this.cb19Ne);
            this.Controls.Add(this.cb19Da);
            this.Controls.Add(this.lb19naslov);
            this.Controls.Add(this.lb19);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmEkonomskaAktivnost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ekonomska aktivnost";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb19;
        private System.Windows.Forms.Label lb19naslov;
        private System.Windows.Forms.CheckBox cb19Da;
        private System.Windows.Forms.CheckBox cb19Ne;
        private System.Windows.Forms.Label lb20;
        private System.Windows.Forms.CheckBox cb20Ne;
        private System.Windows.Forms.CheckBox cb20Da;
        private System.Windows.Forms.Label lb21;
        private System.Windows.Forms.CheckBox cb21Ne;
        private System.Windows.Forms.CheckBox cb21Da;
        private System.Windows.Forms.Label lb22;
        private System.Windows.Forms.CheckBox cb22Ne;
        private System.Windows.Forms.CheckBox cb22Da;
        private System.Windows.Forms.Label lb23;
        private System.Windows.Forms.CheckedListBox clb23;
        private System.Windows.Forms.Label lb24;
        private System.Windows.Forms.TextBox txt24;
        private System.Windows.Forms.Label lb24opis;
        private System.Windows.Forms.Label lb25;
        private System.Windows.Forms.CheckedListBox clb25;
        private System.Windows.Forms.TreeView tv26;
        private System.Windows.Forms.Label lb26;
        private System.Windows.Forms.Label lb26drzava;
        private System.Windows.Forms.ComboBox cmb26Drzava;
        private System.Windows.Forms.TextBox txt27;
        private System.Windows.Forms.Label lb27;
        private System.Windows.Forms.Label lb28;
        private System.Windows.Forms.Label lb28naselje;
        private System.Windows.Forms.ComboBox cmb28Naselje;
        private System.Windows.Forms.Label lb28opstina;
        private System.Windows.Forms.ComboBox cmb28Opstina;
        private System.Windows.Forms.Label lb28Broj;
        private System.Windows.Forms.TextBox txt28Broj;
        private System.Windows.Forms.Label lb28ulica;
        private System.Windows.Forms.Label lb28Adresa;
        private System.Windows.Forms.TextBox txt28Ulica;
        private System.Windows.Forms.TextBox txt29;
        private System.Windows.Forms.Label lb29;
        private System.Windows.Forms.Label lb30;
        private System.Windows.Forms.CheckBox cb30Svakidan;
        private System.Windows.Forms.CheckBox cb30Jednom;
        private System.Windows.Forms.Button btnDalje;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem svaPitanjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem početnaToolStripMenuItem;
    }
}
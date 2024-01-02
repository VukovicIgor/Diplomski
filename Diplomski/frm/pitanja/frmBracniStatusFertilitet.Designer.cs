namespace Diplomski.frm.pitanja
{
    partial class frmBracniStatusFertilitet
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
            this.lb5 = new System.Windows.Forms.Label();
            this.clb9 = new System.Windows.Forms.CheckedListBox();
            this.lb9Pitanje = new System.Windows.Forms.Label();
            this.lb10 = new System.Windows.Forms.Label();
            this.cb10Da = new System.Windows.Forms.CheckBox();
            this.cb10Ne = new System.Windows.Forms.CheckBox();
            this.lb11pod = new System.Windows.Forms.Label();
            this.lb11 = new System.Windows.Forms.Label();
            this.dtp11_1prvo = new System.Windows.Forms.DateTimePicker();
            this.dtp11_1drugo = new System.Windows.Forms.DateTimePicker();
            this.dtp11_1trece = new System.Windows.Forms.DateTimePicker();
            this.lb11_1prvo = new System.Windows.Forms.Label();
            this.lb11_1drugo = new System.Windows.Forms.Label();
            this.lb11_1trece = new System.Windows.Forms.Label();
            this.lb11_1 = new System.Windows.Forms.Label();
            this.lb11_1vise = new System.Windows.Forms.Label();
            this.dtp11_1vise = new System.Windows.Forms.DateTimePicker();
            this.btnDalje = new System.Windows.Forms.Button();
            this.cmb11 = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.svaPitanjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.početnaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb5
            // 
            this.lb5.AutoSize = true;
            this.lb5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lb5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb5.Location = new System.Drawing.Point(56, 9);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(208, 12);
            this.lb5.TabIndex = 20;
            this.lb5.Text = "Pitanja se postavljaju za lice staro 12 i više godina";
            // 
            // clb9
            // 
            this.clb9.BackColor = System.Drawing.SystemColors.Control;
            this.clb9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clb9.CheckOnClick = true;
            this.clb9.FormattingEnabled = true;
            this.clb9.Items.AddRange(new object[] {
            "Neoženjen/neudata",
            "Oženjen/udata (žive zajedno) → pitanje 11",
            "Oženjen/udata (ne žive zajedno) → pitanje 11",
            "Udovac/udovica",
            "Razveden/razvedena"});
            this.clb9.Location = new System.Drawing.Point(35, 51);
            this.clb9.Name = "clb9";
            this.clb9.Size = new System.Drawing.Size(239, 75);
            this.clb9.TabIndex = 85;
            this.clb9.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clb9_ItemCheck);
            // 
            // lb9Pitanje
            // 
            this.lb9Pitanje.AutoSize = true;
            this.lb9Pitanje.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb9Pitanje.Location = new System.Drawing.Point(12, 32);
            this.lb9Pitanje.Name = "lb9Pitanje";
            this.lb9Pitanje.Size = new System.Drawing.Size(126, 16);
            this.lb9Pitanje.TabIndex = 86;
            this.lb9Pitanje.Text = "9. BRAČNI STATUS";
            // 
            // lb10
            // 
            this.lb10.AutoSize = true;
            this.lb10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb10.Location = new System.Drawing.Point(12, 151);
            this.lb10.Name = "lb10";
            this.lb10.Size = new System.Drawing.Size(326, 32);
            this.lb10.TabIndex = 87;
            this.lb10.Text = "10. DA LI LICE ŽIVI SA PARTNEROM/PARTNERKOM\r\n      U VANBRAČNOJ ZAJEDNICI\r\n";
            // 
            // cb10Da
            // 
            this.cb10Da.AutoSize = true;
            this.cb10Da.Location = new System.Drawing.Point(89, 195);
            this.cb10Da.Name = "cb10Da";
            this.cb10Da.Size = new System.Drawing.Size(40, 17);
            this.cb10Da.TabIndex = 88;
            this.cb10Da.Text = "Da";
            this.cb10Da.UseVisualStyleBackColor = true;
            this.cb10Da.CheckedChanged += new System.EventHandler(this.cb10Da_CheckedChanged);
            // 
            // cb10Ne
            // 
            this.cb10Ne.AutoSize = true;
            this.cb10Ne.Location = new System.Drawing.Point(186, 195);
            this.cb10Ne.Name = "cb10Ne";
            this.cb10Ne.Size = new System.Drawing.Size(40, 17);
            this.cb10Ne.TabIndex = 89;
            this.cb10Ne.Text = "Ne";
            this.cb10Ne.UseVisualStyleBackColor = true;
            this.cb10Ne.CheckedChanged += new System.EventHandler(this.cb10Ne_CheckedChanged);
            // 
            // lb11pod
            // 
            this.lb11pod.AutoSize = true;
            this.lb11pod.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb11pod.Location = new System.Drawing.Point(33, 255);
            this.lb11pod.Name = "lb11pod";
            this.lb11pod.Size = new System.Drawing.Size(158, 12);
            this.lb11pod.TabIndex = 91;
            this.lb11pod.Text = "(uključujući i decu koja više nisu živa)";
            // 
            // lb11
            // 
            this.lb11.AutoSize = true;
            this.lb11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb11.Location = new System.Drawing.Point(12, 239);
            this.lb11.Name = "lb11";
            this.lb11.Size = new System.Drawing.Size(189, 16);
            this.lb11.TabIndex = 90;
            this.lb11.Text = "11. BROJ ŽIVOROĐENE DECE";
            // 
            // dtp11_1prvo
            // 
            this.dtp11_1prvo.Location = new System.Drawing.Point(38, 317);
            this.dtp11_1prvo.Name = "dtp11_1prvo";
            this.dtp11_1prvo.Size = new System.Drawing.Size(61, 20);
            this.dtp11_1prvo.TabIndex = 93;
            this.dtp11_1prvo.EnabledChanged += new System.EventHandler(this.dtp11_1prvo_EnabledChanged);
            // 
            // dtp11_1drugo
            // 
            this.dtp11_1drugo.Location = new System.Drawing.Point(128, 317);
            this.dtp11_1drugo.Name = "dtp11_1drugo";
            this.dtp11_1drugo.Size = new System.Drawing.Size(66, 20);
            this.dtp11_1drugo.TabIndex = 94;
            this.dtp11_1drugo.EnabledChanged += new System.EventHandler(this.dtp11_1drugo_EnabledChanged);
            // 
            // dtp11_1trece
            // 
            this.dtp11_1trece.Location = new System.Drawing.Point(221, 317);
            this.dtp11_1trece.Name = "dtp11_1trece";
            this.dtp11_1trece.Size = new System.Drawing.Size(66, 20);
            this.dtp11_1trece.TabIndex = 95;
            this.dtp11_1trece.EnabledChanged += new System.EventHandler(this.dtp11_1trece_EnabledChanged);
            // 
            // lb11_1prvo
            // 
            this.lb11_1prvo.AutoSize = true;
            this.lb11_1prvo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb11_1prvo.Location = new System.Drawing.Point(36, 340);
            this.lb11_1prvo.Name = "lb11_1prvo";
            this.lb11_1prvo.Size = new System.Drawing.Size(63, 12);
            this.lb11_1prvo.TabIndex = 96;
            this.lb11_1prvo.Text = "(prvog deteta)";
            // 
            // lb11_1drugo
            // 
            this.lb11_1drugo.AutoSize = true;
            this.lb11_1drugo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb11_1drugo.Location = new System.Drawing.Point(126, 340);
            this.lb11_1drugo.Name = "lb11_1drugo";
            this.lb11_1drugo.Size = new System.Drawing.Size(67, 12);
            this.lb11_1drugo.TabIndex = 98;
            this.lb11_1drugo.Text = "(drugog deteta)";
            // 
            // lb11_1trece
            // 
            this.lb11_1trece.AutoSize = true;
            this.lb11_1trece.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb11_1trece.Location = new System.Drawing.Point(219, 340);
            this.lb11_1trece.Name = "lb11_1trece";
            this.lb11_1trece.Size = new System.Drawing.Size(65, 12);
            this.lb11_1trece.TabIndex = 99;
            this.lb11_1trece.Text = "(trećeg deteta)";
            // 
            // lb11_1
            // 
            this.lb11_1.AutoSize = true;
            this.lb11_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb11_1.Location = new System.Drawing.Point(32, 292);
            this.lb11_1.Name = "lb11_1";
            this.lb11_1.Size = new System.Drawing.Size(177, 15);
            this.lb11_1.TabIndex = 100;
            this.lb11_1.Text = "11.1 GODINE ROĐENJA DECE";
            // 
            // lb11_1vise
            // 
            this.lb11_1vise.AutoSize = true;
            this.lb11_1vise.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb11_1vise.Location = new System.Drawing.Point(35, 376);
            this.lb11_1vise.Name = "lb11_1vise";
            this.lb11_1vise.Size = new System.Drawing.Size(191, 30);
            this.lb11_1vise.TabIndex = 101;
            this.lb11_1vise.Text = "Za više od tri živorođena deteta\r\nupisati godinu rođenja najmlađeg";
            // 
            // dtp11_1vise
            // 
            this.dtp11_1vise.Location = new System.Drawing.Point(232, 386);
            this.dtp11_1vise.Name = "dtp11_1vise";
            this.dtp11_1vise.Size = new System.Drawing.Size(61, 20);
            this.dtp11_1vise.TabIndex = 102;
            this.dtp11_1vise.EnabledChanged += new System.EventHandler(this.dtp11_1vise_EnabledChanged);
            // 
            // btnDalje
            // 
            this.btnDalje.Location = new System.Drawing.Point(260, 435);
            this.btnDalje.Name = "btnDalje";
            this.btnDalje.Size = new System.Drawing.Size(75, 23);
            this.btnDalje.TabIndex = 103;
            this.btnDalje.Text = "Dalje";
            this.btnDalje.UseVisualStyleBackColor = true;
            this.btnDalje.Click += new System.EventHandler(this.btnDalje_Click);
            // 
            // cmb11
            // 
            this.cmb11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb11.FormattingEnabled = true;
            this.cmb11.ItemHeight = 13;
            this.cmb11.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.cmb11.Location = new System.Drawing.Point(221, 246);
            this.cmb11.Name = "cmb11";
            this.cmb11.Size = new System.Drawing.Size(43, 21);
            this.cmb11.TabIndex = 105;
            this.cmb11.SelectedIndexChanged += new System.EventHandler(this.cmb11_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.svaPitanjaToolStripMenuItem,
            this.početnaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(347, 24);
            this.menuStrip1.TabIndex = 106;
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
            // frmBracniStatusFertilitet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 470);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.cmb11);
            this.Controls.Add(this.btnDalje);
            this.Controls.Add(this.dtp11_1vise);
            this.Controls.Add(this.lb11_1vise);
            this.Controls.Add(this.lb11_1);
            this.Controls.Add(this.lb11_1trece);
            this.Controls.Add(this.lb11_1drugo);
            this.Controls.Add(this.lb11_1prvo);
            this.Controls.Add(this.dtp11_1trece);
            this.Controls.Add(this.dtp11_1drugo);
            this.Controls.Add(this.dtp11_1prvo);
            this.Controls.Add(this.lb11pod);
            this.Controls.Add(this.lb11);
            this.Controls.Add(this.cb10Ne);
            this.Controls.Add(this.cb10Da);
            this.Controls.Add(this.lb10);
            this.Controls.Add(this.lb9Pitanje);
            this.Controls.Add(this.clb9);
            this.Controls.Add(this.lb5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmBracniStatusFertilitet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bracni status i fertilitet";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.CheckedListBox clb9;
        private System.Windows.Forms.Label lb9Pitanje;
        private System.Windows.Forms.Label lb10;
        private System.Windows.Forms.CheckBox cb10Da;
        private System.Windows.Forms.CheckBox cb10Ne;
        private System.Windows.Forms.Label lb11pod;
        private System.Windows.Forms.Label lb11;
        private System.Windows.Forms.DateTimePicker dtp11_1prvo;
        private System.Windows.Forms.DateTimePicker dtp11_1drugo;
        private System.Windows.Forms.DateTimePicker dtp11_1trece;
        private System.Windows.Forms.Label lb11_1prvo;
        private System.Windows.Forms.Label lb11_1drugo;
        private System.Windows.Forms.Label lb11_1trece;
        private System.Windows.Forms.Label lb11_1;
        private System.Windows.Forms.Label lb11_1vise;
        private System.Windows.Forms.DateTimePicker dtp11_1vise;
        private System.Windows.Forms.Button btnDalje;
        private System.Windows.Forms.ComboBox cmb11;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem svaPitanjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem početnaToolStripMenuItem;
    }
}
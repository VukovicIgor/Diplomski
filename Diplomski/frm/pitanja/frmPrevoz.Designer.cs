namespace Diplomski.frm.pitanja
{
    partial class frmPrevoz
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
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("lice je vozač");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("lice je saputnik");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("Automobilom ", new System.Windows.Forms.TreeNode[] {
            treeNode33,
            treeNode34});
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("autobusom");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("tramvajem");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("trolejbusom");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("vozom");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("Javnim gradskim prevozom ", new System.Windows.Forms.TreeNode[] {
            treeNode36,
            treeNode37,
            treeNode38,
            treeNode39});
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("Taksijem");
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("Međugradskim prevozom");
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("Međugradskim vozom");
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("Ogranizovanim prevozom (autobusom, kombijem itd.)");
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("Motociklom/mopedom");
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("Biciklom");
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("Pešice");
            System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("Ostalo (traktor, kamion, skela, trotinet itd.)");
            this.lb26 = new System.Windows.Forms.Label();
            this.tv31 = new System.Windows.Forms.TreeView();
            this.btnDalje = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.svaPitanjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.početnaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb26
            // 
            this.lb26.AutoSize = true;
            this.lb26.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb26.Location = new System.Drawing.Point(12, 51);
            this.lb26.Name = "lb26";
            this.lb26.Size = new System.Drawing.Size(240, 15);
            this.lb26.TabIndex = 110;
            this.lb26.Text = "31. NAČIN PUTOVANJA DO POSLA/ŠKOLE";
            // 
            // tv31
            // 
            this.tv31.BackColor = System.Drawing.SystemColors.Control;
            this.tv31.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tv31.CheckBoxes = true;
            this.tv31.HideSelection = false;
            this.tv31.Location = new System.Drawing.Point(15, 69);
            this.tv31.Name = "tv31";
            treeNode33.Name = "grana1_1";
            treeNode33.Text = "lice je vozač";
            treeNode34.Name = "grana1_2";
            treeNode34.Text = "lice je saputnik";
            treeNode35.Name = "grana1";
            treeNode35.Text = "Automobilom ";
            treeNode36.Name = "grana2_1";
            treeNode36.Text = "autobusom";
            treeNode37.Name = "grana2_2";
            treeNode37.Text = "tramvajem";
            treeNode38.Name = "grana2_3";
            treeNode38.Text = "trolejbusom";
            treeNode39.Name = "grana2_4";
            treeNode39.Text = "vozom";
            treeNode40.Name = "grana2";
            treeNode40.Text = "Javnim gradskim prevozom ";
            treeNode41.Name = "grana3";
            treeNode41.Text = "Taksijem";
            treeNode42.Name = "grana4";
            treeNode42.Text = "Međugradskim prevozom";
            treeNode43.Name = "grana5";
            treeNode43.Text = "Međugradskim vozom";
            treeNode44.Name = "grana6";
            treeNode44.Text = "Ogranizovanim prevozom (autobusom, kombijem itd.)";
            treeNode45.Name = "grana7";
            treeNode45.Text = "Motociklom/mopedom";
            treeNode46.Name = "grana8";
            treeNode46.Text = "Biciklom";
            treeNode47.Name = "grana9";
            treeNode47.Text = "Pešice";
            treeNode48.Name = "grana10";
            treeNode48.Text = "Ostalo (traktor, kamion, skela, trotinet itd.)";
            this.tv31.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode35,
            treeNode40,
            treeNode41,
            treeNode42,
            treeNode43,
            treeNode44,
            treeNode45,
            treeNode46,
            treeNode47,
            treeNode48});
            this.tv31.ShowLines = false;
            this.tv31.ShowPlusMinus = false;
            this.tv31.ShowRootLines = false;
            this.tv31.Size = new System.Drawing.Size(292, 281);
            this.tv31.TabIndex = 109;
            this.tv31.BeforeCheck += new System.Windows.Forms.TreeViewCancelEventHandler(this.tv31_BeforeCheck);
            this.tv31.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tv31_AfterCheck);
            // 
            // btnDalje
            // 
            this.btnDalje.Location = new System.Drawing.Point(252, 398);
            this.btnDalje.Name = "btnDalje";
            this.btnDalje.Size = new System.Drawing.Size(75, 23);
            this.btnDalje.TabIndex = 132;
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
            this.menuStrip1.Size = new System.Drawing.Size(339, 24);
            this.menuStrip1.TabIndex = 154;
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
            // frmPrevoz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 433);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnDalje);
            this.Controls.Add(this.lb26);
            this.Controls.Add(this.tv31);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmPrevoz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sredstvo putovanja";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb26;
        private System.Windows.Forms.TreeView tv31;
        private System.Windows.Forms.Button btnDalje;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem svaPitanjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem početnaToolStripMenuItem;
    }
}
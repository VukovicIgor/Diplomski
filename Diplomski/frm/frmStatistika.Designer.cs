namespace Diplomski.frm
{
    partial class frmStatistika
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Stanovništvo prema nacionalnoj pripadnosti i polu");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Stanovništvo prema nacionalnoj pripadnosti");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Stanovništvo prema nacionalnoj pripadnost", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Stanovništvo prema starosti i polu");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Prosečna starost stanovništva prema polu");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Stanovništvo prema okrugu rođenja");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Stanovništvo prema starosti, polu i mestu rođenja", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Stanovništvo prema veroispovesti");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Stanovništvo prema maternjem jeziku");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Stanovništvo prema mestu stanovanja i obrazovanju");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Stanovništvo prema maternjem jeziku, veroispovesti i obrazovanju", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9,
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Stanovništvo", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode7,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Porodice prema tipu");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Porodice", new System.Windows.Forms.TreeNode[] {
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Stanovi prema površini");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Grejanje u nastanjenim stanovima bez centralnog grejanja");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Prosečan broj lica u stanovima");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Stanovi", new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode16,
            treeNode17});
            this.tv1 = new System.Windows.Forms.TreeView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.svaPitanjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.početnaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tv1
            // 
            this.tv1.BackColor = System.Drawing.SystemColors.Control;
            this.tv1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tv1.CausesValidation = false;
            this.tv1.HideSelection = false;
            this.tv1.Location = new System.Drawing.Point(0, 27);
            this.tv1.Name = "tv1";
            treeNode1.Name = "stanovnistvo1_1";
            treeNode1.Text = "Stanovništvo prema nacionalnoj pripadnosti i polu";
            treeNode2.Name = "stanovnistvo1_2";
            treeNode2.Text = "Stanovništvo prema nacionalnoj pripadnosti";
            treeNode3.Name = "stanovnistvo1";
            treeNode3.Text = "Stanovništvo prema nacionalnoj pripadnost";
            treeNode4.Name = "stanovnistvo2_1";
            treeNode4.Text = "Stanovništvo prema starosti i polu";
            treeNode5.Name = "stanovnistvo2_2";
            treeNode5.Text = "Prosečna starost stanovništva prema polu";
            treeNode6.Name = "stanovnistvo2_3";
            treeNode6.Text = "Stanovništvo prema okrugu rođenja";
            treeNode7.Name = "stanovnistvo2";
            treeNode7.Text = "Stanovništvo prema starosti, polu i mestu rođenja";
            treeNode8.Name = "stanovnistvo3_1";
            treeNode8.Text = "Stanovništvo prema veroispovesti";
            treeNode9.Name = "stanovnistvo3_2";
            treeNode9.Text = "Stanovništvo prema maternjem jeziku";
            treeNode10.Name = "stanovnistvo3_3";
            treeNode10.Text = "Stanovništvo prema mestu stanovanja i obrazovanju";
            treeNode11.Name = "stanovnistvo3";
            treeNode11.Text = "Stanovništvo prema maternjem jeziku, veroispovesti i obrazovanju";
            treeNode12.Name = "stanovnistvo";
            treeNode12.Text = "Stanovništvo";
            treeNode13.Name = "porodice_1";
            treeNode13.Text = "Porodice prema tipu";
            treeNode14.Name = "porodice";
            treeNode14.Text = "Porodice";
            treeNode15.Name = "stanovi_1";
            treeNode15.Text = "Stanovi prema površini";
            treeNode16.Name = "stanovi_2";
            treeNode16.Text = "Grejanje u nastanjenim stanovima bez centralnog grejanja";
            treeNode17.Name = "stanovi_3";
            treeNode17.Text = "Prosečan broj lica u stanovima";
            treeNode18.Name = "stanovi";
            treeNode18.Text = "Stanovi";
            this.tv1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode14,
            treeNode18});
            this.tv1.Size = new System.Drawing.Size(443, 291);
            this.tv1.TabIndex = 2;
            this.tv1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tv1_NodeMouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.svaPitanjaToolStripMenuItem,
            this.početnaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(446, 24);
            this.menuStrip1.TabIndex = 156;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
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
            // frmStatistika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 318);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tv1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmStatistika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistika";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TreeView tv1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem svaPitanjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem početnaToolStripMenuItem;
    }
}
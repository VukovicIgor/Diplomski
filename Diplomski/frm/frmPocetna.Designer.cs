namespace Diplomski
{
    partial class frmPocetna
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
            this.btnPopis = new System.Windows.Forms.Button();
            this.btnAdministracija = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.svaPitanjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.početnaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPopis
            // 
            this.btnPopis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPopis.Location = new System.Drawing.Point(241, 27);
            this.btnPopis.Name = "btnPopis";
            this.btnPopis.Size = new System.Drawing.Size(243, 434);
            this.btnPopis.TabIndex = 4;
            this.btnPopis.Text = "Popis";
            this.btnPopis.UseVisualStyleBackColor = true;
            this.btnPopis.Click += new System.EventHandler(this.btnPopis_Click);
            // 
            // btnAdministracija
            // 
            this.btnAdministracija.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdministracija.Location = new System.Drawing.Point(0, 27);
            this.btnAdministracija.Name = "btnAdministracija";
            this.btnAdministracija.Size = new System.Drawing.Size(243, 434);
            this.btnAdministracija.TabIndex = 3;
            this.btnAdministracija.Text = "Administracija";
            this.btnAdministracija.UseVisualStyleBackColor = true;
            this.btnAdministracija.Click += new System.EventHandler(this.btnAdministracija_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.svaPitanjaToolStripMenuItem,
            this.početnaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 157;
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
            this.početnaToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.početnaToolStripMenuItem.Text = "Odjava";
            this.početnaToolStripMenuItem.Click += new System.EventHandler(this.početnaToolStripMenuItem_Click);
            // 
            // frmPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnPopis);
            this.Controls.Add(this.btnAdministracija);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(200, 200);
            this.Name = "frmPocetna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Početna";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPopis;
        private System.Windows.Forms.Button btnAdministracija;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem svaPitanjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem početnaToolStripMenuItem;
    }
}
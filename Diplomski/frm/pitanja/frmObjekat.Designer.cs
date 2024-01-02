namespace Diplomski.frm.pitanja
{
    partial class frmObjekat
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
            this.cmbOpstina = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbNaselje = new System.Windows.Forms.ComboBox();
            this.txtUlica = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBrojObjekta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBrojStana = new System.Windows.Forms.TextBox();
            this.btnDalje = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.svaPitanjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.početnaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbOpstina
            // 
            this.cmbOpstina.FormattingEnabled = true;
            this.cmbOpstina.ItemHeight = 13;
            this.cmbOpstina.Location = new System.Drawing.Point(15, 53);
            this.cmbOpstina.Name = "cmbOpstina";
            this.cmbOpstina.Size = new System.Drawing.Size(271, 21);
            this.cmbOpstina.Sorted = true;
            this.cmbOpstina.TabIndex = 3;
            this.cmbOpstina.SelectedIndexChanged += new System.EventHandler(this.cmbOpstina_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Opština:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Naselje:";
            // 
            // cmbNaselje
            // 
            this.cmbNaselje.FormattingEnabled = true;
            this.cmbNaselje.ItemHeight = 13;
            this.cmbNaselje.Location = new System.Drawing.Point(15, 111);
            this.cmbNaselje.Name = "cmbNaselje";
            this.cmbNaselje.Size = new System.Drawing.Size(271, 21);
            this.cmbNaselje.Sorted = true;
            this.cmbNaselje.TabIndex = 25;
            // 
            // txtUlica
            // 
            this.txtUlica.Location = new System.Drawing.Point(15, 173);
            this.txtUlica.Name = "txtUlica";
            this.txtUlica.Size = new System.Drawing.Size(271, 20);
            this.txtUlica.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Ulica:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "Broj objekta:";
            // 
            // txtBrojObjekta
            // 
            this.txtBrojObjekta.Location = new System.Drawing.Point(15, 236);
            this.txtBrojObjekta.Name = "txtBrojObjekta";
            this.txtBrojObjekta.Size = new System.Drawing.Size(271, 20);
            this.txtBrojObjekta.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "Broj stana:";
            // 
            // txtBrojStana
            // 
            this.txtBrojStana.Location = new System.Drawing.Point(15, 300);
            this.txtBrojStana.Name = "txtBrojStana";
            this.txtBrojStana.Size = new System.Drawing.Size(271, 20);
            this.txtBrojStana.TabIndex = 31;
            // 
            // btnDalje
            // 
            this.btnDalje.Location = new System.Drawing.Point(169, 368);
            this.btnDalje.Name = "btnDalje";
            this.btnDalje.Size = new System.Drawing.Size(117, 28);
            this.btnDalje.TabIndex = 87;
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
            this.menuStrip1.Size = new System.Drawing.Size(298, 24);
            this.menuStrip1.TabIndex = 134;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // svaPitanjaToolStripMenuItem
            // 
            this.svaPitanjaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.svaPitanjaToolStripMenuItem.Name = "svaPitanjaToolStripMenuItem";
            this.svaPitanjaToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.svaPitanjaToolStripMenuItem.Text = "Sva pitanja";
            this.svaPitanjaToolStripMenuItem.Click += new System.EventHandler(this.svaPitanjaToolStripMenuItem_Click_1);
            // 
            // početnaToolStripMenuItem
            // 
            this.početnaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.početnaToolStripMenuItem.Name = "početnaToolStripMenuItem";
            this.početnaToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.početnaToolStripMenuItem.Text = "Početna";
            this.početnaToolStripMenuItem.Click += new System.EventHandler(this.početnaToolStripMenuItem_Click);
            // 
            // frmObjekat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 408);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnDalje);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBrojStana);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBrojObjekta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUlica);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbNaselje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbOpstina);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "frmObjekat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adresa";
            this.Load += new System.EventHandler(this.frmAdresa_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbOpstina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbNaselje;
        private System.Windows.Forms.TextBox txtUlica;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBrojObjekta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBrojStana;
        private System.Windows.Forms.Button btnDalje;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem svaPitanjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem početnaToolStripMenuItem;
    }
}
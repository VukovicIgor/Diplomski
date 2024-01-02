namespace Diplomski
{
    partial class frmPrikaz
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
            this.bazaDiplomskog = new Diplomski.BazaDiplomskog();
            this.btnAdministracija = new System.Windows.Forms.Button();
            this.btnPrijava = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDiplomskog)).BeginInit();
            this.SuspendLayout();
            // 
            // bazaDiplomskog
            // 
            this.bazaDiplomskog.DataSetName = "BazaDiplomskog";
            this.bazaDiplomskog.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAdministracija
            // 
            this.btnAdministracija.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAdministracija.Location = new System.Drawing.Point(0, 0);
            this.btnAdministracija.Name = "btnAdministracija";
            this.btnAdministracija.Size = new System.Drawing.Size(230, 441);
            this.btnAdministracija.TabIndex = 0;
            this.btnAdministracija.Text = "Administracija";
            this.btnAdministracija.UseVisualStyleBackColor = true;
            // 
            // btnPrijava
            // 
            this.btnPrijava.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPrijava.Location = new System.Drawing.Point(234, 0);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(230, 441);
            this.btnPrijava.TabIndex = 1;
            this.btnPrijava.Text = "Prijava";
            this.btnPrijava.UseVisualStyleBackColor = true;
            // 
            // frmPrikaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 441);
            this.Controls.Add(this.btnPrijava);
            this.Controls.Add(this.btnAdministracija);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(200, 200);
            this.Name = "frmPrikaz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijavljivanje";
            this.Load += new System.EventHandler(this.frmPrikaz_Load);
            this.Resize += new System.EventHandler(this.frmPrikaz_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.bazaDiplomskog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private BazaDiplomskog bazaDiplomskog;
        private System.Windows.Forms.Button btnAdministracija;
        private System.Windows.Forms.Button btnPrijava;
    }
}
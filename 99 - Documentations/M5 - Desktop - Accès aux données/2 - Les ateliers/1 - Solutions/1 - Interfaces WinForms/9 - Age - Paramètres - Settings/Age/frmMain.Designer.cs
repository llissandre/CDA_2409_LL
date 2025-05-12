namespace Age
{
    partial class frmMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.txtDtNaiss = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblDtNaiss = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btCalculer = new System.Windows.Forms.Button();
            this.btFermer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDtNaiss
            // 
            this.txtDtNaiss.Location = new System.Drawing.Point(124, 45);
            this.txtDtNaiss.Name = "txtDtNaiss";
            this.txtDtNaiss.Size = new System.Drawing.Size(166, 20);
            this.txtDtNaiss.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtDtNaiss, "Saisir la date de naissance (jj/mm/aaaa)");
            this.txtDtNaiss.TextChanged += new System.EventHandler(this.txtDtNaiss_TextChanged);
            this.txtDtNaiss.Enter += new System.EventHandler(this.txtDtNaiss_Enter);
            this.txtDtNaiss.Leave += new System.EventHandler(this.txtDtNaiss_Leave);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(124, 7);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(166, 20);
            this.txtNom.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtNom, "Saisir le nom");
            this.txtNom.TextChanged += new System.EventHandler(this.txtNom_TextChanged);
            this.txtNom.Enter += new System.EventHandler(this.txtNom_Enter);
            this.txtNom.Leave += new System.EventHandler(this.txtNom_Leave);
            // 
            // lblDtNaiss
            // 
            this.lblDtNaiss.AutoSize = true;
            this.lblDtNaiss.Location = new System.Drawing.Point(22, 48);
            this.lblDtNaiss.Name = "lblDtNaiss";
            this.lblDtNaiss.Size = new System.Drawing.Size(96, 13);
            this.lblDtNaiss.TabIndex = 8;
            this.lblDtNaiss.Text = "Date de naissance";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(22, 10);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(29, 13);
            this.lblNom.TabIndex = 6;
            this.lblNom.Text = "Nom";
            // 
            // btCalculer
            // 
            this.btCalculer.Enabled = false;
            this.btCalculer.Image = global::Age.Properties.Resources.Age;
            this.btCalculer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCalculer.Location = new System.Drawing.Point(189, 81);
            this.btCalculer.Name = "btCalculer";
            this.btCalculer.Size = new System.Drawing.Size(99, 46);
            this.btCalculer.TabIndex = 1;
            this.btCalculer.Text = "&Calculer";
            this.btCalculer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btCalculer, "Calculer l\'age");
            this.btCalculer.UseVisualStyleBackColor = true;
            this.btCalculer.Click += new System.EventHandler(this.btCalculer_Click);
            // 
            // btFermer
            // 
            this.btFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btFermer.Image = global::Age.Properties.Resources.Quitter;
            this.btFermer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btFermer.Location = new System.Drawing.Point(25, 81);
            this.btFermer.Name = "btFermer";
            this.btFermer.Size = new System.Drawing.Size(99, 46);
            this.btFermer.TabIndex = 0;
            this.btFermer.Text = "&Fermer";
            this.btFermer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btFermer, "Fermer l\'application");
            this.btFermer.UseVisualStyleBackColor = true;
            this.btFermer.Click += new System.EventHandler(this.btFermer_Click);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btCalculer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btFermer;
            this.ClientSize = new System.Drawing.Size(312, 130);
            this.Controls.Add(this.btCalculer);
            this.Controls.Add(this.btFermer);
            this.Controls.Add(this.txtDtNaiss);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblDtNaiss);
            this.Controls.Add(this.lblNom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Age";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btCalculer;
        internal System.Windows.Forms.Button btFermer;
        internal System.Windows.Forms.TextBox txtDtNaiss;
        internal System.Windows.Forms.TextBox txtNom;
        internal System.Windows.Forms.Label lblDtNaiss;
        internal System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}


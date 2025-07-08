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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            txtDtNaiss = new System.Windows.Forms.TextBox();
            txtNom = new System.Windows.Forms.TextBox();
            lblDtNaiss = new System.Windows.Forms.Label();
            lblNom = new System.Windows.Forms.Label();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            btCalculer = new System.Windows.Forms.Button();
            btFermer = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // txtDtNaiss
            // 
            txtDtNaiss.Location = new System.Drawing.Point(351, 142);
            txtDtNaiss.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            txtDtNaiss.Name = "txtDtNaiss";
            txtDtNaiss.Size = new System.Drawing.Size(463, 47);
            txtDtNaiss.TabIndex = 2;
            toolTip1.SetToolTip(txtDtNaiss, "Saisir la date de naissance (jj/mm/aaaa)");
            txtDtNaiss.TextChanged += txtDtNaiss_TextChanged;
            // 
            // txtNom
            // 
            txtNom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            txtNom.Location = new System.Drawing.Point(351, 22);
            txtNom.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            txtNom.Name = "txtNom";
            txtNom.Size = new System.Drawing.Size(463, 47);
            txtNom.TabIndex = 1;
            toolTip1.SetToolTip(txtNom, "Saisir le nom");
            txtNom.TextChanged += txtNom_TextChanged;
            txtNom.KeyPress += txtNom_KeyPress;
            // 
            // lblDtNaiss
            // 
            lblDtNaiss.AutoSize = true;
            lblDtNaiss.Location = new System.Drawing.Point(62, 151);
            lblDtNaiss.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            lblDtNaiss.Name = "lblDtNaiss";
            lblDtNaiss.Size = new System.Drawing.Size(257, 41);
            lblDtNaiss.TabIndex = 8;
            lblDtNaiss.Text = "Date de naissance";
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Location = new System.Drawing.Point(62, 32);
            lblNom.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            lblNom.Name = "lblNom";
            lblNom.Size = new System.Drawing.Size(84, 41);
            lblNom.TabIndex = 6;
            lblNom.Text = "Nom";
            // 
            // btCalculer
            // 
            btCalculer.Enabled = false;
            btCalculer.Image = Properties.Resources.Age;
            btCalculer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btCalculer.Location = new System.Drawing.Point(536, 255);
            btCalculer.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            btCalculer.Name = "btCalculer";
            btCalculer.Size = new System.Drawing.Size(280, 145);
            btCalculer.TabIndex = 4;
            btCalculer.Text = "&Calculer";
            btCalculer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolTip1.SetToolTip(btCalculer, "Calculer l'age");
            btCalculer.UseVisualStyleBackColor = true;
            btCalculer.Click += btCalculer_Click;
            // 
            // btFermer
            // 
            btFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btFermer.Image = Properties.Resources.Quitter;
            btFermer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btFermer.Location = new System.Drawing.Point(71, 255);
            btFermer.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            btFermer.Name = "btFermer";
            btFermer.Size = new System.Drawing.Size(280, 145);
            btFermer.TabIndex = 3;
            btFermer.Text = "&Fermer";
            btFermer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolTip1.SetToolTip(btFermer, "Fermer l'application");
            btFermer.UseVisualStyleBackColor = true;
            btFermer.Click += btFermer_Click;
            // 
            // frmMain
            // 
            AcceptButton = btCalculer;
            AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btFermer;
            ClientSize = new System.Drawing.Size(884, 410);
            Controls.Add(btCalculer);
            Controls.Add(btFermer);
            Controls.Add(txtDtNaiss);
            Controls.Add(txtNom);
            Controls.Add(lblDtNaiss);
            Controls.Add(lblNom);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            MaximizeBox = false;
            Name = "frmMain";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Age";
            ResumeLayout(false);
            PerformLayout();
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


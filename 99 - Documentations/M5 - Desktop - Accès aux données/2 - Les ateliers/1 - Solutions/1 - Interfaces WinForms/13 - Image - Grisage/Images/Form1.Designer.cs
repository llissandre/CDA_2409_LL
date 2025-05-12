namespace Images
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
            ToolTip = new System.Windows.Forms.ToolTip(components);
            txtNomFic = new System.Windows.Forms.TextBox();
            BtRecherche = new System.Windows.Forms.Button();
            OFDImage = new System.Windows.Forms.OpenFileDialog();
            lstbxImages = new System.Windows.Forms.ListBox();
            btAjouter = new System.Windows.Forms.Button();
            btVider = new System.Windows.Forms.Button();
            btSupprimer = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // txtNomFic
            // 
            txtNomFic.Location = new System.Drawing.Point(60, 15);
            txtNomFic.Margin = new System.Windows.Forms.Padding(6);
            txtNomFic.Name = "txtNomFic";
            txtNomFic.ReadOnly = true;
            txtNomFic.Size = new System.Drawing.Size(730, 67);
            txtNomFic.TabIndex = 2;
            txtNomFic.TabStop = false;
            ToolTip.SetToolTip(txtNomFic, "Entrez le chemin et le nom du fichier");
            txtNomFic.TextChanged += TxtNomFic_TextChanged;
            // 
            // BtRecherche
            // 
            BtRecherche.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            BtRecherche.Image = Properties.Resources.Rechercher;
            BtRecherche.Location = new System.Drawing.Point(15, 15);
            BtRecherche.Margin = new System.Windows.Forms.Padding(6);
            BtRecherche.Name = "BtRecherche";
            BtRecherche.Size = new System.Drawing.Size(33, 31);
            BtRecherche.TabIndex = 1;
            ToolTip.SetToolTip(BtRecherche, "Rechercher les fichiers avec la boite de dialogue");
            BtRecherche.UseVisualStyleBackColor = true;
            BtRecherche.Click += BtRecherche_Click;
            // 
            // OFDImage
            // 
            OFDImage.Filter = "Images (*.BMP;*.JPG;*.GIF;*.PNG;*.ICO)|*.BMP;*.JPG;*.GIF;*.PNG;*.ICO;";
            OFDImage.InitialDirectory = "C:\\WINDOWS\\Web\\Wallpaper";
            // 
            // lstbxImages
            // 
            lstbxImages.FormattingEnabled = true;
            lstbxImages.ItemHeight = 59;
            lstbxImages.Location = new System.Drawing.Point(12, 91);
            lstbxImages.Name = "lstbxImages";
            lstbxImages.Size = new System.Drawing.Size(778, 299);
            lstbxImages.TabIndex = 3;
            lstbxImages.SelectedIndexChanged += lstbxImages_SelectedIndexChanged;
            // 
            // btAjouter
            // 
            btAjouter.Image = Properties.Resources.Ajouter_24;
            btAjouter.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btAjouter.Location = new System.Drawing.Point(796, 91);
            btAjouter.Name = "btAjouter";
            btAjouter.Size = new System.Drawing.Size(298, 69);
            btAjouter.TabIndex = 4;
            btAjouter.Text = "&Ajouter";
            btAjouter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btAjouter.UseVisualStyleBackColor = true;
            btAjouter.Click += btAjouter_Click;
            // 
            // btVider
            // 
            btVider.Image = Properties.Resources.Vider_24;
            btVider.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btVider.Location = new System.Drawing.Point(796, 321);
            btVider.Name = "btVider";
            btVider.Size = new System.Drawing.Size(298, 69);
            btVider.TabIndex = 6;
            btVider.Text = "&Vider";
            btVider.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btVider.UseVisualStyleBackColor = true;
            btVider.Click += btVider_Click;
            // 
            // btSupprimer
            // 
            btSupprimer.Image = Properties.Resources.Supprimer_24;
            btSupprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btSupprimer.Location = new System.Drawing.Point(796, 206);
            btSupprimer.Name = "btSupprimer";
            btSupprimer.Size = new System.Drawing.Size(298, 69);
            btSupprimer.TabIndex = 5;
            btSupprimer.Text = "&Supprimer";
            btSupprimer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btSupprimer.UseVisualStyleBackColor = true;
            btSupprimer.Click += btSupprimer_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(30F, 59F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1105, 404);
            Controls.Add(btSupprimer);
            Controls.Add(btVider);
            Controls.Add(btAjouter);
            Controls.Add(lstbxImages);
            Controls.Add(BtRecherche);
            Controls.Add(txtNomFic);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(6);
            Name = "frmMain";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Images";
            FormClosed += frmMain_FormClosed;
            Load += frmMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal System.Windows.Forms.ToolTip ToolTip;
        internal System.Windows.Forms.OpenFileDialog OFDImage;
        internal System.Windows.Forms.Button BtRecherche;
        internal System.Windows.Forms.TextBox txtNomFic;
        private System.Windows.Forms.ListBox lstbxImages;
        private System.Windows.Forms.Button btAjouter;
        private System.Windows.Forms.Button btVider;
        private System.Windows.Forms.Button btSupprimer;
    }
}


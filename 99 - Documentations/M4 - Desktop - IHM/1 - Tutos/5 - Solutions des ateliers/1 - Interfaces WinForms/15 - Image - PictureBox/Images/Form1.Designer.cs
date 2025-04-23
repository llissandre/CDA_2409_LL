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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.txtNomFic = new System.Windows.Forms.TextBox();
            this.BtRecherche = new System.Windows.Forms.Button();
            this.OFDImage = new System.Windows.Forms.OpenFileDialog();
            this.lstbxImages = new System.Windows.Forms.ListBox();
            this.btAjouter = new System.Windows.Forms.Button();
            this.btVider = new System.Windows.Forms.Button();
            this.btSupprimer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picBxImage = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomFic
            // 
            this.txtNomFic.Location = new System.Drawing.Point(60, 15);
            this.txtNomFic.Margin = new System.Windows.Forms.Padding(6);
            this.txtNomFic.Name = "txtNomFic";
            this.txtNomFic.ReadOnly = true;
            this.txtNomFic.Size = new System.Drawing.Size(730, 31);
            this.txtNomFic.TabIndex = 2;
            this.txtNomFic.TabStop = false;
            this.ToolTip.SetToolTip(this.txtNomFic, "Entrez le chemin et le nom du fichier");
            this.txtNomFic.TextChanged += new System.EventHandler(this.TxtNomFic_TextChanged);
            // 
            // BtRecherche
            // 
            this.BtRecherche.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtRecherche.Image = global::Images.Properties.Resources.Rechercher;
            this.BtRecherche.Location = new System.Drawing.Point(15, 15);
            this.BtRecherche.Margin = new System.Windows.Forms.Padding(6);
            this.BtRecherche.Name = "BtRecherche";
            this.BtRecherche.Size = new System.Drawing.Size(33, 31);
            this.BtRecherche.TabIndex = 1;
            this.ToolTip.SetToolTip(this.BtRecherche, "Rechercher les fichiers avec la boite de dialogue");
            this.BtRecherche.UseVisualStyleBackColor = true;
            this.BtRecherche.Click += new System.EventHandler(this.BtRecherche_Click);
            // 
            // OFDImage
            // 
            this.OFDImage.Filter = "Images (*.BMP;*.JPG;*.GIF;*.PNG;*.ICO)|*.BMP;*.JPG;*.GIF;*.PNG;*.ICO;";
            this.OFDImage.InitialDirectory = "C:\\WINDOWS\\Web\\Wallpaper";
            // 
            // lstbxImages
            // 
            this.lstbxImages.FormattingEnabled = true;
            this.lstbxImages.ItemHeight = 25;
            this.lstbxImages.Location = new System.Drawing.Point(12, 91);
            this.lstbxImages.Name = "lstbxImages";
            this.lstbxImages.Size = new System.Drawing.Size(778, 229);
            this.lstbxImages.TabIndex = 3;
            this.lstbxImages.SelectedIndexChanged += new System.EventHandler(this.lstbxImages_SelectedIndexChanged);
            // 
            // btAjouter
            // 
            this.btAjouter.Image = global::Images.Properties.Resources.Ajouter_24;
            this.btAjouter.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAjouter.Location = new System.Drawing.Point(796, 91);
            this.btAjouter.Name = "btAjouter";
            this.btAjouter.Size = new System.Drawing.Size(291, 75);
            this.btAjouter.TabIndex = 4;
            this.btAjouter.Text = "&Ajouter";
            this.btAjouter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAjouter.UseVisualStyleBackColor = true;
            this.btAjouter.Click += new System.EventHandler(this.btAjouter_Click);
            // 
            // btVider
            // 
            this.btVider.Image = global::Images.Properties.Resources.Vider_24;
            this.btVider.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btVider.Location = new System.Drawing.Point(796, 255);
            this.btVider.Name = "btVider";
            this.btVider.Size = new System.Drawing.Size(291, 75);
            this.btVider.TabIndex = 6;
            this.btVider.Text = "&Vider";
            this.btVider.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btVider.UseVisualStyleBackColor = true;
            this.btVider.Click += new System.EventHandler(this.btVider_Click);
            // 
            // btSupprimer
            // 
            this.btSupprimer.Image = global::Images.Properties.Resources.Supprimer_24;
            this.btSupprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSupprimer.Location = new System.Drawing.Point(793, 173);
            this.btSupprimer.Name = "btSupprimer";
            this.btSupprimer.Size = new System.Drawing.Size(291, 75);
            this.btSupprimer.TabIndex = 5;
            this.btSupprimer.Text = "&Supprimer";
            this.btSupprimer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSupprimer.UseVisualStyleBackColor = true;
            this.btSupprimer.Click += new System.EventHandler(this.btAjouter_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.picBxImage);
            this.panel1.Location = new System.Drawing.Point(22, 359);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 204);
            this.panel1.TabIndex = 8;
            // 
            // picBxImage
            // 
            this.picBxImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.picBxImage.Location = new System.Drawing.Point(3, 3);
            this.picBxImage.Name = "picBxImage";
            this.picBxImage.Size = new System.Drawing.Size(282, 90);
            this.picBxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBxImage.TabIndex = 8;
            this.picBxImage.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 585);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btSupprimer);
            this.Controls.Add(this.btVider);
            this.Controls.Add(this.btAjouter);
            this.Controls.Add(this.lstbxImages);
            this.Controls.Add(this.BtRecherche);
            this.Controls.Add(this.txtNomFic);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(970, 533);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Images";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picBxImage;
    }
}


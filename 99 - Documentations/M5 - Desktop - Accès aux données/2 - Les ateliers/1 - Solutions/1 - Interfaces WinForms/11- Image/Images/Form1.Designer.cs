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
            BtRecherche = new System.Windows.Forms.Button();
            TxtNomFic = new System.Windows.Forms.TextBox();
            OFDImage = new System.Windows.Forms.OpenFileDialog();
            SuspendLayout();
            // 
            // BtRecherche
            // 
            BtRecherche.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            BtRecherche.Image = Properties.Resources.Rechercher;
            BtRecherche.Location = new System.Drawing.Point(15, 15);
            BtRecherche.Margin = new System.Windows.Forms.Padding(6);
            BtRecherche.Name = "BtRecherche";
            BtRecherche.Size = new System.Drawing.Size(33, 31);
            BtRecherche.TabIndex = 5;
            ToolTip.SetToolTip(BtRecherche, "Rechercher les fichiers avec la boite de dialogue");
            BtRecherche.UseVisualStyleBackColor = true;
            BtRecherche.Click += BtRecherche_Click;
            // 
            // TxtNomFic
            // 
            TxtNomFic.Location = new System.Drawing.Point(60, 15);
            TxtNomFic.Margin = new System.Windows.Forms.Padding(6);
            TxtNomFic.Name = "TxtNomFic";
            TxtNomFic.ReadOnly = true;
            TxtNomFic.Size = new System.Drawing.Size(730, 67);
            TxtNomFic.TabIndex = 6;
            TxtNomFic.TabStop = false;
            ToolTip.SetToolTip(TxtNomFic, "Entrez le chemin et le nom du fichier");
            // 
            // OFDImage
            // 
            OFDImage.Filter = "Images|*.BMP;*.JPG;*.GIF;*.PNG;|Icones|*.ico;";
            OFDImage.InitialDirectory = "C:\\WINDOWS\\Web\\Wallpaper";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(30F, 59F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(809, 95);
            Controls.Add(BtRecherche);
            Controls.Add(TxtNomFic);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(6);
            Name = "frmMain";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Images";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal System.Windows.Forms.ToolTip ToolTip;
        internal System.Windows.Forms.OpenFileDialog OFDImage;
        internal System.Windows.Forms.Button BtRecherche;
        internal System.Windows.Forms.TextBox TxtNomFic;
    }
}


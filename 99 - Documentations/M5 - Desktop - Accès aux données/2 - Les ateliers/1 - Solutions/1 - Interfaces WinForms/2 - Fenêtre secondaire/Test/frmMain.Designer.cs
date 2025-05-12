namespace Test
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
            txtTitreFen2 = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            btFen2 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // txtTitreFen2
            // 
            txtTitreFen2.Location = new System.Drawing.Point(419, 7);
            txtTitreFen2.Margin = new System.Windows.Forms.Padding(2);
            txtTitreFen2.Name = "txtTitreFen2";
            txtTitreFen2.Size = new System.Drawing.Size(523, 47);
            txtTitreFen2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(11, 10);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(398, 41);
            label1.TabIndex = 4;
            label1.Text = "Veuillez saisir le titre de Fen2";
            // 
            // btFen2
            // 
            btFen2.Location = new System.Drawing.Point(358, 102);
            btFen2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            btFen2.Name = "btFen2";
            btFen2.Size = new System.Drawing.Size(236, 71);
            btFen2.TabIndex = 3;
            btFen2.Text = "Fenêtre fille";
            btFen2.UseVisualStyleBackColor = true;
            btFen2.Click += btFen2_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(953, 187);
            Controls.Add(txtTitreFen2);
            Controls.Add(label1);
            Controls.Add(btFen2);
            Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            Name = "frmMain";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtTitreFen2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btFen2;
    }
}


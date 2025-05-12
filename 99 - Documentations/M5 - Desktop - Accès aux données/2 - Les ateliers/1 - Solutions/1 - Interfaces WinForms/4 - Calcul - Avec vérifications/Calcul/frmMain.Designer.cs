namespace Calcul
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
            txtNb1 = new System.Windows.Forms.TextBox();
            txtNb2 = new System.Windows.Forms.TextBox();
            lblAddition = new System.Windows.Forms.Label();
            lblSeparateur = new System.Windows.Forms.Label();
            btResultat = new System.Windows.Forms.Button();
            toolTip = new System.Windows.Forms.ToolTip(components);
            btCE = new System.Windows.Forms.Button();
            lblResult = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // txtNb1
            // 
            txtNb1.Location = new System.Drawing.Point(224, 38);
            txtNb1.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            txtNb1.Name = "txtNb1";
            txtNb1.Size = new System.Drawing.Size(582, 47);
            txtNb1.TabIndex = 0;
            txtNb1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            toolTip.SetToolTip(txtNb1, "Veuillez entrer le premier nombre");
            txtNb1.KeyPress += txtNb1_KeyPress;
            // 
            // txtNb2
            // 
            txtNb2.Location = new System.Drawing.Point(224, 120);
            txtNb2.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            txtNb2.Name = "txtNb2";
            txtNb2.Size = new System.Drawing.Size(582, 47);
            txtNb2.TabIndex = 1;
            txtNb2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            toolTip.SetToolTip(txtNb2, "Veuillez entrer le deuxieme nombre");
            txtNb2.KeyPress += txtNb2_KeyPress;
            // 
            // lblAddition
            // 
            lblAddition.AutoSize = true;
            lblAddition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblAddition.Location = new System.Drawing.Point(128, 120);
            lblAddition.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            lblAddition.Name = "lblAddition";
            lblAddition.Size = new System.Drawing.Size(44, 46);
            lblAddition.TabIndex = 2;
            lblAddition.Text = "+";
            // 
            // lblSeparateur
            // 
            lblSeparateur.AutoSize = true;
            lblSeparateur.Location = new System.Drawing.Point(130, 192);
            lblSeparateur.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            lblSeparateur.Name = "lblSeparateur";
            lblSeparateur.Size = new System.Drawing.Size(774, 82);
            lblSeparateur.TabIndex = 3;
            lblSeparateur.Text = "---------------------------------------------------------------\r\n\r\n";
            // 
            // btResultat
            // 
            btResultat.FlatStyle = System.Windows.Forms.FlatStyle.System;
            btResultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btResultat.Location = new System.Drawing.Point(128, 246);
            btResultat.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            btResultat.Name = "btResultat";
            btResultat.Size = new System.Drawing.Size(54, 63);
            btResultat.TabIndex = 2;
            btResultat.Text = "=";
            toolTip.SetToolTip(btResultat, "Cliquer ici pour effectuer le calcul");
            btResultat.UseVisualStyleBackColor = true;
            btResultat.Click += btResultat_Click;
            // 
            // btCE
            // 
            btCE.Location = new System.Drawing.Point(907, 32);
            btCE.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            btCE.Name = "btCE";
            btCE.Size = new System.Drawing.Size(76, 69);
            btCE.TabIndex = 3;
            btCE.Text = "&ce";
            toolTip.SetToolTip(btCE, "Cliquez ici pour éffacer les champs");
            btCE.UseVisualStyleBackColor = true;
            btCE.Click += btCE_Click;
            // 
            // lblResult
            // 
            lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblResult.Location = new System.Drawing.Point(224, 246);
            lblResult.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            lblResult.Name = "lblResult";
            lblResult.Size = new System.Drawing.Size(586, 59);
            lblResult.TabIndex = 5;
            lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmMain
            // 
            AcceptButton = btResultat;
            AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1017, 347);
            Controls.Add(lblResult);
            Controls.Add(btCE);
            Controls.Add(btResultat);
            Controls.Add(lblSeparateur);
            Controls.Add(lblAddition);
            Controls.Add(txtNb2);
            Controls.Add(txtNb1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmMain";
            Text = "Calcul";
            toolTip.SetToolTip(this, "Réinitialiser les champs");
            KeyPress += frmMain_KeyPress;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtNb1;
        private System.Windows.Forms.TextBox txtNb2;
        private System.Windows.Forms.Label lblAddition;
        private System.Windows.Forms.Label lblSeparateur;
        private System.Windows.Forms.Button btResultat;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btCE;
        private System.Windows.Forms.Label lblResult;
    }
}


namespace Diviseurs
{
    partial class Form1
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            txtNumerateur = new System.Windows.Forms.TextBox();
            txtDenominateur = new System.Windows.Forms.TextBox();
            btCalculer = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            lblNumerateur = new System.Windows.Forms.Label();
            lblDenominateur = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(34, 28);
            label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(400, 41);
            label1.TabIndex = 0;
            label1.Text = "Veuillez saisir le numérateur :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(34, 151);
            label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(433, 41);
            label2.TabIndex = 1;
            label2.Text = "Veuillez saisir le dénominateur :";
            // 
            // txtNumerateur
            // 
            txtNumerateur.Location = new System.Drawing.Point(490, 19);
            txtNumerateur.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            txtNumerateur.Name = "txtNumerateur";
            txtNumerateur.Size = new System.Drawing.Size(276, 47);
            txtNumerateur.TabIndex = 2;
            txtNumerateur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDenominateur
            // 
            txtDenominateur.Location = new System.Drawing.Point(490, 142);
            txtDenominateur.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            txtDenominateur.Name = "txtDenominateur";
            txtDenominateur.Size = new System.Drawing.Size(276, 47);
            txtDenominateur.TabIndex = 3;
            txtDenominateur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btCalculer
            // 
            btCalculer.Location = new System.Drawing.Point(346, 293);
            btCalculer.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            btCalculer.Name = "btCalculer";
            btCalculer.Size = new System.Drawing.Size(212, 73);
            btCalculer.TabIndex = 4;
            btCalculer.Text = "Calculer";
            toolTip1.SetToolTip(btCalculer, "coucou");
            btCalculer.UseVisualStyleBackColor = true;
            btCalculer.Click += btCalculer_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(482, 91);
            label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(426, 41);
            label3.TabIndex = 5;
            label3.Text = "----------------------------------";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(34, 435);
            label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(414, 41);
            label4.TabIndex = 6;
            label4.Text = "Résultat après simplifications :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(34, 539);
            label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(192, 41);
            label5.TabIndex = 7;
            label5.Text = "Numérateur :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(34, 631);
            label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(223, 41);
            label6.TabIndex = 8;
            label6.Text = "Dénominateur :";
            // 
            // lblNumerateur
            // 
            lblNumerateur.Location = new System.Drawing.Point(295, 539);
            lblNumerateur.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            lblNumerateur.Name = "lblNumerateur";
            lblNumerateur.Size = new System.Drawing.Size(309, 41);
            lblNumerateur.TabIndex = 9;
            lblNumerateur.Text = "0";
            lblNumerateur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDenominateur
            // 
            lblDenominateur.Location = new System.Drawing.Point(295, 631);
            lblDenominateur.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            lblDenominateur.Name = "lblDenominateur";
            lblDenominateur.Size = new System.Drawing.Size(309, 41);
            lblDenominateur.TabIndex = 10;
            lblDenominateur.Text = "0";
            lblDenominateur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(295, 580);
            label7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(426, 41);
            label7.TabIndex = 11;
            label7.Text = "----------------------------------";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(844, 706);
            Controls.Add(label7);
            Controls.Add(lblDenominateur);
            Controls.Add(lblNumerateur);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btCalculer);
            Controls.Add(txtDenominateur);
            Controls.Add(txtNumerateur);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            Name = "Form1";
            Text = "Diviseurs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumerateur;
        private System.Windows.Forms.TextBox txtDenominateur;
        private System.Windows.Forms.Button btCalculer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNumerateur;
        private System.Windows.Forms.Label lblDenominateur;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}


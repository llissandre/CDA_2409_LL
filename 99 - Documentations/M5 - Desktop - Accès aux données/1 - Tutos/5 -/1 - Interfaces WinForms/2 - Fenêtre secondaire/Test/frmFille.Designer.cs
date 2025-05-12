namespace Test
{
    partial class frmFille
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
            txtFen2 = new System.Windows.Forms.TextBox();
            btValider = new System.Windows.Forms.Button();
            btAnnuler = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // txtFen2
            // 
            txtFen2.Location = new System.Drawing.Point(55, 31);
            txtFen2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtFen2.Name = "txtFen2";
            txtFen2.Size = new System.Drawing.Size(355, 53);
            txtFen2.TabIndex = 0;
            // 
            // btValider
            // 
            btValider.Location = new System.Drawing.Point(55, 119);
            btValider.Name = "btValider";
            btValider.Size = new System.Drawing.Size(158, 56);
            btValider.TabIndex = 1;
            btValider.Text = "Valider";
            btValider.UseVisualStyleBackColor = true;
            btValider.Click += btValider_Click;
            // 
            // btAnnuler
            // 
            btAnnuler.Location = new System.Drawing.Point(252, 119);
            btAnnuler.Name = "btAnnuler";
            btAnnuler.Size = new System.Drawing.Size(158, 56);
            btAnnuler.TabIndex = 2;
            btAnnuler.Text = "Annuler";
            btAnnuler.UseVisualStyleBackColor = true;
            btAnnuler.Click += btAnnuler_Click;
            // 
            // frmFille
            // 
            AcceptButton = btValider;
            AutoScaleDimensions = new System.Drawing.SizeF(23F, 46F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btAnnuler;
            ClientSize = new System.Drawing.Size(457, 212);
            Controls.Add(btAnnuler);
            Controls.Add(btValider);
            Controls.Add(txtFen2);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "frmFille";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "frmFille";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal System.Windows.Forms.TextBox txtFen2;
        private System.Windows.Forms.Button btValider;
        private System.Windows.Forms.Button btAnnuler;
    }
}
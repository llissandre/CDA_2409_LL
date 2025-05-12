namespace Utilisateurs
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            dgvUtilisateurs = new System.Windows.Forms.DataGridView();
            tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            txtPrenom = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            txtNom = new System.Windows.Forms.TextBox();
            dtpNaiss = new System.Windows.Forms.DateTimePicker();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            btActualiser = new System.Windows.Forms.Button();
            btAjouter = new System.Windows.Forms.Button();
            btSupprimer = new System.Windows.Forms.Button();
            BSUtilisateurs = new System.Windows.Forms.BindingSource(components);
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            label1 = new System.Windows.Forms.Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUtilisateurs).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BSUtilisateurs).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(dgvUtilisateurs, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 2);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.Size = new System.Drawing.Size(1654, 827);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // dgvUtilisateurs
            // 
            dgvUtilisateurs.AllowUserToAddRows = false;
            dgvUtilisateurs.AllowUserToDeleteRows = false;
            dgvUtilisateurs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvUtilisateurs.BackgroundColor = System.Drawing.SystemColors.Control;
            dgvUtilisateurs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvUtilisateurs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUtilisateurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUtilisateurs.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvUtilisateurs.EnableHeadersVisualStyles = false;
            dgvUtilisateurs.Location = new System.Drawing.Point(8, 9);
            dgvUtilisateurs.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            dgvUtilisateurs.MultiSelect = false;
            dgvUtilisateurs.Name = "dgvUtilisateurs";
            dgvUtilisateurs.ReadOnly = true;
            dgvUtilisateurs.RowHeadersVisible = false;
            dgvUtilisateurs.RowHeadersWidth = 102;
            dgvUtilisateurs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvUtilisateurs.Size = new System.Drawing.Size(1638, 374);
            dgvUtilisateurs.StandardTab = true;
            dgvUtilisateurs.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(txtPrenom, 1, 1);
            tableLayoutPanel3.Controls.Add(label2, 0, 0);
            tableLayoutPanel3.Controls.Add(label3, 0, 2);
            tableLayoutPanel3.Controls.Add(label4, 0, 1);
            tableLayoutPanel3.Controls.Add(txtNom, 1, 0);
            tableLayoutPanel3.Controls.Add(dtpNaiss, 1, 2);
            tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel3.Location = new System.Drawing.Point(8, 401);
            tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new System.Drawing.Size(1638, 255);
            tableLayoutPanel3.TabIndex = 4;
            // 
            // txtPrenom
            // 
            txtPrenom.Dock = System.Windows.Forms.DockStyle.Fill;
            txtPrenom.Location = new System.Drawing.Point(307, 94);
            txtPrenom.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new System.Drawing.Size(1323, 47);
            txtPrenom.TabIndex = 6;
            // 
            // label2
            // 
            label2.Dock = System.Windows.Forms.DockStyle.Fill;
            label2.Location = new System.Drawing.Point(8, 0);
            label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(283, 85);
            label2.TabIndex = 0;
            label2.Text = "Nom";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Dock = System.Windows.Forms.DockStyle.Fill;
            label3.Location = new System.Drawing.Point(8, 170);
            label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(283, 85);
            label3.TabIndex = 2;
            label3.Text = "Date de naissance";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Dock = System.Windows.Forms.DockStyle.Fill;
            label4.Location = new System.Drawing.Point(8, 85);
            label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(283, 85);
            label4.TabIndex = 1;
            label4.Text = "Prénom";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNom
            // 
            txtNom.Dock = System.Windows.Forms.DockStyle.Fill;
            txtNom.Location = new System.Drawing.Point(307, 9);
            txtNom.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            txtNom.Name = "txtNom";
            txtNom.Size = new System.Drawing.Size(1323, 47);
            txtNom.TabIndex = 3;
            // 
            // dtpNaiss
            // 
            dtpNaiss.Dock = System.Windows.Forms.DockStyle.Fill;
            dtpNaiss.Location = new System.Drawing.Point(307, 179);
            dtpNaiss.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            dtpNaiss.Name = "dtpNaiss";
            dtpNaiss.Size = new System.Drawing.Size(1323, 47);
            dtpNaiss.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(btActualiser);
            flowLayoutPanel1.Controls.Add(btAjouter);
            flowLayoutPanel1.Controls.Add(btSupprimer);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel1.Location = new System.Drawing.Point(8, 674);
            flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(1638, 144);
            flowLayoutPanel1.TabIndex = 1;
            flowLayoutPanel1.WrapContents = false;
            // 
            // btActualiser
            // 
            btActualiser.Image = Properties.Resources.Actualiser;
            btActualiser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btActualiser.Location = new System.Drawing.Point(8, 9);
            btActualiser.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            btActualiser.Name = "btActualiser";
            btActualiser.Size = new System.Drawing.Size(277, 126);
            btActualiser.TabIndex = 0;
            btActualiser.Text = "&Actualiser";
            btActualiser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btActualiser.UseVisualStyleBackColor = true;
            btActualiser.Click += btActualiser_Click;
            // 
            // btAjouter
            // 
            btAjouter.Image = Properties.Resources.Ajouter;
            btAjouter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btAjouter.Location = new System.Drawing.Point(301, 9);
            btAjouter.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            btAjouter.Name = "btAjouter";
            btAjouter.Size = new System.Drawing.Size(278, 126);
            btAjouter.TabIndex = 3;
            btAjouter.Text = "A&jouter";
            btAjouter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btAjouter.UseVisualStyleBackColor = true;
            btAjouter.Click += btAjouter_Click;
            // 
            // btSupprimer
            // 
            btSupprimer.Image = Properties.Resources.Supprimer;
            btSupprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btSupprimer.Location = new System.Drawing.Point(595, 9);
            btSupprimer.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            btSupprimer.Name = "btSupprimer";
            btSupprimer.Size = new System.Drawing.Size(278, 126);
            btSupprimer.TabIndex = 4;
            btSupprimer.Text = "&Supprimer";
            btSupprimer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btSupprimer.UseVisualStyleBackColor = true;
            btSupprimer.Click += btSupprimer_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = System.Windows.Forms.DockStyle.Fill;
            label1.Location = new System.Drawing.Point(8, 0);
            label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(283, 85);
            label1.TabIndex = 0;
            label1.Text = "Nom";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1654, 827);
            Controls.Add(tableLayoutPanel1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            MinimumSize = new System.Drawing.Size(1642, 757);
            Name = "frmMain";
            Text = "Utilisateurs";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUtilisateurs).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BSUtilisateurs).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btActualiser;
        private System.Windows.Forms.BindingSource BSUtilisateurs;
        private System.Windows.Forms.DataGridView dgvUtilisateurs;
        private System.Windows.Forms.Button btAjouter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.DateTimePicker dtpNaiss;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Button btSupprimer;
    }
}


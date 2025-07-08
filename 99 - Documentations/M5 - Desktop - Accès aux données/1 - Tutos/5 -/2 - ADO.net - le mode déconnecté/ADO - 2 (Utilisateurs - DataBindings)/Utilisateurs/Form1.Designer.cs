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
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            btActualiser = new System.Windows.Forms.Button();
            lbxUtilisateurs = new System.Windows.Forms.ListBox();
            txtUtilisateurs = new System.Windows.Forms.TextBox();
            dtpUtilisateurs = new System.Windows.Forms.DateTimePicker();
            cbxUtilisateurs = new System.Windows.Forms.ComboBox();
            BSUtilisateurs = new System.Windows.Forms.BindingSource(components);
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            label1 = new System.Windows.Forms.Label();
            BS2Utilisateurs = new System.Windows.Forms.BindingSource(components);
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUtilisateurs).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BSUtilisateurs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BS2Utilisateurs).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(dgvUtilisateurs, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 1);
            tableLayoutPanel1.Controls.Add(lbxUtilisateurs, 0, 2);
            tableLayoutPanel1.Controls.Add(txtUtilisateurs, 0, 3);
            tableLayoutPanel1.Controls.Add(dtpUtilisateurs, 0, 4);
            tableLayoutPanel1.Controls.Add(cbxUtilisateurs, 0, 5);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 176F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new System.Drawing.Size(1610, 914);
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
            dgvUtilisateurs.Size = new System.Drawing.Size(1594, 247);
            dgvUtilisateurs.StandardTab = true;
            dgvUtilisateurs.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(btActualiser);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel1.Location = new System.Drawing.Point(8, 274);
            flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(1594, 144);
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
            // lbxUtilisateurs
            // 
            lbxUtilisateurs.Dock = System.Windows.Forms.DockStyle.Fill;
            lbxUtilisateurs.FormattingEnabled = true;
            lbxUtilisateurs.ItemHeight = 41;
            lbxUtilisateurs.Location = new System.Drawing.Point(3, 430);
            lbxUtilisateurs.Name = "lbxUtilisateurs";
            lbxUtilisateurs.Size = new System.Drawing.Size(1604, 170);
            lbxUtilisateurs.TabIndex = 3;
            // 
            // txtUtilisateurs
            // 
            txtUtilisateurs.Anchor = System.Windows.Forms.AnchorStyles.None;
            txtUtilisateurs.Location = new System.Drawing.Point(435, 637);
            txtUtilisateurs.Name = "txtUtilisateurs";
            txtUtilisateurs.Size = new System.Drawing.Size(740, 47);
            txtUtilisateurs.TabIndex = 4;
            // 
            // dtpUtilisateurs
            // 
            dtpUtilisateurs.Anchor = System.Windows.Forms.AnchorStyles.None;
            dtpUtilisateurs.Location = new System.Drawing.Point(555, 741);
            dtpUtilisateurs.Name = "dtpUtilisateurs";
            dtpUtilisateurs.Size = new System.Drawing.Size(500, 47);
            dtpUtilisateurs.TabIndex = 5;
            // 
            // cbxUtilisateurs
            // 
            cbxUtilisateurs.Anchor = System.Windows.Forms.AnchorStyles.None;
            cbxUtilisateurs.FormattingEnabled = true;
            cbxUtilisateurs.Location = new System.Drawing.Point(535, 838);
            cbxUtilisateurs.Name = "cbxUtilisateurs";
            cbxUtilisateurs.Size = new System.Drawing.Size(539, 49);
            cbxUtilisateurs.TabIndex = 6;
            // 
            // BSUtilisateurs
            // 
            BSUtilisateurs.CurrentChanged += BSUtilisateurs_CurrentChanged;
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
            ClientSize = new System.Drawing.Size(1610, 914);
            Controls.Add(tableLayoutPanel1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            MinimumSize = new System.Drawing.Size(1642, 757);
            Name = "frmMain";
            Text = "Utilisateurs";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUtilisateurs).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BSUtilisateurs).EndInit();
            ((System.ComponentModel.ISupportInitialize)BS2Utilisateurs).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btActualiser;
        private System.Windows.Forms.BindingSource BSUtilisateurs;
        private System.Windows.Forms.DataGridView dgvUtilisateurs;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbxUtilisateurs;
        private System.Windows.Forms.BindingSource BS2Utilisateurs;
        private System.Windows.Forms.TextBox txtUtilisateurs;
        private System.Windows.Forms.DateTimePicker dtpUtilisateurs;
        private System.Windows.Forms.ComboBox cbxUtilisateurs;
    }
}


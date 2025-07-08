namespace Edito
{
    partial class frmMain
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            tableLayoutPanel1 = new TableLayoutPanel();
            tabEdito = new TabControl();
            tabArticles = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            dgvArticles = new DataGridView();
            tableLayoutPanel3 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtTitreArticle = new TextBox();
            txtCorpsArticle = new TextBox();
            txtAuteurArticle = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btArticleActualiser = new Button();
            btArticleAjouter = new Button();
            btArticleModifier = new Button();
            btArticleSupprimer = new Button();
            tabJournaux = new TabPage();
            tabCompositions = new TabPage();
            BSArticles = new BindingSource(components);
            tableLayoutPanel1.SuspendLayout();
            tabEdito.SuspendLayout();
            tabArticles.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvArticles).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BSArticles).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tabEdito, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1468, 912);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tabEdito
            // 
            tabEdito.Appearance = TabAppearance.FlatButtons;
            tabEdito.Controls.Add(tabArticles);
            tabEdito.Controls.Add(tabJournaux);
            tabEdito.Controls.Add(tabCompositions);
            tabEdito.Dock = DockStyle.Fill;
            tabEdito.Location = new Point(3, 3);
            tabEdito.Name = "tabEdito";
            tabEdito.Padding = new Point(20, 3);
            tabEdito.SelectedIndex = 0;
            tabEdito.Size = new Size(1462, 906);
            tabEdito.TabIndex = 0;
            tabEdito.SelectedIndexChanged += tabEdito_SelectedIndexChanged;
            // 
            // tabArticles
            // 
            tabArticles.BackColor = SystemColors.Control;
            tabArticles.Controls.Add(tableLayoutPanel2);
            tabArticles.Location = new Point(4, 53);
            tabArticles.Name = "tabArticles";
            tabArticles.Padding = new Padding(3);
            tabArticles.Size = new Size(1454, 849);
            tabArticles.TabIndex = 0;
            tabArticles.Text = "Articles";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(dgvArticles, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel2.Controls.Add(flowLayoutPanel1, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Margin = new Padding(8, 9, 8, 9);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(1448, 843);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // dgvArticles
            // 
            dgvArticles.AllowUserToAddRows = false;
            dgvArticles.AllowUserToDeleteRows = false;
            dgvArticles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvArticles.BackgroundColor = SystemColors.Control;
            dgvArticles.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.LightCyan;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.LightCyan;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvArticles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvArticles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArticles.Dock = DockStyle.Fill;
            dgvArticles.EnableHeadersVisualStyles = false;
            dgvArticles.Location = new Point(8, 9);
            dgvArticles.Margin = new Padding(8, 9, 8, 9);
            dgvArticles.MultiSelect = false;
            dgvArticles.Name = "dgvArticles";
            dgvArticles.ReadOnly = true;
            dgvArticles.RowHeadersVisible = false;
            dgvArticles.RowHeadersWidth = 102;
            dgvArticles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvArticles.Size = new Size(1432, 427);
            dgvArticles.StandardTab = true;
            dgvArticles.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.AutoSize = true;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Controls.Add(label2, 0, 1);
            tableLayoutPanel3.Controls.Add(label3, 0, 2);
            tableLayoutPanel3.Controls.Add(txtTitreArticle, 1, 0);
            tableLayoutPanel3.Controls.Add(txtCorpsArticle, 1, 1);
            tableLayoutPanel3.Controls.Add(txtAuteurArticle, 1, 2);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 448);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(1442, 230);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(107, 53);
            label1.TabIndex = 0;
            label1.Text = "Titre";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 53);
            label2.Name = "label2";
            label2.Size = new Size(107, 124);
            label2.TabIndex = 1;
            label2.Text = "Corps";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 177);
            label3.Name = "label3";
            label3.Size = new Size(107, 53);
            label3.TabIndex = 2;
            label3.Text = "Auteur";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtTitreArticle
            // 
            txtTitreArticle.Dock = DockStyle.Fill;
            txtTitreArticle.Location = new Point(116, 3);
            txtTitreArticle.Name = "txtTitreArticle";
            txtTitreArticle.Size = new Size(1323, 47);
            txtTitreArticle.TabIndex = 3;
            // 
            // txtCorpsArticle
            // 
            txtCorpsArticle.Dock = DockStyle.Fill;
            txtCorpsArticle.Location = new Point(116, 56);
            txtCorpsArticle.Multiline = true;
            txtCorpsArticle.Name = "txtCorpsArticle";
            txtCorpsArticle.Size = new Size(1323, 118);
            txtCorpsArticle.TabIndex = 4;
            // 
            // txtAuteurArticle
            // 
            txtAuteurArticle.Dock = DockStyle.Fill;
            txtAuteurArticle.Location = new Point(116, 180);
            txtAuteurArticle.Name = "txtAuteurArticle";
            txtAuteurArticle.Size = new Size(1323, 47);
            txtAuteurArticle.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(btArticleActualiser);
            flowLayoutPanel1.Controls.Add(btArticleAjouter);
            flowLayoutPanel1.Controls.Add(btArticleModifier);
            flowLayoutPanel1.Controls.Add(btArticleSupprimer);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(8, 690);
            flowLayoutPanel1.Margin = new Padding(8, 9, 8, 9);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1432, 144);
            flowLayoutPanel1.TabIndex = 1;
            flowLayoutPanel1.WrapContents = false;
            // 
            // btArticleActualiser
            // 
            btArticleActualiser.Image = Properties.Resources.Synchroniser_48;
            btArticleActualiser.ImageAlign = ContentAlignment.MiddleLeft;
            btArticleActualiser.Location = new Point(8, 9);
            btArticleActualiser.Margin = new Padding(8, 9, 50, 9);
            btArticleActualiser.Name = "btArticleActualiser";
            btArticleActualiser.Size = new Size(277, 126);
            btArticleActualiser.TabIndex = 0;
            btArticleActualiser.Text = "&Actualiser";
            btArticleActualiser.TextAlign = ContentAlignment.MiddleRight;
            btArticleActualiser.UseVisualStyleBackColor = true;
            btArticleActualiser.Click += btArticleActualiser_Click;
            // 
            // btArticleAjouter
            // 
            btArticleAjouter.Image = Properties.Resources.Ajouter;
            btArticleAjouter.ImageAlign = ContentAlignment.MiddleLeft;
            btArticleAjouter.Location = new Point(343, 9);
            btArticleAjouter.Margin = new Padding(8, 9, 8, 9);
            btArticleAjouter.Name = "btArticleAjouter";
            btArticleAjouter.Size = new Size(277, 126);
            btArticleAjouter.TabIndex = 1;
            btArticleAjouter.Text = "A&jouter";
            btArticleAjouter.TextAlign = ContentAlignment.MiddleRight;
            btArticleAjouter.TextImageRelation = TextImageRelation.ImageBeforeText;
            btArticleAjouter.UseVisualStyleBackColor = true;
            btArticleAjouter.Click += btArticleAjouter_Click;
            // 
            // btArticleModifier
            // 
            btArticleModifier.Image = Properties.Resources.Modifier;
            btArticleModifier.ImageAlign = ContentAlignment.MiddleLeft;
            btArticleModifier.Location = new Point(636, 9);
            btArticleModifier.Margin = new Padding(8, 9, 8, 9);
            btArticleModifier.Name = "btArticleModifier";
            btArticleModifier.Size = new Size(277, 126);
            btArticleModifier.TabIndex = 2;
            btArticleModifier.Text = "&Modifier";
            btArticleModifier.TextAlign = ContentAlignment.MiddleRight;
            btArticleModifier.UseVisualStyleBackColor = true;
            btArticleModifier.Click += btArticleModifier_Click;
            // 
            // btArticleSupprimer
            // 
            btArticleSupprimer.Image = Properties.Resources.Supprimer;
            btArticleSupprimer.ImageAlign = ContentAlignment.MiddleLeft;
            btArticleSupprimer.Location = new Point(929, 9);
            btArticleSupprimer.Margin = new Padding(8, 9, 8, 9);
            btArticleSupprimer.Name = "btArticleSupprimer";
            btArticleSupprimer.Size = new Size(277, 126);
            btArticleSupprimer.TabIndex = 3;
            btArticleSupprimer.Text = "&Supprimer";
            btArticleSupprimer.TextAlign = ContentAlignment.MiddleRight;
            btArticleSupprimer.UseVisualStyleBackColor = true;
            btArticleSupprimer.Click += btArticleSupprimer_Click;
            // 
            // tabJournaux
            // 
            tabJournaux.BackColor = SystemColors.Control;
            tabJournaux.Location = new Point(4, 53);
            tabJournaux.Name = "tabJournaux";
            tabJournaux.Padding = new Padding(3);
            tabJournaux.Size = new Size(1454, 849);
            tabJournaux.TabIndex = 1;
            tabJournaux.Text = "Journaux";
            // 
            // tabCompositions
            // 
            tabCompositions.BackColor = SystemColors.Control;
            tabCompositions.Location = new Point(4, 53);
            tabCompositions.Name = "tabCompositions";
            tabCompositions.Padding = new Padding(3);
            tabCompositions.Size = new Size(1454, 849);
            tabCompositions.TabIndex = 2;
            tabCompositions.Text = "Compositions";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1468, 912);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1500, 1000);
            Name = "frmMain";
            Text = "Edito";
            Load += frmMain_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tabEdito.ResumeLayout(false);
            tabArticles.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvArticles).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BSArticles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TabControl tabEdito;
        private TabPage tabArticles;
        private TabPage tabJournaux;
        private TabPage tabCompositions;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridView dgvArticles;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btArticleActualiser;
        private BindingSource BSArticles;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtTitreArticle;
        private TextBox txtCorpsArticle;
        private TextBox txtAuteurArticle;
        private Button btArticleAjouter;
        private Button btArticleModifier;
        private Button btArticleSupprimer;
    }
}
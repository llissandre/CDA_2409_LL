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
            Button btJournalCompositionExclure;
            Button btJournalCompositionInclure;
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
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
            tableLayoutPanel4 = new TableLayoutPanel();
            dgvJournaux = new DataGridView();
            tableLayoutPanel5 = new TableLayoutPanel();
            label4 = new Label();
            label5 = new Label();
            txtTitreJournal = new TextBox();
            dtpDtParutionJournal = new DateTimePicker();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btJournalActualiser = new Button();
            btJournalAjouter = new Button();
            btJournalModifier = new Button();
            btJournalSupprimer = new Button();
            tabCompositions = new TabPage();
            tableLayoutPanel6 = new TableLayoutPanel();
            btJournalCompositionActualiser = new Button();
            gbxArticlesOut = new GroupBox();
            dgvArticlesNotInJournal = new DataGridView();
            gbxArticlesIn = new GroupBox();
            dgvArticlesInJournal = new DataGridView();
            gbxJournauxCompo = new GroupBox();
            dgvJournalComposition = new DataGridView();
            BSArticles = new BindingSource(components);
            BSJournaux = new BindingSource(components);
            BSJournauxCompo = new BindingSource(components);
            BSArticlesInJournal = new BindingSource(components);
            BSArticlesNotInJournal = new BindingSource(components);
            btJournalCompositionExclure = new Button();
            btJournalCompositionInclure = new Button();
            tableLayoutPanel1.SuspendLayout();
            tabEdito.SuspendLayout();
            tabArticles.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvArticles).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tabJournaux.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvJournaux).BeginInit();
            tableLayoutPanel5.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            tabCompositions.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            gbxArticlesOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvArticlesNotInJournal).BeginInit();
            gbxArticlesIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvArticlesInJournal).BeginInit();
            gbxJournauxCompo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvJournalComposition).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BSArticles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BSJournaux).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BSJournauxCompo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BSArticlesInJournal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BSArticlesNotInJournal).BeginInit();
            SuspendLayout();
            // 
            // btJournalCompositionExclure
            // 
            btJournalCompositionExclure.Anchor = AnchorStyles.None;
            btJournalCompositionExclure.AutoSize = true;
            btJournalCompositionExclure.Image = Properties.Resources.Supprimer;
            btJournalCompositionExclure.ImageAlign = ContentAlignment.MiddleLeft;
            btJournalCompositionExclure.Location = new Point(1482, 111);
            btJournalCompositionExclure.Margin = new Padding(30, 3, 3, 3);
            btJournalCompositionExclure.Name = "btJournalCompositionExclure";
            btJournalCompositionExclure.Size = new Size(277, 126);
            btJournalCompositionExclure.TabIndex = 4;
            btJournalCompositionExclure.Text = "&Exclure";
            btJournalCompositionExclure.TextAlign = ContentAlignment.MiddleRight;
            btJournalCompositionExclure.UseVisualStyleBackColor = true;
            btJournalCompositionExclure.Click += btJournalCompositionExclure_Click;
            // 
            // btJournalCompositionInclure
            // 
            btJournalCompositionInclure.Anchor = AnchorStyles.None;
            btJournalCompositionInclure.AutoSize = true;
            btJournalCompositionInclure.Image = Properties.Resources.Ajouter;
            btJournalCompositionInclure.ImageAlign = ContentAlignment.MiddleLeft;
            btJournalCompositionInclure.Location = new Point(1482, 460);
            btJournalCompositionInclure.Margin = new Padding(30, 3, 3, 3);
            btJournalCompositionInclure.Name = "btJournalCompositionInclure";
            btJournalCompositionInclure.Size = new Size(277, 126);
            btJournalCompositionInclure.TabIndex = 5;
            btJournalCompositionInclure.Text = "&Inclure";
            btJournalCompositionInclure.TextAlign = ContentAlignment.MiddleRight;
            btJournalCompositionInclure.UseVisualStyleBackColor = true;
            btJournalCompositionInclure.Click += btJournalCompositionInclure_Click;
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
            tableLayoutPanel1.Size = new Size(1782, 912);
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
            tabEdito.Size = new Size(1776, 906);
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
            tabArticles.Size = new Size(1768, 849);
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
            tableLayoutPanel2.Size = new Size(1762, 843);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // dgvArticles
            // 
            dgvArticles.AllowUserToAddRows = false;
            dgvArticles.AllowUserToDeleteRows = false;
            dgvArticles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvArticles.BackgroundColor = SystemColors.Control;
            dgvArticles.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.LightCyan;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = Color.LightCyan;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvArticles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
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
            dgvArticles.Size = new Size(1746, 427);
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
            tableLayoutPanel3.Size = new Size(1756, 230);
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
            txtTitreArticle.Size = new Size(1637, 47);
            txtTitreArticle.TabIndex = 3;
            // 
            // txtCorpsArticle
            // 
            txtCorpsArticle.Dock = DockStyle.Fill;
            txtCorpsArticle.Location = new Point(116, 56);
            txtCorpsArticle.Multiline = true;
            txtCorpsArticle.Name = "txtCorpsArticle";
            txtCorpsArticle.Size = new Size(1637, 118);
            txtCorpsArticle.TabIndex = 4;
            // 
            // txtAuteurArticle
            // 
            txtAuteurArticle.Dock = DockStyle.Fill;
            txtAuteurArticle.Location = new Point(116, 180);
            txtAuteurArticle.Name = "txtAuteurArticle";
            txtAuteurArticle.Size = new Size(1637, 47);
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
            flowLayoutPanel1.Size = new Size(1746, 144);
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
            tabJournaux.Controls.Add(tableLayoutPanel4);
            tabJournaux.Location = new Point(4, 53);
            tabJournaux.Name = "tabJournaux";
            tabJournaux.Padding = new Padding(3);
            tabJournaux.Size = new Size(1768, 849);
            tabJournaux.TabIndex = 1;
            tabJournaux.Text = "Journaux";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(dgvJournaux, 0, 0);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 1);
            tableLayoutPanel4.Controls.Add(flowLayoutPanel2, 0, 2);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Margin = new Padding(8, 9, 8, 9);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.Size = new Size(1762, 843);
            tableLayoutPanel4.TabIndex = 3;
            // 
            // dgvJournaux
            // 
            dgvJournaux.AllowUserToAddRows = false;
            dgvJournaux.AllowUserToDeleteRows = false;
            dgvJournaux.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvJournaux.BackgroundColor = SystemColors.Control;
            dgvJournaux.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.LightCyan;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = Color.LightCyan;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvJournaux.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvJournaux.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJournaux.Dock = DockStyle.Fill;
            dgvJournaux.EnableHeadersVisualStyles = false;
            dgvJournaux.Location = new Point(8, 9);
            dgvJournaux.Margin = new Padding(8, 9, 8, 9);
            dgvJournaux.MultiSelect = false;
            dgvJournaux.Name = "dgvJournaux";
            dgvJournaux.ReadOnly = true;
            dgvJournaux.RowHeadersVisible = false;
            dgvJournaux.RowHeadersWidth = 102;
            dgvJournaux.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvJournaux.Size = new Size(1746, 551);
            dgvJournaux.StandardTab = true;
            dgvJournaux.TabIndex = 2;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.AutoSize = true;
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(label4, 0, 0);
            tableLayoutPanel5.Controls.Add(label5, 0, 1);
            tableLayoutPanel5.Controls.Add(txtTitreJournal, 1, 0);
            tableLayoutPanel5.Controls.Add(dtpDtParutionJournal, 1, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 572);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.Size = new Size(1756, 106);
            tableLayoutPanel5.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(242, 53);
            label4.TabIndex = 0;
            label4.Text = "Titre";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(3, 53);
            label5.Name = "label5";
            label5.Size = new Size(242, 53);
            label5.TabIndex = 1;
            label5.Text = "Date de parution";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtTitreJournal
            // 
            txtTitreJournal.Dock = DockStyle.Fill;
            txtTitreJournal.Location = new Point(251, 3);
            txtTitreJournal.Name = "txtTitreJournal";
            txtTitreJournal.Size = new Size(1502, 47);
            txtTitreJournal.TabIndex = 3;
            // 
            // dtpDtParutionJournal
            // 
            dtpDtParutionJournal.Dock = DockStyle.Fill;
            dtpDtParutionJournal.Location = new Point(251, 56);
            dtpDtParutionJournal.Name = "dtpDtParutionJournal";
            dtpDtParutionJournal.ShowCheckBox = true;
            dtpDtParutionJournal.Size = new Size(1502, 47);
            dtpDtParutionJournal.TabIndex = 4;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.Controls.Add(btJournalActualiser);
            flowLayoutPanel2.Controls.Add(btJournalAjouter);
            flowLayoutPanel2.Controls.Add(btJournalModifier);
            flowLayoutPanel2.Controls.Add(btJournalSupprimer);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(8, 690);
            flowLayoutPanel2.Margin = new Padding(8, 9, 8, 9);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1746, 144);
            flowLayoutPanel2.TabIndex = 1;
            flowLayoutPanel2.WrapContents = false;
            // 
            // btJournalActualiser
            // 
            btJournalActualiser.Image = Properties.Resources.Synchroniser_48;
            btJournalActualiser.ImageAlign = ContentAlignment.MiddleLeft;
            btJournalActualiser.Location = new Point(8, 9);
            btJournalActualiser.Margin = new Padding(8, 9, 50, 9);
            btJournalActualiser.Name = "btJournalActualiser";
            btJournalActualiser.Size = new Size(277, 126);
            btJournalActualiser.TabIndex = 0;
            btJournalActualiser.Text = "&Actualiser";
            btJournalActualiser.TextAlign = ContentAlignment.MiddleRight;
            btJournalActualiser.UseVisualStyleBackColor = true;
            btJournalActualiser.Click += btJournalActualiser_Click;
            // 
            // btJournalAjouter
            // 
            btJournalAjouter.Image = Properties.Resources.Ajouter;
            btJournalAjouter.ImageAlign = ContentAlignment.MiddleLeft;
            btJournalAjouter.Location = new Point(343, 9);
            btJournalAjouter.Margin = new Padding(8, 9, 8, 9);
            btJournalAjouter.Name = "btJournalAjouter";
            btJournalAjouter.Size = new Size(277, 126);
            btJournalAjouter.TabIndex = 1;
            btJournalAjouter.Text = "A&jouter";
            btJournalAjouter.TextAlign = ContentAlignment.MiddleRight;
            btJournalAjouter.TextImageRelation = TextImageRelation.ImageBeforeText;
            btJournalAjouter.UseVisualStyleBackColor = true;
            btJournalAjouter.Click += btJournalAjouter_Click;
            // 
            // btJournalModifier
            // 
            btJournalModifier.Image = Properties.Resources.Modifier;
            btJournalModifier.ImageAlign = ContentAlignment.MiddleLeft;
            btJournalModifier.Location = new Point(636, 9);
            btJournalModifier.Margin = new Padding(8, 9, 8, 9);
            btJournalModifier.Name = "btJournalModifier";
            btJournalModifier.Size = new Size(277, 126);
            btJournalModifier.TabIndex = 2;
            btJournalModifier.Text = "&Modifier";
            btJournalModifier.TextAlign = ContentAlignment.MiddleRight;
            btJournalModifier.UseVisualStyleBackColor = true;
            btJournalModifier.Click += btJournalModifier_Click;
            // 
            // btJournalSupprimer
            // 
            btJournalSupprimer.Image = Properties.Resources.Supprimer;
            btJournalSupprimer.ImageAlign = ContentAlignment.MiddleLeft;
            btJournalSupprimer.Location = new Point(929, 9);
            btJournalSupprimer.Margin = new Padding(8, 9, 8, 9);
            btJournalSupprimer.Name = "btJournalSupprimer";
            btJournalSupprimer.Size = new Size(277, 126);
            btJournalSupprimer.TabIndex = 3;
            btJournalSupprimer.Text = "&Supprimer";
            btJournalSupprimer.TextAlign = ContentAlignment.MiddleRight;
            btJournalSupprimer.UseVisualStyleBackColor = true;
            btJournalSupprimer.Click += btJournalSupprimer_Click;
            // 
            // tabCompositions
            // 
            tabCompositions.BackColor = SystemColors.Control;
            tabCompositions.Controls.Add(tableLayoutPanel6);
            tabCompositions.Location = new Point(4, 53);
            tabCompositions.Name = "tabCompositions";
            tabCompositions.Padding = new Padding(3);
            tabCompositions.Size = new Size(1768, 849);
            tabCompositions.TabIndex = 2;
            tabCompositions.Text = "Compositions";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 3;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel6.Controls.Add(btJournalCompositionActualiser, 0, 2);
            tableLayoutPanel6.Controls.Add(btJournalCompositionInclure, 2, 1);
            tableLayoutPanel6.Controls.Add(btJournalCompositionExclure, 2, 0);
            tableLayoutPanel6.Controls.Add(gbxArticlesOut, 1, 1);
            tableLayoutPanel6.Controls.Add(gbxArticlesIn, 1, 0);
            tableLayoutPanel6.Controls.Add(gbxJournauxCompo, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 3;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle());
            tableLayoutPanel6.Size = new Size(1762, 843);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // btJournalCompositionActualiser
            // 
            btJournalCompositionActualiser.Anchor = AnchorStyles.None;
            btJournalCompositionActualiser.Image = Properties.Resources.Synchroniser_48;
            btJournalCompositionActualiser.ImageAlign = ContentAlignment.MiddleLeft;
            btJournalCompositionActualiser.Location = new Point(203, 707);
            btJournalCompositionActualiser.Margin = new Padding(8, 9, 50, 9);
            btJournalCompositionActualiser.Name = "btJournalCompositionActualiser";
            btJournalCompositionActualiser.Size = new Size(277, 126);
            btJournalCompositionActualiser.TabIndex = 4;
            btJournalCompositionActualiser.Text = "&Actualiser";
            btJournalCompositionActualiser.TextAlign = ContentAlignment.MiddleRight;
            btJournalCompositionActualiser.UseVisualStyleBackColor = true;
            btJournalCompositionActualiser.Click += btJournalCompositionActualiser_Click;
            // 
            // gbxArticlesOut
            // 
            gbxArticlesOut.AutoSize = true;
            gbxArticlesOut.Controls.Add(dgvArticlesNotInJournal);
            gbxArticlesOut.Dock = DockStyle.Fill;
            gbxArticlesOut.Location = new Point(729, 352);
            gbxArticlesOut.Name = "gbxArticlesOut";
            gbxArticlesOut.Size = new Size(720, 343);
            gbxArticlesOut.TabIndex = 2;
            gbxArticlesOut.TabStop = false;
            gbxArticlesOut.Text = "Articles exclus";
            // 
            // dgvArticlesNotInJournal
            // 
            dgvArticlesNotInJournal.AllowUserToAddRows = false;
            dgvArticlesNotInJournal.AllowUserToDeleteRows = false;
            dgvArticlesNotInJournal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvArticlesNotInJournal.BackgroundColor = SystemColors.Control;
            dgvArticlesNotInJournal.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.LightCyan;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = Color.LightCyan;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgvArticlesNotInJournal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgvArticlesNotInJournal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArticlesNotInJournal.Dock = DockStyle.Fill;
            dgvArticlesNotInJournal.EnableHeadersVisualStyles = false;
            dgvArticlesNotInJournal.Location = new Point(3, 43);
            dgvArticlesNotInJournal.Margin = new Padding(8, 9, 8, 9);
            dgvArticlesNotInJournal.MultiSelect = false;
            dgvArticlesNotInJournal.Name = "dgvArticlesNotInJournal";
            dgvArticlesNotInJournal.ReadOnly = true;
            dgvArticlesNotInJournal.RowHeadersVisible = false;
            dgvArticlesNotInJournal.RowHeadersWidth = 102;
            dgvArticlesNotInJournal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvArticlesNotInJournal.Size = new Size(714, 297);
            dgvArticlesNotInJournal.StandardTab = true;
            dgvArticlesNotInJournal.TabIndex = 5;
            // 
            // gbxArticlesIn
            // 
            gbxArticlesIn.AutoSize = true;
            gbxArticlesIn.Controls.Add(dgvArticlesInJournal);
            gbxArticlesIn.Dock = DockStyle.Fill;
            gbxArticlesIn.Location = new Point(729, 3);
            gbxArticlesIn.Name = "gbxArticlesIn";
            gbxArticlesIn.Size = new Size(720, 343);
            gbxArticlesIn.TabIndex = 1;
            gbxArticlesIn.TabStop = false;
            gbxArticlesIn.Text = "Articles inclus";
            // 
            // dgvArticlesInJournal
            // 
            dgvArticlesInJournal.AllowUserToAddRows = false;
            dgvArticlesInJournal.AllowUserToDeleteRows = false;
            dgvArticlesInJournal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvArticlesInJournal.BackgroundColor = SystemColors.Control;
            dgvArticlesInJournal.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.LightCyan;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = Color.LightCyan;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvArticlesInJournal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvArticlesInJournal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArticlesInJournal.Dock = DockStyle.Fill;
            dgvArticlesInJournal.EnableHeadersVisualStyles = false;
            dgvArticlesInJournal.Location = new Point(3, 43);
            dgvArticlesInJournal.Margin = new Padding(8, 9, 8, 9);
            dgvArticlesInJournal.MultiSelect = false;
            dgvArticlesInJournal.Name = "dgvArticlesInJournal";
            dgvArticlesInJournal.ReadOnly = true;
            dgvArticlesInJournal.RowHeadersVisible = false;
            dgvArticlesInJournal.RowHeadersWidth = 102;
            dgvArticlesInJournal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvArticlesInJournal.Size = new Size(714, 297);
            dgvArticlesInJournal.StandardTab = true;
            dgvArticlesInJournal.TabIndex = 4;
            // 
            // gbxJournauxCompo
            // 
            gbxJournauxCompo.AutoSize = true;
            gbxJournauxCompo.Controls.Add(dgvJournalComposition);
            gbxJournauxCompo.Dock = DockStyle.Fill;
            gbxJournauxCompo.Location = new Point(3, 3);
            gbxJournauxCompo.Name = "gbxJournauxCompo";
            tableLayoutPanel6.SetRowSpan(gbxJournauxCompo, 2);
            gbxJournauxCompo.Size = new Size(720, 692);
            gbxJournauxCompo.TabIndex = 0;
            gbxJournauxCompo.TabStop = false;
            gbxJournauxCompo.Text = "Journaux";
            // 
            // dgvJournalComposition
            // 
            dgvJournalComposition.AllowUserToAddRows = false;
            dgvJournalComposition.AllowUserToDeleteRows = false;
            dgvJournalComposition.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvJournalComposition.BackgroundColor = SystemColors.Control;
            dgvJournalComposition.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.LightCyan;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = Color.LightCyan;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dgvJournalComposition.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dgvJournalComposition.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJournalComposition.Dock = DockStyle.Fill;
            dgvJournalComposition.EnableHeadersVisualStyles = false;
            dgvJournalComposition.Location = new Point(3, 43);
            dgvJournalComposition.Margin = new Padding(8, 9, 8, 9);
            dgvJournalComposition.MultiSelect = false;
            dgvJournalComposition.Name = "dgvJournalComposition";
            dgvJournalComposition.ReadOnly = true;
            dgvJournalComposition.RowHeadersVisible = false;
            dgvJournalComposition.RowHeadersWidth = 102;
            dgvJournalComposition.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvJournalComposition.Size = new Size(714, 646);
            dgvJournalComposition.StandardTab = true;
            dgvJournalComposition.TabIndex = 3;
            // 
            // BSJournauxCompo
            // 
            BSJournauxCompo.CurrentChanged += BSJournauxCompo_CurrentChanged;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1782, 912);
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
            tabJournaux.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvJournaux).EndInit();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            tabCompositions.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            gbxArticlesOut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvArticlesNotInJournal).EndInit();
            gbxArticlesIn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvArticlesInJournal).EndInit();
            gbxJournauxCompo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvJournalComposition).EndInit();
            ((System.ComponentModel.ISupportInitialize)BSArticles).EndInit();
            ((System.ComponentModel.ISupportInitialize)BSJournaux).EndInit();
            ((System.ComponentModel.ISupportInitialize)BSJournauxCompo).EndInit();
            ((System.ComponentModel.ISupportInitialize)BSArticlesInJournal).EndInit();
            ((System.ComponentModel.ISupportInitialize)BSArticlesNotInJournal).EndInit();
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
        private TableLayoutPanel tableLayoutPanel4;
        private DataGridView dgvJournaux;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label4;
        private Label label5;
        private TextBox txtTitreJournal;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btJournalActualiser;
        private Button btJournalAjouter;
        private Button btJournalModifier;
        private Button btJournalSupprimer;
        private DateTimePicker dtpDtParutionJournal;
        private BindingSource BSJournaux;
        private TableLayoutPanel tableLayoutPanel6;
        private GroupBox gbxJournauxCompo;
        private GroupBox gbxArticlesOut;
        private GroupBox gbxArticlesIn;
        private DataGridView dgvJournalComposition;
        private Button btJournalCompositionActualiser;
        private BindingSource BSJournauxCompo;
        private BindingSource BSArticlesInJournal;
        private DataGridView dgvArticlesInJournal;
        private BindingSource BSArticlesNotInJournal;
        private DataGridView dgvArticlesNotInJournal;
    }
}
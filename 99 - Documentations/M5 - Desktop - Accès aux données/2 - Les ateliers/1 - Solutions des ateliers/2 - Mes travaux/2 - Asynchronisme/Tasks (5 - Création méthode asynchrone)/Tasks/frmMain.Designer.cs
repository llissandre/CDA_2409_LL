namespace Tasks
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btSynchrone = new Button();
            lbxNombres = new ListBox();
            lblTempo = new Label();
            btAsynchrone = new Button();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 1);
            tableLayoutPanel1.Controls.Add(lbxNombres, 0, 0);
            tableLayoutPanel1.Controls.Add(lblTempo, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(950, 657);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.None;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(btSynchrone);
            flowLayoutPanel1.Controls.Add(btAsynchrone);
            flowLayoutPanel1.Location = new Point(112, 536);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(496, 118);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // lbxNombres
            // 
            tableLayoutPanel1.SetColumnSpan(lbxNombres, 2);
            lbxNombres.Dock = DockStyle.Fill;
            lbxNombres.FormattingEnabled = true;
            lbxNombres.IntegralHeight = false;
            lbxNombres.ItemHeight = 41;
            lbxNombres.Location = new Point(3, 3);
            lbxNombres.Name = "lbxNombres";
            lbxNombres.Size = new Size(944, 527);
            lbxNombres.TabIndex = 1;
            // 
            // lblTempo
            // 
            lblTempo.AutoSize = true;
            lblTempo.Dock = DockStyle.Fill;
            lblTempo.Location = new Point(724, 533);
            lblTempo.Name = "lblTempo";
            lblTempo.Size = new Size(223, 124);
            lblTempo.TabIndex = 2;
            lblTempo.Text = "Temps écoulé : ";
            lblTempo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btAsynchrone
            // 
            btAsynchrone.Location = new Point(278, 30);
            btAsynchrone.Margin = new Padding(30);
            btAsynchrone.Name = "btAsynchrone";
            btAsynchrone.Size = new Size(188, 58);
            btAsynchrone.TabIndex = 1;
            btAsynchrone.Text = "Asynchrone";
            btAsynchrone.UseVisualStyleBackColor = true;
            btAsynchrone.Click += btAsynchrone_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 657);
            Controls.Add(tableLayoutPanel1);
            Name = "frmMain";
            Text = "Tasks";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btSynchrone;
        private ListBox lbxNombres;
        private Label lblTempo;
        private Button btAsynchrone;
    }
}
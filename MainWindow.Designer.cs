namespace PDFTool
{
    partial class MainForm
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
            TabControl = new TabControl();
            TabMerger = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            listBoxDocuments = new ListBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            buttonSelectDocuments = new Button();
            buttonMergeDocuments = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            buttonRemove = new Button();
            buttonMoveUp = new Button();
            buttonMoveDown = new Button();
            pictureBoxPreview = new PictureBox();
            tabPage2 = new TabPage();
            TabControl.SuspendLayout();
            TabMerger.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPreview).BeginInit();
            SuspendLayout();
            // 
            // TabControl
            // 
            TabControl.Controls.Add(TabMerger);
            TabControl.Controls.Add(tabPage2);
            TabControl.Dock = DockStyle.Fill;
            TabControl.Font = new Font("Segoe UI", 12F);
            TabControl.Location = new Point(0, 0);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(1494, 1258);
            TabControl.TabIndex = 0;
            // 
            // TabMerger
            // 
            TabMerger.Controls.Add(tableLayoutPanel2);
            TabMerger.Location = new Point(4, 41);
            TabMerger.Name = "TabMerger";
            TabMerger.Padding = new Padding(3);
            TabMerger.Size = new Size(1486, 1213);
            TabMerger.TabIndex = 0;
            TabMerger.Text = "Merge";
            TabMerger.UseVisualStyleBackColor = true;
            TabMerger.Enter += TabMerger_Enter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(listBoxDocuments, 0, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 1, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tableLayoutPanel2.Size = new Size(1480, 1207);
            tableLayoutPanel2.TabIndex = 7;
            // 
            // listBoxDocuments
            // 
            listBoxDocuments.Dock = DockStyle.Fill;
            listBoxDocuments.FormattingEnabled = true;
            listBoxDocuments.ItemHeight = 32;
            listBoxDocuments.Location = new Point(3, 184);
            listBoxDocuments.Name = "listBoxDocuments";
            listBoxDocuments.Size = new Size(1104, 1020);
            listBoxDocuments.TabIndex = 2;
            listBoxDocuments.SelectedIndexChanged += listBoxDocuments_SelectedIndexChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(buttonSelectDocuments, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonMergeDocuments, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1104, 175);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // buttonSelectDocuments
            // 
            buttonSelectDocuments.Dock = DockStyle.Fill;
            buttonSelectDocuments.Location = new Point(3, 3);
            buttonSelectDocuments.Name = "buttonSelectDocuments";
            buttonSelectDocuments.Size = new Size(546, 169);
            buttonSelectDocuments.TabIndex = 0;
            buttonSelectDocuments.Text = "Select Documents";
            buttonSelectDocuments.UseVisualStyleBackColor = true;
            buttonSelectDocuments.Click += buttonSelectDocuments_Click;
            // 
            // buttonMergeDocuments
            // 
            buttonMergeDocuments.Dock = DockStyle.Fill;
            buttonMergeDocuments.Enabled = false;
            buttonMergeDocuments.Location = new Point(555, 3);
            buttonMergeDocuments.Name = "buttonMergeDocuments";
            buttonMergeDocuments.Size = new Size(546, 169);
            buttonMergeDocuments.TabIndex = 1;
            buttonMergeDocuments.Text = "Merge Documents";
            buttonMergeDocuments.UseVisualStyleBackColor = true;
            buttonMergeDocuments.Click += buttonMergeDocuments_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(buttonRemove, 0, 3);
            tableLayoutPanel3.Controls.Add(buttonMoveUp, 0, 1);
            tableLayoutPanel3.Controls.Add(buttonMoveDown, 0, 2);
            tableLayoutPanel3.Controls.Add(pictureBoxPreview, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(1113, 184);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.Size = new Size(364, 1020);
            tableLayoutPanel3.TabIndex = 7;
            // 
            // buttonRemove
            // 
            buttonRemove.Dock = DockStyle.Fill;
            buttonRemove.Enabled = false;
            buttonRemove.Location = new Point(3, 819);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(358, 198);
            buttonRemove.TabIndex = 5;
            buttonRemove.Text = "🗑️";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // buttonMoveUp
            // 
            buttonMoveUp.Dock = DockStyle.Fill;
            buttonMoveUp.Enabled = false;
            buttonMoveUp.Location = new Point(3, 411);
            buttonMoveUp.Name = "buttonMoveUp";
            buttonMoveUp.Size = new Size(358, 198);
            buttonMoveUp.TabIndex = 3;
            buttonMoveUp.Text = "↑";
            buttonMoveUp.UseVisualStyleBackColor = true;
            buttonMoveUp.Click += buttonMoveUp_Click;
            // 
            // buttonMoveDown
            // 
            buttonMoveDown.Dock = DockStyle.Fill;
            buttonMoveDown.Enabled = false;
            buttonMoveDown.Location = new Point(3, 615);
            buttonMoveDown.Name = "buttonMoveDown";
            buttonMoveDown.Size = new Size(358, 198);
            buttonMoveDown.TabIndex = 4;
            buttonMoveDown.Text = "↓";
            buttonMoveDown.UseVisualStyleBackColor = true;
            buttonMoveDown.Click += buttonMoveDown_Click;
            // 
            // pictureBoxPreview
            // 
            pictureBoxPreview.Dock = DockStyle.Fill;
            pictureBoxPreview.Location = new Point(3, 3);
            pictureBoxPreview.Name = "pictureBoxPreview";
            pictureBoxPreview.Size = new Size(358, 402);
            pictureBoxPreview.TabIndex = 6;
            pictureBoxPreview.TabStop = false;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 41);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1486, 1213);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Slice";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1494, 1258);
            Controls.Add(TabControl);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PDFTool";
            TabControl.ResumeLayout(false);
            TabMerger.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxPreview).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl TabControl;
        private TabPage TabMerger;
        private TabPage tabPage2;
        private Button buttonSelectDocuments;
        private Button buttonMergeDocuments;
        private Button buttonRemove;
        private Button buttonMoveDown;
        private Button buttonMoveUp;
        private ListBox listBoxDocuments;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel3;
        private PictureBox pictureBoxPreview;
    }
}

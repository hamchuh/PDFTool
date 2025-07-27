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


        private void InitializeComponent()
        {
            TabControl = new TabControl();
            TabMerger = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            listBoxDocuments = new ListBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            buttonSelectDocumentsToMerge = new Button();
            buttonMergeDocuments = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            buttonRemove = new Button();
            buttonMoveUp = new Button();
            buttonMoveDown = new Button();
            pictureBoxPreview = new PictureBox();
            TabToImages = new TabPage();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            buttonConvert = new Button();
            buttonSelectDocumentToSlice = new Button();
            panelPagesToSlice = new Panel();
            groupBoxPreferences = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            numberImageQuality = new NumericUpDown();
            numberJPEGQuality = new NumericUpDown();
            label1 = new Label();
            numberPageTo = new NumericUpDown();
            numberPageFrom = new NumericUpDown();
            comboBoxFileFormat = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            TabControl.SuspendLayout();
            TabMerger.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPreview).BeginInit();
            TabToImages.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            panelPagesToSlice.SuspendLayout();
            groupBoxPreferences.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numberImageQuality).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numberJPEGQuality).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numberPageTo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numberPageFrom).BeginInit();
            SuspendLayout();
            // 
            // TabControl
            // 
            TabControl.Controls.Add(TabMerger);
            TabControl.Controls.Add(TabToImages);
            TabControl.Dock = DockStyle.Fill;
            TabControl.Font = new Font("Segoe UI", 12F);
            TabControl.Location = new Point(0, 0);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(1000, 1200);
            TabControl.TabIndex = 0;
            // 
            // TabMerger
            // 
            TabMerger.Controls.Add(tableLayoutPanel2);
            TabMerger.Location = new Point(4, 41);
            TabMerger.Name = "TabMerger";
            TabMerger.Padding = new Padding(3);
            TabMerger.Size = new Size(992, 1155);
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
            tableLayoutPanel2.Size = new Size(986, 1149);
            tableLayoutPanel2.TabIndex = 7;
            // 
            // listBoxDocuments
            // 
            listBoxDocuments.Dock = DockStyle.Fill;
            listBoxDocuments.FormattingEnabled = true;
            listBoxDocuments.ItemHeight = 32;
            listBoxDocuments.Location = new Point(3, 175);
            listBoxDocuments.Name = "listBoxDocuments";
            listBoxDocuments.Size = new Size(733, 971);
            listBoxDocuments.TabIndex = 2;
            listBoxDocuments.SelectedIndexChanged += listBoxDocuments_SelectedIndexChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(buttonSelectDocumentsToMerge, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonMergeDocuments, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(733, 166);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // buttonSelectDocumentsToMerge
            // 
            buttonSelectDocumentsToMerge.Dock = DockStyle.Fill;
            buttonSelectDocumentsToMerge.Location = new Point(3, 3);
            buttonSelectDocumentsToMerge.Name = "buttonSelectDocumentsToMerge";
            buttonSelectDocumentsToMerge.Size = new Size(360, 160);
            buttonSelectDocumentsToMerge.TabIndex = 0;
            buttonSelectDocumentsToMerge.Text = "Select Documents";
            buttonSelectDocumentsToMerge.UseVisualStyleBackColor = true;
            buttonSelectDocumentsToMerge.Click += buttonSelectDocuments_Click;
            // 
            // buttonMergeDocuments
            // 
            buttonMergeDocuments.Dock = DockStyle.Fill;
            buttonMergeDocuments.Enabled = false;
            buttonMergeDocuments.Location = new Point(369, 3);
            buttonMergeDocuments.Name = "buttonMergeDocuments";
            buttonMergeDocuments.Size = new Size(361, 160);
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
            tableLayoutPanel3.Location = new Point(742, 175);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.Size = new Size(241, 971);
            tableLayoutPanel3.TabIndex = 7;
            // 
            // buttonRemove
            // 
            buttonRemove.Dock = DockStyle.Fill;
            buttonRemove.Enabled = false;
            buttonRemove.Location = new Point(3, 779);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(235, 189);
            buttonRemove.TabIndex = 5;
            buttonRemove.Text = "🗑️";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // buttonMoveUp
            // 
            buttonMoveUp.Dock = DockStyle.Fill;
            buttonMoveUp.Enabled = false;
            buttonMoveUp.Location = new Point(3, 391);
            buttonMoveUp.Name = "buttonMoveUp";
            buttonMoveUp.Size = new Size(235, 188);
            buttonMoveUp.TabIndex = 3;
            buttonMoveUp.Text = "↑";
            buttonMoveUp.UseVisualStyleBackColor = true;
            buttonMoveUp.Click += buttonMoveUp_Click;
            // 
            // buttonMoveDown
            // 
            buttonMoveDown.Dock = DockStyle.Fill;
            buttonMoveDown.Enabled = false;
            buttonMoveDown.Location = new Point(3, 585);
            buttonMoveDown.Name = "buttonMoveDown";
            buttonMoveDown.Size = new Size(235, 188);
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
            pictureBoxPreview.Size = new Size(235, 382);
            pictureBoxPreview.TabIndex = 6;
            pictureBoxPreview.TabStop = false;
            // 
            // TabToImages
            // 
            TabToImages.Controls.Add(tableLayoutPanel4);
            TabToImages.Location = new Point(4, 41);
            TabToImages.Name = "TabToImages";
            TabToImages.Padding = new Padding(3);
            TabToImages.Size = new Size(992, 1155);
            TabToImages.TabIndex = 1;
            TabToImages.Text = "PDF To Images";
            TabToImages.UseVisualStyleBackColor = true;
            TabToImages.Enter += TabToImages_Enter;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 0);
            tableLayoutPanel4.Controls.Add(panelPagesToSlice, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tableLayoutPanel4.Size = new Size(986, 1149);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(buttonConvert, 1, 0);
            tableLayoutPanel5.Controls.Add(buttonSelectDocumentToSlice, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(980, 166);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // buttonConvert
            // 
            buttonConvert.Dock = DockStyle.Fill;
            buttonConvert.Enabled = false;
            buttonConvert.Location = new Point(493, 3);
            buttonConvert.Name = "buttonConvert";
            buttonConvert.Size = new Size(484, 160);
            buttonConvert.TabIndex = 1;
            buttonConvert.Text = "Convert to .jpg";
            buttonConvert.UseVisualStyleBackColor = true;
            buttonConvert.Click += buttonConvert_Click;
            // 
            // buttonSelectDocumentToSlice
            // 
            buttonSelectDocumentToSlice.Dock = DockStyle.Fill;
            buttonSelectDocumentToSlice.Location = new Point(3, 3);
            buttonSelectDocumentToSlice.Name = "buttonSelectDocumentToSlice";
            buttonSelectDocumentToSlice.Size = new Size(484, 160);
            buttonSelectDocumentToSlice.TabIndex = 0;
            buttonSelectDocumentToSlice.Text = "Select Document";
            buttonSelectDocumentToSlice.UseVisualStyleBackColor = true;
            buttonSelectDocumentToSlice.Click += buttonSelectDocumentToSlice_Click;
            // 
            // panelPagesToSlice
            // 
            panelPagesToSlice.AutoScroll = true;
            panelPagesToSlice.Controls.Add(groupBoxPreferences);
            panelPagesToSlice.Dock = DockStyle.Fill;
            panelPagesToSlice.Location = new Point(3, 175);
            panelPagesToSlice.Name = "panelPagesToSlice";
            panelPagesToSlice.Size = new Size(980, 971);
            panelPagesToSlice.TabIndex = 1;
            // 
            // groupBoxPreferences
            // 
            groupBoxPreferences.Controls.Add(label6);
            groupBoxPreferences.Controls.Add(label5);
            groupBoxPreferences.Controls.Add(numberImageQuality);
            groupBoxPreferences.Controls.Add(numberJPEGQuality);
            groupBoxPreferences.Controls.Add(label1);
            groupBoxPreferences.Controls.Add(numberPageTo);
            groupBoxPreferences.Controls.Add(numberPageFrom);
            groupBoxPreferences.Controls.Add(comboBoxFileFormat);
            groupBoxPreferences.Controls.Add(label4);
            groupBoxPreferences.Controls.Add(label3);
            groupBoxPreferences.Controls.Add(label2);
            groupBoxPreferences.Dock = DockStyle.Fill;
            groupBoxPreferences.Enabled = false;
            groupBoxPreferences.Location = new Point(0, 0);
            groupBoxPreferences.Name = "groupBoxPreferences";
            groupBoxPreferences.Size = new Size(980, 971);
            groupBoxPreferences.TabIndex = 0;
            groupBoxPreferences.TabStop = false;
            groupBoxPreferences.Text = "Preferences";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(515, 125);
            label6.Name = "label6";
            label6.Size = new Size(48, 32);
            label6.TabIndex = 14;
            label6.Text = "dpi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 125);
            label5.Name = "label5";
            label5.Size = new Size(175, 32);
            label5.TabIndex = 13;
            label5.Text = "Image Quality: ";
            // 
            // numberImageQuality
            // 
            numberImageQuality.Location = new Point(187, 123);
            numberImageQuality.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numberImageQuality.Minimum = new decimal(new int[] { 20, 0, 0, 0 });
            numberImageQuality.Name = "numberImageQuality";
            numberImageQuality.Size = new Size(322, 39);
            numberImageQuality.TabIndex = 12;
            numberImageQuality.Value = new decimal(new int[] { 150, 0, 0, 0 });
            // 
            // numberJPEGQuality
            // 
            numberJPEGQuality.Location = new Point(317, 169);
            numberJPEGQuality.Name = "numberJPEGQuality";
            numberJPEGQuality.Size = new Size(246, 39);
            numberJPEGQuality.TabIndex = 11;
            numberJPEGQuality.Value = new decimal(new int[] { 80, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 171);
            label1.Name = "label1";
            label1.Size = new Size(305, 32);
            label1.TabIndex = 10;
            label1.Text = "JPEG Compression Quality: ";
            // 
            // numberPageTo
            // 
            numberPageTo.Location = new Point(383, 32);
            numberPageTo.Name = "numberPageTo";
            numberPageTo.Size = new Size(180, 39);
            numberPageTo.TabIndex = 9;
            // 
            // numberPageFrom
            // 
            numberPageFrom.Location = new Point(145, 32);
            numberPageFrom.Name = "numberPageFrom";
            numberPageFrom.Size = new Size(180, 39);
            numberPageFrom.TabIndex = 8;
            numberPageFrom.ValueChanged += numberPageFrom_ValueChanged;
            // 
            // comboBoxFileFormat
            // 
            comboBoxFileFormat.FormattingEnabled = true;
            comboBoxFileFormat.Items.AddRange(new object[] { ".jpg", ".png" });
            comboBoxFileFormat.Location = new Point(145, 77);
            comboBoxFileFormat.Name = "comboBoxFileFormat";
            comboBoxFileFormat.Size = new Size(418, 40);
            comboBoxFileFormat.TabIndex = 7;
            comboBoxFileFormat.SelectedIndexChanged += comboBoxFileFormat_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 80);
            label4.Name = "label4";
            label4.Size = new Size(94, 32);
            label4.TabIndex = 6;
            label4.Text = "Format:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(331, 35);
            label3.Name = "label3";
            label3.Size = new Size(41, 32);
            label3.TabIndex = 4;
            label3.Text = "to:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 35);
            label2.Name = "label2";
            label2.Size = new Size(133, 32);
            label2.TabIndex = 2;
            label2.Text = "Pages from";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 1200);
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
            TabToImages.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            panelPagesToSlice.ResumeLayout(false);
            groupBoxPreferences.ResumeLayout(false);
            groupBoxPreferences.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numberImageQuality).EndInit();
            ((System.ComponentModel.ISupportInitialize)numberJPEGQuality).EndInit();
            ((System.ComponentModel.ISupportInitialize)numberPageTo).EndInit();
            ((System.ComponentModel.ISupportInitialize)numberPageFrom).EndInit();
            ResumeLayout(false);


        }

        private void MainForm_Load()
        {
            this.Width = Screen.PrimaryScreen.Bounds.Width / 3;
            this.Height = Screen.PrimaryScreen.Bounds.Height * 2 / 3;
        }

        private TabControl TabControl;
        private TabPage TabMerger;
        private TabPage TabToImages;
        private Button buttonSelectDocumentsToMerge;
        private Button buttonMergeDocuments;
        private Button buttonRemove;
        private Button buttonMoveDown;
        private Button buttonMoveUp;
        private ListBox listBoxDocuments;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel3;
        private PictureBox pictureBoxPreview;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private Button buttonSelectDocumentToSlice;
        private Panel panelPagesToSlice;
        private Button buttonConvert;
        private GroupBox groupBoxPreferences;
        private Label label3;
        private Label label2;
        private ComboBox comboBoxFileFormat;
        private Label label4;
        private NumericUpDown numberPageTo;
        private NumericUpDown numberPageFrom;
        private NumericUpDown numberJPEGQuality;
        private Label label1;
        private Label label6;
        private Label label5;
        private NumericUpDown numberImageQuality;
    }
}

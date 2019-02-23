namespace Library
{
    partial class Registry
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registry));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchByBookIDToolStrip = new System.Windows.Forms.ToolStrip();
            this.iDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.iDToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.searchByBookIDToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOOKIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHONENUMBERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEGISTRYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSet = new Library.LibraryDataSet();
            this.rEGISTRYTableAdapter = new Library.LibraryDataSetTableAdapters.REGISTRYTableAdapter();
            this.searchByNumToolStrip = new System.Windows.Forms.ToolStrip();
            this.nUMToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.nUMToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.searchByNumToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.searchByBookIDToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rEGISTRYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            this.searchByNumToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.bOOKIDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.pHONENUMBERDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rEGISTRYBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(674, 347);
            this.dataGridView1.TabIndex = 0;
            // 
            // searchByBookIDToolStrip
            // 
            this.searchByBookIDToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.searchByBookIDToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iDToolStripLabel,
            this.iDToolStripTextBox,
            this.searchByBookIDToolStripButton,
            this.toolStripSeparator1,
            this.toolStripButton1,
            this.toolStripSeparator2,
            this.toolStripButton2,
            this.toolStripSeparator3,
            this.toolStripButton3});
            this.searchByBookIDToolStrip.Location = new System.Drawing.Point(0, 0);
            this.searchByBookIDToolStrip.Name = "searchByBookIDToolStrip";
            this.searchByBookIDToolStrip.Size = new System.Drawing.Size(706, 27);
            this.searchByBookIDToolStrip.TabIndex = 1;
            this.searchByBookIDToolStrip.Text = "searchByBookIDToolStrip";
            // 
            // iDToolStripLabel
            // 
            this.iDToolStripLabel.Name = "iDToolStripLabel";
            this.iDToolStripLabel.Size = new System.Drawing.Size(69, 24);
            this.iDToolStripLabel.Text = "Book ID: ";
            // 
            // iDToolStripTextBox
            // 
            this.iDToolStripTextBox.Name = "iDToolStripTextBox";
            this.iDToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // searchByBookIDToolStripButton
            // 
            this.searchByBookIDToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.searchByBookIDToolStripButton.Name = "searchByBookIDToolStripButton";
            this.searchByBookIDToolStripButton.Size = new System.Drawing.Size(57, 24);
            this.searchByBookIDToolStripButton.Text = "Search";
            this.searchByBookIDToolStripButton.Click += new System.EventHandler(this.searchByBookIDToolStripButton_Click);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bOOKIDDataGridViewTextBoxColumn
            // 
            this.bOOKIDDataGridViewTextBoxColumn.DataPropertyName = "BOOK_ID";
            this.bOOKIDDataGridViewTextBoxColumn.HeaderText = "BOOK_ID";
            this.bOOKIDDataGridViewTextBoxColumn.Name = "bOOKIDDataGridViewTextBoxColumn";
            this.bOOKIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pHONENUMBERDataGridViewTextBoxColumn
            // 
            this.pHONENUMBERDataGridViewTextBoxColumn.DataPropertyName = "PHONE_NUMBER";
            this.pHONENUMBERDataGridViewTextBoxColumn.HeaderText = "PHONE_NUMBER";
            this.pHONENUMBERDataGridViewTextBoxColumn.Name = "pHONENUMBERDataGridViewTextBoxColumn";
            this.pHONENUMBERDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rEGISTRYBindingSource
            // 
            this.rEGISTRYBindingSource.DataMember = "REGISTRY";
            this.rEGISTRYBindingSource.DataSource = this.libraryDataSet;
            // 
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "LibraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rEGISTRYTableAdapter
            // 
            this.rEGISTRYTableAdapter.ClearBeforeFill = true;
            // 
            // searchByNumToolStrip
            // 
            this.searchByNumToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.searchByNumToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nUMToolStripLabel,
            this.nUMToolStripTextBox,
            this.searchByNumToolStripButton});
            this.searchByNumToolStrip.Location = new System.Drawing.Point(0, 27);
            this.searchByNumToolStrip.Name = "searchByNumToolStrip";
            this.searchByNumToolStrip.Size = new System.Drawing.Size(706, 27);
            this.searchByNumToolStrip.TabIndex = 2;
            this.searchByNumToolStrip.Text = "searchByNumToolStrip";
            // 
            // nUMToolStripLabel
            // 
            this.nUMToolStripLabel.Name = "nUMToolStripLabel";
            this.nUMToolStripLabel.Size = new System.Drawing.Size(66, 24);
            this.nUMToolStripLabel.Text = "Number:";
            // 
            // nUMToolStripTextBox
            // 
            this.nUMToolStripTextBox.Name = "nUMToolStripTextBox";
            this.nUMToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // searchByNumToolStripButton
            // 
            this.searchByNumToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.searchByNumToolStripButton.Name = "searchByNumToolStripButton";
            this.searchByNumToolStripButton.Size = new System.Drawing.Size(57, 24);
            this.searchByNumToolStripButton.Text = "Search";
            this.searchByNumToolStripButton.Click += new System.EventHandler(this.searchByNumToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(62, 24);
            this.toolStripButton1.Text = "Refresh";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(92, 24);
            this.toolStripButton2.Text = "Take a Book";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(106, 24);
            this.toolStripButton3.Text = "Return a Book";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // Registry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 458);
            this.Controls.Add(this.searchByNumToolStrip);
            this.Controls.Add(this.searchByBookIDToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Registry";
            this.Text = "Registry";
            this.Load += new System.EventHandler(this.Registry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.searchByBookIDToolStrip.ResumeLayout(false);
            this.searchByBookIDToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rEGISTRYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            this.searchByNumToolStrip.ResumeLayout(false);
            this.searchByNumToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private LibraryDataSet libraryDataSet;
        private System.Windows.Forms.BindingSource rEGISTRYBindingSource;
        private LibraryDataSetTableAdapters.REGISTRYTableAdapter rEGISTRYTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOOKIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pHONENUMBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip searchByBookIDToolStrip;
        private System.Windows.Forms.ToolStripLabel iDToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox iDToolStripTextBox;
        private System.Windows.Forms.ToolStripButton searchByBookIDToolStripButton;
        private System.Windows.Forms.ToolStrip searchByNumToolStrip;
        private System.Windows.Forms.ToolStripLabel nUMToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox nUMToolStripTextBox;
        private System.Windows.Forms.ToolStripButton searchByNumToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
    }
}
namespace Library
{
    partial class Readers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Readers));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchByNumberToolStrip = new System.Windows.Forms.ToolStrip();
            this.nUMBERToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.nUMBERToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.searchByNumberToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHONENUMBERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEADERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSet = new Library.LibraryDataSet();
            this.rEADERSTableAdapter = new Library.LibraryDataSetTableAdapters.READERSTableAdapter();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TDB_tools = new System.Windows.Forms.ToolStripDropDownButton();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerAReaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.searchByNumberToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rEADERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nAMEDataGridViewTextBoxColumn,
            this.pHONENUMBERDataGridViewTextBoxColumn,
            this.aDDRESSDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rEADERSBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(54, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(429, 220);
            this.dataGridView1.TabIndex = 0;
            // 
            // searchByNumberToolStrip
            // 
            this.searchByNumberToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.searchByNumberToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nUMBERToolStripLabel,
            this.nUMBERToolStripTextBox,
            this.searchByNumberToolStripButton,
            this.toolStripSeparator1,
            this.TDB_tools});
            this.searchByNumberToolStrip.Location = new System.Drawing.Point(0, 0);
            this.searchByNumberToolStrip.Name = "searchByNumberToolStrip";
            this.searchByNumberToolStrip.Size = new System.Drawing.Size(580, 27);
            this.searchByNumberToolStrip.TabIndex = 1;
            this.searchByNumberToolStrip.Text = "searchByNumberToolStrip";
            // 
            // nUMBERToolStripLabel
            // 
            this.nUMBERToolStripLabel.Name = "nUMBERToolStripLabel";
            this.nUMBERToolStripLabel.Size = new System.Drawing.Size(72, 24);
            this.nUMBERToolStripLabel.Text = "NUMBER:";
            // 
            // nUMBERToolStripTextBox
            // 
            this.nUMBERToolStripTextBox.Name = "nUMBERToolStripTextBox";
            this.nUMBERToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // searchByNumberToolStripButton
            // 
            this.searchByNumberToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.searchByNumberToolStripButton.Name = "searchByNumberToolStripButton";
            this.searchByNumberToolStripButton.Size = new System.Drawing.Size(57, 24);
            this.searchByNumberToolStripButton.Text = "Search";
            this.searchByNumberToolStripButton.Click += new System.EventHandler(this.searchByNumberToolStripButton_Click);
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "NAME";
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            this.nAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pHONENUMBERDataGridViewTextBoxColumn
            // 
            this.pHONENUMBERDataGridViewTextBoxColumn.DataPropertyName = "PHONE_NUMBER";
            this.pHONENUMBERDataGridViewTextBoxColumn.HeaderText = "PHONE_NUMBER";
            this.pHONENUMBERDataGridViewTextBoxColumn.Name = "pHONENUMBERDataGridViewTextBoxColumn";
            this.pHONENUMBERDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aDDRESSDataGridViewTextBoxColumn
            // 
            this.aDDRESSDataGridViewTextBoxColumn.DataPropertyName = "ADDRESS";
            this.aDDRESSDataGridViewTextBoxColumn.HeaderText = "ADDRESS";
            this.aDDRESSDataGridViewTextBoxColumn.Name = "aDDRESSDataGridViewTextBoxColumn";
            this.aDDRESSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rEADERSBindingSource
            // 
            this.rEADERSBindingSource.DataMember = "READERS";
            this.rEADERSBindingSource.DataSource = this.libraryDataSet;
            // 
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "LibraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rEADERSTableAdapter
            // 
            this.rEADERSTableAdapter.ClearBeforeFill = true;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // TDB_tools
            // 
            this.TDB_tools.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TDB_tools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.registerAReaderToolStripMenuItem});
            this.TDB_tools.Image = ((System.Drawing.Image)(resources.GetObject("TDB_tools.Image")));
            this.TDB_tools.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TDB_tools.Name = "TDB_tools";
            this.TDB_tools.Size = new System.Drawing.Size(58, 24);
            this.TDB_tools.Text = "Tools";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // registerAReaderToolStripMenuItem
            // 
            this.registerAReaderToolStripMenuItem.Name = "registerAReaderToolStripMenuItem";
            this.registerAReaderToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.registerAReaderToolStripMenuItem.Text = "Register a reader";
            this.registerAReaderToolStripMenuItem.Click += new System.EventHandler(this.registerAReaderToolStripMenuItem_Click);
            // 
            // Readers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 454);
            this.Controls.Add(this.searchByNumberToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Readers";
            this.Text = "Readers";
            this.Load += new System.EventHandler(this.Readers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.searchByNumberToolStrip.ResumeLayout(false);
            this.searchByNumberToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rEADERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private LibraryDataSet libraryDataSet;
        private System.Windows.Forms.BindingSource rEADERSBindingSource;
        private LibraryDataSetTableAdapters.READERSTableAdapter rEADERSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pHONENUMBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDDRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip searchByNumberToolStrip;
        private System.Windows.Forms.ToolStripLabel nUMBERToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox nUMBERToolStripTextBox;
        private System.Windows.Forms.ToolStripButton searchByNumberToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton TDB_tools;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerAReaderToolStripMenuItem;
    }
}
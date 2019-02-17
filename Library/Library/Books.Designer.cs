namespace Library
{
    partial class Books
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Books));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tITLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aUTHORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pUBLISHERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aVAILABLEDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bOOKSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSet = new Library.LibraryDataSet();
            this.searchToolStrip = new System.Windows.Forms.ToolStrip();
            this.titleToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.titleToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.searchToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSB_available_books = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TSB_refresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.TSB_add = new System.Windows.Forms.ToolStripButton();
            this.bOOKSTableAdapter = new Library.LibraryDataSetTableAdapters.BOOKSTableAdapter();
            this.TSB_remove = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.TSBD_availability = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.makeAvailableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeUnavailableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            this.searchToolStrip.SuspendLayout();
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
            this.tITLEDataGridViewTextBoxColumn,
            this.aUTHORDataGridViewTextBoxColumn,
            this.pUBLISHERDataGridViewTextBoxColumn,
            this.aVAILABLEDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.bOOKSBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(755, 357);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tITLEDataGridViewTextBoxColumn
            // 
            this.tITLEDataGridViewTextBoxColumn.DataPropertyName = "TITLE";
            this.tITLEDataGridViewTextBoxColumn.HeaderText = "TITLE";
            this.tITLEDataGridViewTextBoxColumn.Name = "tITLEDataGridViewTextBoxColumn";
            this.tITLEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aUTHORDataGridViewTextBoxColumn
            // 
            this.aUTHORDataGridViewTextBoxColumn.DataPropertyName = "AUTHOR";
            this.aUTHORDataGridViewTextBoxColumn.HeaderText = "AUTHOR";
            this.aUTHORDataGridViewTextBoxColumn.Name = "aUTHORDataGridViewTextBoxColumn";
            this.aUTHORDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pUBLISHERDataGridViewTextBoxColumn
            // 
            this.pUBLISHERDataGridViewTextBoxColumn.DataPropertyName = "PUBLISHER";
            this.pUBLISHERDataGridViewTextBoxColumn.HeaderText = "PUBLISHER";
            this.pUBLISHERDataGridViewTextBoxColumn.Name = "pUBLISHERDataGridViewTextBoxColumn";
            this.pUBLISHERDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aVAILABLEDataGridViewCheckBoxColumn
            // 
            this.aVAILABLEDataGridViewCheckBoxColumn.DataPropertyName = "AVAILABLE";
            this.aVAILABLEDataGridViewCheckBoxColumn.HeaderText = "AVAILABLE";
            this.aVAILABLEDataGridViewCheckBoxColumn.Name = "aVAILABLEDataGridViewCheckBoxColumn";
            this.aVAILABLEDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // bOOKSBindingSource
            // 
            this.bOOKSBindingSource.DataMember = "BOOKS";
            this.bOOKSBindingSource.DataSource = this.libraryDataSet;
            // 
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "LibraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // searchToolStrip
            // 
            this.searchToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.searchToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.titleToolStripLabel,
            this.titleToolStripTextBox,
            this.searchToolStripButton,
            this.toolStripSeparator1,
            this.TSB_available_books,
            this.toolStripSeparator2,
            this.TSB_refresh,
            this.toolStripSeparator3,
            this.TSB_add,
            this.toolStripSeparator4,
            this.TSB_remove,
            this.toolStripSeparator5,
            this.TSBD_availability});
            this.searchToolStrip.Location = new System.Drawing.Point(0, 0);
            this.searchToolStrip.Name = "searchToolStrip";
            this.searchToolStrip.Size = new System.Drawing.Size(787, 27);
            this.searchToolStrip.TabIndex = 2;
            this.searchToolStrip.Text = "searchToolStrip";
            // 
            // titleToolStripLabel
            // 
            this.titleToolStripLabel.Name = "titleToolStripLabel";
            this.titleToolStripLabel.Size = new System.Drawing.Size(41, 24);
            this.titleToolStripLabel.Text = "Title:";
            // 
            // titleToolStripTextBox
            // 
            this.titleToolStripTextBox.Name = "titleToolStripTextBox";
            this.titleToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // searchToolStripButton
            // 
            this.searchToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.searchToolStripButton.Name = "searchToolStripButton";
            this.searchToolStripButton.Size = new System.Drawing.Size(57, 24);
            this.searchToolStripButton.Text = "Search";
            this.searchToolStripButton.Click += new System.EventHandler(this.searchToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // TSB_available_books
            // 
            this.TSB_available_books.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSB_available_books.Image = ((System.Drawing.Image)(resources.GetObject("TSB_available_books.Image")));
            this.TSB_available_books.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_available_books.Name = "TSB_available_books";
            this.TSB_available_books.Size = new System.Drawing.Size(119, 24);
            this.TSB_available_books.Text = "Available Books";
            this.TSB_available_books.Click += new System.EventHandler(this.TSB_available_books_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // TSB_refresh
            // 
            this.TSB_refresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSB_refresh.Image = ((System.Drawing.Image)(resources.GetObject("TSB_refresh.Image")));
            this.TSB_refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_refresh.Name = "TSB_refresh";
            this.TSB_refresh.Size = new System.Drawing.Size(62, 24);
            this.TSB_refresh.Text = "Refresh";
            this.TSB_refresh.Click += new System.EventHandler(this.TSB_refresh_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // TSB_add
            // 
            this.TSB_add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSB_add.Image = ((System.Drawing.Image)(resources.GetObject("TSB_add.Image")));
            this.TSB_add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_add.Name = "TSB_add";
            this.TSB_add.Size = new System.Drawing.Size(91, 24);
            this.TSB_add.Text = "Add a book";
            this.TSB_add.Click += new System.EventHandler(this.TSB_add_Click);
            // 
            // bOOKSTableAdapter
            // 
            this.bOOKSTableAdapter.ClearBeforeFill = true;
            // 
            // TSB_remove
            // 
            this.TSB_remove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSB_remove.Image = ((System.Drawing.Image)(resources.GetObject("TSB_remove.Image")));
            this.TSB_remove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_remove.Name = "TSB_remove";
            this.TSB_remove.Size = new System.Drawing.Size(117, 24);
            this.TSB_remove.Text = "Remova a book";
            this.TSB_remove.Click += new System.EventHandler(this.TSB_remove_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // TSBD_availability
            // 
            this.TSBD_availability.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSBD_availability.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeAvailableToolStripMenuItem,
            this.makeUnavailableToolStripMenuItem});
            this.TSBD_availability.Image = ((System.Drawing.Image)(resources.GetObject("TSBD_availability.Image")));
            this.TSBD_availability.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBD_availability.Name = "TSBD_availability";
            this.TSBD_availability.Size = new System.Drawing.Size(97, 24);
            this.TSBD_availability.Text = "Availability";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // makeAvailableToolStripMenuItem
            // 
            this.makeAvailableToolStripMenuItem.Name = "makeAvailableToolStripMenuItem";
            this.makeAvailableToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.makeAvailableToolStripMenuItem.Text = "Make Available";
            this.makeAvailableToolStripMenuItem.Click += new System.EventHandler(this.makeAvailableToolStripMenuItem_Click);
            // 
            // makeUnavailableToolStripMenuItem
            // 
            this.makeUnavailableToolStripMenuItem.Name = "makeUnavailableToolStripMenuItem";
            this.makeUnavailableToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.makeUnavailableToolStripMenuItem.Text = "Make Unavailable";
            this.makeUnavailableToolStripMenuItem.Click += new System.EventHandler(this.makeUnavailableToolStripMenuItem_Click);
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 442);
            this.Controls.Add(this.searchToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Books";
            this.Text = "Books";
            this.Load += new System.EventHandler(this.Books_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            this.searchToolStrip.ResumeLayout(false);
            this.searchToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private LibraryDataSet libraryDataSet;
        private System.Windows.Forms.BindingSource bOOKSBindingSource;
        private LibraryDataSetTableAdapters.BOOKSTableAdapter bOOKSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tITLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aUTHORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pUBLISHERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aVAILABLEDataGridViewCheckBoxColumn;
        private System.Windows.Forms.ToolStrip searchToolStrip;
        private System.Windows.Forms.ToolStripLabel titleToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox titleToolStripTextBox;
        private System.Windows.Forms.ToolStripButton searchToolStripButton;
        private System.Windows.Forms.ToolStripButton TSB_available_books;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton TSB_refresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton TSB_add;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton TSB_remove;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripDropDownButton TSBD_availability;
        private System.Windows.Forms.ToolStripMenuItem makeAvailableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeUnavailableToolStripMenuItem;
    }
}
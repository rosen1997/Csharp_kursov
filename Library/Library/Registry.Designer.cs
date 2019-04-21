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
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOOKIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHONENUMBERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEGISTRYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSet = new Library.LibraryDataSet();
            this.searchByBookIDToolStrip = new System.Windows.Forms.ToolStrip();
            this.iDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.iDToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.searchByBookIDToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.searchByNumToolStrip = new System.Windows.Forms.ToolStrip();
            this.nUMToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.nUMToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.searchByNumToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.rEGISTRYTableAdapter = new Library.LibraryDataSetTableAdapters.REGISTRYTableAdapter();
            this.booksTableAdapter1 = new Library.LibraryDataSetTableAdapters.BOOKSTableAdapter();
            this.libraryDataSet1 = new Library.LibraryDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEGISTRYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            this.searchByBookIDToolStrip.SuspendLayout();
            this.searchByNumToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet1)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(9, 74);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(506, 282);
            this.dataGridView1.TabIndex = 0;
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
            // searchByBookIDToolStrip
            // 
            this.searchByBookIDToolStrip.BackColor = System.Drawing.Color.Transparent;
            this.searchByBookIDToolStrip.BackgroundImage = global::Library.Properties.Resources.FL_Web_design_background_rustic_brown;
            this.searchByBookIDToolStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            this.searchByBookIDToolStrip.Size = new System.Drawing.Size(530, 31);
            this.searchByBookIDToolStrip.TabIndex = 1;
            this.searchByBookIDToolStrip.Text = "searchByBookIDToolStrip";
            // 
            // iDToolStripLabel
            // 
            this.iDToolStripLabel.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDToolStripLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iDToolStripLabel.Name = "iDToolStripLabel";
            this.iDToolStripLabel.Size = new System.Drawing.Size(60, 28);
            this.iDToolStripLabel.Text = "Book ID: ";
            // 
            // iDToolStripTextBox
            // 
            this.iDToolStripTextBox.Name = "iDToolStripTextBox";
            this.iDToolStripTextBox.Size = new System.Drawing.Size(76, 31);
            this.iDToolStripTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.iDToolStripTextBox_KeyPress);
            // 
            // searchByBookIDToolStripButton
            // 
            this.searchByBookIDToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.searchByBookIDToolStripButton.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByBookIDToolStripButton.Name = "searchByBookIDToolStripButton";
            this.searchByBookIDToolStripButton.Size = new System.Drawing.Size(56, 28);
            this.searchByBookIDToolStripButton.Text = "Search";
            this.searchByBookIDToolStripButton.Click += new System.EventHandler(this.searchByBookIDToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(59, 28);
            this.toolStripButton1.Text = "Refresh";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(82, 28);
            this.toolStripButton2.Text = "Take a Book";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(96, 28);
            this.toolStripButton3.Text = "Return a Book";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // searchByNumToolStrip
            // 
            this.searchByNumToolStrip.BackColor = System.Drawing.Color.Transparent;
            this.searchByNumToolStrip.BackgroundImage = global::Library.Properties.Resources.FL_Web_design_background_rustic_brown;
            this.searchByNumToolStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchByNumToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.searchByNumToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nUMToolStripLabel,
            this.nUMToolStripTextBox,
            this.searchByNumToolStripButton});
            this.searchByNumToolStrip.Location = new System.Drawing.Point(0, 31);
            this.searchByNumToolStrip.Name = "searchByNumToolStrip";
            this.searchByNumToolStrip.Size = new System.Drawing.Size(530, 31);
            this.searchByNumToolStrip.TabIndex = 2;
            this.searchByNumToolStrip.Text = "searchByNumToolStrip";
            // 
            // nUMToolStripLabel
            // 
            this.nUMToolStripLabel.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUMToolStripLabel.Name = "nUMToolStripLabel";
            this.nUMToolStripLabel.Size = new System.Drawing.Size(59, 28);
            this.nUMToolStripLabel.Text = "Number:";
            // 
            // nUMToolStripTextBox
            // 
            this.nUMToolStripTextBox.MaxLength = 10;
            this.nUMToolStripTextBox.Name = "nUMToolStripTextBox";
            this.nUMToolStripTextBox.Size = new System.Drawing.Size(76, 31);
            this.nUMToolStripTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nUMToolStripTextBox_KeyPress);
            // 
            // searchByNumToolStripButton
            // 
            this.searchByNumToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.searchByNumToolStripButton.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByNumToolStripButton.Name = "searchByNumToolStripButton";
            this.searchByNumToolStripButton.Size = new System.Drawing.Size(56, 28);
            this.searchByNumToolStripButton.Text = "Search";
            this.searchByNumToolStripButton.Click += new System.EventHandler(this.searchByNumToolStripButton_Click);
            // 
            // rEGISTRYTableAdapter
            // 
            this.rEGISTRYTableAdapter.ClearBeforeFill = true;
            // 
            // booksTableAdapter1
            // 
            this.booksTableAdapter1.ClearBeforeFill = true;
            // 
            // libraryDataSet1
            // 
            this.libraryDataSet1.DataSetName = "LibraryDataSet";
            this.libraryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Registry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library.Properties.Resources.FL_Web_design_background_rustic_brown;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(530, 372);
            this.Controls.Add(this.searchByNumToolStrip);
            this.Controls.Add(this.searchByBookIDToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Registry";
            this.Text = "Registry";
            this.Load += new System.EventHandler(this.Registry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEGISTRYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            this.searchByBookIDToolStrip.ResumeLayout(false);
            this.searchByBookIDToolStrip.PerformLayout();
            this.searchByNumToolStrip.ResumeLayout(false);
            this.searchByNumToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet1)).EndInit();
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
        private LibraryDataSetTableAdapters.BOOKSTableAdapter booksTableAdapter1;
        private LibraryDataSet libraryDataSet1;
    }
}
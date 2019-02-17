namespace Library
{
    partial class Insert_Book
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
            this.TXB_title = new System.Windows.Forms.TextBox();
            this.TXB_author = new System.Windows.Forms.TextBox();
            this.TXB_publisher = new System.Windows.Forms.TextBox();
            this.CB_available = new System.Windows.Forms.CheckBox();
            this.BTN_addBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TXB_title
            // 
            this.TXB_title.Location = new System.Drawing.Point(47, 22);
            this.TXB_title.Name = "TXB_title";
            this.TXB_title.Size = new System.Drawing.Size(143, 22);
            this.TXB_title.TabIndex = 0;
            this.TXB_title.Text = "Title";
            // 
            // TXB_author
            // 
            this.TXB_author.Location = new System.Drawing.Point(47, 50);
            this.TXB_author.Name = "TXB_author";
            this.TXB_author.Size = new System.Drawing.Size(143, 22);
            this.TXB_author.TabIndex = 1;
            this.TXB_author.Text = "Author";
            // 
            // TXB_publisher
            // 
            this.TXB_publisher.Location = new System.Drawing.Point(47, 78);
            this.TXB_publisher.Name = "TXB_publisher";
            this.TXB_publisher.Size = new System.Drawing.Size(143, 22);
            this.TXB_publisher.TabIndex = 2;
            this.TXB_publisher.Text = "Publisher";
            // 
            // CB_available
            // 
            this.CB_available.AutoSize = true;
            this.CB_available.Location = new System.Drawing.Point(47, 106);
            this.CB_available.Name = "CB_available";
            this.CB_available.Size = new System.Drawing.Size(87, 21);
            this.CB_available.TabIndex = 3;
            this.CB_available.Text = "Available";
            this.CB_available.UseVisualStyleBackColor = true;
            // 
            // BTN_addBook
            // 
            this.BTN_addBook.Location = new System.Drawing.Point(47, 158);
            this.BTN_addBook.Name = "BTN_addBook";
            this.BTN_addBook.Size = new System.Drawing.Size(143, 23);
            this.BTN_addBook.TabIndex = 4;
            this.BTN_addBook.Text = "Add";
            this.BTN_addBook.UseVisualStyleBackColor = true;
            this.BTN_addBook.Click += new System.EventHandler(this.BTN_addBook_Click);
            // 
            // Insert_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 227);
            this.Controls.Add(this.BTN_addBook);
            this.Controls.Add(this.CB_available);
            this.Controls.Add(this.TXB_publisher);
            this.Controls.Add(this.TXB_author);
            this.Controls.Add(this.TXB_title);
            this.Name = "Insert_Book";
            this.Text = "Insert sBook";
            this.Load += new System.EventHandler(this.Insert_Book_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXB_title;
        private System.Windows.Forms.TextBox TXB_author;
        private System.Windows.Forms.TextBox TXB_publisher;
        private System.Windows.Forms.CheckBox CB_available;
        private System.Windows.Forms.Button BTN_addBook;
    }
}
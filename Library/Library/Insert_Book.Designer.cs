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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTN_addBook = new System.Windows.Forms.Button();
            this.TXB_title = new System.Windows.Forms.TextBox();
            this.TXB_author = new System.Windows.Forms.TextBox();
            this.TXB_publisher = new System.Windows.Forms.TextBox();
            this.CB_available = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Library.Properties.Resources.FL_Web_design_background_rustic_brown;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.BTN_addBook);
            this.panel1.Controls.Add(this.TXB_title);
            this.panel1.Controls.Add(this.TXB_author);
            this.panel1.Controls.Add(this.TXB_publisher);
            this.panel1.Controls.Add(this.CB_available);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 176);
            this.panel1.TabIndex = 5;
            // 
            // BTN_addBook
            // 
            this.BTN_addBook.BackgroundImage = global::Library.Properties.Resources.file_add;
            this.BTN_addBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_addBook.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_addBook.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.BTN_addBook.Location = new System.Drawing.Point(38, 134);
            this.BTN_addBook.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_addBook.Name = "BTN_addBook";
            this.BTN_addBook.Size = new System.Drawing.Size(38, 31);
            this.BTN_addBook.TabIndex = 4;
            this.BTN_addBook.UseVisualStyleBackColor = true;
            this.BTN_addBook.Click += new System.EventHandler(this.BTN_addBook_Click);
            // 
            // TXB_title
            // 
            this.TXB_title.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_title.Location = new System.Drawing.Point(37, 12);
            this.TXB_title.Margin = new System.Windows.Forms.Padding(2);
            this.TXB_title.MaxLength = 32;
            this.TXB_title.Name = "TXB_title";
            this.TXB_title.Size = new System.Drawing.Size(108, 30);
            this.TXB_title.TabIndex = 0;
            this.TXB_title.Text = "Title";
            // 
            // TXB_author
            // 
            this.TXB_author.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_author.Location = new System.Drawing.Point(38, 48);
            this.TXB_author.Margin = new System.Windows.Forms.Padding(2);
            this.TXB_author.MaxLength = 32;
            this.TXB_author.Name = "TXB_author";
            this.TXB_author.Size = new System.Drawing.Size(108, 30);
            this.TXB_author.TabIndex = 1;
            this.TXB_author.Text = "Author";
            // 
            // TXB_publisher
            // 
            this.TXB_publisher.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_publisher.Location = new System.Drawing.Point(38, 82);
            this.TXB_publisher.Margin = new System.Windows.Forms.Padding(2);
            this.TXB_publisher.MaxLength = 32;
            this.TXB_publisher.Name = "TXB_publisher";
            this.TXB_publisher.Size = new System.Drawing.Size(108, 30);
            this.TXB_publisher.TabIndex = 2;
            this.TXB_publisher.Text = "Publisher";
            // 
            // CB_available
            // 
            this.CB_available.AutoSize = true;
            this.CB_available.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_available.Location = new System.Drawing.Point(38, 115);
            this.CB_available.Margin = new System.Windows.Forms.Padding(2);
            this.CB_available.Name = "CB_available";
            this.CB_available.Size = new System.Drawing.Size(66, 24);
            this.CB_available.TabIndex = 3;
            this.CB_available.Text = "Available";
            this.CB_available.UseVisualStyleBackColor = true;
            // 
            // Insert_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 176);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Insert_Book";
            this.Text = "Insert sBook";
            this.Load += new System.EventHandler(this.Insert_Book_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TXB_title;
        private System.Windows.Forms.TextBox TXB_author;
        private System.Windows.Forms.TextBox TXB_publisher;
        private System.Windows.Forms.CheckBox CB_available;
        private System.Windows.Forms.Button BTN_addBook;
        private System.Windows.Forms.Panel panel1;
    }
}
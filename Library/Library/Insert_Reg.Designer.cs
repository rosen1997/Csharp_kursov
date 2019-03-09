namespace Library
{
    partial class Insert_Reg
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
            this.TXB_bookID = new System.Windows.Forms.TextBox();
            this.TXB_readerID = new System.Windows.Forms.TextBox();
            this.BTN_take = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TXB_bookID
            // 
            this.TXB_bookID.Location = new System.Drawing.Point(76, 62);
            this.TXB_bookID.Name = "TXB_bookID";
            this.TXB_bookID.Size = new System.Drawing.Size(153, 22);
            this.TXB_bookID.TabIndex = 0;
            this.TXB_bookID.Text = "Book ID";
            this.TXB_bookID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXB_bookID_KeyPress);
            // 
            // TXB_readerID
            // 
            this.TXB_readerID.Location = new System.Drawing.Point(76, 90);
            this.TXB_readerID.Name = "TXB_readerID";
            this.TXB_readerID.Size = new System.Drawing.Size(153, 22);
            this.TXB_readerID.TabIndex = 1;
            this.TXB_readerID.Text = "Reader ID";
            this.TXB_readerID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXB_readerID_KeyPress);
            // 
            // BTN_take
            // 
            this.BTN_take.Location = new System.Drawing.Point(110, 146);
            this.BTN_take.Name = "BTN_take";
            this.BTN_take.Size = new System.Drawing.Size(75, 23);
            this.BTN_take.TabIndex = 2;
            this.BTN_take.Text = "Take";
            this.BTN_take.UseVisualStyleBackColor = true;
            this.BTN_take.Click += new System.EventHandler(this.BTN_take_Click);
            // 
            // Insert_Reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 226);
            this.Controls.Add(this.BTN_take);
            this.Controls.Add(this.TXB_readerID);
            this.Controls.Add(this.TXB_bookID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Insert_Reg";
            this.Text = "Insert_Reg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXB_bookID;
        private System.Windows.Forms.TextBox TXB_readerID;
        private System.Windows.Forms.Button BTN_take;
    }
}
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TXB_bookID
            // 
            this.TXB_bookID.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_bookID.Location = new System.Drawing.Point(40, 34);
            this.TXB_bookID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TXB_bookID.Name = "TXB_bookID";
            this.TXB_bookID.Size = new System.Drawing.Size(116, 30);
            this.TXB_bookID.TabIndex = 0;
            this.TXB_bookID.Text = "Book ID";
            this.TXB_bookID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXB_bookID_KeyPress);
            // 
            // TXB_readerID
            // 
            this.TXB_readerID.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_readerID.Location = new System.Drawing.Point(40, 76);
            this.TXB_readerID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TXB_readerID.Name = "TXB_readerID";
            this.TXB_readerID.Size = new System.Drawing.Size(116, 30);
            this.TXB_readerID.TabIndex = 1;
            this.TXB_readerID.Text = "Reader ID";
            this.TXB_readerID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXB_readerID_KeyPress);
            // 
            // BTN_take
            // 
            this.BTN_take.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_take.Location = new System.Drawing.Point(63, 114);
            this.BTN_take.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_take.Name = "BTN_take";
            this.BTN_take.Size = new System.Drawing.Size(56, 33);
            this.BTN_take.TabIndex = 2;
            this.BTN_take.Text = "Take";
            this.BTN_take.UseVisualStyleBackColor = true;
            this.BTN_take.Click += new System.EventHandler(this.BTN_take_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Library.Properties.Resources.FL_Web_design_background_rustic_brown;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.TXB_bookID);
            this.panel1.Controls.Add(this.BTN_take);
            this.panel1.Controls.Add(this.TXB_readerID);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 173);
            this.panel1.TabIndex = 3;
            // 
            // Insert_Reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 172);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Insert_Reg";
            this.Text = "Insert_Reg";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TXB_bookID;
        private System.Windows.Forms.TextBox TXB_readerID;
        private System.Windows.Forms.Button BTN_take;
        private System.Windows.Forms.Panel panel1;
    }
}
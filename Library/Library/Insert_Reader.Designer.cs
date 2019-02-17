namespace Library
{
    partial class Insert_Reader
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
            this.TXB_name = new System.Windows.Forms.TextBox();
            this.TXB_number = new System.Windows.Forms.TextBox();
            this.TXB_address = new System.Windows.Forms.TextBox();
            this.BTN_register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TXB_name
            // 
            this.TXB_name.Location = new System.Drawing.Point(56, 28);
            this.TXB_name.Name = "TXB_name";
            this.TXB_name.Size = new System.Drawing.Size(151, 22);
            this.TXB_name.TabIndex = 0;
            this.TXB_name.Text = "Name";
            // 
            // TXB_number
            // 
            this.TXB_number.Location = new System.Drawing.Point(56, 56);
            this.TXB_number.Name = "TXB_number";
            this.TXB_number.Size = new System.Drawing.Size(151, 22);
            this.TXB_number.TabIndex = 1;
            this.TXB_number.Text = "Number";
            // 
            // TXB_address
            // 
            this.TXB_address.Location = new System.Drawing.Point(56, 84);
            this.TXB_address.Multiline = true;
            this.TXB_address.Name = "TXB_address";
            this.TXB_address.Size = new System.Drawing.Size(151, 60);
            this.TXB_address.TabIndex = 2;
            this.TXB_address.Text = "Address";
            // 
            // BTN_register
            // 
            this.BTN_register.Location = new System.Drawing.Point(86, 169);
            this.BTN_register.Name = "BTN_register";
            this.BTN_register.Size = new System.Drawing.Size(88, 29);
            this.BTN_register.TabIndex = 3;
            this.BTN_register.Text = "Register";
            this.BTN_register.UseVisualStyleBackColor = true;
            this.BTN_register.Click += new System.EventHandler(this.BTN_register_Click);
            // 
            // Insert_Reader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 253);
            this.Controls.Add(this.BTN_register);
            this.Controls.Add(this.TXB_address);
            this.Controls.Add(this.TXB_number);
            this.Controls.Add(this.TXB_name);
            this.Name = "Insert_Reader";
            this.Text = "Insert_Reader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXB_name;
        private System.Windows.Forms.TextBox TXB_number;
        private System.Windows.Forms.TextBox TXB_address;
        private System.Windows.Forms.Button BTN_register;
    }
}
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTN_register = new System.Windows.Forms.Button();
            this.TXB_name = new System.Windows.Forms.TextBox();
            this.TXB_number = new System.Windows.Forms.TextBox();
            this.TXB_address = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Library.Properties.Resources.FL_Web_design_background_rustic_brown;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.BTN_register);
            this.panel1.Controls.Add(this.TXB_name);
            this.panel1.Controls.Add(this.TXB_number);
            this.panel1.Controls.Add(this.TXB_address);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 182);
            this.panel1.TabIndex = 4;
            // 
            // BTN_register
            // 
            this.BTN_register.BackgroundImage = global::Library.Properties.Resources.user_add;
            this.BTN_register.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_register.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_register.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BTN_register.Location = new System.Drawing.Point(72, 147);
            this.BTN_register.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_register.Name = "BTN_register";
            this.BTN_register.Size = new System.Drawing.Size(66, 33);
            this.BTN_register.TabIndex = 3;
            this.BTN_register.UseVisualStyleBackColor = true;
            this.BTN_register.Click += new System.EventHandler(this.BTN_register_Click);
            // 
            // TXB_name
            // 
            this.TXB_name.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_name.Location = new System.Drawing.Point(51, 24);
            this.TXB_name.Margin = new System.Windows.Forms.Padding(2);
            this.TXB_name.MaxLength = 64;
            this.TXB_name.Name = "TXB_name";
            this.TXB_name.Size = new System.Drawing.Size(114, 30);
            this.TXB_name.TabIndex = 0;
            this.TXB_name.Text = "Name";
            this.TXB_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXB_name_KeyPress);
            // 
            // TXB_number
            // 
            this.TXB_number.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_number.Location = new System.Drawing.Point(51, 58);
            this.TXB_number.Margin = new System.Windows.Forms.Padding(2);
            this.TXB_number.MaxLength = 10;
            this.TXB_number.Name = "TXB_number";
            this.TXB_number.Size = new System.Drawing.Size(114, 30);
            this.TXB_number.TabIndex = 1;
            this.TXB_number.Text = "Number";
            this.TXB_number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXB_number_KeyPress);
            // 
            // TXB_address
            // 
            this.TXB_address.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_address.Location = new System.Drawing.Point(51, 93);
            this.TXB_address.Margin = new System.Windows.Forms.Padding(2);
            this.TXB_address.MaxLength = 128;
            this.TXB_address.Multiline = true;
            this.TXB_address.Name = "TXB_address";
            this.TXB_address.Size = new System.Drawing.Size(114, 50);
            this.TXB_address.TabIndex = 2;
            this.TXB_address.Text = "Address";
            // 
            // Insert_Reader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 182);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Insert_Reader";
            this.Text = "Insert_Reader";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TXB_name;
        private System.Windows.Forms.TextBox TXB_number;
        private System.Windows.Forms.TextBox TXB_address;
        private System.Windows.Forms.Button BTN_register;
        private System.Windows.Forms.Panel panel1;
    }
}
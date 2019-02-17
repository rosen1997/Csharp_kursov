using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Insert_Reader : Form
    {
        public Reader rd { get; set; }
        public Insert_Reader()
        {
            InitializeComponent();
            rd = new Reader(); 
        }

        public Insert_Reader(string n, string num, string a)
        {
            InitializeComponent();
            rd = new Reader(n, num, a);
            TXB_name.Text = rd.getName();
            TXB_number.Text = rd.getNumber();
            TXB_address.Text = rd.getAddress();
            TXB_name.ReadOnly = true;
            
        }

        private void BTN_register_Click(object sender, EventArgs e)
        {
            rd.setName(TXB_name.Text);
            rd.setNumber(TXB_number.Text);
            rd.setAddress(TXB_address.Text);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

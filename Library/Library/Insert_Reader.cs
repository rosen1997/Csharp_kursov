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
        }

        private void BTN_register_Click(object sender, EventArgs e)
        {
            rd = new Reader(TXB_name.Text, TXB_number.Text, TXB_address.Text);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

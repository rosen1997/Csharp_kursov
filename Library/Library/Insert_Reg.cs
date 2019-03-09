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
    public partial class Insert_Reg : Form
    {
        public CRegistry rg { get; set; }
        public Insert_Reg()
        {
            InitializeComponent();
        }

        private void BTN_take_Click(object sender, EventArgs e)
        {
            rg = new CRegistry(int.Parse(TXB_bookID.Text), int.Parse(TXB_readerID.Text));

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void TXB_bookID_KeyPress(object sender, KeyPressEventArgs e)
        {
            Registry.onlyNums(e);
        }

        private void TXB_readerID_KeyPress(object sender, KeyPressEventArgs e)
        {
            Registry.onlyNums(e);
        }
    }
}

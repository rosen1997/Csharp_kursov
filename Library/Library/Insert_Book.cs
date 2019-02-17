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
    public partial class Insert_Book : Form
    {
        public Book bk { get; set; }
        public Insert_Book()
        {
            InitializeComponent();
        }

        private void Insert_Book_Load(object sender, EventArgs e)
        {
           
        }

        private void BTN_addBook_Click(object sender, EventArgs e)
        {
            bk = new Book(TXB_title.Text, TXB_author.Text, TXB_publisher.Text, CB_available.Checked);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

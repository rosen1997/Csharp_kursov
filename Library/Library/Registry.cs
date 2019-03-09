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
    public partial class Registry : Form
    {
        public Registry()
        {
            InitializeComponent();
        }

        private void Registry_Load(object sender, EventArgs e)
        {
            try
            {
                this.rEGISTRYTableAdapter.Fill(this.libraryDataSet.REGISTRY);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void searchByBookIDToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.rEGISTRYTableAdapter.SearchByBookID(this.libraryDataSet.REGISTRY, ((int)(System.Convert.ChangeType(iDToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void searchByNumToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.rEGISTRYTableAdapter.SearchByNum(this.libraryDataSet.REGISTRY, nUMToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Registry_Load(sender, e);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow oneRow in dataGridView1.SelectedRows)
            {
                if (oneRow.Selected)
                {
                    DialogResult res = MessageBox.Show("Returning a book!", "Returning", MessageBoxButtons.OKCancel);
                    if (res == DialogResult.OK)
                    {

                        int ID_to_del = Convert.ToInt16(oneRow.Cells[0].Value);

                        try
                        {
                            this.rEGISTRYTableAdapter.ReturnBook(ID_to_del);
                            dataGridView1.Rows.RemoveAt(oneRow.Index);
                        }
                        catch (System.Exception ex)
                        {
                            System.Windows.Forms.MessageBox.Show(ex.Message);
                        }

                    }
                }

            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            bool bAvailable;// =(bool)booksTableAdapter1.GetAvailability(22);

            CRegistry reg;
            using (var form = new Insert_Reg())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    reg = form.rg;
                    bAvailable = (bool)this.booksTableAdapter1.GetAvailability(reg.getBookID());

                    if (bAvailable == true)
                    {

                        try
                        {
                            this.rEGISTRYTableAdapter.InsertQuery(reg.getBookID(), reg.getReaderID());
                            this.booksTableAdapter1.UpdateAvailable(false, reg.getBookID());
                        }
                        catch (System.Exception ex)
                        {
                            System.Windows.Forms.MessageBox.Show(ex.Message);
                        }

                        toolStripButton1_Click(sender, e);
                    }
                    else if(bAvailable==false)
                    {
                        MessageBox.Show("Book not available!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        public static void onlyNums(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void nUMToolStripTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNums(e);
        }

        private void iDToolStripTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNums(e);
        }
    }
}

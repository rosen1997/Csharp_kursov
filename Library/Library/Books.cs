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
    public partial class Books : Form
    {
        public Books()
        {
            InitializeComponent();
        }

        private void Books_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet.BOOKS' table. You can move, or remove it, as needed.
            try
            {
                this.bOOKSTableAdapter.Fill(this.libraryDataSet.BOOKS);
            }
            catch(System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void searchToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.bOOKSTableAdapter.Search(this.libraryDataSet.BOOKS, titleToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }


        private void TSB_available_books_Click(object sender, EventArgs e)
        {
            try
            {
                this.bOOKSTableAdapter.Show_Available_Books(this.libraryDataSet.BOOKS);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void TSB_refresh_Click(object sender, EventArgs e)
        {
            Books_Load(sender, e);
        }

        private void TSB_add_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            using (var form = new Insert_Book())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    book = form.bk;

                    try
                    {
                        this.bOOKSTableAdapter.InsertQuery(book.getTitle(), book.getAuthor(), book.getPublisher(), book.getAvailable());
                    }
                    catch (System.Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                    }

                    TSB_refresh_Click(sender, e);
                }
            }

        }

        private void TSB_remove_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow oneRow in dataGridView1.SelectedRows)
            {
                if (oneRow.Selected)
                {
                    DialogResult res = MessageBox.Show("Deleting a book!", "Delete", MessageBoxButtons.OKCancel);
                    if (res == DialogResult.OK)
                    {
                        
                        int ID_to_del =Convert.ToInt16(oneRow.Cells[0].Value);

                        try
                        {
                            this.bOOKSTableAdapter.DeleteBook(ID_to_del);
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

        private void update_available(bool chType)
        {
            foreach (DataGridViewRow oneRow in dataGridView1.SelectedRows)
            {
                if (oneRow.Selected)
                {

                    int ID_to_update = Convert.ToInt16(oneRow.Cells[0].Value);

                    try
                    {
                        this.bOOKSTableAdapter.UpdateAvailable(chType, ID_to_update);
                        dataGridView1[4, oneRow.Index].Value = chType;
                    }
                    catch (System.Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                    }

                }

            }
        }

        private void makeAvailableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            update_available(true);
        }

        private void makeUnavailableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            update_available(false);
        }

       
    }
}

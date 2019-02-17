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
    public partial class Readers : Form
    {
        public Readers()
        {
            InitializeComponent();
        }

        private void Readers_Load(object sender, EventArgs e)
        {
            try
            {
                this.rEADERSTableAdapter.Fill(this.libraryDataSet1.READERS);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void searchByNumberToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.rEADERSTableAdapter.SearchByNumber(this.libraryDataSet.READERS, nUMBERToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Readers_Load(sender, e);
        }

        private void registerAReaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reader reader = new Reader();
            using (var form = new Insert_Reader())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    reader = form.rd;

                    try
                    {
                        this.rEADERSTableAdapter.Insert(reader.getName(), reader.getNumber(), reader.getAddress());
                    }
                    catch (System.Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                    }

                    refreshToolStripMenuItem_Click(sender, e);
                }
            }
        }

        private void removeAReaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow oneRow in dataGridView1.SelectedRows)
            {
                if (oneRow.Selected)
                {
                    DialogResult res = MessageBox.Show("Removing a reader!", "Removing", MessageBoxButtons.OKCancel);
                    if (res == DialogResult.OK)
                    {

                        string Num_to_del = oneRow.Cells[1].Value.ToString();

                        try
                        {
                            this.rEADERSTableAdapter.DeleteByNum(Num_to_del);
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

        private void updateAReaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reader reader = new Reader();

            foreach (DataGridViewRow oneRow in dataGridView1.SelectedRows)
            {
                if (oneRow.Selected)
                {
                    int id =Convert.ToInt16(oneRow.Cells[0].Value);
                    string name = oneRow.Cells[1].Value.ToString();
                    string num = oneRow.Cells[2].Value.ToString();
                    string address = oneRow.Cells[3].Value.ToString();


                    using (var form = new Insert_Reader(name, num, address))
                    {
                        var result = form.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            reader = form.rd;

                            try
                            {
                                this.rEADERSTableAdapter.UpdateReader(reader.getNumber(), reader.getAddress(), id);
                            }
                            catch (System.Exception ex)
                            {
                                System.Windows.Forms.MessageBox.Show(ex.Message);
                            }

                            refreshToolStripMenuItem_Click(sender, e);
                        }
                    }
                }

            }
           
        }

    }
}

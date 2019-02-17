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
            // TODO: This line of code loads data into the 'libraryDataSet.READERS' table. You can move, or remove it, as needed.
            try
            {
                this.rEADERSTableAdapter.Fill(this.libraryDataSet.READERS);
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
    }
}

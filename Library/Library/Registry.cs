﻿using System;
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
    }
}
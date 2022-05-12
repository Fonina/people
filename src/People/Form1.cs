using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace People
{
    public partial class Form1 : Form
    {
        HR hr;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                hr.Add(tbSurname.Text, tbName.Text, Int32.Parse(tbAge.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка ввода! Подробности:" + ex.Message.ToString());
                return;
            }

            tbSurname.Clear();
            tbName.Clear();
            tbAge.Clear();
        }

        private void btnSetSize_Click(object sender, EventArgs e)
        {
            hr = new HR(Int32.Parse(tbSize.Text));
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            hr.Sort();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog SFD = new SaveFileDialog();
            SFD.FileName = "result";
            SFD.Filter = "text (*.txt)|*.txt";

            if (SFD.ShowDialog() == DialogResult.OK)
            {
                hr.writeToFile(SFD.FileName);
            }
        }
    }
}

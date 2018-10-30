using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            textBoxColumns.Text = "3";
            textBoxRows.Text = "3";
            dataGridViewMatrix.ColumnCount = int.Parse(textBoxColumns.Text);
            dataGridViewMatrix.RowCount = int.Parse(textBoxRows.Text);
        }

        private void textBoxColumns_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            int countRows;
            int countColumns;
            try
            {
                countRows = int.Parse(textBoxRows.Text);
            }
            catch
            {
                MessageBox.Show("Введите количество строк!");
                textBoxRows.Focus();
                return;
            }

            try
            {
                countColumns = int.Parse(textBoxColumns.Text);
            }
            catch
            {
                MessageBox.Show("Введите количество столбцов!");
                textBoxColumns.Focus();
                return;
            }

            int currentRows = dataGridViewMatrix.RowCount;
            int currentColums = dataGridViewMatrix.ColumnCount;

            if ((currentColums > countColumns) || (currentRows > countRows))
            {
                DialogResult dialogResult = MessageBox.Show(this, "Новый размер матрицы меньше текущего. Данные будут потеряны.", "Подтвердите изменение размера", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    dataGridViewMatrix.ColumnCount = currentColums; 
                    dataGridViewMatrix.RowCount = currentRows;
                    dataGridViewMatrix.Refresh();
                    /*for (int i = countColumns + 1; i <= currentColums; i++)
                    {
                        dataGridViewMatrix.Columns.RemoveAt(i);
                    }
                    for (int i = countRows + 1; i <= currentColums; i++)
                    {
                        dataGridViewMatrix.Columns.RemoveAt(i);
                    }*/

                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Lab_2.Handler;

namespace Lab_2
{
    public partial class MainForm : Form
    {
        Handler Helper = new Handler();

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
                    dataGridViewMatrix.ColumnCount = countColumns;
                    dataGridViewMatrix.RowCount = countRows;
                }
                else return;
            }
            else
            {
                dataGridViewMatrix.ColumnCount = countColumns;
                dataGridViewMatrix.RowCount = countRows;
            }
        }

        /*private void dataGridViewMatrix_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress += new KeyPressEventHandler(Cell_KeyPress);
        }

        private void Cell_KeyPress(object Sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.KeyChar = Convert.ToChar("\0");
        }*/

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxColumns.Text = "3";
            textBoxRows.Text = "3";
            textBoxResult.Clear();
            dataGridViewMatrix.Rows.Clear();
            dataGridViewMatrix.ColumnCount = 3;
            dataGridViewMatrix.RowCount = 3;
            textBoxRectangle.Clear();
            DefaultColor();
        }

        private void DefaultColor()
        {
            for (int i = 0; i < dataGridViewMatrix.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridViewMatrix.RowCount; j++)
                {
                    dataGridViewMatrix[i, j].Style.BackColor = System.Drawing.Color.White;
                }
            }

        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            DefaultColor();
            int[,] matrix = new int[dataGridViewMatrix.ColumnCount, dataGridViewMatrix.RowCount];
            bool IsEmpty = false;

            for (int column = 0; column < dataGridViewMatrix.Columns.Count; column++)
            {
                for (int row = 0; row < dataGridViewMatrix.Rows.Count; row++)
                {
                    if (dataGridViewMatrix[column, row].Value is null)
                    {
                        IsEmpty = true;
                        dataGridViewMatrix[column, row].Value = 0;
                    }
                    try
                    {
                        matrix[column, row] = Convert.ToInt32(dataGridViewMatrix[column, row].Value);
                    }
                    catch
                    {
                        MessageBox.Show(this, "Не удалось преобразовать значение этой ячейки в число", "Ошибка матрицы");
                        dataGridViewMatrix.CurrentCell = dataGridViewMatrix[column, row];
                        return;
                    }
                }
            }
            if (IsEmpty)
            {
                MessageBox.Show("Матрица оказалась заполнена не вся. Пустые ячейки будут заполнены нулями!");
            }

            Helper.FillMatrix(matrix, dataGridViewMatrix.ColumnCount, dataGridViewMatrix.RowCount);
            Info result = Helper.FindZeroRectangle();
            textBoxResult.Text = result.Result.ToString();
            textBoxRectangle.Text = "Полученный прямоугольник с суммой элементов, наиболее близких к нулю, задается координатами: [" + result.StartColumn.ToString() + ","
                + result.StartRow.ToString() + "] и [" + result.EndColumn + "," + result.EndRow.ToString() + "]";

            for (int i = result.StartColumn; i <= result.EndColumn; i++)
            {
                for (int j = result.StartRow; j <= result.EndRow; j++)
                {
                    dataGridViewMatrix[i, j].Style.BackColor = System.Drawing.Color.Aqua;
                }
            }
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            bool check = false;
            bool choice = false;

            for (int i = 0; i < dataGridViewMatrix.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridViewMatrix.RowCount; j++)
                {
                    if (!(dataGridViewMatrix[i, j].Value is null))
                    {
                        if (!check)
                        {
                            DialogResult dialogResult = MessageBox.Show(this, "Обнаружены уже введенные данные. Перезатереть их?", "Вопрос", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                choice = true;
                            }
                            check = true;
                        }
                        if (choice)
                        {
                            dataGridViewMatrix[i, j].Value = random.Next(-100, 100);
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else
                    {
                        dataGridViewMatrix[i, j].Value = random.Next(-100, 100);
                    }

                }
            }
        }
    }
}
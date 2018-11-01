using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Handler
    {
        private int columns;
        private int rows;
        private int[,] matrix;

        public void FillMatrix(int[,] _matrix, int _columns, int _rows)
        {
            matrix = _matrix;
            columns = _columns;
            rows = _rows;
        }

        public int FindZeroRectangle()
        {
            int result = int.MaxValue;

            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    int temp = Run(i, j);
                    if (Math.Abs(temp - 0) < Math.Abs(result - 0))
                    {
                        result = temp;
                    };
                }
            }

            return result;
        }

        public int Run(int _column, int _row)
        {
            //Промежуточный результат на выход
            int tempresult = int.MaxValue;
            //Промежуточный результат по столбцам/строкам
            int temp_ = 0;
            //Проверка на первую итерацию (т.к. нужна сумма нескольких ячеек, то мы не можем учитывать значение единственной ячейки)
            bool firstIteration = true;

            //Проход по столбцам сверху вниз
            for (int i = _column; i < columns; i++)
            {
                //мы проходим по текущему столбцу
                if (i == _column)
                {
                    int temp = 0;
                    for (int j = _row; j < rows; j++)
                    {
                        //в самом начале цикла, если мы попадаем на одну ячейку, то ее должны пропустить, т.к. нужна сумма
                        if (firstIteration)
                        {
                            temp += matrix[i, j];
                            firstIteration = false;
                            continue;
                        }

                        //на второй итерации уже можно сравнивать суммы
                        temp += matrix[i, j];
                        if (Math.Abs(temp - 0) < Math.Abs(tempresult - 0))
                        {
                            tempresult = temp;
                        };
                    }
                    temp_ += temp;
                }
                //если мы изменили i, то нам необходимо добавлять уже целый столбец, а не по ячейке
                else
                {
                    int temp = 0;
                    for (int j = _row; j < rows; j++)
                    {
                        temp += matrix[i, j];
                    }
                    if (Math.Abs(temp + temp_ - 0) < Math.Abs(tempresult - 0))
                    {
                        tempresult = temp + temp_;
                    };
                }
            }

            firstIteration = true;
            temp_ = 0;
            //Проход по строкам справа налево
            for (int j = _row; j < rows; j++)
            {
                //мы проходим по текущему столбцу
                if (j == _row)
                {
                    int temp = 0;
                    for (int i = _column; i < columns; i++)
                    {
                        //в самом начале цикла, если мы попадаем на одну ячейку, то ее должны пропустить, т.к. нужна сумма
                        if (firstIteration)
                        {
                            temp += matrix[i, j];
                            firstIteration = false;
                            continue;
                        }

                        //на второй итерации уже можно сравнивать суммы
                        temp += matrix[i, j];
                        if (Math.Abs(temp - 0) < Math.Abs(tempresult - 0))
                        {
                            tempresult = temp;
                        };
                    }
                    temp_ += temp;
                }
                //если мы изменили i, то нам необходимо добавлять уже целый столбец, а не по ячейке
                else
                {
                    int temp = 0;
                    for (int i = _column; i < columns; i++)
                    {
                        temp += matrix[i, j];
                    }
                    if (Math.Abs(temp + temp_ - 0) < Math.Abs(tempresult - 0))
                    {
                        tempresult = temp + temp_;
                    };
                }
            }

            return tempresult;
        }
    }
}

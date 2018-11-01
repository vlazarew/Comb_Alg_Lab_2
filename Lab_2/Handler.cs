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

        //Струтура для грамотного вывода на форма
        public struct Info
        {
            //Индекс начальной колонки
            public int StartColumn;
            //Индекс конечной колонки
            public int EndColumn;
            //Индекс начальной строки
            public int StartRow;
            //Индекс начальной строки
            public int EndRow;
            //Результат суммы прямоугольника
            public int Result;

            public Info(int _startcolumn, int _endcolumn, int _startrow, int _endrow, int _result)
            {
                StartColumn = _startcolumn;
                EndColumn = _endcolumn;
                StartRow = _startrow;
                EndRow = _endrow;
                Result = _result;
            }

        }

        public void FillMatrix(int[,] _matrix, int _columns, int _rows)
        {
            matrix = _matrix;
            columns = _columns;
            rows = _rows;
        }

        public Info FindZeroRectangle()
        {
            Info result = new Info(0, 0, 0, 0, int.MaxValue);

            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Info temp = Run(i, j);
                    if (Math.Abs(temp.Result - 0) < Math.Abs(result.Result - 0))
                    {
                        result = temp;
                    };
                }
            }

            return result;
        }

        public Info Run(int _column, int _row)
        {
            //Промежуточный результат на выход
            Info tempinfo = new Info(_column, _column, _row, _row, int.MaxValue);

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
                        if (Math.Abs(temp - 0) < Math.Abs(tempinfo.Result - 0))
                        {
                            tempinfo.Result = temp;
                            tempinfo.EndColumn = i;
                            tempinfo.EndRow = j;
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
                    if (Math.Abs(temp + temp_ - 0) <= Math.Abs(tempinfo.Result - 0))
                    {
                        tempinfo.Result = temp + temp_;
                        tempinfo.EndColumn = i;
                        tempinfo.EndRow = rows - 1;
                        temp_ += temp;
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
                        if (Math.Abs(temp - 0) < Math.Abs(tempinfo.Result - 0))
                        {
                            tempinfo.Result = temp;
                            tempinfo.EndColumn = i;
                            tempinfo.EndRow = j;
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
                    if (Math.Abs(temp + temp_ - 0) <= Math.Abs(tempinfo.Result - 0))
                    {
                        tempinfo.Result = temp + temp_;
                        tempinfo.EndColumn = columns - 1;
                        tempinfo.EndRow = j;
                        temp_ += temp;
                    };
                }
            }

            return tempinfo;
        }
    }
}

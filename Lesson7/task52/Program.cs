// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int [,] Fillarray (int row, int columns)
{
    int [,] array = new int[row, columns];
    for(int i = 0; i < row; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(1, 10);
            Console.Write(array[i, j]+ " ");
        }
        Console.WriteLine();
    }
    return array;
}

double [] Average (int [,] array)
{
  int row = array.GetLength(0);
  int columns = array.GetLength(1);
  double [] sumarray = new double [columns];
  for(int i = 0; i<columns;i++)
  {
    int summ = 0;
    for(int j =0; j<row;j++)
    {
       summ+= array[j,i];
    }
     sumarray [i]= (double)summ/(double)row;
  }
  return sumarray;
}

Console.WriteLine("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int [,] array = Fillarray ( row, columns);
double [] finishstr = Average(array);
Console.WriteLine(string.Join(", ",finishstr));

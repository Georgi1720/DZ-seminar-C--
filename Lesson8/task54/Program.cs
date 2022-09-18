// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int [,] FillArray (int row,int colomns)
{
  int [,] array = new int [row,colomns];
  for(int i = 0;i<row;i++)
  {
    for(int j = 0;j<colomns;j++)
    {
      array [j,i] = new Random().Next(1,10);
      Console.Write(array[j,i]+ " ");
    }
    Console.WriteLine();
  }
  return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] SortArray(int[,] array)
{
   int temp = 0;
   for(int n = 0; n < array.GetLength(1); n++)
   {
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            if (array[i, j] < array[i, j + 1])
            {
                temp = array[i, j];
                array[i, j] = array[i, j + 1];
                array[i, j + 1] = temp;
              
            }
        }
    }
   }
   return array;
}

Console.WriteLine("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов: ");
int colomns = Convert.ToInt32(Console.ReadLine());
int [,] array = FillArray(row,colomns);
Console.WriteLine();
PrintArray(SortArray(array));

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
int [,] FillArray(int row, int colomns)
{

  int [,] array = new int[row,colomns];
  Random rnd = new Random();

  for(int i = 0; i<array.GetLength(0);i++)
    {
      for(int j = 0; j<array.GetLength(1);j++)
      {
       array[i,j]= rnd.Next(1,10);
      }
    }
    return array;
}


void PrintArray (int [,] array)
{
  for(int i = 0; i<array.GetLength(0);i++)
  {
    for(int j = 0;j<array.GetLength(1);j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}


Console.WriteLine("Введите кол-во строк :");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов :");
int colomns = Convert.ToInt32(Console.ReadLine());
Random rnd = new Random();
int [,] arrayResult = FillArray( row, colomns);
PrintArray(arrayResult);

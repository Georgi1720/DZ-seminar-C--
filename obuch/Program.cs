// 3)Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]
//
// int [] array = new int [8];
// Random rnd = new Random();
//
// for (int i= 0;i<array.Length; i++)
//  {
//    array[i]=rnd.Next(0,2);
//  }
//  Console.WriteLine();
//  Console.Write(String.Join("|", array));

// //4) Создайте массив А[7] с помощью генератора случайных чисел и выведите его на экран. Увеличьте все его элементы в 2 раза.
// int [] array = new int [7];
// Random rnd = new Random();
// int [] resultArray = new int[7];
//
// for (int i = 0;i<array.Length;i++)
//  {
//     array[i]= rnd.Next(1,10);
//     resultArray[i]=array[i]*2;
//  }
//  Console.WriteLine(String.Join(",", array));
 //Console.WriteLine(String.Join(",", resultArray));

// 5) Создайте массив А[12] с помощью генератора случайных чисел с элементами от –20 до 10 и выведите его на экран.
//Замените все отрицательные элементы массива числом 0.
// int [] array = new int[12];
// Random rnd = new Random();
// int [] zeroarray = new int [12];
// for (int i = 0;i<array.Length;i++)
// {
//     array[i]=rnd.Next(-20,10);
//     zeroarray[i]=array[i];
//     if(zeroarray[i]<0)
//     {
//       zeroarray[i]=0;
//     }
// }
// Console.WriteLine(String.Join(",", array));
// Console.WriteLine(String.Join(",", zeroarray));



// 6) Найти сумму всех элементов массива чисел, больших заданного числа.
// Размерность массива – 20. Заполнение массива осуществить случайными числами от 50 до 100
  // Console.WriteLine("Введите число: ");
  // int maxnumber = Convert.ToInt32(Console.ReadLine());
  // int [] array = new int [5];
  // Random rnd = new Random();
  // for(int i = 0; i<array.Length;i++)
  //  {
  //     array[i]=rnd.Next(50,101);
  //  }
  //  Console.WriteLine(String.Join(",", array));
  //
  //  int sum = 0;
  //  for(int g = 0;g<array.Length;g++)
  //  {
  //    if(array[g]>maxnumber)
  //    sum=sum+array[g];
  //  }
  //  Console.WriteLine($"сумма элементов массива больше {maxnumber} равна {sum}");


  // 7)Найти минимальный и максимальный элемент массива заполненного случайными числами.
  // Размер массива - 10ж

  // int [] array = new int [10];
  // Random rnd = new Random();
  // for(int i = 0 ; i<array.Length;i++)
  // {
  //   array[i]= rnd.Next(1,11);
  // }
  // Console.WriteLine(String.Join(",",array));
  // int maxnumber = array.Max();
  // int minnumber = array.Min();
  // Console.WriteLine($"Максимальное число массива {maxnumber},а минимальное {minnumber}");


// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// // [-4, -8, 8, 2] -> [4, 8, -8, -2]
// int [] array = new int [4];
// Random rnd = new Random();
// int [] obrarray = new int [4];
// for(int i = 0,  g = 0;i < array.Length; i++,g++)
//  {
//     array[i]=rnd.Next(-5,5);
//     obrarray[g]=array[i]*-1;
//  }
//  Console.WriteLine(String.Join(",", array));
//  Console.WriteLine(String.Join(",", obrarray));
// Console.WriteLine("введи число в десятичной системе ");
// int a = Convert.ToInt32(Console.ReadLine());
// for(int i =0; i<a;i++)
// {
//   if(a%2==0)
//   int ost = ost+
//   else
// }




// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5





// Console.WriteLine("Введите числа: n ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите числа:  m ");
// int n = Convert.ToInt32(Console.ReadLine());
// int [,] array = new int [m,n];
//
// for(int i =0; i<m;i++)
// {
//   for(int g =0; g<m;g++)
//   {
//     array[i,g] = i+g;
//     Console.Write(array[i,g]);
//   }
// }
// Console.Write(array[i,g]);

//Задания еще на второй странице
//Задача дополнительная
//Задайте двумерный массив. Найдите сумму элементов, находящихся ниже главной диагонали

// int[,] Fill2DArray(int m, int n)
// {
//     int[,] array = new int[m,n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             array[i,j] = new Random().Next(1,10);
//         }
//     }
//     return array;
// }
//
// int SumElement(int[,] array, int row, int colomns)
// {
//     int result = 0;
//     for (int i = row-1; i >= 0; i--)
//     {
//         for (int j = colomns-1; j >= 0; j--)
//         {
//             if(i == j)
//             {
//                 result += array[i,j];
//             }
//         }
//     }
    // return result;
// }
//
// void PrintArray(int[,] array, int row, int colomns)
// {
//     int mSize = row;//array.GetLength(0);
//     int nSize = colomns;//array.GetLength(1);
//     for (int i = 0; i < mSize; i++)
//         {
//             Console.WriteLine();
//             for (int j = 0; j < nSize; j++)
//             {
//                 Console.Write(array[i,j]+" ");
//             }
//
//         }
//
// }
// Console.WriteLine("Введите число строк: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число столбцов: ");
// int colomns = Convert.ToInt32(Console.ReadLine());
// int[,] arrayFill = Fill2DArray(row,colomns);
// PrintArray(arrayFill,row,colomns);
// Console.WriteLine();
// int sum = SumElement(arrayFill,row,colomns);
// Console.WriteLine("Сумма главной диагонали = "+sum);

// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 8 4 2 4
// 5 9 2 3
// 1 4 7 2

// int[,] FillArray(int m, int n)
//  { int[,] array = new int[m, n];
//    for (int i = 0; i < m; i++)
//    { for (int j = 0; j < n; j++)
//      { array[i, j] = new Random().Next(0, 10);
//        }
//        } return array;
//        }
//        void PrintArray(int[,] array)
//         {
//           for (int i = 0; i < array.GetLength(0); i++)
//            {
//              for (int j = 0; j < array.GetLength(1); j++)
//               {
//                 Console.Write(array[i, j] + " ");
//                 } Console.WriteLine();
//                 }
//                  }
//                   int[,] ReversString(int[,] array)
//                    {
//                      int temp = 0;
//                       int i = 0;
//                       for (int j = 0; j < array.GetLength(1); j++)
//                       {
//                         temp = array[i,j];
//                         array[i,j] = array[array.GetLength(0)-1,j];
//                         array[array.GetLength(0)-1,j] = temp;
//                          } return array;
//                          }
//                          int[,] array = FillArray(5, 5);
//                          PrintArray(array); Console.WriteLine();
//                          PrintArray(ReversString(array));

// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
//  В случае, если это невозможно, программа должна вывести сообщение для пользователя.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// В итоге получается вот такой массив:
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7

//int[,] FillArray(int m, int n) { int[,] array = new int[m, n]; for (int i = 0; i < m; i++) { for (int j = 0; j < n; j++) { array[i, j] = new Random().Next(0, 10); } } return array; } void PrintArray(int[,] array) { for (int i = 0; i < array.GetLength(0); i++) { for (int j = 0; j < array.GetLength(1); j++) { Console.Write(array[i, j] + " "); } Console.WriteLine(); } } int[,] ReverseArray(int[,] array) { int row = array.GetLength(0); int columns = array.GetLength(1); int[,] numbers = new //int[row, columns]; for (int i = 0; i < columns; i++) { for (int j = 0; j < row; j++) { numbers[i,j] = array[j,i]; } } return numbers; } Console.WriteLine("Введите колличество строк: "); int m = Convert.ToInt32(Console.ReadLine()); Console.WriteLine("Введите колличество столбцов: "); int n = Convert.ToInt32(Console.ReadLine()); int[,] array = FillArray(m, n); PrintArray(array); Console.WriteLine(); if (m == n) { PrintArray(ReverseArray(array)); } else Console.WriteLine("Некорректные данные");

// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза

// Console.WriteLine("Введите кол-во строк: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите кол-во столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// int[,] array = Fillarray(row, columns);
//
//
// int [,] Fillarray (int row, int columns)
// {
//     int [,] array = new int[row, columns];
//     for(int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//             Console.Write(array[i, j]+ " ");
//         }
//         Console.WriteLine();
//     }
//     return array;
//
// }
//
// int [,] Chtochto (int [] array)
// {
//   int [] newArray = new int [row];
//   for(int i =0;i<array.GetLength(0);i++)
//   {
//
//     for(int j =0;j<array.GetLength(1);j++)
//       {
//         if(newArray[i]==newArray[j])
//       }
//   }
// }

// int[] a = { 4,5,8,8,8,8};
// Dictionary<int, int> Count = new Dictionary<int, int>();
// for (int i = 0; i < a.Length; i++)
// {
//     for (int j = i; j < a.Length; j++)
//     {
//         if (a[i] != a[j])
//           {
//             Count.Add(a[i], j - i);
//             i = j - 1;
//             break;
//           }
//         if (j == a.Length - 1)
//           {
//             Count.Add(a[i], j - i + 1);
//             i = j;
//           }
//     }
// }

// foreach (var elem in Count)
// {
// System.Console.WriteLine($"{elem.Key} встречено {elem.Value}");
// }




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

Console.WriteLine("стррока");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("столб");
int colomns = Convert.ToInt32(Console.ReadLine());
int [,] array = FillArray(row,colomns);
Console.WriteLine();
PrintArray(SortArray(array));



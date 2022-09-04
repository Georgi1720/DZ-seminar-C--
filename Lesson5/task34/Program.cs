// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int [] array = new int [3];
Random rnd = new Random();
int count = 0;
   
   for(int i=0;i<array.Length;i++)   
   {
       array[i]=rnd.Next(100,999);
       if(i==0)
        {
            Console.Write($"[ {array[i]}, ");
        }
       else if(i>=1 && i<=array.Length-2)
        {
            Console.Write($"{array[i]}, ");
        }
       else 
        {
            Console.Write($"{array[i]} ] ");
        }
   }
   
   for (int g = 0;g<array.Length;g++)   // прошелся по массиву с проверкой на чётность 
   {
       if(array[g]%2==0) count = count+1;

   }
Console.WriteLine();
Console.WriteLine($"В этом массиве четных чисел: {count}шт");
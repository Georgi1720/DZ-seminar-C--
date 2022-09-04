// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
//стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0



 int [] array = new int [5];
   Random rnd= new Random();
   int sumnechet = 0;
   
   for(int i=0;i<array.Length;i++)
   {
       array[i]=rnd.Next(1,50);
       if (i==0)
       {
           Console.Write($"[ {array[i]},");
       }
       else if (i>=1 && i<=array.Length-2)
       {
           Console.Write($" {array[i]},");
       }
       else
       {
           Console.Write($" {array[i]} ]");
       }
   }
   
   for(int g = 0;g<array.Length;g++)
   {
        if(g==0)
        {
            
        }
        else if(g%2 != 0) sumnechet+=array[g];
   }
   
   Console.WriteLine();
   Console.WriteLine($"Сумма нечетных позиций массива равна: {sumnechet}");

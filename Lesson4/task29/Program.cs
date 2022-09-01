// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int [] array = {1,2,3,80,5,6,7,13}; 
for(int i =0; i<array.Length;i++)
{
  if(i==0)
   	{
     Console.Write($"[ {array[i]}, ");
    }
	 else if (i>=1 && i<array.Length-1)
    {
  	 Console.Write($"{array[i]}, ");
   	} 
	 else 
  	{
     Console.Write($"{array[i]} ] ");    
	}
}

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] array = new int[4];
Random random = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(1,50);
    if(i == 0)
    {
       Console.Write($"[ {array[i]},");
    }
    else if(i >=1 && i<=array.Length-2)
    { 
       Console.Write($"{array[i]},");
    }
    else if(i == array.Length-1)
    {     
        Console.Write($"{array[i]} ]");
    }
    
}
int maxNumber = array.Max();
int minNumber = array.Min();
int result = maxNumber - minNumber;
Console.WriteLine();
Console.WriteLine($"Разница между минимальным и максимальным элементом массива равна {result}");
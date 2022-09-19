// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""


static void Enumeration(int start, int finish)
{
    if (start <finish)
    {
        Console.Write($"{start},");
        Enumeration(++start, finish);
    }
    else
    {
        Console.Write($"{start}");
    }
}

Console.WriteLine("Введите начало диапазона : ");
int start = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите окончание диапазона : ");
int finish = Convert.ToInt32(Console.ReadLine());
Enumeration(start,finish);
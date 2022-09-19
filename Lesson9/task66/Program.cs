// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30



static int InterimAmount(int start, int finish)
{
    if (start < finish)
    {
        
        return start + InterimAmount(++start, finish);
    }
    else
    {
        return start;
    }
}
Console.WriteLine("Введите начало диапазона суммирования: ");
int start = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите окончание диапазона суммирования: ");
int finish = Convert.ToInt32(Console.ReadLine());
int summ = InterimAmount(start, finish);
Console.WriteLine();
Console.WriteLine($"Сумма указанного диапазона равна {summ} ");



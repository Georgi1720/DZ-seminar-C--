// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.WriteLine("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    string a = Convert.ToString(number);
    if(a.Length<2)
    {
        Console.WriteLine("Это третьей цифры нет ");
    }
    else
    {
        Console.WriteLine("Третья цифра числа равна " + a[2]);
    }
    
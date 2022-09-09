// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
int ReadConsole(int count)
{
    Console.WriteLine("Введите число :");
    string number = Console.ReadLine();

    if(number == "stop") return count;
    else
    {
        int numberstr = Convert.ToInt32(number);
            if( numberstr > 0) return ReadConsole(count+1);
        return ReadConsole(count);
    }
}


Console.WriteLine($"Для завершения введите слово 'stop' ");
int result = ReadConsole(0);

Console.WriteLine($"Чисел больше 0- {result} шт");

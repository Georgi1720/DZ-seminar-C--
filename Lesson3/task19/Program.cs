// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
string b = Convert.ToString(a);
char num1 = b[0];
char num2 = b[1];
char num3 = b[2];
char num4 = b[3];
char num5 = b[4];
if(num1==num5 && num2==num4)
{
    Console.WriteLine("Это палиндром");
}
else
{
    Console.WriteLine("Это НЕ палиндром");
}

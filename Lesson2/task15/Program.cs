﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if(a>7 || a<0)
{
    Console.WriteLine("Это число не обозначает какой либо день недели ");
}
else if(a>=1 && a<6)
{
    Console.WriteLine("Рабочий день и солнце еще высоко");
}
else
{
    Console.WriteLine("Ура, Выходной!");
}
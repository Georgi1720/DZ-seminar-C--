// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
string numb = Console.ReadLine();
int sum =0;
for(int i=0;i<numb.Length;i++)
{
    int cifr =numb[i]-'0';
    sum=sum+cifr;
}

Console.WriteLine(sum);
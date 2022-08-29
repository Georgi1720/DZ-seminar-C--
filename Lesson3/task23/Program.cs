//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int index = 1;
int kub = 0;
while(index<a+1)
{
    kub =(index*index*index);
    Console.WriteLine(kub);
    index++;

}

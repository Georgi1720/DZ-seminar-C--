//Задача 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17->такого числа в массиве нет


Console.WriteLine("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число для поиска в массиве: ");
int match = Convert.ToInt32(Console.ReadLine());
int[,] array = Fillarray(row, columns);
Accordance(array);



int [,] Fillarray (int row, int columns)
{
    int [,] array = new int[row, columns];
    for(int i = 0; i < row; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(1, 10);
            Console.Write(array[i, j]+ " ");
        }
        Console.WriteLine();
    }
    return array;

}

void Accordance (int [,] array)
{
int row = array.GetLength(0);
int columns = array.GetLength(1);
int count = 0;
 for(int i = 0; i<row;i++)
 {
    for(int j = 0; j<columns;j++)
    {
        if(array[i,j]==match)
        {
            count = count+1;
        }
        else
        {

        }
    }

 }
 if(count>0)  Console.WriteLine($"число {match} в массиве присутствует ");
 else Console.WriteLine($"число {match} в массиве отсутствует ");
}

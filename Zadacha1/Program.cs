/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/
int[,] ArrayMatrix(int m, int n)
{
    Random rnd = new Random();
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.WriteLine($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int GetNumber(string message)
{
    System.Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}

int[,] GetArray(int[,] array)
{
    int[,] resultArray = new int[array.GetLength(0), array.GetLength(1)];
    
}



// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double [,] CreateRandomArray ()
{
    Console.Write("Enter the number of rows m: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter number of columns n: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    double [,] array = new double [m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(0,100) + new Random().NextDouble();
        }
    }
    return array;
}

void PrintArray(double[,]array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j <array.GetLength(1); j++)
        {
            Console.Write(array[i, j].ToString("00.0000000"+ "  "));
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[,] arr = CreateRandomArray();
PrintArray(arr);


/*

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int [,] CreateRandomArray ()
{
    Console.Write("Enter the number of rows: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter number of columns: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Element position in two-dimensional array i: ");
    int k = Convert.ToInt32(Console.ReadLine());
    Console.Write("Element position in two-dimensional array j: ");
    int l = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    int [,] array = new int [m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(0,100);
        }
    }
    if (k>=m || l>=n) Console.Write("There is no such element");
    else Console.Write($"array[{k}, {l}] = {array[k, l]}");
    Console.WriteLine();
    return array;
}

void PrintArray(int[,]array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j <array.GetLength(1); j++)
        {
            Console.Write(array[i, j].ToString("0,0"+ "  "));
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] arr = CreateRandomArray();
PrintArray(arr);

*/

/*

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


int [,] CreateRandomArray ()
{
    Console.Write("Enter the number of rows: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter number of columns: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    int [,] array = new int [m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(0,100);
        }
    }
    Console.WriteLine();
    return array;
}


void PrintArray(int[,]array)
{   
    int m = array.GetLength(0);
    int n = array.GetLength(1);
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(array[i, j].ToString("0,0"+ "  "));
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    double [] arrayAverage = new double [n];
    double sum = 0;
    for (int j = 0; j < n; j++)
    {
        for (int i = 0; i < m; i++)
        {
            sum += array[i, j];    
        }
        arrayAverage[j] = sum / m;
        sum = 0;
    }
    for (int j = 0; j < n; j++)
        {
            Console.WriteLine($"arrayAverage[{j}] = {arrayAverage[j]}");
        }
    Console.WriteLine();
}

int[,] arr = CreateRandomArray();
PrintArray(arr);

*/



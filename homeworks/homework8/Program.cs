/*

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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


int [,] SortArray (int[,]array)
{
    int m = array.GetLength(0);
    int n = array.GetLength(1);
    Console.WriteLine();
    for (int k = 0; k < n; k++)
    {    
        for (int i = 0; i < m; i++)
        {
            for (int j = n-1; j > 0; j--)
            {
                if (array[i, j] > array[i, j-1])
                {   
                    int temp = array[i, j];
                    array[i, j] = array[i, j-1];
                    array[i, j-1] = temp;
                }
            }
        }
    }
    return array;
}
 
    int[,] arr = CreateRandomArray();
    PrintArray(arr);
    SortArray(arr);
    PrintArray(arr);

*/

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

/*

int [,] CreateRandomArray ()
{
    Console.Write("Enter the number of rows: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    int [,] array = new int [m, m];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < m; j++)
        {
           array[i, j] = new Random().Next(0,100);
        }
    }
    return array;
}


void MinSumStr (int[,]array)
{
    int m = array.GetLength(0);
    Console.WriteLine();
    int sum = 0;
    int min = 0;
    int rows = 0;
           
    for (int i = 0; i < m; i++)
    {
        sum = 0;
        for (int j = 0; j < m; j++)  sum += array[i, j];
               
        if (i == 0 || sum < min) 
        {
            min = sum;
            rows = i;
        }
    }     
    Console.WriteLine($"The row with the smallest sum of elements: {rows+1},  Min Sum: {min}");
    Console.WriteLine();
 
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
    MinSumStr (arr);
    
*/

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

/*

int [,] CreateRandomArray (int m, int n )
{
    Console.WriteLine();
    int [,] array = new int [m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(0,10);
        }
    }
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
 


int[,] arr1 = CreateRandomArray(2, 2);
int[,] arr2 = CreateRandomArray(2, 2);
Console.WriteLine("Matrix multiplication 2X2");
Console.WriteLine();
Console.WriteLine("A");
PrintArray(arr1);
Console.WriteLine("B");
PrintArray(arr2);
Console.WriteLine("C");
int [,] arrayC = new int [2, 2];
arrayC[0, 0] = arr1[0, 0] * arr2[0, 0] +  arr1[0, 1] * arr2[1, 0];
arrayC[0, 1] = arr1[0, 0] * arr2[0, 1] +  arr1[0, 1] * arr2[1, 1];
arrayC[1, 0] = arr1[1, 0] * arr2[0, 0] +  arr1[1, 1] * arr2[1, 0];
arrayC[1, 1] = arr1[1, 0] * arr2[0, 1] +  arr1[1, 1] * arr2[1, 1];
PrintArray(arrayC);

*/

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.

/*

int [,,] CreateRandomArray (int m, int n, int k )
{
    Console.WriteLine();
    int [,,] array = new int [m, n, k];
    int schetchik = 10;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int l = 0; l < k; l++)
            {
                array[i, j, l] = schetchik;
                schetchik++;
            }
        }
    }
    return array;
}


void PrintArray(int[,,]array, int sloy)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j <array.GetLength(1); j++)
        {
            Console.Write(array[i, j, sloy].ToString("0,0"+ "  "));
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}



int[,,] arr = CreateRandomArray(6, 5, 3);
Console.WriteLine("0 layer");
PrintArray(arr, 0);
Console.WriteLine("1 layer");
PrintArray(arr, 1);
Console.WriteLine("2 layer");
PrintArray(arr, 2);


*/



// Задача 62. Напишите программу, которая заполнит спирально массив


int [,] CreateRandomArray (int m, int n )
{
    int num = 1;
    Console.WriteLine();
    int [,] array = new int [m, n];
    for (int i = 0; i < 1; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = num;
            num++;
        }
    }
    for (int i = m-1; i < m; i++)
    {
        for (int j = 1; j < n; j++)
        {
            array[j, i] = num;
            num++;
        }
    }
    for (int i = m-1; i < m; i++)
    {
        for (int j = 0; j < n-1; j++)
        {
            array[i, j] = num+n-2;
            num--;
        }
    }
    for (int i = 1; i < m-1; i++)
    {
        for (int j = 0; j < 1; j++)
        {
            array[i, j] = num+3*n-5;
            num--;
        }
    }

    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    System.Threading.Thread.Sleep(100);
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


System.Threading.Thread.Sleep(100);
int[,] arr = CreateRandomArray(7,7);
System.Threading.Thread.Sleep(100);
PrintArray(arr);









/*

 
int [,] CreateRandomArray (int m, int n )
{
    int num = 1;
    Console.WriteLine();
    int [,] array = new int [m, n];
    for (int i = 0; i < 1; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = num;
            num++;
        }
    }
    for (int i = m-1; i < m; i++)
    {
        for (int j = 1; j < n; j++)
        {
            array[j, i] = num;
            num++;
        }
    }
    for (int i = m-1; i < m; i++)
    {
        for (int j = 0; j < n-1; j++)
        {
            array[i, j] = num+n-2;
            num--;
        }
    }
    for (int i = 1; i < m-1; i++)
    {
        for (int j = 0; j < 1; j++)
        {
            array[i, j] = num+3*n-5;
            num--;
        }
    }














*/

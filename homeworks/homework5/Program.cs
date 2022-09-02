
//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

/*

void even(int[]a)
{
    for (int i=0; i<a.Length; i++)
    {
        Console.WriteLine($"a[{i}] = {a[i]}");
    }

    int n=0;
    for (int i=0; i<a.Length; i++)
    {
        if (a[i]%2==0) n++;
    }
    Console.WriteLine($"The number of even numbers in the array = {n}");
}


Console.Write("Enter the number of array elements: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] arr = new int[size];
for (int i=0; i<size; i++)
    arr[i]=new Random().Next(100, 1000);
even(arr);

*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

/*

void sum(int[]a)
{
    int n=0;
    for (int i=0; i<a.Length; i++)
    {
        if (i%2==1) n+=a[i];
    }
    for (int i=0; i<a.Length; i++)
    {
        Console.WriteLine($"a[{i}] = {a[i]}");
    }
    Console.WriteLine($"sum of elements in odd positions = {n}");
}


Console.Write("Enter the number of array elements: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] arr = new int[size];
for (int i=0; i<size; i++)
    arr[i]=new Random().Next(0, 10);
sum(arr);

*/

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

/*

void razn(double[]a)
{   
    double min=a[0];
    double max=a[0];
    for (int i=0; i<a.Length; i++)
    {
        if (a[i]>max) max=a[i];
        if (a[i]<min) min=a[i];
    }
    Console.WriteLine($"the difference between the maximum and minimum array elements = {max-min}");
}


Console.Write("Enter size array of real numbers: ");
int size = Convert.ToInt32(Console.ReadLine());
double [] arr = new double[size];
for (int i=0; i<size; i++)
{
    arr[i]=new Random().Next(0, 10);
    arr[i]+=new Random().NextDouble();
    Console.WriteLine($"arr[{i}] = {arr[i]}");
}
razn(arr);

*/

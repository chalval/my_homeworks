
//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/*

int degree (int a, int b)
{
    int st = 1;
    for (int i=0; i<b; i++) 
        st=st*a;
    return st;
}

Console.Write("Input first number A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number B: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("A to natural degree B = " + degree(a, b));

*/

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*

long sum (long n)
{  
    long size=0;
    for (long i=1; i<n; i*=10) size++;
    if (n<2) size=1;
    if(n%10==0 && n!=0) size++;
    //Console.WriteLine("size="+size);
    long[]num = new long[size];
    for (long i=0; i<size; i++)
    {
        num [i] = n%10;
        n=n/10;
        //Console.WriteLine($"num [{i}] = {num [i]}");
    }
    long summa=0;
    for (long i=0; i<size; i++)
        summa+=num[i];
    return summa;
}

Console.Write("Please enter a number up to 18 digits: ");
long number = Convert.ToInt64(Console.ReadLine());
Console.WriteLine("The sum of the digits in a number: " + sum(number));

*/

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

/*

void inp(int size)
{
    int[]array = new int[size];
    for (int i=0; i<size; i++)
    {    
        Console.Write($"Enter array element array[{i}] = ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    for (int i=0; i<size; i++)
        Console.Write($"array[{i}] = {array[i]}, ");
}

Console.Write("Enter the number of array elements: ");
int size = Convert.ToInt32(Console.ReadLine());
inp(size);
Console.WriteLine();

*/


﻿/*

// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1>num2) 
{
    Console.WriteLine($"First number {num1} > second number {num2}");
}
else if (num1<num2) 
{
    Console.WriteLine($"First number {num1} < second number {num2}");
}
else 
{
    Console.WriteLine($"First number {num1} = second number {num2}");
}

*/

/*

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;
if (num2>max)
{
    max = num2;
}
if (num3>max)
{
    max = num3;
}
Console.WriteLine($"Largest number {max}");

*/

/*

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num%2 == 0)
{
    Console.WriteLine($"number {num} is even");
}
else
{
    Console.WriteLine($"number {num} is not even");
}

*/

/*

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Input number N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Even numbers from 1 to N: ");
int index=1;
while (index <= n)
{
    if (index%2 == 0)
    {
        Console.Write(index + " ");
    }
    index++;
}
Console.WriteLine();

*/




/*
// личные задачки

Console.Clear();
// Console.SetCursorPosition(4, 10);
// Console.WriteLine("+");

int x1=10, y1=30, x2=60, y2=1, x3=90, y3=35;
Console.SetCursorPosition(x1, y1);
Console.WriteLine("1");
Console.SetCursorPosition(x2, y2);
Console.WriteLine("2");
Console.SetCursorPosition(x3, y3);
Console.WriteLine("3");
int t1=0, i=0;
int x=x1, y=y1;


while (i<100000)
{   t1=new Random().Next(0, 3);
    if (t1==0)
    {
        x=(x+x1)/3;
        y=(y+y1)/3;
        Console.SetCursorPosition(x, y);
        Console.WriteLine("1");
    }
    if (t1==1)
    {
        x=(x+x2)/3;
        y=(y+y2)/3;
        Console.SetCursorPosition(x, y);
        Console.WriteLine("2");
    }
    if (t1==2)
    {
        x=(x+x3)/3;
        y=(y+y3)/3;
        Console.SetCursorPosition(x, y);
        Console.WriteLine("3");
    }
    //System.Threading.Thread.Sleep(100);
    i++;
}
*/
/*
//int[]ddd=new int[5];
//Console.WriteLine(ddd[3]);

//double[]fff=new double[8];
//fff[3]=1.44;
//Console.WriteLine(fff[3]+1.2);
*/



decimal[]fff=new decimal[8];
fff[3]=1.44444444444444444444444444444444444444444444444444444444444444444444444M;
decimal c = fff[3]+1.22222222222222222222222222222222222222222222222222222222222222M;
Console.WriteLine(c);









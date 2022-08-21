/*

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


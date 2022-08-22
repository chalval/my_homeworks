

// Знакомство с языками программирования (семинары)
//Урок 2. Массивы и функции в программировании

//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*

int second (int a)
{
int b = (a%100-a%10)/10;
return b;
}

Console.Write("Input three-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"The second digit of this number: {second(num)}");

*/

/*

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.



void third (int n)
{
    if (n < 100) 
    {
        Console.WriteLine("No third digit");
        return;
    }    
    while (n > 999) n = n / 10;
    Console.WriteLine($"Third digit: {n%10}");
    return;
}

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
third(num);

*/

/*

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


bool weekend (int num)
{
    if (num > 5  &&  num < 8) return true;
    else return false;
}

Console.Write("Input day number: ");
int day = Convert.ToInt32(Console.ReadLine());
if (weekend(day)) Console.WriteLine("Weekend");
else Console.WriteLine("No weekend");

*/


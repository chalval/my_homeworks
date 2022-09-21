
/*

// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

void Natural(int m, int n)
{
    if(n > m) Natural(m, n-1);
    Console.Write(n + " ");
}

Console.Write("Enter the first natural number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second natural number: ");
int n = Convert.ToInt32(Console.ReadLine());

Natural(m, n);
Console.WriteLine();

*/

/*

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.


int NaturalSum(int m, int n)
{
    if(n >= m) return m + NaturalSum(m+1, n);
    else return 0;
}

Console.Write("Enter the first natural number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second natural number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Summa = " + NaturalSum(m, n));
Console.WriteLine();

*/

/*

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// Формула вычисления  https://wikimedia.org/api/rest_v1/media/math/render/svg/c8c2aa0b20532014ea35c4a09c2380a01b3d1423


int Akkerman(int m, int n)
{
if (m == 0) return n + 1;
if ( m >0 && n == 0) return Akkerman(m-1, 1);
if (m > 0 && n > 0) return Akkerman(m - 1, Akkerman(m, n - 1));
else return 0;
}

Console.Write("Enter the first integer m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second integer n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"A(m, n) = A({m},{n}) = " + Akkerman(m, n));
Console.WriteLine();

*/

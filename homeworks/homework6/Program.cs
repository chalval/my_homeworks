
//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

/*

int kolvo(int m)
{
    int n=0;
    for (int i=0; i<m; i++)
    {
        Console.Write($"Enter the number {i+1} : ");
        int mm = Convert.ToInt32(Console.ReadLine());
        if (mm>0) n++;
    }
    return n;
}

Console.Write("How many numbers are we going to enter: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{kolvo(m)} numbers greater than 0 entered by the user");

*/

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

/*

Console.Write("Input coordinates b1 of the first point: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input coordinates k1 of the first point: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input coordinates b2 of the first point: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input coordinates k2 of the first point: ");
double k2 = Convert.ToDouble(Console.ReadLine());
double x=(b2-b1)/(k1-k2);
double y= k1*x+b1;
Console.WriteLine($"x={x}, y={y}");

*/

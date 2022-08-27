
//Знакомство с языками программирования (семинары)

//Урок 3. Массивы и функции в программировании

//Задача 19 Напишите программу, которая принимает на вход многозначное число и проверяет, является ли оно палиндромом.

/*

bool sravn (int n)
{
    int size=0;
    for (int i=1; i<n; i*=10) size++;
    if (n<2) size=1;
    if(n%10==0 && n!=0) size++;
    //Console.WriteLine("size="+size);
    int[]num = new int[size];
    for (int i=0; i<size; i++)
    {
        num [i] = n%10;
        n=n/10;
        //Console.WriteLine($"num [{i}] = {num [i]}");
    }
    for (int i=0; i<=size/2; i++)
    {
        if (num[i]!=num[size-i-1]) return false;
    }
return true;
}

Console.Write("Please enter a number up to 9 digits: ");
int number = Convert.ToInt32(Console.ReadLine());
if (sravn(number)) Console.WriteLine($"Number {number} is a palindrome");
else Console.WriteLine($"Number {number} is not a palindrome");

*/

Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.




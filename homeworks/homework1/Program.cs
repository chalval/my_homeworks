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

/*

decimal[]fff=new decimal[8];
fff[3]=1.44444444444444444444444444444444444444444444444444444444444444444444444M;
decimal c = fff[3]+1.22222222222222222222222222222222222222222222222222222222222222M;
Console.WriteLine(c);


bool sravn (long n)
{
    long size=0;
    for (long i=1; i<n; i*=10) 
    {
        size++;
        Console.WriteLine("i="+i);
        if (size>23) break;
    }    
    if (n<2) size=1;
    if(n%10==0 && n!=0) size++;
    Console.WriteLine("size="+size);
    long[]num = new long[size];
    for (long i=0; i<size; i++)
    {
        num [i] = n%10;
        n=n/10;
        Console.WriteLine($"num [{i}] = {num [i]}");
    }
    for (long i=0; i<=size/2; i++)
    {
        if (num[i]!=num[size-i-1]) return false;
    }
return true;
}

Console.Write("Please enter a number up to 9 digits: ");
long number = Convert.ToInt64(Console.ReadLine());
if (sravn(number)) Console.WriteLine($"Number {number} is a palindrome");
else Console.WriteLine($"Number {number} is not a palindrome");

*/
//bool i=false;
//Console.ReadKey(true);
//Console.WriteLine(i);

// Generate and display 5 random floating point values from 0 to 1.
//var rand = new Random();

/*
Console.WriteLine("Five Doubles.");
for (int ctr = 0; ctr <= 10000; ctr++)
{
    int i=new Random().Next(-20,8);
    Console.Write(" "+i);
    Console.Write("|"+rand.Next(1,8));
    }
Console.WriteLine();
*/
/*
double x=9;
double y=10.5;
double i=Math.Pow(x, y);
Console.WriteLine(i/3);
*/

// рекурсия факториал эксперимент
/*
decimal fact(int n)
{
    if (n==0) return 1;
    //System.Threading.Thread.Sleep(1);
    //Console.WriteLine($"fact({n-1}) = {fact(n-1)}");
    //System.Threading.Thread.Sleep(100);
    //else 
    return n*fact(n-1);
}

for (int i = 0; i < 27; i++)
{
    Console.WriteLine($"fact({i}) = {fact(i)}");
}
*/
/*
double [,,] t = new double[3,2,1];

for (int i = 0; i < t.GetLength(0); i++)
{
    for (int j = 0; j < t.GetLength(1); j++)
    {
        for (int k = 0; k < t.GetLength(2); k++)
        {   
            //int i=new Random().Next(-20,8);
            t[i, j, k] = new Random().Next(0,100) + new Random().NextDouble();
            Console.WriteLine($"t[{i}, {j}, {k}] = {t[i, j, k]}");
        }
    }
}

*/
/*

var chars = new[]
{
    'j',
    '\u006A',
    '\x006A',
    (char)106,
    (char)107,
    //77755555,
};
Console.WriteLine(string.Join(" ", chars));  // output: j j j j k
string v="\u006A";
int c=107;
char p=(char)c;
char t=Convert.ToChar(v);
Console.WriteLine($"{t}, {p}");
*/

/*
string x="\\u";
Console.WriteLine($"{x}");
for (int i = 0; i < 32768; i++)
{
    //System.Threading.Thread.Sleep(1000);
    char p=(char)i;  
    Console.Write($"{p}");
}
*/

/*


string x="\\u";
Console.WriteLine($"{x}");
for (int i = 0; i < 32768; i++)
{   
    int t = i;
    int a0=t%16;
    t = (t-a0)/16;
    int a1=t%16;
    t = (t-a1)/16;
    int a2=t%16;
    t = (t-a1)/16;
    int a3=t%16;
    t = (t-a1)/16;
    Console.Write($"a{i} = {a3}, {a2}, {a1}, {a0} *** ");
    //Console.Write($"a{i} = {a3}, {a2}, {a1}, {a0} *** ");



    //System.Threading.Thread.Sleep(1000);
    //char p=(char)i;  
    //Console.Write($"{p}");
}


*/
/*
string x="\\u";
Console.WriteLine($"{x}");
Console.WriteLine(x);
string b0=string.Empty;
string b1=string.Empty;
string b2=string.Empty;
string b3=string.Empty;


for (int i = 0; i < 32768; i++)
{   
    //string b0=string.Empty;
    int t = i;
    int a0=t%16;
    t = (t-a0)/16;
    int a1=t%16;
    t = (t-a1)/16;
    int a2=t%16;
    t = (t-a1)/16;
    int a3=t%16;
    t = (t-a1)/16;
    
    if (a0==0) b0="0";
    if (a0==1) b0="1";
    if (a0==2) b0="2";
    if (a0==3) b0="3";
    if (a0==4) b0="4";
    if (a0==5) b0="5";
    if (a0==6) b0="6";
    if (a0==7) b0="7";
    if (a0==8) b0="8";
    if (a0==9) b0="9";
    if (a0==10) b0="A";
    if (a0==11) b0="B";
    if (a0==12) b0="C";
    if (a0==13) b0="D";
    if (a0==14) b0="E";
    if (a0==15) b0="F";

    if (a1==0) b1="0";
    if (a1==1) b1="1";
    if (a1==2) b1="2";
    if (a1==3) b1="3";
    if (a1==4) b1="4";
    if (a1==5) b1="5";
    if (a1==6) b1="6";
    if (a1==7) b1="7";
    if (a1==8) b1="8";
    if (a1==9) b1="9";
    if (a1==10) b1="A";
    if (a1==11) b1="B";
    if (a1==12) b1="C";
    if (a1==13) b1="D";
    if (a1==14) b1="E";
    if (a1==15) b1="F";

    if (a2==0) b2="0";
    if (a2==1) b2="1";
    if (a2==2) b2="2";
    if (a2==3) b2="3";
    if (a2==4) b2="4";
    if (a2==5) b2="5";
    if (a2==6) b2="6";
    if (a2==7) b2="7";
    if (a2==8) b2="8";
    if (a2==9) b2="9";
    if (a2==10) b2="A";
    if (a2==11) b2="B";
    if (a2==12) b2="C";
    if (a2==13) b2="D";
    if (a2==14) b2="E";
    if (a2==15) b2="F";

    if (a3==0) b3="0";
    if (a3==1) b3="1";
    if (a3==2) b3="2";
    if (a3==3) b3="3";
    if (a3==4) b3="4";
    if (a3==5) b3="5";
    if (a3==6) b3="6";
    if (a3==7) b3="7";
    if (a3==8) b3="8";
    if (a3==9) b3="9";
    if (a3==10) b3="A";
    if (a3==11) b3="B";
    if (a3==12) b3="C";
    if (a3==13) b3="D";
    if (a3==14) b3="E";
    if (a3==15) b3="F";

    //string w = string.Empty;
    string w = x+b3+b2+b1+b0;
    //Console.Write(w+",");
    //w = string.Empty;
   
    //int c=i;
    char p=(char)i;
    //char p=Convert.ToChar(x+b3+b2+b1+b0); //String[] args
    Console.Write(p+" ");
    System.Threading.Thread.Sleep(1);
}
    //Console.Write($"a{i} = {a3}, {a2}, {a1}, {a0} *** ");
    //Console.Write($"a{i} = {a3*4096+a2*256+a1*16+a0} *** ");
    //Console.Write(Convert.ToString(i, 16));
    Console.WriteLine();
*/
/*

for (int i = 0; i < 65535; i++)
{
    if (i%1000==0) Console.WriteLine(i);
    char p=(char)i;
    Console.Write(p+" ");
    //System.Threading.Thread.Sleep(1);
}
Console.WriteLine();
*/










    











































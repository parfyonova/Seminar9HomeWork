/* Задача 64: Задайте значение N. Напишите программу, которая выведет все 
натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

Console.WriteLine("Задача №64");
Console.WriteLine();
Console.Write("Введите число N: ");
int n64 = int.Parse(Console.ReadLine()!);
int m64 = 1;
Console.WriteLine(PrintNumbers(m64, n64));
Console.WriteLine();

int PrintNumbers(int m, int n)
{
    if (n == m) return n;
    else Console.Write($"{PrintNumbers(m + 1, n)}, ");
    return m;
}

/* Задача 66: Задайте значения M и N. Напишите программу, которая 
найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.WriteLine("Задача №66");
Console.WriteLine();
Console.Write("Введите число N: ");
int n66 = int.Parse(Console.ReadLine()!);
Console.Write("Введите число M: ");
int m66 = int.Parse(Console.ReadLine()!);
if (n66 > m66) Console.WriteLine(SumNumbers(m66, n66));
else Console.WriteLine(SumNumbers(n66, m66));
Console.WriteLine();

int SumNumbers(int m, int n)
{
    int sum = 0;
    if (n == m) return n;
    else sum = n + SumNumbers(m, n-1);
    return sum;
}

/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

Console.WriteLine("Задача №68");
Console.WriteLine();
Console.Write("Введите число M: ");
int m68 = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N: ");
int n68 = int.Parse(Console.ReadLine()!);
Console.WriteLine(AkkermanFunction(m68, n68));
Console.WriteLine();

int AkkermanFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return AkkermanFunction(m - 1, 1);
    }
    else
    {
        return (AkkermanFunction(m - 1, AkkermanFunction(m, n - 1)));
    }
}
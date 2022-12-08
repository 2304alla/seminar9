// Задача 66: Задайте значения M и N.
//  Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNumMN(int m, int n)
{
    if (m == n) return  n;
    if (n > m)
    {
        return n + SumNumMN(n - 1, m);
    }
    else
    {
        return m + SumNumMN(m - 1, n);
    }
}


Console.WriteLine("Ведите натуральное число M");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ведите натуральное число  N");
int numberN = Convert.ToInt32(Console.ReadLine());

int sum = SumNumMN(numberM, numberN);

Console.WriteLine($"Сумма элементов от {numberM} до {numberN} = {sum}");
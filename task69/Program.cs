// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8




int DegreeAinB(int a, int b)
{
    if (b == 0) return 1;
    return a * DegreeAinB(a, b - 1);
}


Console.WriteLine("Ведите натуральное число A");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ведите натуральное число B");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberB >= 0)
{
    int degree = DegreeAinB(numberA, numberB);
    Console.WriteLine($"{numberA} в степени {numberB} = {degree}");
}
else Console.WriteLine("Ведите натуральную степень числа");
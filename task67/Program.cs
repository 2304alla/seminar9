// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9



int SumNumberElement(int num)
{
    if(num==0) return 0;
    return num%10 +SumNumberElement(num/10);
}





Console.WriteLine("Ведите натуральное число ");
int number = Convert.ToInt32(Console.ReadLine());

int sumNum =SumNumberElement(number);
Console.WriteLine($"Сумма цифр числа= {sumNum}");
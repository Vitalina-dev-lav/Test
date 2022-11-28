// Задача 27: Напишите программу, которая 
// 1.принимает на вход число и 
// 2.выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SummaDigit(int num)
{
    int summa = 0;
    while (num > 0)
    {
        summa = summa + num % 10;
        num = num / 10;
    }
    return summa;
}
if (number < 0) number = - number;
int summaDigit = SummaDigit(number);
Console.WriteLine($"Сумма цифр числа {number} -> {summaDigit}");
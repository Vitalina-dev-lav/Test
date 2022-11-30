// Задача 24. Напишите программу , которая 
// 1.принимает на вход число (A)и 
// 2.выдает сумму чисел от 1 до А

// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
//int sum = 0;

int SumDigits(int num)
{
    int sum = 0;
    for (int i = 0; i <= num; i++)
    {
        sum = sum + i;
    }
    return sum;
}
if (number > 0)
{
int SumDigits = SumDigits(number);
Console.WriteLine($"Сумма чисел от 1 до {number} = {sumDigits}");
}
else System.Console.WriteLine("Требуется ввести натуральное число");
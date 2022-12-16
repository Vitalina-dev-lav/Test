// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.WriteLine("Введите первое число");
int number = Convert.ToInt32(Console.ReadLine());

int SumDigts(int numb)
{
    return numb != 0 ? numb % 10 + SumDigts(numb / 10) : 0;
}

Console.WriteLine(SumDigts(Math.Abs(number)));


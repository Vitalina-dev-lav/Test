// Задача 13: Напишите программу, которая 
// 1.выводит третью цифру заданного числа или 
// 2.сообщает, что третьей цифры нет. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

string Digit = Convert.ToString(number);

if (Digit.Length > 2)
{
    Console.WriteLine( $"Третье число: { Digit}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
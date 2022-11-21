// Задача 7. Напишите программу, которая принимает на вход 
// трехзначное число и на выходе показывает последнюю цифру этого числа.

// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

int result = number / 1 % 1;

Console.Write("Третье число: ");
Console.WriteLine(result);
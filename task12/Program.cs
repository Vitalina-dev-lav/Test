﻿// Задача 12. Напишите программу, которая будет принимать на 
// вход два числа и выводить, является ли первое число кратным второму.
// Если число 1 не кратно 2, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите число 1");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2");
int num2 = Convert.ToInt32(Console.ReadLine());

bool Multiplicity (int number1, int number2)
{
    if (number1 % number2 == 0) return true;
    return false;
}

int MultiplicitySecond (int number1, int number2)
{
    return number1 % number2; 
}
bool result = Multiplicity (num1, num2);
Console.WriteLine(result ? "Первое число кратно второму": $"Не кратно, остаток = {num1 % num2}");

int result2 = MultiplicitySecond(num1, num2);
Console.WriteLine(result2 == 0 ? "Первое число кратно второму" : $"Не кратно, остаток = {result2}");
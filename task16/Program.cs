// Задача 16. Напишите программу, которая принимает На
// вход два числа и 
// проверяет, является ли одно число квадратом другово.

// 5, 25 -> Да
// -4, 16 -> Да
// 25, 5 -> Да
// 8, 9 -> Нет

Console.WriteLine("Введите первое число:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(square(num1,num2) ? "Да" : "Нет");

bool square (int firstNum, int secondNum)
{
    return (firstNum == secondNum*secondNum) || (secondNum == firstNum*firstNum);
}
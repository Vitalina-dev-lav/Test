// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22

Console.Clear();
Console.WriteLine("Введите первое число:");
int Num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int Num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число:");
int Num3 = Convert.ToInt32(Console.ReadLine());

if (Num1<Num2) Console.WriteLine($"{Num2}");
else if (Num2<Num3) Console.WriteLine($"{Num3}");
else if (Num3<Num1) Console.WriteLine($"{Num1}");



      
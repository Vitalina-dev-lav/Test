// Задача 22. Напиши программу,которая 
// 1.принимает на вход число (N) и 
// 2.выдает таблицу квадратов чисел от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 ->  1, 4

Console.WriteLine("Введите число:");
int num1 = Convert.ToInt32(Console.ReadLine());

void Square(int n)
{
    for (int i = 1; i <= n ; i++)
    {
        Console.WriteLine($"{i} -> {i*i} " );
    }
}
Square(num1);
// Задача17. Напишите программу, которая принимает
// 1. на вход координаты точки (X и Y),
// 2. причем X≠0 и Y≠0 и
// 3. выдает номер четверти плоскости, в которой находится эта
// точка.

Console.WriteLine("Введите координаты точки");
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки");
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

int Quarter (int xc, int yc)
{
    if (xc > 0 && yc > 0) return 1;
    if (xc < 0 && yc > 0) return 2;
    if (xc < 0 && yc < 0) return 3;
    if (xc > 0 && yc < 0) return 4;
}

int quarter = Quarter(x, y);
string result = quarter > 0
     ? $"Указанные координаты соотвествует четверти -> {quarter}"
     : "Введены некоректные координаты";
Console.WriteLine(result);
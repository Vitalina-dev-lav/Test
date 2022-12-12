// Задача40.
// 1.Напишите программу, которая принимает на вход три числа
// 2. и проверяет, может ли существовать треугольник с сторонами такой длины.

// *теорема о неравенстве треугольника: каждая сторона треугольника 
// меньше суммы двух других сторон.

Console.WriteLine("Введите первую сторону треугольника");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую сторону треугольника");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третью сторону треугольника");
int c = Convert.ToInt32(Console.ReadLine());


bool Triagnle(int ab, int ac, int bc)
{
  return a < b+c && b < a+c && c < a+b; 
}

Console.WriteLine(Triagnle(a,b,c)?"Треугольник может существовать":"Треугольник не может существовать");
// Задача 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// Например:
// 3 -> Среда 
// 5 -> Пятница
Console.Clear();
Console.WriteLine("Введите номер дня недели:" );
int Day = Convert.ToInt32(Console.ReadLine());
if (Day == 1) Console.WriteLine("Понедельник");
else if (Day == 2) Console.WriteLine("Вторник");
else if (Day == 3) Console.WriteLine("Среда");
else if (Day == 4) Console.WriteLine("Четверг");
else if (Day == 5) Console.WriteLine("Пятница");
else if (Day == 6) Console.WriteLine("Суббота");
else if (Day == 7) Console.WriteLine("Воскресенье");
else Console.WriteLine("Такого дня недели нет");
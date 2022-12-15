﻿// Задача 53. 1.Задайте двумерный массив.
// 2.Напишите программу, которая заменяет строки на столбцы.
// 3. В случае если это невозможно, программа должна вывести сообщение для пользователя.



int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)

{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

void ReplaceRows (int[,] matrix)
{
    int temp = 0;
    for(int j = 0; j < matrix.GetLength(1); j++ )
    {
        temp = matrix[0, j];
        matrix[0, j] = matrix[matrix.GetLength(0) - 1, j];
        matrix[matrix.GetLength(0), j] = temp;
    }
}

int[,] array2D = CreateMatrixRndInt(3, 4, 0, 5);
PrintMatrix(array2D);
Console.WriteLine();
ReplaceRows(array2D);
PrintMatrix(array2D);




// int[,] RandomMatrix(int rows, int columns, int min, int max)
// {
//     int[,] matrix = new int[rows, columns];
//     Random rnd = new Random();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rnd.Next(min, max + 1);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix, string sep1, string sep2)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         Console.Write($"{sep1}");
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5}|");
//             else Console.Write($"{matrix[i, j],5}");
//         }
//         Console.WriteLine($"{sep2}");
//     }
// }

// void ChangeStrngFirstToLast(int[,] matrix)
// {
//     int temp = 0;
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         temp = matrix[0,j];
//         matrix[0, j] = matrix[matrix.GetLength(0) - 1, j];
//         matrix[matrix.GetLength(0) - 1, j] = temp;
//     }
// }

// int stringsize = 0;
// int columsize = 0;
// int stringIndex = 0;
// int columIndex = 0;
// while (stringsize <= 0 || columsize <= 0)
// {
//     Console.WriteLine($"Введите количество сторок");
//     stringsize = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine($"Введите количество столбцов");
//     columsize = Convert.ToInt32(Console.ReadLine());

//     if (stringsize <= 0 || columsize <= 0)
//         Console.WriteLine("Введены неверные данные");
// }
// int[,] array2D = RandomMatrix(stringsize, columsize, 0, 10);
// PrintMatrix(array2D, "|", "|");
// ChangeStrngFirstToLast(array2D);
// Console.WriteLine();
// PrintMatrix(array2D, "|", "|");
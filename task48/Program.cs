// Задача 48. 1.Задайте двумерный массив размера m на n,
// 2.каждый элемент в массиве находится на формуле: Amn = m + n.
// 3.Выведите полученный массив нв экран.

// m=3,n=4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int[,] CreateMatrixInt(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    

    for (int i = 0; i < matrix.GetLength(0); i++) //3
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // matrix.GetLength(2)
        {
            matrix[i, j] = i+j;  //2 - 3
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
            if (j < matrix.Length - 1) Console.Write($"{matrix[i, j], 4},");
            else Console.Write($"{matrix[i, j], 4} ");

        }
        Console.WriteLine("|");

    }
}

int[,] array2D = CreateMatrixInt(3,4);
PrintMatrix(array2D);
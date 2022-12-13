// Задача 51. 1.Задайте двумерный массив.
// 2.Найдите сумму элементов,находящихся на главной диагонали 
// (с индексами (0,0);(1;1) и т.д)

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) //3
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // matrix.GetLength(2)
        {
            matrix[i, j] = rnd.Next(min, max + 1);  //2 - 3
        }

    }
    return matrix;
}

void PrintMatrix(int[,] matrix,string beginRow, string separatorElem,string endRow)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write(beginRow);
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) 
            Console.Write($"{matrix[i, j], 4}{separatorElems}");
            else Console.Write($"{matrix[i, j], 4} ");

        }
        Console.WriteLine(endRow);

    }
}

int[,] array =  CreateMatrixRndInt(3, 4, 1, 9);
 PrintMatrix(array, );
// Задача 51. Задайте двумерный массив, найдите сумму элементовб находящихся на главной диагонали
// (с индексами 0,0, 1,1 и т.д).

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
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
         Console.Write($"{matrix[i, j], 3} ");
        

    }
    Console.WriteLine();
}
}

int SumAlementsMainDiagonal (int [,] matrix)
{
    int sum = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j) sum = sum + matrix[i, j];
        }
    }
    return sum;
}

// int SumAlementsMainDiagonal(int[,] matrix)
// {
//     int sum = 0;
//     for (int i = 0; i < matrix.GetLength(0) && i < matrix.GetLength(1); i++)
//     {
        
//             sum = sum + matrix[i, i];
//             Console.WriteLine($" {sum} = {matrix[i, i]} и {i} b {i}");
        
//     }
//     return sum;
//     }

int [,] array2d = CreateMatrixRndInt(3, 4, -10, 10);
PrintMatrix(array2d);
Console.WriteLine("--------------------------------");

int sumAlementsMainDiagonal = SumAlementsMainDiagonal(array2d);
Console.WriteLine($"Сумма элементов на главной диагонали составляет {sumAlementsMainDiagonal}");
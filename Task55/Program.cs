// Задайте двумерный массив. Напишите программу, которая меняет столбцы на строки или
// выводит информацию, что это невозможно

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

int [,] CreateNewArray (int [,] arr)
{
    int [,] matrix = new int[arr.GetLength(0), arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0;j < arr.GetLength(1);j++)
    {
        matrix[i, j] = arr [j,i];
    }
}
return matrix;


}
int [,] matrix = CreateMatrixRndInt(4, 4, 0, 10);
PrintMatrix(matrix);
Console.WriteLine();
if (matrix.GetLength(0) == matrix.GetLength(1))
{
int[,] newmatrix = CreateNewArray(matrix);
PrintMatrix(newmatrix);
}

else WriteLine("Матрица не является симметричной");
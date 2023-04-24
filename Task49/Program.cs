// Задайте двумерный массив. Найдите элементыб у которых оба индекса четные и замените эти элементы на их квадраты

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
int [,] FindeElementsEvantIndex (int [,] matrix)
{
    int [,] newmatrix = matrix;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i % 2 ==0 && j % 2 == 0) newmatrix[i, j] = matrix[i, j] * matrix[i, j];

        }
    }
    return newmatrix;
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

int [,] array2d = CreateMatrixRndInt(3, 4, -10, 10);
PrintMatrix(array2d);
Console.WriteLine("--------------------------------");
int [,] newarray2d = FindeElementsEvantIndex(array2d);
PrintMatrix(newarray2d);

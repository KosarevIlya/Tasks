// Создайте двумерный массив из целых чисел,напишите программу, которая удалит 
// строку и столбец, на пересечении которыхрасположен наименьший элемент массива


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
            Console.Write($"{matrix[i, j],3} ");


        }
        Console.WriteLine();
    }
}

(int Row, int Colums) MinElement(int[,] matrix)
{
    int indexMinRow = 0, indexMinColums = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[indexMinRow, indexMinColums] > matrix[i, j])
                {
                    indexMinRow = i;
                    indexMinColums = j;
                }
            }
        }
    return(indexMinRow, indexMinColums);
}

int [,] DeleteRowColums (int [,] matrix, int row, int colum)
{
    int [,] newMatrix = new int [matrix.GetLength(0) - 1, matrix.GetLength(1) -1];
    int m = 0, n = 0;
    for ( int i = 0; i < newMatrix.GetLength(0); i++)
    {
        if (m == row) m++;
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            if (n == colum) n++;
            newMatrix[ i, j] = matrix[m, n];
            n++;
        }
        m++;
        n=0;
    }
    return newMatrix;
}

int[,] arr2d = CreateMatrixRndInt(4,4,0,10);
PrintMatrix(arr2d);
Console.WriteLine("");
(int Row, int Colums) indexMin = MinElement(arr2d);
int [,] newarr2d = DeleteRowColums(arr2d, indexMin.Row, indexMin.Colums);
PrintMatrix(newarr2d);


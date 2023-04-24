// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    double sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
                    matrix[i, j] = rnd.Next(min, max + 1);
                    sum = sum+matrix[i, j];
        }
        Console.WriteLine($"{sum}   {sum/i+1}");
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

// int  FindeElementsEvantIndex (int [,] matrix)
// {
//     int [,] newmatrix = matrix;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         Console.WriteLine(sum);
//         sum = 0;
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             sum = sum + matrix[i,j];

//         }
//     }
//     return sum;
// }
// double [] Arif(int [,] array)
// {
//     double [] arr = new double [array.Length];
//     Random rand = new Random();
// for (i = 0; i < array.GetLength(0); i++)
// {
// double sum = 0;
// for (j= 0; j < array.GetLength(0); j++)
// {
// sum = sum + array[i,j];
// }
//         arr[i] =Math.Round(num/i, 1);

// }
// return sum;
// }

int [,] array2d = CreateMatrixRndInt(3, 4, -5, 5);
PrintMatrix(array2d);

// double [] math =Arif (array2d);
// Console.WriteLine(math[array2]);
// Задача 35. Создайте одномерный массив из 123 случайных чисел. Найдите колличество элементов 
// массива, значения которых лежат в отрезке [10, 99]

// создание массива и его заполнение
int [] CreateArrayRndInt(int size, int min, int max)
{
    int [] arr = new int [size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max+1);
    }
    return arr;

}

int NumberInSegment (int [] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 9 && arr [i] < 100) sum++;
                                   
        }
        return sum;
    }
        int [] array = CreateArrayRndInt(123, -0, 200);
        int numberInSegment = NumberInSegment(array);

        Console.WriteLine($"В заданном массиве число цифр из отрезка 10 - 99 {numberInSegment}");

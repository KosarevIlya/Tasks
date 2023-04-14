//  29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

// ввод числа с экрана

int Promt (string message)
{

Console.Write(message);
string ReadInput = Console.ReadLine();
int resault = int.Parse(ReadInput);
return resault;

}


// метод для получения слуайных значений массива 

int [] GenerateArray (int lenght, int minValue, int maxValue)
{
    int [] array = new int [lenght]; //обьявление массива
    Random random = new Random();
    for (int i = 0; i < lenght; i++)
    {
     array[i] = random.Next(minValue, maxValue +1 ); // заполняем случайными цифрами из диапазона SatrArr до EndArr    
    }
    return array;
}

void PrintArray (int [] array)
{
    Console.Write ("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}"); //вывод значения массива
    }
    Console.Write ($"{array[array.Length -1]}"); // вывод значения массива
    Console.WriteLine("]");
}

int lenght = Promt("Длинна массива:");
int min = Promt ("Начальное значение, для диапазона случайного числа:");
int max = Promt( "Конечное значение для диапазона случайного числа:");
int [] array = GenerateArray (lenght, min, max); // Заполнение массива случайными числами
PrintArray (array); // вывод массива
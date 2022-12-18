// Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

Console.Clear();
Console.Write("Введите число строк массива : ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов массива : ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] array = FillArray(row, column, 0, 9);

Console.WriteLine();
Console.WriteLine("Получившийся массив:");

PrintArray(array);
Console.WriteLine();


Console.WriteLine($"Минимальная сумма в строке -  {FindRowNumberOfMinSum(array)}; сумма элементов равна  - {FindMinSumRow(array)}");


int FindRowNumberOfMinSum(int[,] arr)
{
    int min = FindRowSumm(arr, 0);
    int num = 0;
    for (int i = 1; i < arr.GetLength(0); i++)
    {
        if (min > FindRowSumm(arr, i))
        {
            min = FindRowSumm(arr, i);
            num = i+1;
        }
    }
    return num;
}


int FindMinSumRow(int[,] arr)
{
    int min = FindRowSumm(arr, 0);
    for (int i = 1; i < arr.GetLength(0); i++)
    {
        if (min > FindRowSumm(arr, i))
            min = FindRowSumm(arr, i);
    }
    return min;
}


int FindRowSumm(int[,] arr, int row)
{
    int summ = 0;
    for (int i = 0; i < arr.GetLength(1); i++)
        summ += arr[row, i];
    return summ;
}

void PrintArray(int[,] arr)
{
    Console.WriteLine("--------------------");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] >= 0 ? $"  {arr[i, j]}" : $" {arr[i, j]}");
        }
        Console.WriteLine();
    }
}

int[,] FillArray(int rowArray, int colArray, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[,] resultArray = new int[rowArray, colArray];
    for (int i = 0; i < rowArray; i++)
        for (int j = 0; j < colArray; j++)
        {
            resultArray[i, j] = rnd.Next(minValue, maxValue + 1);
        }
    return resultArray;
}

// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();
Console.Write("Введите число строк массива : ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов массива : ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] array = FillArray(row, column, 0, 100);

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

Console.WriteLine();
Console.WriteLine("Получившийся массив:");

PrintArray(array);
Console.WriteLine();

SortArray(array);
Console.WriteLine();

Console.WriteLine("Отсортированный массив:");
PrintArray(array);

void SortArray(int[,] arr)
{
    int temp = 0;
    for (int k = 0; k < arr.GetLength(0); k++)
        for (int i = 0; i < arr.GetLength(1) - 1; i++)
            for (int j = i + 1; j < arr.GetLength(1); j++)
                if (arr[k, i] < arr[k, j])
                {
                    temp = arr[k, i];
                    arr[k, i] = arr[k, j];
                    arr[k, j] = temp;
                }
}
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();
Console.Write("Введите размерность матрицы матрицы : ");
int size = Convert.ToInt32(Console.ReadLine());


int[,] arrayFirst = FillArray(size, size, 0, 9);
int[,] arraySecond = FillArray(size, size, 0, 9);

Console.WriteLine();
Console.WriteLine("Первая матрица:");

PrintArray(arrayFirst);

Console.WriteLine("Вторая матрица:");

PrintArray(arraySecond);

Console.WriteLine("Результат умножения матриц");
PrintArray(FindProductOfMatrix(arrayFirst, arraySecond));


int[,] FindProductOfMatrix(int[,] arrA, int[,] arrB)
{
    int size = arrA.GetLength(0);
    int[,] result = new int[size, size];
    for (int i = 0; i < size; i++)
        for (int j = 0; j < size; j++)
        {
            result[i, j] = 0;
            for (int k = 0; k < size; k++)
                result[i, j] += arrA[i, k] * arrB[k, j];
        }
    return result;
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

// Напишите программу, которая на вход принимает индексы элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1,1 -> 9
// 1,7 -> элемента с данными индексами в массиве нет

Console.Clear();

Console.Write("Введите число строк массива : ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов массива : ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] array = FillArray(row, column, 0, 9);

Console.Write("Введите индекс строки двумерного массива : ");
int indexrow = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс столбца двумерного массива : ");
int indexcolumn = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("Получившийся двумерный массив:");

PrintArray(array);

Console.WriteLine($"Элемент с индексом ({indexrow},{indexcolumn}) -- > {SearhNumsByIndex(array,indexrow,indexcolumn)}");

if (indexrow > array.GetLength(0))
    Console.WriteLine($"Элемента с такими индексами ({indexrow},{indexcolumn}) нет.");
else if (indexcolumn > array.GetLength(1))
     Console.WriteLine($"Элемента с такими индексами ({indexrow},{indexcolumn}) нет.");

int SearhNumsByIndex (int [,] arr, int indrow, int indcolumn){
    
    int result = arr[0,0];

    for (int i =0; i<arr.GetLength(0);i++){
        for (int j =0 ; j < arr.GetLength(1); j++){
             if (i == indrow && j == indcolumn)
                result = arr[i,j];
        }
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
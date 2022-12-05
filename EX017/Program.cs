//  Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

Console.Clear();

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] mass = new double[size];

double[] FillArray(double[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = Convert.ToDouble(new Random().Next(100, 1000));
        index++;
    }
    return array;
}
Console.WriteLine($"Исходный массив[" + String.Join(",", FillArray(mass)) + "]");

double FaindDiffBetweenMaxAndMinNums(double[] arr)
{
    double max = arr[0];
    double min = arr[0];
    double diff = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]>max)
            max = arr[i];
        else if (arr[i]<min)
            min = arr[i];
    }
    Console.WriteLine($"Максимальное значение --> {max}");
    Console.WriteLine($"Минимальное значение --> {min}");
    diff = max - min;
    return diff;
}

Console.WriteLine($"Разница между максимальным и минимальным значениями в массиве --> { FaindDiffBetweenMaxAndMinNums(mass)}");




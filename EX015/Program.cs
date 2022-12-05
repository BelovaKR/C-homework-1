// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

Console.Clear();

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] mass = new int [size];

int[] FillArray(int[] array)
{
    int length  = array.Length;
    int index = 0;
    while (index< length)
    {
        array[index] = new Random().Next(100,1000);
        index++;
    }
    return array;
}
Console.WriteLine($"Исходный массив[" + String.Join(",", FillArray(mass)) + "]");

int FaindEvenNumbersInArray(int [] arr){
    int count = 0;
    for(int i =0; i<arr.Length;i++)
    {
        if (arr[i]%2 == 0)
        count++;
    }
    return count;
}
Console.WriteLine($"Количество четных чисел в массиве = {FaindEvenNumbersInArray(mass)}");
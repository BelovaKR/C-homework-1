//  Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

Console.Clear();

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] mass = new int[size];

int[] FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(-100, 200);
        index++;
    }
    return array;
}
Console.WriteLine($"Исходный массив[" + String.Join(",", FillArray(mass)) + "]");

int FaindSumOfOddNumbersInArray(int[] arr)
{
    int sum = 0;
    int i = 1;
    while (i < arr.Length)
    {
        sum = sum + arr[i];
        i = i + 2;
    }
    return sum;
}

Console.WriteLine($"Сумма чисел, cтоящих на нечетных позициях --> {FaindSumOfOddNumbersInArray(mass)}");
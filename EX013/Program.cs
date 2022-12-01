// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

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
        array[index] = new Random().Next(0,10000);
        index++;
    }
    return array;
}

Console.WriteLine("[" + String.Join(",", FillArray(mass)) + "]");
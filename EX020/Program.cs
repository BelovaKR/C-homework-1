// Задайте одномерный массив, заполненный случайными числами. 
//Из входного массива сформируйте массив с чётными и массив с нечётными значениями 
//элементов входного массива. Найдите ср. арифметическое из полученных значений элементов 
//массивов и выведите результат сравнения средних арифметических.
//[1,2,3,4] -> средн. арифм. значений элементов массива с чётными числами > средн. арифм. значений элементов с нечётными числами
//[2,3,5,7] -> средн. арифм. массива значений элементов с нечётными числами > средн. арифм. значений элементов с чётными числами
//[1,2,5,4] -> средн. арифм. значений элементов массива с нечётными числами = средн. арифм. значений элементов с чётными числами

Console.Clear();

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] mass = new int[size];

double avgEven = GetAvg(FillArrayEvenNums(mass));
double avgOdd =  GetAvg(FillArrayOddNums(mass));


int[] FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(100, 200);
        index++;
    }
    return array;
}
Console.WriteLine($"Исходный массив[" + String.Join(",", FillArray(mass)) + "]");


int [] FillArrayEvenNums(int[] arr)
{   

    int[] result = new int [arr.Length];
    for(int i =0; i< arr.Length;i++)
        if (arr[i]%2 ==0)
            result[i] = result[i] + arr[i] ;

    return result;
}
Console.WriteLine($"Массив с четными значениями: [" + String.Join(",", FillArrayEvenNums(mass)) + "]");

int [] FillArrayOddNums(int[] ar)
{   
    int sum =0;
    int arg =0;
    int[] res = new int [ar.Length];
    for(int i =0; i< ar.Length;i++)
        if (ar[i]%2 !=0)
            res[i] = res[i] + ar[i] ;
    return res;
}
Console.WriteLine($"Массив с НЕчетными значениями: [" + String.Join(",", FillArrayOddNums(mass))+ "]");

double GetAvg(int[] arr)
{
    int summ = 0;
    for (int i = 0; i < arr.Length; i++) summ += arr[i];
    double avg = Convert.ToDouble(summ) / Convert.ToDouble(arr.Length);
    return avg;
}
Console.WriteLine($"Среднее арифметическое значение массива с четными значениями --> {avgEven}");
Console.WriteLine($"Среднее арифметическое значение массива с НЕчетными значениями --> {avgOdd}");
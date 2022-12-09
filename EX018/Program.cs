//Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

Console.Clear();

Console.WriteLine("Введите количество значений для ввода:");

int numberValue = Convert.ToInt32(Console.ReadLine());

int[] mas = new int [numberValue];

int [] FillArrayKeyboard(int [] array)
{
    for(int i=0; i<array.Length;i++){
        Console.Write($"Введите {i+1} значение: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    } 
    return array;
}
Console.WriteLine($"Введенные значения :[" + String.Join(",", FillArrayKeyboard(mas)) + "]");

int CheckNumMoreZero (int [] arr){
    int count =0;
    int index =0;
    while (index < arr.Length)
    {
        if (arr[index]>0)
        {
            count = count +1;
            index++;
        }
        else
            index++;
    }
    return count;
}

Console.WriteLine($"Введено значений больше 0 --> {CheckNumMoreZero(mas)} ");
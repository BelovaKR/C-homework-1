// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.Clear();

Console.Write("Введите число : ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма цифр в числе {num} равна {FaindSumOfNums(num)} ");


int FaindSumOfNums(int numbers)
{
    int result = 0;
    int i = numbers;
    
    while (i>0){
    int n = i % 10;
    i = i /10;
    result = result + n;
    }
    return result;
}
// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в 
// промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.Write("Введите число M : ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N : ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма натуральных элементов от {m} до {n} равна {CalculateSummOFInterval(m,n)}");

int CalculateSummOFInterval (int val, int max)
{
    if (val > max) return 0;
    int sum = val;
    sum += CalculateSummOFInterval(val+1,max);
    return sum;

}
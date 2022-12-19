// Задача 68: Задайте значения M и N. 
// Напишите программу, которая найдёт наибольший общий делитель (НОД) этих чисел с помощью рекурсии.
// M = 28; N = 7 -> 7

Console.Clear();
Console.Write("Введите число M : ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N : ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"M = {m}, N = {n} наибольший общий делитель --> {FindDivider(m,n)}");

int FindDivider(int a, int b)
{
    if (b == 0) return a;             // Закомментировала для себя.
    return FindDivider(b, a % b);    // a = 28 ; b = 7 --> 28 % 7 = 0 --> return-7.
                                     // a = 24 ; b = 54 --> 24 % 54 = 6 --> 6 % 6 = 0 --> return - 6.
}
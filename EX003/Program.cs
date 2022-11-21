// Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).
Console.Clear();

Console.WriteLine("Введите число: ");
int i = int.Parse(Console.ReadLine());

if (i % 2 == 0)
{
    Console.WriteLine($"{i} - является четным");
}
else
{
    Console.WriteLine($"{i} - НЕчетное");
}
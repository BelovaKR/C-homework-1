//Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным

Console.Clear();

Console.WriteLine("Введите номер дня недели");
int num = Convert.ToInt32(Console.ReadLine());

if (num == 1 || num == 2 || num == 3 || num == 4 || num == 5)
{
    Console.WriteLine("Работаем((((");
}
else if (num == 6 || num == 7)
{
    Console.WriteLine("Выходной!!!");
}

else
    Console.WriteLine("Это не день недели!");
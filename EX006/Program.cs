// Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет

Console.Clear();

int MakeArray(int a, int b)
{
int result = 0;
    if (b < 3)
    {
        Console.Write("Третьей цифры нет, держи: ");
    }
    else
    {
        int c = 1;
        for (int i = b; i > 3; i--)
        {
            c = c * 10;
        }

        result = (a / c) % 10;
    }
return result;
}

Console.WriteLine("Введите любое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int str = num.ToString().Length;

Console.Write(MakeArray(num, str));


    








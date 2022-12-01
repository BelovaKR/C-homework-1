// Напишите программу, которая на вход принимает радиус 
//круга и находит его площадь округленную до целого числа, 
//необходимо вывести максимальную цифру в полученном округлённом 
//значении площади круга.
//10 -> 4
//20 -> 7
//30 -> 8

Console.Clear();
Console.WriteLine("Введите радиус круга: ");
double R = Convert.ToDouble(Console.ReadLine());
double Pi = 3.141592653589793;
double S = 0;

S = Pi * R * R;
Console.WriteLine($"Площадь круга = {Math.Round(S, MidpointRounding.ToEven)}");

int num = Convert.ToInt32(S);

Console.WriteLine($"Максимальная цифра - {FaindMaxNum(num)}");

int FaindMaxNum(int num)
{
    int max = 0;
    int n = 0; 

        while (num>0){
            n = num % 10;
            if (n > max)
             max = n;
        num = num / 10;
        }
     return max;
}


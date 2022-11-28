// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.

Console.Clear();

Console.Write("Введите пятизначное число : ");
int num = Convert.ToInt32(Console.ReadLine());

if(num < 10000 || num > 99999){
    Console.WriteLine("Число не пятизначное!");
}

int num1 = num / 10000;
int num2 = num / 1000 % 10;
int num4 = num / 10 % 10;
int num5 = num % 10;

while (num>=10000){
    if ( num1 == num5 && num2 == num4){
    Console.WriteLine($"Число {num} является палиндромом");
    
    break;
    }
    else
    Console.WriteLine($"Число {num} НЕ является палиндромом");
    break;
    
}
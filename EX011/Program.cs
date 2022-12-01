// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.Clear();

Console.Write("Введите первое число : ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число : ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Число {num1} в степени {num2} = {RaisePowerNum(num1,num2)}");

int RaisePowerNum(int a,int b){

    int result = a;

for(int i = 1; i < b; i++){
    result = result * a;
}
    return result;
}


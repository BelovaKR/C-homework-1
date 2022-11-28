// Напишите программу, которая принимает на вход 2 числf (N,M) и выдаёт
// таблицу кубов чисел от N до М.

Console.Clear();

Console.Write("Введите N : ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите M : ");
int m = Convert.ToInt32(Console.ReadLine());

int count = Math.Abs(n);

if (count < Math.Abs(m))
{
    Console.Write($"Возведение в куб от {Math.Abs(n)} до {Math.Abs(m)} --> ");

    while (count <= Math.Abs(m))
    {
        Console.Write(Math.Pow(count, 3));
        if (count < Math.Abs(m)) Console.Write(", ");
        else Console.Write(".");
        count++;
    }
}
else if(Math.Abs(n) > Math.Abs(m)){
    Console.Write($"Возведение в куб от {Math.Abs(n)} до {Math.Abs(m)} --> ");

    while (count >= Math.Abs(m))
        {
         Console.Write(Math.Pow(count, 3));
         if (count > Math.Abs(m)) Console.Write(", ");
         else Console.Write(".");
        count--;
   
   }

}
else if (Math.Abs(n)==Math.Abs(m)) {
    Console.WriteLine("Числа равны друг другу");
    Console.Write($"{Math.Abs(n)} в кубе -- > ");
    Console.Write(Math.Pow(n, 3));
}

    
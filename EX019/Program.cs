// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();

Console.Write("Введите X первой точки : ");
double b1 = Convert.ToInt32(Console.ReadLine()); //2

Console.Write("Введите Y первой точки : ");
double k1 = Convert.ToInt32(Console.ReadLine()); //5

Console.Write("Введите X второй точки : ");
double b2 = Convert.ToInt32(Console.ReadLine()); //4

Console.Write("Введите Y второй точки : ");
double k2 = Convert.ToInt32(Console.ReadLine());  //9

double x = (b2 - b1)/(k1 - k2); //(4 - 2) /  (5 - 9) = 2/-4
double y = k2 * x + b2; //9 * -0.5 + 4

Console.WriteLine($"Прямые пересекутся в точке с координатами X({x}); Y({y})");

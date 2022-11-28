// Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

Console.Write("Введите X первой точки : ");
int ax = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите Y первой точки : ");
int ay = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите Z первой точки : ");
int az = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите X второй точки : ");
int bx = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите Y второй точки : ");
int by = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите Z второй точки : ");
int bz = Convert.ToInt32(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by, 2) + Math.Pow(az - bz, 2));

Console.WriteLine($"Расстояние между точками в 3D пространстве равно {Math.Round(d,2,MidpointRounding.ToZero)}");

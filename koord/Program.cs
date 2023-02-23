// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53



double[] coord_A = new double [3];
double[] coord_B = new double [3];

Console.WriteLine("Введите  координатe X точки А:");
coord_A[0] = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите  координатe Y точки А:");
coord_A[1] = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите  координатe Z точки А:");
coord_A[2] = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine("Введите  координатe X точки B:");
coord_B[0] = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите  координатe Y точки B:");
coord_B[1] = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите  координатe Z точки B:");
coord_B[2] = Convert.ToInt32(Console.ReadLine()); 

    double distance = Math.Sqrt (Math.Pow((coord_B[0]-coord_A[0]),2) + (Math.Pow((coord_B[1]-coord_A[1]),2)) +(Math.Pow((coord_B[2]-coord_A[2]),2)));
Console.WriteLine ($"Расстояние между тточкой  А и В в 3D пространстве: {Math.Round(distance, 2)}" );

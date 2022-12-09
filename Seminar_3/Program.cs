// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
/*
int FindQuadrant(double x, double y)
{
    if(x > 0 && y > 0) return 1;
    if(x < 0 && y > 0) return 2;
    if(x < 0 && y < 0) return 3;
    if(x > 0 && y < 0) return 4;
    return 0;
}

Console.Write("Input an x-coordinate: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input an y-coordinate: ");
double yA = Convert.ToDouble(Console.ReadLine());

int quadNam = FindQuadrant(xA, yA);
Console.WriteLine($"The point A ({xA}, {yA}) is on the {quadNam} quadrant");
*/

// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
/*
void GetCoordinates(int quadrant)
{
    if(quadrant == 1) Console.WriteLine("x > 0, y > 0");
    else if(quadrant == 2) Console.WriteLine("x < 0, y > 0");
    else if(quadrant == 3) Console.WriteLine("x < 0, y < 0");
    else if(quadrant == 4) Console.WriteLine("x > 0, y < 0");
    else Console.WriteLine("There is no such quadrant");
}

Console.WriteLine("Input a number of the quadrant");
int quadrantPoint = Convert.ToInt32(Console.ReadLine());

GetCoordinates(quadrantPoint);
*/

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
/*
double Distance(double xA, double yA, double xB, double yB)
{
    double length = Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2));
    return Math.Round(length, 2);
}
Console.WriteLine("Input an x-coordinate of point A: ");
double xA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input an y-coordinate of point A: ");
double yA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input an x-coordinate of point B: ");
double xB = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input an y-coordinate of point B: ");
double yB = Convert.ToDouble(Console.ReadLine());

double distanceBetweenAB = Distance(xA, yA, xB, yB);
Console.WriteLine($"Distance between points A and B is {distanceBetweenAB}.");
*/

// Напишите программу, которая принимает на вход число (N) и выдаёт ряд квадратов чисел от 1 до N.

/*
void Squares(int number)
{
    int counter = 1;
    while(counter <= number)
    {
        Console.Write($"{Math.Pow(counter, 2)}");
        if(counter != number) Console.Write(", ");
        counter++;
    }
}

Console.Write("Input an integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("The series of squares of numbers: ");
Squares(num);
*/
/*
double Distance(double xA, double yA, double zA, double xB, double yB, double zB )
{
    double length = Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2)+ Math.Pow(zB - zA, 2));
    return Math.Round(length, 2);
}
Console.WriteLine("Input an x-coordinate of point A: ");
double xA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input an y-coordinate of point A: ");
double yA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input an z-coordinate of point A: ");
double zA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input an x-coordinate of point B: ");
double xB = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input an y-coordinate of point B: ");
double yB = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input an z-coordinate of point B: ");
double zB = Convert.ToDouble(Console.ReadLine());


double distanceBetweenAB = Distance(xA, yA, zA, xB, yB, zB);
Console.WriteLine($"Distance between points A and B is {distanceBetweenAB}.");
*/
//  Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double Read(string arg)
{
    System.Console.Write($"Enter {arg}: ");
    double num = double.Parse(Console.ReadLine());
    return num;
}

void Ecuation(double b1, double k1, double b2, double k2)
{
    double x = (b1 - b2) / (k2 - k1);
    double y = (k1 * x) + b1;
    System.Console.WriteLine($"({x}; {y})");
}

double b1 = Read("b1");
double k1 = Read("k1");
double b2 = Read("b2");
double k2 = Read("k2");
Ecuation(b1, k1, b2, k2);
 
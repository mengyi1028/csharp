using System;

public class QuadraticEquation
{
    public static Tuple<double, double> FindRoots(double a, double b, double c)
    {
       // throw new NotImplementedException("Waiting to be implemented.");
        double temp = Math.Sqrt(Math.Pow(b,2)-4*a*c);
        double first = (temp-b) / (2*a);
        double second = (0-temp-b) / (2*a);      
        
        return new Tuple<double, double>(first, second);
    }

    public static void Main(string[] args)
    {
        Tuple<double, double> roots = QuadraticEquation.FindRoots(2, 10, 8);
        Console.WriteLine("Roots: " + roots.Item1 + ", " + roots.Item2);
    }
}

using System;

class Program
{
    static double AreaRectangulo(double baseRectangulo, double altura)
    {
        return baseRectangulo * altura;
    }

    static void Main(string[] args)
    {
        Console.Write("Ingrese la base del rectángulo: ");
        double baseRectangulo = double.Parse(Console.ReadLine());

        Console.Write("Ingrese la altura del rectángulo: ");
        double altura = double.Parse(Console.ReadLine());

        double area = AreaRectangulo(baseRectangulo, altura);
        Console.WriteLine("El área del rectángulo es: " + area);
    }
}

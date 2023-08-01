using ExercicioPOO_Triangulo;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Triangulo x, y;

        x = new Triangulo();
        y = new Triangulo();    

        Console.WriteLine("Entre com as medidas do triangulo X:");
        x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Entre com as medidas do triangulo X:");
        y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine();

        double p = (x.A + x.B + x.C) / 2.0;
        double areaX = Math.Sqrt(p * (p-x.A)*(p-x.B)*(p-x.C));

        p = (y.A + y.B + y.C) / 2.0;
        double areaY = Math.Sqrt(p * (p - y.A) * (p -y.B) * (p - y.C));


        Console.WriteLine("Area de X = " + areaX.ToString("f4", CultureInfo.InvariantCulture));
        Console.WriteLine("Area de Y = " + areaY.ToString("f4", CultureInfo.InvariantCulture));

        if (areaX > areaY) {

            Console.WriteLine("Maior área é do X.");
        }
        else
        {
            Console.WriteLine("Maior área é do Y.");
        }
    }
}
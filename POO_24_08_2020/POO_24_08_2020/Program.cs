using System;
using System.Globalization;

namespace POO_24_08_2020
{
    
    class Program
    {
        static void Main(string[] args)
        {
            /*{
                double xA, xB, xC;
                double yA, yB, yC;

                Console.WriteLine("Entre  com as medidas  do triângulo X:");
                xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Entre  com as medidas  do triângulo Y:");
                yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                double p = (xA + xB + xC) / 2.0;
                double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));
                p = (yA + yB + yC) / 2.0;
                double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));
                Console.WriteLine("Área  de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
                Console.WriteLine("Área  de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));
                if (areaX > areaY)
                {
                    Console.WriteLine("Maior  área: X");
                }
                else { Console.WriteLine("Maior  área: Y"); }
            }*/
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre  com as medidas  do triângulo X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.calculaArea();

            Console.WriteLine("Entre  com as medidas  do triângulo Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.calculaArea();

            Console.WriteLine("Área  de X = " + x.area.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área  de Y = " + y.area.ToString("F4", CultureInfo.InvariantCulture));

            if(x.area > y.area)
            {
                Console.WriteLine("A área de X é maior que a área de Y.");
            }
            else if (x.area < y.area)
            {
                Console.WriteLine("A área de Y é maior que a área de X.");
            }
            else
            {
                Console.WriteLine("Resultado inesperado.");
            }
        }
    }
}

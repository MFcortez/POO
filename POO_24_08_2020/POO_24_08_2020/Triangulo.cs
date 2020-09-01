using System;
using System.Globalization;

namespace POO_24_08_2020
{
    public class Triangulo
        {
            public double A;
            public double B;
            public double C;
            public double area;

            public void calculaArea()
            {
                double p = (A + B + C) / 2.0;
                area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            }
        }
}
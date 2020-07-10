using System;

namespace Course_0._2
{
    class Triangulo
    {
        public double A;
        public double B;
        public double C;


        public double CalculaArea()
        {
            double valorArea = 2.0;

            double p = (A + B + C) / valorArea;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}

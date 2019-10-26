using System;
using System.Collections.Generic;
using System.Text;

namespace AreaPerimetroDiagonalDoRetanguloClasses
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }
        public double Perimetro()
        {
            return 2 * (Largura + Altura);
        }
        public double Diagonal()
        {
            double D = ((Largura * Largura) + (Altura * Altura));
            return Math.Sqrt(D); 
        }
    }
}

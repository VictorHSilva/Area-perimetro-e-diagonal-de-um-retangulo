using System;
using System.Globalization;

namespace AreaPerimetroDiagonalDoRetanguloClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret = new Retangulo();
            

            Console.Write("Entre com a Altura do Retangulo: ");
            ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Entre com a largura do Retangulo: ");
            ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("A area do retangulo é: "+ret.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.Write("O Perimetro do retangulo é: "+ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.Write("A diagonal do retangulo é: "+ret.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
            

        }
    }
}

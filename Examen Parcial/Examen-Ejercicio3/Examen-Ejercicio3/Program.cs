using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Operaciones o = new Operaciones();
            o.CuandosSeaMenoraCero += NumMenor;
            Console.WriteLine("Introduzca los valores de las constantes");
            double a, b, c,x1,x2;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            x1 = (-b + Math.Sqrt(b * b - 4 * a * c)) / 2 * a;
            x2 = (-b - Math.Sqrt(b * b - 4 * a * c)) / 2 * a;
            
            Console.WriteLine("Raiz 1: {0} Raiz 2: {1}",x1,x2);
            double res = o.Menor0(a, b, c);
            Console.ReadKey();
        }
        static void NumMenor(double a, double b, double c)
        {
            Console.WriteLine("Raiz Imaginaria");
        }
        
    }
    
    class Operaciones
    {
        public delegate void Delegatres(double a, double b, double c);
        public event Delegatres CuandosSeaMenoraCero;
        public double Menor0(double a, double b, double c)
        {
            double res;
            if ((b*b-4*a*c) < 0 && CuandosSeaMenoraCero!=null)
            {
                CuandosSeaMenoraCero(a,b,c);
            }
            res = b * b - 4 * a * c;
            return res;
            
        }
    }
}

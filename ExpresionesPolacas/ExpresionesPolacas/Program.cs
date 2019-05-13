using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpresionesPolacas
{
    class Program
    {
        static void Main(string[] args)
        {
            String Expresion;
            Console.WriteLine("Introducir una Expresion Algebraica");
            Expresion = Console.ReadLine();
            Evaluacion ev = new Evaluacion(Expresion);
            ev.CrearPolaca();
         // Console.WriteLine("\nSolucion: "+ev.EvaluarPolaca());
            Console.ReadKey();

        }
    }
}

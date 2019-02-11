using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventosTP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Operaciones A = new Operaciones();
            A.Cuandoelfactorialseamultiplode3 += Sumatoria;
            int Res = A.Factorial (2);
            Console.WriteLine("factorial " + Res);
            Res = A.Factorial(3);
            Console.WriteLine("factorial "+Res);
            Console.ReadKey();
        }
        static void Sumatoria(int n)
        {
            int suma = 0;
            for(int i=1;i<=n;i++)
            {
                suma = suma + i;
            }
            Console.WriteLine("La sumatoria es " + suma);
        }
    }
}

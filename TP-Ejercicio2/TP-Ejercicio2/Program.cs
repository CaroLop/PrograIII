using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum=0,n,res=0;
            
            Console.WriteLine("Introduzca el limite");
            n = int.Parse(Console.ReadLine());
                int[] Vector = new int[n];
            Operaciones O = new Operaciones();
            O.CuandoRecibaMultiplosTres += Mult3;
            Console.WriteLine("Introduzca {0} valores", n);
            for (int i=0;i<n;i++)
            {
                Vector[i] = int.Parse(Console.ReadLine());
                sum = sum + Vector[i];
                res = O.Multres(Vector[i]);
                    }
            Console.WriteLine("Suma:"+sum);
            
            Console.ReadKey();
        }
       static void Mult3(int x)
        {
            double div = x / 3;
            Console.WriteLine("Division: "+div);
        }

    }
    class Operaciones
    {
        public delegate void Delegado(int n); 
        public event Delegado CuandoRecibaMultiplosTres;
        public int Multres(int x)
        {
           
            if ((x% 3 == 0) && (CuandoRecibaMultiplosTres != null)) 
            { CuandoRecibaMultiplosTres(x); }
            return x;
        }
    }
}

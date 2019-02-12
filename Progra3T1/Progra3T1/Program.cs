using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra3T1
{
    class Program
    {
        public delegate void del<T>(T[] vector);
        static void Main(string[] args)
        {
            
            char[] ch = { 'A', 'X', 'R', 'B' , 'L','D'};
            int[] Num = { 2, 7, 6, 3, 10,1,4 };
            double[] Dou = { 5.2, 8.1, 4.1, 1.7,2.4,7.2,3.3 };

            
            Console.WriteLine("Vector char:");
            Imprimir(ch);
            Console.WriteLine();
            MetodoBurbuja(ch);
            Imprimir(ch);

            Console.WriteLine();
            Console.WriteLine("Vector int:");
            Imprimir(Num);
            Console.WriteLine();
            MetodoBurbuja(Num);
            Imprimir(Num);

            Console.WriteLine();
            Console.WriteLine("Vector double:");
            Imprimir(Dou);
            Console.WriteLine();
            MetodoBurbuja(Dou);
            Imprimir(Dou);

            Console.ReadKey();

        }
        public static void MetodoBurbuja<T>(T[] vector) where T:IComparable
        {
            T t;
            int a,b;
                        
            for ( a = 1; a < vector.Length; a++)
                for ( b = vector.Length - 1; b >= a; b--)
                {
                    
                    if (vector[b-1].CompareTo(vector[b])>0)
                    {
                        t = vector[b - 1];
                        vector[b - 1] = vector[b];
                        vector[b] = t;
                    }
                }
        }
        public static void Imprimir<T>(T[] vector)
        { 
            for (int f = 0; f < vector.Length; f++)
            {
                Console.Write(vector[f] + "  ");
            }
        }
    }
}

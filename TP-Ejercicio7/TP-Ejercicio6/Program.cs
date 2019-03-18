using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Ejercicio7
{
    class Program
    {
        public delegate double Delegatres(double[] vector);
        static void Main(string[] args)
        {
            double[] Numeros = { 6, 12 , 7, 2, 16, 10, 13, 4, 5, 3, 9 };
            
            
            Delegatres DelMax = delegate (double[] vector)
            {
                double max = vector[0];
                for (int i = 0; i < vector.Length; i++)
                {
                    if (vector[i] > max)
                    { max = vector[i]; }
                }
                return max;
            };
           
            Delegatres DelMin = delegate (double[] vector)
            {
                double min = vector[0];
                for (int i = 0; i < vector.Length; i++)
                {
                    if (vector[i] < min)
                    { min = vector[i]; }
                }
                return min;
            };
            
            Delegatres DelSum = delegate (double[] vector)
            {
                double Sum=0;
                for (int i = 0; i < vector.Length; i++)
                {
                    Sum = Sum + vector[i];
                }
                return Sum;
            };

            Delegatres DelMult5 = delegate (double[] vector)
            {
                double Sum = 0;
                for (int i = 0; i < vector.Length; i++)
                {
                    if(vector[i]%5==0)
                    { Sum = Sum + vector[i]; }
                }
                return Sum ;
            };
            Delegatres DelDiv = delegate (double[] vector)
            {
                double min=0,max=0;
                for (int i = 0; i < vector.Length; i++)
                {
                    if (vector[i] < min)
                    { min = vector[i]; }
                    if (vector[i] > max)
                    { max = vector[i]; }
                }
                return max/min;
            };
            Console.WriteLine("1. Mayor de los numeros");
            Console.WriteLine("Mayor: " + DelMax(Numeros));
            Console.WriteLine("2. Menor de los numeros");
            Console.WriteLine("Menor: " + DelMin(Numeros));
            Console.WriteLine("3. Suma de los numeros");
            Console.WriteLine("Suma: " + DelSum(Numeros));
            Console.WriteLine("4. Suma de los Multiplos de 5");
            Console.WriteLine("Suma: " + DelMult5(Numeros));
            Console.WriteLine("5. Division entre el numero mayor y el menor");
            Console.WriteLine("Division: "+DelDiv(Numeros));

            Console.ReadKey();
        }
    }
}

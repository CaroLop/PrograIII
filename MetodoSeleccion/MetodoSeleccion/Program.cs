using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoSeleccion
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = {5,2,7,2,6,1,8,3 };
            int n = x.Length;
            int minimo = 0,temp;
            for (int i = 0; i < n ; i++)
            {
                minimo = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (x[minimo] > x[j]) minimo = j;
                }
                temp = x[minimo];
                x[minimo] = x[i];
                x[i] = temp;
                Console.WriteLine(x[i]);
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesVectores
{
    class Program
    {
        static void Main(string[] args)
        {
            MostarOperacion MO = new MostarOperacion();
            Console.WriteLine("Introduzca los Vectores");
            double[] a = new double[3];
            double[] b = new double[3];
           // if (Console.ReadLine()!=null)
           // {
                for(int i=0;i<a.Length;i++)
                {
                    a[i] = int.Parse(Console.ReadLine());
                   
                }
                for (int i = 0; i < b.Length; i++)
                {
                    b[i] = int.Parse(Console.ReadLine());
                   
                }
           // }
            Vector vct = new Vector(a, b);
            Console.WriteLine("Digite una opcion");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicar");
            int op = int.Parse(Console.ReadLine());
            String Opcion ="";
            do
            {
                Console.Clear();
                switch(op)
                {
                    case 1:
                        Opcion = "Suma";
                        vct.Mostrar(Opcion);
                        break;
                    case 2:
                        Opcion = "Resta";
                       vct.Mostrar(Opcion);
                        break;
                    case 3:
                       Opcion = "Multiplicacion";                    
                       vct.Mostrar(Opcion);
                        break;
                }
            } while (op==4);
            MO.Show();
            Console.ReadKey();
            
        }
    }
}

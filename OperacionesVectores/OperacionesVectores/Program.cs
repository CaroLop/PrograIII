using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OperacionesVectores
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca la longitud de los vectores");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca los Vectores");

            double[] a = new double[x];
            double[] b = new double[x];
                for(int i=0;i<a.Length;i++)
                {
                    a[i] = int.Parse(Console.ReadLine());
                   
                }
                for (int i = 0; i < b.Length; i++)
                {
                    b[i] = int.Parse(Console.ReadLine());
                   
                }
            Vector vct = new Vector(a, b);
            int op = 0;
            String Opcion ="";
            MostarOperacion Mo = new MostarOperacion();
                       do
            {
                Console.WriteLine("Digite una opcion");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicar");
                op = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (op)
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
         
            Console.ReadKey();
            
        }
    }
}

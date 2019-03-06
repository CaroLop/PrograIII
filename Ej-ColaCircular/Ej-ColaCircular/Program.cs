using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_ColaCircular
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean Salir = false;
            int opcion = 4, a = 0;
            ColaCircular<int> P = new ColaCircular<int>();
            while (Salir == false)
            {
                Console.Clear();
                Console.WriteLine("1. Insertar");
                Console.WriteLine("2. Eliminar");
                Console.WriteLine("3. Mostrar");
                Console.WriteLine("4. Salir");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Introduzca un numero");
                        a = int.Parse(Console.ReadLine());
                        P.Push(a);
                        break;
                    case 2:
                        a = P.Pop();
                        Console.WriteLine("Eliminado: " + a);
                        Console.ReadKey();
                        break;
                    case 3:
                        P.Mostrar();
                        
                        Console.ReadKey();
                        break;
                    case 4:
                        Salir = true;
                        break;
                }
               
            }
            Console.ReadKey();

        }
    }
}

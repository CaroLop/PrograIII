using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_Pila
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean Salir = false;
            int opcion = 4,a=0;
            Pila<int> p = new Pila<int>();
            while(Salir==false)
            {
                Console.WriteLine("1. Push");
                Console.WriteLine("2. Pop");
                Console.WriteLine("3. Mostrar");
                Console.WriteLine("4. Salir");

                opcion = int.Parse(Console.ReadLine());
                switch(opcion)
                {
                    case 1:
                        Console.WriteLine("Introduzca un elemento");
                        a = int.Parse(Console.ReadLine());
                        p.Push(a);
                        
                        break;
                        
                    case 2:
                       a = p.Pop();
                        Console.WriteLine("Elemento Eliminado " + a);
                        break;
                    case 3:
                        p.Mostar();
                        Console.WriteLine();
                        break;

                }
                
            }
            Console.ReadKey();
        }
    }
}

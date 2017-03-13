using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean Salir = false;
            int opcion = 4;
            string a;
            List<string> p = new List<string>();
            while (Salir == false)
            {
                Console.Clear();
                Console.WriteLine("1. Insertar");
                Console.WriteLine("2. Eliminar");
                Console.WriteLine("3. Ordenar");
                Console.WriteLine("4. Mostrar");
                Console.WriteLine("5. Salir");

                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Introduzca un elemento");
                        a = Console.ReadLine();
                        p.Add(a);

                        break;

                    case 2:
                        Console.WriteLine("Introduzca un elemento");
                        a = Console.ReadLine();
                        p.Remove(a);
                        Console.WriteLine("Elemento Eliminado " + a);
                       
                        break;
                    case 4:
                        Console.WriteLine("Lista: ");
                        foreach (Object o in p)
                        {
                            Console.Write(o.ToString() + " ");
                        }
                        Console.ReadKey();
                            break;
                    case 3:
                        p.Sort();
                        Console.WriteLine("Se ordeno la lista");
                        break;
                    case 5:
                        Salir = true;
                        break;
                }

            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            
            BiCola<Persona> p = new BiCola<Persona>();
            Persona persona;
            string a, s, c; int e;
            while (opcion != 6)
            {
                Console.Clear();
                Console.WriteLine("1. Insertar por Detras");
                Console.WriteLine("2. Insertar por Delante");
                Console.WriteLine("3. Eliminar por Delante");
                Console.WriteLine("4. Eliminar por Atras");
                Console.WriteLine("5. Mostrar");
                Console.WriteLine("6. Salir");

                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese los datos para insertar por Atras");
                        Console.Write("Nombre: ");
                        a = Console.ReadLine();
                        Console.Write("Edad: ");
                        e = int.Parse(Console.ReadLine());
                        Console.Write("Sexo (M/F): ");
                        s = Console.ReadLine();
                        Console.Write("Carrera: ");
                        c = Console.ReadLine();
                        persona = new Persona(a, e, s, c);
                        p.InsertarAtras(persona);
                        break;
                    case 2:
                        Console.WriteLine("Ingrese los datos un elemento por Delante");
                        
                        Console.Write("Nombre: ");
                        a = Console.ReadLine();
                        Console.Write("Edad: ");
                        e = int.Parse(Console.ReadLine());
                        Console.Write("Sexo (M/F): ");
                        s = Console.ReadLine();
                        Console.Write("Carrera: ");
                        c = Console.ReadLine();
                        persona = new Persona(a, e, s, c);

                        
                        p.InsertarDelante(persona);
                        break;
                    case 3:
                        persona = p.EliminarDelante();
                        Console.WriteLine("El elemento eliminado es {0}", persona.Nombre1);
                        Console.ReadKey();
                        break;
                    case 4:
                        persona = p.EliminarAtras();
                        Console.WriteLine("El elemento eliminado es {0}", persona.Nombre1);
                        Console.ReadKey();
                        break;
                    case 5:
                        p.mostrar();
                        Console.ReadKey();
                        break;

                }


            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_TrabajoPractico
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno;
            Boolean Salir = false;
            int opcion = 4, i=0,e;
            string a,s,c;
            Pila<Alumno> p = new Pila<Alumno>();
            while (Salir == false)
            {
                Console.WriteLine("1.Insertar los datos del alumno");
                Console.WriteLine("2. Eliminar ");
                Console.WriteLine("3. Mostrar");
                Console.WriteLine("4. Salir");

                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese los datos");
                        Console.Write("Nombre: ");
                        a = Console.ReadLine();
                        Console.Write("Edad: ");
                        e = int.Parse(Console.ReadLine());
                        Console.Write("Sexo (M/F): ");
                        s = Console.ReadLine();
                        Console.Write("Carrera: ");
                        c = Console.ReadLine();
                        alumno = new Alumno(a, e, s,c);
                        p.Push(alumno);
                        
                        break;

                    case 2:
                       
                       alumno= p.Pop();
                        Console.WriteLine("Elemento Eliminado " +alumno.Nombre1);
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

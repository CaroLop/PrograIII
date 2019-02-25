using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELinq_Metodos
{
    class Program
    {
        public delegate T DPersona<T>(T Value);
        static void Main(string[] args)
        {
            Persona[] Alumnos = new Persona[7];
            Alumnos[0] = new Persona("Diego", "La Torre", 18, "M", "2384124", 1.74, 75);
            Alumnos[1] = new Persona("Alejandro", "Castro", 19, "M", "2356812", 1.69, 70);
            Alumnos[2] = new Persona("Carolina", "Lopez", 19, "F", "7504259", 1.65, 60);
            Alumnos[3] = new Persona("Gustavo", "Zarate", 19, "M", "9631245", 1.70, 69);
            Alumnos[4] = new Persona("Rossimar", "Guzman", 18, "F", "1958923", 1.70, 40);
            Alumnos[5] = new Persona("Dieter", "Quiñones", 19, "M", "1204962", 1.70, 59);
            Alumnos[6] = new Persona("Franco", "Adamczyk", 18, "M", "1059294", 1.70, 65);

            Console.WriteLine("1.- Apellidos ordenados descendente");
            var Metodo1 = Alumnos.OrderByDescending(a => a.Apellidos1);
            foreach(var x in Metodo1)
            {
                Console.WriteLine(x.Nomb1 + " " + x.Apellidos1);
            }
            Console.WriteLine();
            Console.WriteLine("2.- Alumnos de 18 masculino ");
            var Metodo2 = Alumnos.Where(x => x.Edad==18 && x.Sexo=="M");
            foreach (var x in Metodo2)
            {
                Console.WriteLine(x.Nomb1 + " " + x.Apellidos1);
            }
            Console.WriteLine();
            Console.WriteLine("3.- Grupo de alumnos por sexo");
            var Metodo3 = Alumnos.GroupBy(a => a.Sexo);
            foreach (var x in Metodo3)
            {
                Console.WriteLine(x.Key);
               foreach(Persona P in x)
                {
                    Console.WriteLine(P.Nomb1+" "+P.Apellidos1);
                }
            }
            Console.WriteLine();
            Console.WriteLine("4.- Nro de alumos por sexo");
            var Metodo4 = Alumnos.GroupBy(b=>new { a = b.Sexo})
            .Select( g => new {Cantidad = g.Count() , Sexo = g.Key.a});
            foreach (var x in Metodo4)
            {
                Console.WriteLine(x.Sexo+" "+x.Cantidad);
                
            }
            Console.WriteLine();
            Console.WriteLine("5.- Promedio de edad por Sexo");
            var Metodo5 = Alumnos.GroupBy(a => a.Sexo )
                .Select(x => new { sexo = x.Key, Prom = x.Average(p => p.Edad) });
            foreach(var x in Metodo5)
            {
                Console.WriteLine(x.sexo + " " + x.Prom);
            }

            Console.ReadKey();
        }
        
    }
}

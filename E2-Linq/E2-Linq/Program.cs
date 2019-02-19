using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2_Linq
{
    class Program
    {
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

            var consul = from alm in Alumnos
                         select alm;

            var consul2 = from alm in Alumnos
                          where alm.Edad == 18
                          select alm;

            var consul3 = from alm in Alumnos
                          orderby alm.Apellidos1
                          select alm;
            /*foreach (Persona alumno in consul3)
            {
                Console.WriteLine(alumno.Nomb1);
            }
           

            var consultedad = from alum in Alumnos
                              group alum by alum.Edad into edad
                              select edad;
            foreach (var groupedades in consultedad)
            {
                Console.WriteLine(groupedades.Key);
                foreach(Persona alumno in groupedades)
                {
                    Console.WriteLine(alumno.Nomb1 + " " + alumno.Apellidos1);
                }
            }
            Console.WriteLine();
            var consultedad2 = from alum in Alumnos
                              group alum by alum.Edad into edad
                              select new { Edad = edad.Key, Cantidad = edad.Count() };
            foreach (var groupedades in consultedad2)
            {
                
                    Console.WriteLine(groupedades.Edad + " " + groupedades.Cantidad);
                
            }*/
            Console.WriteLine("1.-");
            var consul4 = from alm in Alumnos
                          orderby alm.Apellidos1 descending
                          select alm;
            foreach (Persona persona in consul4)
            {
                Console.WriteLine("{0} {1}", persona.Apellidos1, persona.Nomb1);
            }
            Console.WriteLine("2.-");
            var consul5 = from alm in Alumnos
                          where alm.Edad == 18 && alm.Sexo == "M"
                          select alm;
            foreach (Persona persona in consul5)
            {
                Console.WriteLine("{0}", persona.Nomb1);
            }

            Console.WriteLine("3.-");
            var consultS1 = from alum in Alumnos
                            group alum by alum.Sexo into sexo
                            select sexo;
            foreach (var groups in consultS1)
            {
                Console.WriteLine(groups.Key);
                foreach (Persona alumno in groups)
                {
                    Console.WriteLine(alumno.Nomb1 + " " + alumno.Apellidos1);
                }
            }
            Console.WriteLine("4.-");
            var consultS2 = from alum in Alumnos
                               group alum by alum.Sexo into sexo
                               select new { Sexo = sexo.Key, Cantidad = sexo.Count() };
            foreach (var groupedades in consultS2)
            {

                Console.WriteLine(groupedades.Sexo + " " + groupedades.Cantidad);

            }
            Console.WriteLine("5.-");
            var consulpr = from alum in Alumnos
                          
                            group alum by alum.Sexo into sexo
                            select sexo;

            
                foreach (var groupedades in consulpr)
               {
                int res = 0;
                Console.WriteLine(groupedades.Key);
                foreach (Persona alumno in Alumnos)
                {
                  
                        res = (alumno.Edad + res) ;
                    
                }
                
                res = res / 5;
                Console.WriteLine(groupedades.Key + " " + res);
            }
               

            Console.ReadKey();
        }
    }
}

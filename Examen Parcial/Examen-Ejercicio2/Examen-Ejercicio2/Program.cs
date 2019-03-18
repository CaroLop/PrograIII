using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona[] Maestros = new Persona[4];
            List<string> LJM = new List<string>();
            LJM.Add("Dionisio"); LJM.Add("Pedro");LJM.Add("Juan");
            List<string> LMP = new List<string>();
            LMP.Add("Marcela"); LMP.Add("Maria"); LMP.Add("Ricardo");
            Maestros[0] = new Persona("Juan","Perez",35,"Masculino","Ing. Industrial",LJM);
            Maestros[1] = new Persona("Maria", "Gomez", 35, "Femenino", "Ing. Civil", LMP);
            LMP.Remove("Maria"); LMP.Remove("Ricardo");
            Maestros[2] = new Persona("Pedro", "Vaca", 35, "Masculino", "Ing. Civil", LMP);
            Maestros[3] = new Persona("Marta", "Aramayo", 40, "Femenino", "Ing. Industrial", LJM);

            var Consulta1 = from M in Maestros
                            orderby  M.Edad1, M.Nombre1 ascending
                            select M;
                            
            foreach (Persona M in Consulta1)
            { Console.WriteLine("{0} ", M.Nombre1); }

            Console.WriteLine("************************************");
            var Consulta2 = from M in Maestros
                            where M.Edad1==35
                            select M;
            foreach (Persona M in Consulta2)
            { Console.WriteLine("{0} ", M.Nombre1); }
            Console.WriteLine("************************************");
            var Consulta3 = from M in Maestros
                            group M by M.Carrera1  into Carrera
                            select new { carrera = Carrera.Key, sexo = Maestros.GroupBy(a => a.Sexo1),cantidad = Carrera.Count() };
           foreach(var groups in Consulta3)
            {
                Console.WriteLine(groups.carrera + " " + groups.cantidad);
            }
                Console.WriteLine("************************************");
                var Consulta4 = from M in Maestros
                            where M.Sexo1 == "Femenino"
                            group M by M.Edad1 into edad
                            select new {Edad=edad.Key, Cantidad=edad.Count() };
            foreach(var group in Consulta4)
            {
                Console.WriteLine(group.Edad+" "+group.Cantidad);
                
            }
            Console.ReadKey();
        }
    }
}

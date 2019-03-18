using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona[] Maestros=new Persona[5];
            List<string> L = new List<string>();
            L.Add("IIS"); L.Add("IC"); L.Add("IS"); L.Add("CI");
            Maestros[0] = new Persona("Aquiles", "Vaesa", 45, "Ing. Sistemas",L);
            L.Remove("CI");
            Maestros[1] = new Persona("Jherson", "Torres", 61, "Ing. Civil",L );
            L.Add("DG");
            Maestros[2] = new Persona("Pancon", "Queso", 49, "Disenador Grafico", L);
            L.Add("IA"); L.Remove("IS");
            Maestros[3] = new Persona("Furro", "Grillo", 65, "Ing. Agronomo", L);
            L.Add("IM");
            Maestros[4] = new Persona("Elba", "Neado", 45 , "Ing. Comercial", L);

            Console.WriteLine("1.- Lista de docentes por Apellido Descendentemente");
            var Consulta1 = from Mast in Maestros
                            orderby Mast.Apellidos1 descending
                            select Mast;
            foreach(Persona M in Consulta1)
            { Console.WriteLine("{0} {1} ",M.Apellidos1,M.Nomb1); }
            Console.WriteLine("**************************************");
            Console.WriteLine("2.- Lista de Docentes mayores a 60");
            var Consulta2 = from Mast in Maestros
                            where Mast.Edad >= 60
                            select Mast;
            foreach (Persona M in Consulta2)
            { Console.WriteLine("{0} {1} ", M.Nomb1, M.Apellidos1); }
            Console.WriteLine("**************************************");
            Console.WriteLine("3.- Grupos de Maestros por Edad");
            var Consulta3 = from Mast in Maestros
                            group Mast by Mast.Edad into edad
                            select edad;

            foreach (var group in Consulta3)
            {
                Console.Write(group.Key);
                foreach(Persona M in group)
                { Console.WriteLine(" {0} {1} ", M.Apellidos1, M.Nomb1); }
            }

            Console.ReadKey();
        }
    }
}

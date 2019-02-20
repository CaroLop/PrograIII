using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELinq_Metodos
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
            ListAlApellidoDes(Alumnos);
        }
        
    }
}

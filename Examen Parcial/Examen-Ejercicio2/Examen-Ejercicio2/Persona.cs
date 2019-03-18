using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Ejercicio2
{
    class Persona
    {
        string Nombre;
        string Apellido;
        int Edad;
        string Sexo;
        string Carrera;
        List<string> Alumnos = new List<string>();
        public Persona(string nombre,string apellido, int edad, string sexo, string carrera,List<string> alumnos)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Edad = edad;
            this.Sexo = sexo;
            this.Carrera = carrera;
            this.Alumnos = alumnos;
        }

        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public int Edad1 { get => Edad; set => Edad = value; }
        public string Sexo1 { get => Sexo; set => Sexo = value; }
        public string Carrera1 { get => Carrera; set => Carrera = value; }
        public string Apellido1 { get => Apellido; set => Apellido = value; }
        public List<string> Alumnos1 { get => Alumnos; set => Alumnos = value; }
    }
}

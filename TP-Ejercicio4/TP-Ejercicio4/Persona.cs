using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Ejercicio4
{
    class Persona
    {

        string Nomb;
        string Apellidos;
        int edad;
        string Carrera;
        List<string> list = new List<string>();
        
        public Persona(string n, string a, int e, string C, List<string> List)
        {
            this.Nomb = n;
            this.Apellidos = a;
            this.edad = e;
            this.Carrera = C;
            this.list = List;
        }

        public string Nomb1 { get => Nomb; set => Nomb = value; }
        public string Apellidos1 { get => Apellidos; set => Apellidos = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Carrera1 { get => Carrera; set => Carrera = value; }
    }
}

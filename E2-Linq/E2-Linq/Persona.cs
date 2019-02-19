using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2_Linq
{
    class Persona
    {
        string Nomb;
        string Apellidos;
        int edad;
        string sexo;
        string CI;
        double altura;
        double peso;
        public Persona(string n, string a, int e, string s, string ci, double al, double p)
        {
            this.Nomb = n;
            this.Apellidos = a;
            this.edad = e;
            this.sexo = s;
            this.CI = ci;
            this.altura = al;
            this.peso = p;

        }

        public string Nomb1 { get => Nomb; set => Nomb = value; }
        public string Apellidos1 { get => Apellidos; set => Apellidos = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string CI1 { get => CI; set => CI = value; }
        public double Altura { get => altura; set => altura = value; }
        public double Peso { get => peso; set => peso = value; }
    }
}

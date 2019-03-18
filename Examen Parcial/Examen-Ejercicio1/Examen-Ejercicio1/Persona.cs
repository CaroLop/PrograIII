using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Ejercicio1
{
    class Persona
    {
        string Nombre;
        int Edad;
        string Sexo;
        string Carrera;
        public Persona(string nombre,int edad,string sexo,string carrera)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Sexo = sexo;
            this.Carrera = carrera;
        }

        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public int Edad1 { get => Edad; set => Edad = value; }
        public string Sexo1 { get => Sexo; set => Sexo = value; }
        public string Carrera1 { get => Carrera; set => Carrera = value; }
    }
    class BiCola<T>
    {
        public const int Maximo = 10;
        private Persona[] arreglo = new Persona[Maximo];
        private int final = 0;
        private int frente = 0;
        public void InsertarAtras(Persona valor)
        {
            if (!LLena())
            {
                arreglo[final] = valor;
                final = (final + 1) % Maximo;
            }
            else
                Console.WriteLine("La Cola esta llena");
        }
        public void InsertarDelante(Persona valor)
        {
            if (!LLena())
            {
                if (frente == 0)
                    frente = Maximo - 1;
                else
                    frente++;
                arreglo[frente] = valor;
            }
            else
                Console.WriteLine("La Cola esta llena");
        }
        public Persona EliminarDelante()
        {
            if (!Vacia())
            {
                Persona valor;
                valor = arreglo[frente];
                frente = (frente + 1) % Maximo;
                return valor;
            }
            else
            {
                Console.WriteLine("La Cola esta Vacia");
                return arreglo[frente];
            }
        }
        public Persona EliminarAtras()
        {
            if (!Vacia())
            {

                Persona valor;
                if (final == 0)
                {
                    final = Maximo - 1;
                }
                final--;
                valor = arreglo[final];
                return valor;
            }
            else
            {
                Console.WriteLine("La Cola esta Vacia");
                return arreglo[frente];
            }
        }


        public void mostrar()
        {
            int aux = frente;
            while (aux != final)
            {
                Console.Write(arreglo[aux].Nombre1 + " ");
                aux = (aux + 1) % Maximo;
            }
        }
        private Boolean Vacia()
        {
            return frente == final;
        }
        private Boolean LLena()
        {
            return frente == (final + 1) % Maximo;
        }
    }
}

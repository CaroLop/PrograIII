using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_TrabajoPractico
{
    class Pila<T>
    {
        private Alumno[] Vector = new Alumno[10];
        private int tope = -1;

        public void Push(Alumno x)
        {
            if (!Llena())
            {
                tope++;
               
                Vector[tope] = x;
           
            }
            else
            {
                Console.WriteLine("La pila esta llena");
            }
            
        }
        public Alumno Pop()
        {

            if (!Vacia())
            {
                tope--;
                return Vector[tope + 1];
            }
            else
            {
                Console.WriteLine("La pila esta vacia");
                return Vector[tope + 1];
            }


        }
        private Boolean Vacia()
        {

            return tope == -1;

        }
        private Boolean Llena()
        {

            return tope == 10;

        }
        public void Mostar()
        {
            for (int i = 0; i <= tope; i++)
            {
                Console.Write("Nombre: "+Vector[i].Nombre1 + " Edad: "+Vector[i].Edad1+"   ");
            }
        }
       
    }
    public class Alumno
    {
        string Nombre;
        int Edad;
        string Sexo;
        string Carrera;

        public Alumno(string nombre, int edad, string sexo, string carrera)
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
}

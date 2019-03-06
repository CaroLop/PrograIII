using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_ColaCircular
{
    class ColaCircular<T>
    {
        private const int max = 10;
        private T[] Vector = new T[max];
        private int cola = 0;
        private int frente = 0;
        public void Push(T x)
        {
            if (!Llena())
            {
                Vector[cola] = x;
                cola = (cola + 1) % max;
            }
            else
            {
                Console.WriteLine("La lista esta llena");
            }
        }
        public T Pop()
        {
            T val;
            if (!vacia())
            {
                val = Vector[frente];
                frente = (frente + 1) % max;
                return val;
            }
            else
            {

                Console.WriteLine("La lista esta Vacia");
                return Vector[cola + 1];
            }
        }
        public Boolean vacia()
        {
            return frente == cola;
        }
        public Boolean Llena()
        {
            return (cola+1)%max==frente;
        }
        public void Mostrar()
        {
            int i = frente;
            Console.WriteLine("Vector: ");
            while (i!=cola)
            {
                
                Console.Write(Vector[i] + " ");
                i = (i + 1) % max;
            }
            
        }
    }
}

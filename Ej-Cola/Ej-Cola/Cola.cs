using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_Cola
{
    class Cola<T>
    {
        private T[] Vector = new T[10];
        private int cola = -1;
        public int frente = 0;
        public void Push(T x)
        {
            if (!Llena())
            {
                cola++;
                Vector[cola] = x;
            }
            else
            {
                Console.WriteLine("La pila esta llena");
            }
        }
        public T Pop()
        {
            
            if (!Vacia())
            {
                frente++;

                return Vector[frente]; 
            }
            else
            {
                Console.WriteLine("La pila esta vacia");
                return Vector[cola + 1];
            }


        }
        private Boolean Vacia()
        {

            return frente>=cola;

        }
        private Boolean Llena()
        {

            return cola==10;

        }
        public void Mostar()
        {
            for (int i = 0; i < cola + 1; i++)
            {

                Console.Write(Vector[i] + " ");

            }
        }
    }
}

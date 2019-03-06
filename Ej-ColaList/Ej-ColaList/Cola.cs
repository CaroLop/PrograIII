using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_ColaList
{
    class Cola<T>
    {
        private int max = 10;
        private T[] Vector = new T[10];
        private int cola = -1;
        private int frente = 0;
        public void Push(T x)
        {
            if(!Llena())
            {
                cola++;
                Vector[cola] = x;
            }
            else
            {
                Console.WriteLine("La Lista esta llena");
            }
        }
        public T Pop()
        {
            if (!vacia())
            {

                return Vector[frente++];

            }
            else
            {
                Console.WriteLine("La lista esta Vacia");
                return Vector[cola + 1];
            }
        }
        public Boolean vacia()
        {
            return frente > cola;
        }
        public Boolean Llena()
        {
            return cola == 10;
        }
        public void Mostrar()
        {
            int i = 0;

            while(i<=cola)
            {
                    Console.Write(Vector[i++] + " ");
            }
               
            
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_Pila
{
    

    class Pila<T>
    {
        private T[] Vector = new T[10];
        private int tope=-1;
        public void Push(T x)
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
        public T Pop()
        {
            
            if (!Vacia())
            {
                tope--;
               return Vector[tope+1];
            }
            else
            {
                 Console.WriteLine("La pila esta vacia");
                return Vector[tope + 1]; 
            }
            
            
        }
        private Boolean Vacia()
        {
           
                return tope==-1;

        }
        private Boolean Llena()
        {
            
                return tope==10;
            
        }
        public void Mostar()
        {
            for(int i=0;i<tope+1;i++)
            {
               
                    Console.Write(Vector[i] + " ");

            }
        }
    }
}

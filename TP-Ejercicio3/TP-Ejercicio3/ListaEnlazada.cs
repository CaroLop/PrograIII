using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Ejercicio3
{
    class Nodo<T>
    {
            public String info;
            public Nodo<T> Siguiente;
            public Nodo(String valor)
            {
                info = valor;
                Siguiente = null;
            }
        }
    class Lista<T>
    {
        public Nodo<T> Actual;
        public void Insertar(T valor)
        {
            Nodo<T> nuevo = new Nodo<T>(valor.ToString());
            if (Actual == null)
            { Actual = nuevo; }
            else
            {
                Nodo<T> aux = Actual;
                while (aux.Siguiente != null)
                {
                    aux = aux.Siguiente;
                }

                aux.Siguiente = nuevo;
            }
        }
        public void Eliminar(T valor)
        {
            if (Actual != null)
            {
                Nodo<T> aux = Actual;
                Nodo<T> ant = null;
                while (aux.Siguiente != null && aux.info != valor.ToString())
                {
                    ant = aux;
                    aux = aux.Siguiente;
                }
                if (aux.info == valor.ToString())
                {
                    if (ant == null)
                        Actual = aux.Siguiente;
                    else
                        ant.Siguiente = aux.Siguiente;
                }
                else
                    Console.WriteLine("No se encontro el valor");


            }
        }
        public void Mostrar()
        {
            if (Actual != null)
            {
                Nodo<T> aux = Actual;
                while (aux != null)
                {
                    Console.Write(aux.info+" ");
                    aux = aux.Siguiente;

                }
            }
        }
    }  
}

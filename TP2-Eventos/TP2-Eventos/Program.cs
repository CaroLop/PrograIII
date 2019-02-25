using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Eventos
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, res=0,a,b=0;
            Console.WriteLine("introduzca el valor del stock");
            a = int.Parse(Console.ReadLine());
            do
            {
                
                Console.WriteLine("Menu\n1.-Incrementar\n2.-Disminuir\n3.-Mostrar\n4.-salir");
                Console.WriteLine("Seleccione una opcion: ");
                n = int.Parse(Console.ReadLine());
                Stock st = new Stock();
                st.Inventario += stockmin;
<<<<<<< HEAD
                st.Stocks = 10;
                
=======
                st.Stocks = a;
>>>>>>> a05a6c2b9cadb567bd40d27fbeced37ae7bf627f
                switch(n)
                {
                    case 1:

<<<<<<< HEAD
                        if (res !=0)
                        {
                            st.Stocks = res;
                            res = st.IncrementarI(5);
                            Console.WriteLine("Incrementado a " + res);
                        }

                        else 
                        {
                            res = st.Stocks;
                            res = st.IncrementarI(5);
=======
                        if (res > 0 )
                        {
                            Console.WriteLine("Introduzca el valor a aumentar");
                            b = int.Parse(Console.ReadLine());
                            st.Stocks = res;
                            res = st.IncrementarI(b);
                            Console.WriteLine("Incrementado a " + res);
                        }
                        else 
                        {
                            Console.WriteLine("Introduzca el valor a aumentar");
                            b = int.Parse(Console.ReadLine());
                            res = st.Stocks;
                            res = st.IncrementarI(b);
>>>>>>> a05a6c2b9cadb567bd40d27fbeced37ae7bf627f
                            Console.WriteLine("Incrementado a " + res);
                        }
                        
                        break;
                    case 2:
<<<<<<< HEAD
                        if (res > st.Stocks)
                        {
                            st.Stocks = res;
                            res = st.Disminuir(3);

=======
                        if (res > st.Stocks )
                        {
                            Console.WriteLine("Introduzca el valor a disminuir");
                            b = int.Parse(Console.ReadLine());
                            st.Stocks = res;
                            res = st.Disminuir(b);
                            Console.WriteLine("Disminuido a " + res);
                        }
                        
                        
                        else if(res!=0 && res<5 && st.Stocks>=res)
                        {
                            Console.WriteLine("Introduzca el valor a disminuir");
                            b = int.Parse(Console.ReadLine());
                            st.Stocks = res;
                            res = st.Disminuir(b);
>>>>>>> a05a6c2b9cadb567bd40d27fbeced37ae7bf627f
                            Console.WriteLine("Disminuido a " + res);
                        }
                        else
                        {
<<<<<<< HEAD
                            res = st.Stocks;
                            res = st.Disminuir(3);

                            Console.WriteLine("Disminuido a " + res);
                        }
                       
=======
                            Console.WriteLine("Introduzca el valor a disminuir");
                            b = int.Parse(Console.ReadLine());
                            res = st.Stocks;
                            res = st.Disminuir(b);
                            Console.WriteLine("Disminuido a " + res);
                        }
>>>>>>> a05a6c2b9cadb567bd40d27fbeced37ae7bf627f
                        break;
                    case 3:
                        st.Stocks = res;
                        st.Mostrar();
                        
                        break;
<<<<<<< HEAD
                  
                   
                }     
                       
               
                Console.ReadKey();

=======

                }     
                Console.ReadKey();
                Console.WriteLine();
>>>>>>> a05a6c2b9cadb567bd40d27fbeced37ae7bf627f
            } while (n<4);
           
        }
        static void stockmin(int n)
        {
            Console.WriteLine("Alerta el Stock es minimo");
        }
    }
}

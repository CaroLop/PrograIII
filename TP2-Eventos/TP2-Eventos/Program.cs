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
                st.Stocks = a;
                switch(n)
                {
                    case 1:

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
                            Console.WriteLine("Incrementado a " + res);
                        }
                        
                        break;
                    case 2:
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
                            Console.WriteLine("Disminuido a " + res);
                        }
                        else
                        {
                            Console.WriteLine("Introduzca el valor a disminuir");
                            b = int.Parse(Console.ReadLine());
                            res = st.Stocks;
                            res = st.Disminuir(b);
                            Console.WriteLine("Disminuido a " + res);
                        }
                        break;
                    case 3:
                        st.Stocks = res;
                        st.Mostrar();
                        
                        break;

                }     
                Console.ReadKey();
                Console.WriteLine();
            } while (n<4);
           
        }
        static void stockmin(int n)
        {
            Console.WriteLine("Alerta el Stock es minimo");
        }
    }
}

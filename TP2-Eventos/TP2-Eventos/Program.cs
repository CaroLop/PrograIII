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
            int n, res=0;
            do
            {
                Console.WriteLine("1.-Incrementar\n2.-Disminuir\n3.-Mostrar\n4.-salir");
                Console.WriteLine("Seleccione una opcion: ");
                n = int.Parse(Console.ReadLine());
                Stock st = new Stock();
                st.Inventario += stockmin;
                st.Stocks = 10;
                
                switch(n)
                {
                    case 1:

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
                            Console.WriteLine("Incrementado a " + res);
                        }
                        
                        break;
                    case 2:
                        if (res > st.Stocks)
                        {
                            st.Stocks = res;
                            res = st.Disminuir(3);

                            Console.WriteLine("Disminuido a " + res);
                        }
                        else
                        {
                            res = st.Stocks;
                            res = st.Disminuir(3);

                            Console.WriteLine("Disminuido a " + res);
                        }
                       
                        break;
                    case 3:
                        st.Stocks = res;
                        st.Mostrar();
                        
                        break;
                  
                   
                }     
                       
               
                Console.ReadKey();

            } while (n<4);
           
        }
        static void stockmin(int n)
        {
            Console.WriteLine("Alerta el Stock es minimo");
        }
    }
}

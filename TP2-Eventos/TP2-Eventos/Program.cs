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
                st.Stock = 10;
                
                switch(n)
                {
                    case 1:
                        res = st.IncrementarI(5);
                       Console.WriteLine("Incrementado a "+res);
                        
                        Console.ReadKey();
                        break;
                    case 2:
                        
                        Console.WriteLine("Disminuido a " + st.Disminuir(3));
                        Console.ReadKey();
                        break;
                    case 3:
                        st.Mostrar();
                        Console.ReadKey();
                        break;
                    case 4:
                        break;
                }
                Console.WriteLine("Seleccione una opcion");
                
            } while (n!=4);
            Console.ReadKey();
        }
        static void stockmin(int n)
        {
            Console.WriteLine("Alerta el Stock es minimo");
        }
    }
}

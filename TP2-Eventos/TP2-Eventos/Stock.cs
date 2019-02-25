using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Eventos
{
    class Stock
    {
        private int stock;

        public int Stocks { get => stock; set => stock = value; }

        public delegate void MDStock(int n);
        public event MDStock Inventario;
        public int IncrementarI(int n)
        {
            int sum = 0;
            Stocks += sum;
        if(Stocks<5 && Inventario!=null)
            {      
                Inventario(sum);
            }
            return Stocks=Stocks+n;
        }
        public int Disminuir(int n)
        {
            int res = 0;
            Stocks -= res;
            if (n > Stocks)
            {
<<<<<<< HEAD
                Console.WriteLine("La disminucion es menor al stock");
                if (Stocks< 5 && Inventario != null)
                {
                    Inventario(res);
                }
            }
=======
                Console.WriteLine("La disminucion es menor al stock, No se puede disminuir esa cantidad");
                
            }
            else if (Stocks < 5 && Inventario != null)
            {
                Inventario(res);
            }
>>>>>>> a05a6c2b9cadb567bd40d27fbeced37ae7bf627f
            return Stocks=Stocks-n;
        }
        public void Mostrar()
        {
<<<<<<< HEAD
            Console.WriteLine("Stock: "+Stocks);
=======
            Console.WriteLine("Stock actual: "+Stocks);
>>>>>>> a05a6c2b9cadb567bd40d27fbeced37ae7bf627f
        }
        

    }
}

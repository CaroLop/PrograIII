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
                Console.WriteLine("La disminucion es menor al stock");
                if (Stocks< 5 && Inventario != null)
                {
                    Inventario(res);
                }
            }
            return Stocks=Stocks-n;
        }
        public void Mostrar()
        {
            Console.WriteLine("Stock: "+Stocks);
        }
        

    }
}

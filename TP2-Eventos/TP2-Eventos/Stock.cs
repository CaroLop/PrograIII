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

        public int Stock { get => stock; set => stock = value; }

        public delegate void MDStock(int n);
        public event MDStock Inventario;
        public int IncrementarI(int n)
        {
            int sum = 0;
            Stock += sum;
        if(Stock<=5 && Inventario!=null)
            {      
                Inventario(sum);
            }
            return Stock+n;
        }
        public int Disminuir(int n)
        {
            int res = 0;
            Stock -= res;
            if (n > Stock)
            {
                Console.WriteLine("La disminucion es menor al stock");
                if (Stock <= 5 && Inventario != null)
                {
                    Inventario(res);
                }
            }
            return Stock-n;
        }
        public void Mostrar()
        {
            Console.WriteLine("Stock: "+Stock);
        }

    }
}

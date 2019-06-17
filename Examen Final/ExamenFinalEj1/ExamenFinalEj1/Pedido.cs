using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinalEj1
{
    class Pedido
    {
        public int nropedido = 0;
        public string tipodepedido;
        public double Monto;
        public string horadepedido;
        public string heroadeentrega;
        public Pedido(int nro, string tipo, double monto, string hp,string he)
        {

            this.nropedido = nro;
            this.tipodepedido = tipo;
            this.Monto = monto;
            this.horadepedido = hp;
            this.heroadeentrega = he;
        }
    }
    class EntregadelPedido
    {
        private List<Pedido> Pedidos = new List<Pedido>();
       
        public void Insertar(Pedido pedido)
        {
            Pedidos.Add(pedido);
        }
        
        public List<int> GetEntregasSinRegistro()
        {
            List<int> aux = new List<int>();
            var consulta2 = from al in Pedidos
                            where al.heroadeentrega=="0"
                            select al;
            foreach (Pedido p in consulta2)
            {
                aux.Add(p.nropedido);
            }

            return aux;
        }
        public List<double> GetMontos()
        {
            List<double> aux = new List<double>();
            var consulta = from ped in Pedidos
                           where ped.Monto < 250
                           select ped;
             foreach(Pedido group in consulta)
                {   
                        aux.Add(group.nropedido);
                }
                
            return aux;
        }
        public List<string> GetNroPedidos()
        {
            List<string> aux = new List<string>();

            var consulta = from ped in Pedidos
                           group ped by ped.tipodepedido into type
                           select new {cantidad = type.Count(), tipo=type.Key};
            foreach (var a in consulta)
            {
                    aux.Add(a.tipo);
                    aux.Add(a.cantidad.ToString());
            }
            return aux;
        }
       
    }
    
}

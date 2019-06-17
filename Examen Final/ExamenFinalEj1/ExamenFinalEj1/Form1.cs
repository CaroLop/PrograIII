using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenFinalEj1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Pedido pedido;
        EntregadelPedido entrega= new EntregadelPedido();
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="")
            {
                textBox1.Text = "0";
                pedido = new Pedido(int.Parse(txtNroPedido.Text), cbTipoPedido.Text, double.Parse(txtMonto.Text), TxtHraPedido.Text, textBox1.Text);
            }
           else
            {
                pedido = new Pedido(int.Parse(txtNroPedido.Text), cbTipoPedido.Text, double.Parse(txtMonto.Text), TxtHraPedido.Text, textBox1.Text);
            }
            
            entrega.Insertar(pedido);
            TxtHraPedido.Clear();
            txtMonto.Clear();
            txtNroPedido.Clear();
            
        }

        private void btnRegistroHe_Click(object sender, EventArgs e)
        {

         

        }

        private void btnSinEntrega_Click(object sender, EventArgs e)
        {
            int arriba = 0;
            panel1.Controls.Clear();
            List<int> resgist = entrega.GetEntregasSinRegistro();
            foreach (int are in resgist)
            {
                Label lbl = new Label();
                lbl.Top = arriba;
                arriba += 25;
                lbl.Text ="Nro: "+ are.ToString();
                panel1.Controls.Add(lbl);
            }
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnMontos_Click(object sender, EventArgs e)
        {
            int arriba = 0;
            panel1.Controls.Clear();
            List<double> resgist = entrega.GetMontos();
          foreach (double are in resgist)
            {
                Label lbl = new Label();
                lbl.Top = arriba;
                arriba += 25;
               lbl.Text = "Nro: "+are.ToString();
                panel1.Controls.Add(lbl);
            }

        }

        private void btntipodepedido_Click(object sender, EventArgs e)
        {
            int arriba = 0;
            panel1.Controls.Clear();
            List<string> resgist = entrega.GetNroPedidos();
            foreach (string are in resgist)
            {
                Label lbl = new Label();
                lbl.Top = arriba;
                arriba += 25;
                lbl.Text = are;
                panel1.Controls.Add(lbl);
            }
        }
    }
}

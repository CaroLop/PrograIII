using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BTNOBTEMP_Click(object sender, EventArgs e)
        {
            STClima ob = STClima.getInstance();
            LBLRESULTADO.Text = null;
            double a;
            a = Convert.ToDouble(txtleer.Text);
            ob.ObtenerTemp(a);
            LBLRESULTADO.Text = "Obtenido";
            txtleer.Clear();
        }

        private void BTNCOLTEMP_Click(object sender, EventArgs e)
        {
            STClima stclima = STClima.getInstance();
            LBLRESULTADO.Text = Convert.ToString("Temperatura: " + stclima.ColocarTemp() + "°");
        }
    }
}

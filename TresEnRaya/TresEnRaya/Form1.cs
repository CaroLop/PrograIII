using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TresEnRaya
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void AnalizaResp(String mensaje)
        {
            String[] respuesta = mensaje.Split(':');
            switch(respuesta[0])
            {
                case "ganador":
                    MessageBox.Show("El ganador es: "+respuesta[1]);
                    break;
                case "continuar":
                    if (lblTurno.Text == "x")
                        lblTurno.Text = "o";
                    else if (lblTurno.Text == "o")
                        lblTurno.Text = "x";
                    break;
                case "resultado":
                    MessageBox.Show("El juego acabo en empate");
                    break;
                case "error":
                    MessageBox.Show("Error: "+respuesta[1]);
                    break;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Raya.getInstancia().Reiniciar();
            pb00.Image = null;
            pb01.Image = null;
            pb02.Image = null;
            pb10.Image = null;
            pb11.Image = null;
            pb12.Image = null;
            pb20.Image = null;
            pb21.Image = null;
            pb22.Image = null;
            lblTurno.Text = "x";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            String respuesta= Raya.getInstancia().marcar(0,0, lblTurno.Text[0]);
            if (lblTurno.Text=="x")
                pb00.Image= new System.Drawing.Bitmap("D:\\X.png");
            else
                pb00.Image = new System.Drawing.Bitmap("D:\\o.jpg");
            AnalizaResp(respuesta);
        }

        private void pb01_Click(object sender, EventArgs e)
        {
            String respuesta = Raya.getInstancia().marcar(0, 1, lblTurno.Text[0]);
            if (lblTurno.Text == "x")
                pb01.Image = new System.Drawing.Bitmap("D:\\X.png");
            else
                pb01.Image = new System.Drawing.Bitmap("D:\\o.jpg");
            AnalizaResp(respuesta);
        }

        private void pb02_Click(object sender, EventArgs e)
        {
            String respuesta = Raya.getInstancia().marcar(0, 2, lblTurno.Text[0]);
            if (lblTurno.Text == "x")
                pb02.Image = new System.Drawing.Bitmap("D:\\X.png");
            else
                pb02.Image = new System.Drawing.Bitmap("D:\\o.jpg");
            AnalizaResp(respuesta);
        }

        private void pb10_Click(object sender, EventArgs e)
        {
            String respuesta = Raya.getInstancia().marcar(1, 0, lblTurno.Text[0]);
            if (lblTurno.Text == "x")
                pb10.Image = new System.Drawing.Bitmap("D:\\X.png");
            else
                pb10.Image = new System.Drawing.Bitmap("D:\\o.jpg");
            AnalizaResp(respuesta);
        }

        private void pb11_Click(object sender, EventArgs e)
        {
            String respuesta = Raya.getInstancia().marcar(1, 1, lblTurno.Text[0]);
            if (lblTurno.Text == "x")
                pb11.Image = new System.Drawing.Bitmap("D:\\X.png");
            else
                pb11.Image = new System.Drawing.Bitmap("D:\\o.jpg");
            AnalizaResp(respuesta);
        }

        private void pb12_Click(object sender, EventArgs e)
        {
            String respuesta = Raya.getInstancia().marcar(1, 2, lblTurno.Text[0]);
            if (lblTurno.Text == "x")
                pb12.Image = new System.Drawing.Bitmap("D:\\X.png");
            else
                pb12.Image = new System.Drawing.Bitmap("D:\\o.jpg");
            AnalizaResp(respuesta);
        }

        private void pb20_Click(object sender, EventArgs e)
        {
            String respuesta = Raya.getInstancia().marcar(2, 0, lblTurno.Text[0]);
            if (lblTurno.Text == "x")
                pb20.Image = new System.Drawing.Bitmap("D:\\X.png");
            else
                pb20.Image = new System.Drawing.Bitmap("D:\\o.jpg");
            AnalizaResp(respuesta);
        }

        private void pb21_Click(object sender, EventArgs e)
        {
            String respuesta = Raya.getInstancia().marcar(2, 1, lblTurno.Text[0]);
            if (lblTurno.Text == "x")
                pb21.Image = new System.Drawing.Bitmap("D:\\X.png");
            else
                pb21.Image = new System.Drawing.Bitmap("D:\\o.jpg");
            AnalizaResp(respuesta);
        }

        private void pb22_Click(object sender, EventArgs e)
        {
            String respuesta = Raya.getInstancia().marcar(2, 2, lblTurno.Text[0]);
            if (lblTurno.Text == "x")
                pb22.Image = new System.Drawing.Bitmap("D:\\X.png");
            else
                pb22.Image = new System.Drawing.Bitmap("D:\\o.jpg");
            AnalizaResp(respuesta);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesVectores
{
    class Vector
    {
        private double[] vector1;
        private double[] vector2;
        public Vector(double[] a, double[] b)
        {
            this.vector1 = a;
            this.vector2 = b;
        }
        public double Sumar()
        {
            double[] Suma = new double[vector1.Length];
            for (int i = 0; i < vector1.Length; i++)
            {
                Suma[i] = vector1[i] + vector2[i];
                Console.WriteLine(Suma[i]);
            }
            
            return 0;
        }
        public double Resta()
        {
            double[] Resta = new double[vector1.Length];
            for (int i = 0; i < vector1.Length; i++)
            {
                Resta[i] = vector1[i] - vector2[i];
                Console.WriteLine(Resta[i]);
            }
            return 0;
        }
        public double Multiplicacion()
        {
            double[] Mult = new double[vector1.Length];
            double Suma=0;
            for (int i = 0; i < vector1.Length; i++)
            {
                Mult[i]= vector1[i] * vector2[i];
                Suma = Suma + Mult[i];
            }
            Console.WriteLine(Suma);
            return Suma;
        }
        public void Mostrar(String Operacion)
        {
            MostarOperacion Mo = new MostarOperacion();
            if (Operacion == "Suma")
            {

                Mo.lbxmostarop.Items.Add("(");
                for (int i = 0; i < vector1.Length; i++)
                {
                    Mo.lbxmostarop.Items.Add(vector1[i] + " ");
                }
                Mo.lbxmostarop.Items.Add(")");
                Mo.lbxmostarop.Items.Add("+");
                Mo.lbxmostarop.Items.Add("(");
                for (int i = 0; i < vector1.Length; i++)
                {
                    Mo.lbxmostarop.Items.Add(vector1[i] + " ");
                }
                Mo.lbxmostarop.Items.Add(")");
                Mo.lbxmostarop.Items.Add("=");
                Sumar();
            }
            if (Operacion == "Resta")
            {

                Mo.lbxmostarop.Items.Add("(");
                for (int i = 0; i < vector1.Length; i++)
                {
                    Mo.lbxmostarop.Items.Add(vector1[i] + " ");
                }
                Mo.lbxmostarop.Items.Add(")");
                Mo.lbxmostarop.Items.Add("-");
                Mo.lbxmostarop.Items.Add("(");
                for (int i = 0; i < vector1.Length; i++)
                {
                    Mo.lbxmostarop.Items.Add(vector1[i] + " ");
                }
                Mo.lbxmostarop.Items.Add(")");
                Mo.lbxmostarop.Items.Add("=");
                Resta();
            }
            if (Operacion == "Multiplicacion")
            {

                Mo.lbxmostarop.Items.Add("(");
                for (int i = 0; i < vector1.Length; i++)
                {
                    Mo.lbxmostarop.Items.Add(vector1[i] + " ");
                }
                Mo.lbxmostarop.Items.Add(")");
                Mo.lbxmostarop.Items.Add("*");
                Mo.lbxmostarop.Items.Add("(");
                for (int i = 0; i < vector1.Length; i++)
                {
                    Mo.lbxmostarop.Items.Add(vector1[i] + " ");
                }
                Mo.lbxmostarop.Items.Add(")");
                Mo.lbxmostarop.Items.Add("=");
                Multiplicacion();
            }
            
        }
    }
}

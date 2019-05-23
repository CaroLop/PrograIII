using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
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
            foreach (double a in Suma)
            {
                return a;
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
            foreach(double a in Resta)
            {
                return a;
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
            // El resultado se muestra en consola que es el correcto pero noc muestra en el list box (nose porque) pero el rendimiento es demasiado lento y no muestra el resultado
            // No reconozco el error en el proyecto
            switch (Operacion)
            {
                case "Suma":
                    Mo.lbxmostarop.Items.Add("(");
                    for (int i = 0; i < vector1.Length; i++)
                    {
                        Mo.lbxmostarop.Items.Add(vector1[i]);
                    }
                    Mo.lbxmostarop.Items.Add(")");
                    Mo.lbxmostarop.Items.Add("+");
                    Mo.lbxmostarop.Items.Add("(");
                    for (int i = 0; i < vector2.Length; i++)
                    {
                        Mo.lbxmostarop.Items.Add(vector2[i]);
                    }
                    Mo.lbxmostarop.Items.Add(")");
                    Mo.lbxmostarop.Items.Add("=");
                    Mo.lbxmostarop.Items.Add(Sumar());
                    Mo.Show();
                    break;
                case "Resta":
                        Mo.lbxmostarop.Items.Add("(");
                        for (int i = 0; i < vector1.Length; i++)
                        {
                            Mo.lbxmostarop.Items.Add(vector1[i]);
                        }
                        Mo.lbxmostarop.Items.Add(")");
                        Mo.lbxmostarop.Items.Add("-");
                        Mo.lbxmostarop.Items.Add("(");
                        for (int i = 0; i < vector2.Length; i++)
                        {
                            Mo.lbxmostarop.Items.Add(vector2[i]);
                        }
                        Mo.lbxmostarop.Items.Add(")");
                        Mo.lbxmostarop.Items.Add("=");                   
                        Mo.lbxmostarop.Items.Add(Resta());
                    Mo.Show();
                    break;
                case "Multiplicacion":

                        Mo.lbxmostarop.Items.Add("(");
                        for (int i = 0; i < vector1.Length; i++)
                        {
                            Mo.lbxmostarop.Items.Add(vector1[i]);
                        }
                        Mo.lbxmostarop.Items.Add(")");
                        Mo.lbxmostarop.Items.Add("*");
                        Mo.lbxmostarop.Items.Add("(");
                        for (int i = 0; i < vector2.Length; i++)
                        {
                            Mo.lbxmostarop.Items.Add(vector2[i]);
                        }
                        Mo.lbxmostarop.Items.Add(")");
                        Mo.lbxmostarop.Items.Add("=");
                        Mo.lbxmostarop.Items.Add(Multiplicacion());
                    Mo.Show();
                    break;
            }
            
        }
    }
}

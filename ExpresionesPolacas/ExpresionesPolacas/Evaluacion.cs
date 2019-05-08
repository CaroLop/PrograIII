using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpresionesPolacas
{
    class Evaluacion
    {
        private Pila<String> Pila;
        private List<String> ExpresionPolaca;
        private String Expresion;
        public Evaluacion(String Exp)
        {
            this.Expresion = Exp;
        }
        public void CrearPolaca()
        {
            int i = 0;
            while(Expresion!=null)
            {
                foreach (char cadena in Expresion)
                {
                    if (cadena == '+' || cadena == '/' || cadena == '*' || cadena == '-'||cadena=='('||cadena==')')
                    {
                        Pila.Push(cadena.ToString());
                    }
                    else
                    {
                        ExpresionPolaca.Add(cadena.ToString());
                    }
                }
                i++;
            }
        }
        public double EvaluarPolaca()
        {
            return 0;
        }

    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpresionesPolacas
{
    class Evaluacion
    {
        private Stack<String> Pila=new Stack<string>();
        private List<String> ExpresionPolaca = new List<String>();
        private String Expresion;
        public Evaluacion(String Exp)
        {
            this.Expresion = Exp;
        }
        public String CrearPolaca()
        {
            int i=0;
              
              while(i<Expresion.Length)
                {
                foreach (char cadena in Expresion)
                {
                    if (cadena == '0' || cadena == '1' || cadena == '2' || cadena == '3' || cadena == '4' || cadena == '5' || cadena == '6' || cadena == '7' || cadena == '8' || cadena == '9')
                    {
                        ExpresionPolaca.Add(cadena.ToString());
                    }
                    else if (cadena == '(')
                    {
                        Pila.Push(cadena.ToString());
                    }
                    else if (cadena == '*' || cadena == '/' || cadena == '-' || cadena == '+')
                    {
                        while (Pila.Count > 0 && Pila.Peek() != '('.ToString())
                        {
                            if (Prioridad(Pila.Peek(), cadena.ToString()))
                            {
                                ExpresionPolaca.Add(Pila.Pop());
                            }
                            else
                                break;
                        }
                        Pila.Push(cadena.ToString());
                    }
                    else if (cadena == ')')
                    {
                        while (Pila.Count > 0 && Pila.Peek() != '('.ToString())
                        {
                            ExpresionPolaca.Add(Pila.Pop());
                        }
                        if (Pila.Count > 0)
                        {
                            Pila.Pop();
                        }

                    }
                    i++;
                }
               
            }
                while (Pila.Count > 0)
                {
                    ExpresionPolaca.Add(Pila.Pop());
                }
            foreach (String a in ExpresionPolaca)
            {
                Console.Write("" + a);
                Expresion = a;
            }
            
            return "";
        }
        public String EvaluarPolaca()
        {
            
                foreach (String cadena in ExpresionPolaca)
                {
                
                if (cadena == "*" || cadena == "/" || cadena == "-" || cadena == "+")
                    {
                        int res = Operaciones(Convert.ToInt16(Pila.Pop()), Convert.ToInt16(Pila.Pop()), cadena);
                        Pila.Push(res.ToString());
                    }
                    else if (cadena == "0" || cadena == "1" || cadena == "2" || cadena == "3" || cadena == "4" || cadena == "5" || cadena == "6" || cadena == "7" || cadena == "8" || cadena == "9")
                    {
                        int res = Convert.ToInt16(cadena);
                        Pila.Push(res.ToString());
                    }
                
                }
            
            return Pila.Pop();
        }

       private  Boolean Prioridad(String top, String a)
        {
            if (top == '*'.ToString()  && a == '-'.ToString())
            {
                return true;
            }
            if (top == '+'.ToString() &&  a == '*'.ToString())
            {
                return false;
            }
            if (top == '+'.ToString() && a == '-'.ToString())
            {
                return true;
            }
            if (top == '+'.ToString() && a == '/'.ToString())
            {
                return false;
            }
            return true;
        }
        private int Operaciones(int a, int b, String c)
        {
            switch(c)
            {
                case "+":
                    return a + b;
                case "-":
                    return b - a;
                case "*":
                    return b * a;
                case "/":
                    return b / a;
                default:
                    return -1;
            }
        }
       
    }

}

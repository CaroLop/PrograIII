using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventosTP1
{
    class Operaciones
    {
        public delegate void MDfactorial(int n);
        public event MDfactorial Cuandoelfactorialseamultiplode3;
        public int Factorial(int a)
        {
            int fact = 1;
            for(int i=1;i<=a;i=i+1)
            {
                fact = fact * i;

            }
            if (fact % 3 == 0 && Cuandoelfactorialseamultiplode3 != null)
            { Cuandoelfactorialseamultiplode3(fact); }
            return fact;
        }
    }
}

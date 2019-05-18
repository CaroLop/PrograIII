using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class STClima
    {
        private double temperatura;
        private static STClima instance;
        public static STClima getInstance()
        {
            if (instance == null)
                instance = new STClima();
            return instance;
        }
        public double ObtenerTemp(double Temperatura)
        {
            temperatura = Temperatura;
            return temperatura;
        }
        public double ColocarTemp()
        {
            return temperatura;
        }
    }
}

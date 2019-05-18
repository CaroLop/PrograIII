using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteAhorcado
{
    class Ahorcado
    {
        private static readonly string[] Palabras = { "Computacion", "Español", "Avion", "Pudin" };
        private String PalabraAdivinar;
        private List<char> Letras;
        public int Estado { get; private set; }
        private String Guiones;
        private static Ahorcado Instancia;  //singleton
        private Ahorcado()
        { //singleton
            Iniciar();
        }
        public void Iniciar()
        {
            Estado = 0;
            Letras = new List<char>();
            Random rnd = new Random();
            int indice = rnd.Next(3);
            PalabraAdivinar = Palabras[indice];
            Guiones = "";
            Guiones = Guiones.PadLeft(PalabraAdivinar.Count(), '_');
        }
        public String Buscar(char Letra)
        {
            Letras.Add(Letra);
            String aux = "";
            if (PalabraAdivinar.Contains(Letra.ToString()))
            {
                for (int i = 0; i < PalabraAdivinar.Count(); i++)
                {

                    if (PalabraAdivinar[i] == Letra)
                    {
                        aux += Letra;
                    }
                    else
                    {
                        aux += Guiones[i];

                    }
                }
                Guiones = aux;

                return aux;

            }
            else
            {
                Estado++;
                return Estado.ToString();
            }
        }
        public Boolean BuscarPalabra(String Palabra)
        {
            if (Palabra == PalabraAdivinar)
                return true;
            else
            {
                Estado++;
                return false;
            }

        }

        public static Ahorcado getInstancia() //singleton
        {
            if (Instancia == null)
            {
                Instancia = new Ahorcado();
            }
            return Instancia;
        }
        public String Imagen(int estado)
        {
            estado = Estado;
            switch(estado)
            {
                case 0:
                    return "0.png";
                case 1:
                    return "1.png";
                case 2:
                    return "2.png";
                case 3:
                    return "3.png";
                case 4:
                    return "4.png";
                case 5:
                    return "5.png";
                case 6:
                    return "6.png";
                case 7:
                    return "7.png";
            }
            return "";
        }
    }
}

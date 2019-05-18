using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServidorAhorcado
{
    class Ahorcado
    {
        private static readonly string[] Palabras = { "computacion", "español", "avion", "pudin" };
        private String PalabraAdivinar;
        private List<char> Letras;
        public int Estado { get; private set; }
        private String Guiones;
        private static Ahorcado Instancia;  //singleton
        private Ahorcado()
        { //singleton
            Iniciar();
        }
        public String Iniciar()
        {
            Estado = 0;
            Letras = new List<char>();
            Random rnd = new Random();
            int indice = rnd.Next(3);
            PalabraAdivinar = Palabras[indice];
            Guiones = "";
            Guiones = Guiones.PadLeft(PalabraAdivinar.Count(), '_');
            return Guiones;
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
        
    }
}

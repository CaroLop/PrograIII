using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace HilosPreguntas
{
    class Program
    {
       
        public static String[] Pregunta = { "Pregunta 1", "Pregunta 2", "Pregunta 3", "Pregunta 4", "Pregunta 5", "Pregunta 6", "Pregunta 7", "Pregunta 8", "Pregunta 9", "Pregunta 10" };
        static void Main(string[] args)
        {
            // Thread t = new Thread(new ThreadStart(ThreadProc));
            Thread t2 = new Thread(new ThreadStart(Resp));
            t2.Start();
            if (Contador != 10)
            {
                Thread.Sleep(120000);
                Console.WriteLine("Puntaje: " + Contador);
                t2.Abort();
            }
            t2.Join();
            
            Console.ReadLine();
        }
        static double Contador=0;
        
        public static void Resp()
        {
            foreach (String Preguntas in Pregunta)
            {
                String[] a = Preguntas.Split(' ');
                Console.WriteLine(Preguntas);
                String RespuestaA = Console.ReadLine();
                for (int i = 1; i < 10; i++)
                {
                    if (a[1] == i.ToString() && RespuestaA == "ok")
                    {
                        Contador++;
                    }
                    

                }
                if (a[1] == 10.ToString())
                {
                    Console.WriteLine("Puntaje: " + Contador);
                }

            }        

        }
    }
}

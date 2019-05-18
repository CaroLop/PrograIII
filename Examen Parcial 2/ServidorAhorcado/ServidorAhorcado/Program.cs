using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ServidorAhorcado
{
    class Program
    {
        string data = "";
        static void Main(string[] args)
        {
            byte[] bytes = new Byte[1024];

            IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Any, 11000);
            Socket listener = new Socket(IPAddress.Any.AddressFamily,
                SocketType.Stream, ProtocolType.Tcp);
            String Respuesta = "";
            try
            {
                listener.Bind(localEndPoint);
                listener.Listen(10);
                while (true)
                {
                    Console.WriteLine("Esperando por conexiones ...");
                    Socket handler = listener.Accept();
                    // La conexion de entrada necesita ser procesada.  
                    int bytesRec = handler.Receive(bytes);
                    string solicitud = Encoding.ASCII.GetString(bytes, 0, bytesRec);
                    string mensaje = Encoding.ASCII.GetString(bytes, 0, bytesRec);
                    String[] a1 = solicitud.Split(':');
                    if (solicitud == "op:Iniciar")
                    {
                       Respuesta = Ahorcado.getInstancia().Iniciar();
                    }
                    
                    else if (a1[0] == "Palabra")
                    {
                        String[] sol = solicitud.Split(':');
                        string a = sol[1];
                        Respuesta = Ahorcado.getInstancia().BuscarPalabra(a).ToString();

                    }
                    else if (a1[0] == "Letra")
                    {
                        String[] sol = solicitud.Split(':');
                        char marca = sol[1][0];
                        Respuesta = Ahorcado.getInstancia().Buscar(marca); ;
                    }
                    else if (solicitud == "op:Estado")
                    {
                        int a = Ahorcado.getInstancia().Estado;
                        Respuesta = a.ToString();

                    }
                    byte[] msg = Encoding.ASCII.GetBytes(Respuesta);
                    handler.Send(msg);
                    Console.WriteLine("Texto recibido: {0}", solicitud);
                    Console.WriteLine("Texto enviado: {0}", Respuesta);

                    handler.Shutdown(SocketShutdown.Both);
                    handler.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine("\nPresiones ENTER para continuar...");
            Console.Read();


        }

    } 
}

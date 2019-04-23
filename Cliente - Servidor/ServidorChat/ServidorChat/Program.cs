using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace ServidorChat
{
    class Program
    {
        static void Main(string[] args)
        {
            StartListening();
        }
        public static string data = null;
        public static void StartListening()
        {

            byte[] bytes = new Byte[1024];

            IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress ipAddress = ipHostInfo.AddressList[0];
            IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Any, 11000);


            Socket listener = new Socket(IPAddress.Any.AddressFamily,
                SocketType.Stream, ProtocolType.Tcp);
            List<String> mensajes = new List<String>();

            try
            {
                listener.Bind(localEndPoint);
                listener.Listen(10);

                while (true)
                {

                    Socket handler = listener.Accept();
                    data = null;
                    int bytesRec = handler.Receive(bytes);
                    data = Encoding.ASCII.GetString(bytes, 0, bytesRec);

                    // Prepara los datos para responder  al cliente.  
                    Console.WriteLine("Texto recibido: {0}", data);
                    mensajes.Add(data);
                    foreach (String cadena in mensajes)
                    { 
                        byte[] msg = Encoding.ASCII.GetBytes(cadena+"-");
                    handler.Send(msg);
                }
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

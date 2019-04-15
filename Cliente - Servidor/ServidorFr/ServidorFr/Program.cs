using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace ServidorFr
{
    class Program
    {
        public static string data = null;

        public static int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
                return Factorial(n - 1) * n;
        }
        public static void StartListening()
        {

            byte[] bytes = new Byte[1024];

            IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress ipAddress = ipHostInfo.AddressList[0];
            IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Any, 11000);

            
            Socket listener = new Socket(IPAddress.Any.AddressFamily,
                SocketType.Stream, ProtocolType.Tcp);


            try
            {
                listener.Bind(localEndPoint);
                listener.Listen(10);

                while (true)
                {
                    Console.WriteLine("Esperando por ceonexiones ...");
                    Socket handler = listener.Accept();
                    data = null;

                    // La conexion de entrada necesita ser procesada.  
                        int bytesRec = handler.Receive(bytes);
                        data = Encoding.ASCII.GetString(bytes, 0, bytesRec);

                    // Muestra los datos en la consola .  
                    Console.WriteLine("Nro Recibido: {0}", data);

                    // Prepara los datos para responder  al cliente.  
                    int fact = Factorial(int.Parse(data));
                        byte[] msg = Encoding.ASCII.GetBytes(fact.ToString());

                    handler.Send(msg);
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
        static void Main(string[] args)
        {
            StartListening();
           
        }
    }
}

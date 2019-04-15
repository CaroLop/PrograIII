using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace ClienteFactorial
{
    class Program
    {
        public static void StartClient(String cadena)
        {
            // Declara un bufer de  datos para recibir datos .  
            byte[] bytes = new byte[1024];

            // Se conecta al dispositivo remoto .  
            try
            {
                // Establece un punto remoto final para el socket.  
                // Este ejemplo usa el puerto 11000 en la computadora local.  
                IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
                IPAddress ipAddress = ipHostInfo.AddressList[0];
                //IPEndPoint remoteEP = new IPEndPoint(ipAddress, 11000);
                IPEndPoint remoteEP = new IPEndPoint(IPAddress.Parse("192.168.50.88"), 11000);
                // Crear un socket TCP/IP  .  
                Socket sender = new Socket(AddressFamily.InterNetwork,
                    SocketType.Stream, ProtocolType.Tcp);

                // Conetarse al punto final remoto  captura cualquier error .  
                try
                {
                    sender.Connect(remoteEP);

                    Console.WriteLine("Socket connectado a {0}",
                        sender.RemoteEndPoint.ToString());

                    // codifica datos en un string dentro de un arreglo de bits. 

                    byte[] msg = Encoding.ASCII.GetBytes(cadena.ToString());

                    // Envia datos a traves del socket .  
                    int bytesSent = sender.Send(msg);

                    // Recibe ladespuesta desde el dispositivo remoto .  
                    int bytesRec = sender.Receive(bytes);
                    Console.WriteLine("El Factorial es  = {0}",
                        Encoding.ASCII.GetString(bytes, 0, bytesRec));

                    // libera el socket.  
                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();
                    Console.ReadLine();
                }
                catch (ArgumentNullException ane)
                {
                    Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
                }
                catch (SocketException se)
                {
                    Console.WriteLine("SocketException : {0}", se.ToString());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error no manejado  : {0}", e.ToString());
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public static int Main(String[] args)
        {
            Console.WriteLine("Introduzca un numero");
            String cadena = Console.ReadLine();
            StartClient(cadena);
            Console.ReadKey();
            return 0;
        }
    }
    
}

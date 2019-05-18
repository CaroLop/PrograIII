using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Text;

namespace SocketsNumCliente
{
    
    public class StateObject
    {
        // Socket cliente .  
        public Socket workSocket = null;
        // tamaño del bufer de recepcion.  
        public const int BufferSize = 256;
        // buffer para recibir.  
        public byte[] buffer = new byte[BufferSize];
        // dato string recibir.  
        public StringBuilder sb = new StringBuilder();
    }
    public class AsynchronousClient
    {
        static void Main(string[] args)
        {
            StartClient();
            Console.ReadKey();
        }
        // el numero de puerto para eldispositivo remoto.  
        private const int port = 11000;

        // instancia de señal ManualResetEvent .  
        private static ManualResetEvent connectDone =
            new ManualResetEvent(false);
        private static ManualResetEvent sendDone =
            new ManualResetEvent(false);
        private static ManualResetEvent receiveDone =
            new ManualResetEvent(false);

        // la respuesta desde el dispositivo remoto.  
        private static String response = String.Empty;

        private static void StartClient()
        {
            // Connectar al dispositivo remoto.  
            try
            {

                IPEndPoint remoteEP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 11000);

                Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                // Conectarse con el punto final remoto.  
                client.BeginConnect(remoteEP,
                    new AsyncCallback(ConnectCallback), client);
                connectDone.WaitOne();

                // Enviar datos de prueba al dispositivo remoto .
                Console.WriteLine("Introduzca un numero");
                int nro = int.Parse(Console.ReadLine());
                
                Send(client, nro);
                sendDone.WaitOne();

                // Recibir la respuesta desde el dispositivoremoto .  in
                Receive(client);
                receiveDone.WaitOne();

                // Escribir la respuesta en la consola .  
                Console.WriteLine("REspuesta Recibida: {0}", response);

                // Liberar el socket.  
                client.Shutdown(SocketShutdown.Both);
                client.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private static void ConnectCallback(IAsyncResult ar)
        {
            try
            {
                // Recuperar elsocket desde elobjeto de estaos  
                Socket client = (Socket)ar.AsyncState;

                // Conexion Completa.  
                client.EndConnect(ar);

                Console.WriteLine("Socket connectado a {0}",
                    client.RemoteEndPoint.ToString());

                // Señal que la coneccion ha sido hecha.  
                connectDone.Set();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private static void Receive(Socket client)
        {
            try
            {
                // Crear un objeto de estado .  
                StateObject state = new StateObject();
                state.workSocket = client;

                // Comienza a recibir el dispositivo remoto .  
                client.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                    new AsyncCallback(ReceiveCallback), state);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private static void ReceiveCallback(IAsyncResult ar)
        {
            try
            {
              
                StateObject state = (StateObject)ar.AsyncState;
                Socket client = state.workSocket;

                // Leer datos desde el dispositivo remoto.  
                int bytesRead = client.EndReceive(ar);

                if (bytesRead > 0)
                {
                    // Puede haber más datos, así que almacene los datos recibidos hasta el momento.  
                    state.sb.Append(Encoding.ASCII.GetString(state.buffer, 0, bytesRead));

                    // obtener el resto de lo sdatos .  
                    client.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                        new AsyncCallback(ReceiveCallback), state);
                }
                else
                {
                    // Todos los datoshan llegadoponer enlarespuesta .  
                    if (state.sb.Length > 0)
                    {
                        response = state.sb.ToString();
                    }
                    // Señala que todos los bytes han sido recibidos.  
                    receiveDone.Set();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private static void Send(Socket client, int data)
        {
            // Convertir el string  a datos  byte usando codificacion ASCII .  
            byte[] byteData = Encoding.ASCII.GetBytes(data.ToString());

            // Empieza enviados el data desde Begin sending the data to the remote device.  
            client.BeginSend(byteData, 0, byteData.Length, 0,
                new AsyncCallback(SendCallback), client);
        }

        private static void SendCallback(IAsyncResult ar)
        {
            try
            {
                // Retrieve the socket from the state object.  
                Socket client = (Socket)ar.AsyncState;

                // Completar envio de los datoaldispositivo remoto.  
                int bytesSent = client.EndSend(ar);
                Console.WriteLine("Enviar {0} bytes para el server.", bytesSent);

                // Señal que todos los bytes han sido enviados.  
                sendDone.Set();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
    }

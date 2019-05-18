using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net;
using System.Net.Sockets;


namespace SocketsNum
{
    public class StateObject
    {
        // socket del Client  .  
        public Socket workSocket = null;
        // Tamaño del buffer para recibir Size of receive buffer.  
        public const int BufferSize = 1024;
        // buffe reicibido .  
        public byte[] buffer = new byte[BufferSize];
        // datos string recibidos.  
        public StringBuilder sb = new StringBuilder();
    }
    public class AsynchronousSocketListener

    {
        static void Main(string[] args)
        {
            StartListening();
        }

            public static int sumatoria(int n)
            {
                if (n == 0)
                    return 0;
                else
                    return sumatoria(n - 1) + n;
            }
            // Señal de hilo .  
            public static ManualResetEvent allDone = new ManualResetEvent(false);

             public static void StartListening()
            {
               
                IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Any, 11000);


                // Crear el socket TCP/IP .  
                Socket listener = new Socket(IPAddress.Any.AddressFamily,
                    SocketType.Stream, ProtocolType.Tcp);

                // Nombrar el socket en el puntodeentrada final y escuchar conexiones entrantes.  
                try
                {
                    listener.Bind(localEndPoint);
                    listener.Listen(100);

                    while (true)
                    {
                        // colocar el evento al estado sin señal.  
                        allDone.Reset();

                        // iniciar el socket asincrono paraescuchar las conexiones .  
                        Console.WriteLine("Esperando por conexiones ...");
                        listener.BeginAccept(
                            new AsyncCallback(AcceptCallback),
                            listener);

                        // esperar hasta que  la conexion sea hecha antes de continuar .  
                        allDone.WaitOne();
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }

                Console.WriteLine("\n Presiones INTRO para continuar...");
                Console.Read();

            }

            public static void AcceptCallback(IAsyncResult ar)
            {
                // Señal en el hulo principal para continuar .  
                allDone.Set();

                // obtenet el socket cuyo hilo en el cliente es requerido.  
                Socket listener = (Socket)ar.AsyncState;
                Socket handler = listener.EndAccept(ar);

                // Crear el objeto estado.  
                StateObject state = new StateObject();
                state.workSocket = handler;
                handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                    new AsyncCallback(ReadCallback), state);
            }

            public static void ReadCallback(IAsyncResult ar)
            {
                String content = String.Empty;

                // REcuperar el estado del objeto y del manejador del socket
                // desde el objeto de estado asincrono.  
                StateObject state = (StateObject)ar.AsyncState;
                Socket handler = state.workSocket;

                // Leer datos desde elsocket cliente.   
                int bytesRead = handler.EndReceive(ar);

            if (bytesRead > 0)
            {
                // Podría haber más datos, asi que almacena los datos recibidos .  
                state.sb.Append(Encoding.ASCII.GetString(
                    state.buffer, 0, bytesRead));

                // verifica el tag fin de arhivo . si este no esta ahi lee
                // mas datos.  
                content = state.sb.ToString();
                if (content.Length>0)
                { 
                string nro = content.Substring(0, content.Length);

                int sum = sumatoria(int.Parse(nro));
                String respuesta = sum.ToString();

                Console.WriteLine("Calculo de la sumatoria  de {0} es  \n Dato : {1}",
                   nro, respuesta);

                Send(handler, respuesta);
                }
            else {
                handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                new AsyncCallback(ReadCallback), state);
            }
                }
            }

            private static void Send(Socket handler, String data)
            {
               
                byte[] byteData = Encoding.ASCII.GetBytes(data);

                handler.BeginSend(byteData, 0, byteData.Length, 0,
                    new AsyncCallback(SendCallback), handler);
            }

            private static void SendCallback(IAsyncResult ar)
            {
                try
                {
                    // Recuperar el socket del objeto de estado.  
                    Socket handler = (Socket)ar.AsyncState;

                    // Completar enviado los datos de  el dispositivo remoto .  
                    int bytesSent = handler.EndSend(ar);
                    Console.WriteLine("Enviado {0} bytes al  cliente.", bytesSent);

                    handler.Shutdown(SocketShutdown.Both);
                    handler.Close();

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }
    
}

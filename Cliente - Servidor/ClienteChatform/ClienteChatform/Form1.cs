using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Net;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteChatform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RTXCONVERSACION_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNENVIAR_Click(object sender, EventArgs e)
        {
            String mensaje = TXTNICK.Text + ": " + TXTMSG.Text;
            StartClient(mensaje);
            
           
            
        }
        public void StartClient(String cadena)
        {
            byte[] bytes = new byte[1024];
            String Respuesta="";
            // Se conecta al dispositivo remoto .  
            try
            {
                // Establece un punto remoto final para el socket.  
                // Este ejemplo usa el puerto 11000 en la computadora local.  
                IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
                IPAddress ipAddress = ipHostInfo.AddressList[0];
                //IPEndPoint remoteEP = new IPEndPoint(ipAddress, 11000);
                IPEndPoint remoteEP = new IPEndPoint(IPAddress.Parse(TXTIP.Text), 11000);
                // Crear un socket TCP/IP  .  
                Socket sender = new Socket(AddressFamily.InterNetwork,
                    SocketType.Stream, ProtocolType.Tcp);
                // Conetarse al punto final remoto  captura cualquier error .  
                try
                {
                    sender.Connect(remoteEP);

                  
                    byte[] msg = Encoding.ASCII.GetBytes(cadena);
                    // Envia datos a traves del socket .  
                    int bytesSent = sender.Send(msg); 
                    int bytesRec = sender.Receive(bytes);
                    while (bytesRec > 0)
                    {
                        Respuesta = Encoding.ASCII.GetString(bytes, 0, bytesRec);
                        bytesRec = sender.Receive(bytes);
                       
                    }
                   String[] resp = Respuesta.Split('-');
                    lbConversacion.Items.Clear();
                 
                    foreach (String r in resp)
                    {
                        lbConversacion.Items.Add(r);
                        String[] MEN = r.Split(':');
                        if (LBPARTICIPANTES.FindString(MEN[0]) == -1)
                            LBPARTICIPANTES.Items.Add(MEN[0]);

                    }
                   
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

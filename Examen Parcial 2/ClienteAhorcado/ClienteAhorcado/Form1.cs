using System;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;


namespace ClienteAhorcado
{
    public partial class Form1 : Form
    {
        String Solicitud = "";
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Respuesta;

            Solicitud = "Letra:" + txtLetra.Text;
            Respuesta = EnviarMensaje(Solicitud);
            
            lblPalabra.Text = Respuesta.ToUpper();

            Solicitud = "op:Estado";
            Respuesta = EnviarMensaje(Solicitud);
            if (Convert.ToInt16(Respuesta) > 0)
                pictureBox1.Image = new System.Drawing.Bitmap("D:\\"+Respuesta +".png");
            else
            {
                pictureBox1.Image = new System.Drawing.Bitmap("D:\\" + Respuesta + ".png");
            }
            txtLetra.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Solicitud = "op:Iniciar";
            String Respuesta = EnviarMensaje(Solicitud);
            
            lblPalabra.Text = Respuesta;
            Solicitud = "op:Estado";
            Respuesta = EnviarMensaje(Solicitud);
            if (Convert.ToInt16(Respuesta) > 0)
                pictureBox1.Image = new System.Drawing.Bitmap("D:\\" + Respuesta + ".png");
            else
            {
                pictureBox1.Image = new System.Drawing.Bitmap("D:\\" + Respuesta + ".png");
            }
        }

        private String EnviarMensaje(String Mensaje)
        {
            byte[] bytes = new byte[1024];
            try
            {
                IPEndPoint remoteEP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 11000);
                // Crear un socket TCP/IP  .  
                Socket sender = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                try
                {
                    // de conecta al servidor
                    sender.Connect(remoteEP);
                    Console.WriteLine("Socket connectado a {0}",
                        sender.RemoteEndPoint.ToString());
                    byte[] msg = Encoding.ASCII.GetBytes(Mensaje);
                    // aqui se manda el mensaje
                    int bytesSent = sender.Send(msg);
                    // Recibe ladespuesta desde el dispositivo remoto .  

                    int bytesRec = sender.Receive(bytes);


                    String Respuesta = Encoding.ASCII.GetString(bytes, 0, bytesRec);

                    return Respuesta;
              
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

            return null;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Solicitud = "Palabra:"+txtpalabra.Text;
            String Respuesta = EnviarMensaje(Solicitud);
            lblPalabra.Text = Respuesta;
            if (Respuesta == "True")
            {
                lblganador.Text = "Ganador";
            }
            else
            {
                lblganador.Text = "Sigue Intentando";
            }
                    
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}

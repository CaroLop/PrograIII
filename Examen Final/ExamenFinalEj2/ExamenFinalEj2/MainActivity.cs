using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;

namespace ExamenFinalEj2
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        Pedido pedido;
        EntregadelPedido entrega;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            EditText nro = FindViewById<EditText>(Resource.Id.txtNrodePedido);
            EditText tipo = FindViewById<EditText>(Resource.Id.txtPedido);
            EditText monto = FindViewById<EditText>(Resource.Id.txtMonto);
            EditText hraP = FindViewById<EditText>(Resource.Id.txtHRaPedido);
            EditText hraE = FindViewById<EditText>(Resource.Id.txtHRaentrga);
            Button Registrar = FindViewById<Button>(Resource.Id.btnRegistrar);
            Button Listados = FindViewById<Button>(Resource.Id.btnNuevo);
            Registrar.Click += Registrar_Click;
            void Registrar_Click(object sender, System.EventArgs e)
            {
                if (hraE.Text == "")
                {
                    hraE.Text = "0";
                    pedido = new Pedido(int.Parse(nro.Text), tipo.Text, double.Parse(monto.Text), hraP.Text, hraE.Text);
                }
                else
                {
                    pedido = new Pedido(int.Parse(nro.Text), tipo.Text, double.Parse(monto.Text), hraP.Text, hraE.Text);
                }

                entrega.Insertar(pedido);   
            }
            Listados.Click += Listado_click;
            void Listado_click(object sender, System.EventArgs e)
            {
                var insertar = new Intent(this, typeof(Activity1));
                insertar.PutExtra("Datos", "Datos Enviados");
                StartActivity(insertar);
            }
        }
    }
}
using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace TresEnRayaXamarin
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
           
            TextView resultado = FindViewById<TextView>(Resource.Id.txtResultado1);
            ImageButton i00 = FindViewById<ImageButton>(Resource.Id.img00);
            ImageButton i01 = FindViewById<ImageButton>(Resource.Id.img01);
            ImageButton i02 = FindViewById<ImageButton>(Resource.Id.img02);
            ImageButton i10 = FindViewById<ImageButton>(Resource.Id.img10);
            ImageButton i11 = FindViewById<ImageButton>(Resource.Id.img11);
            ImageButton i12 = FindViewById<ImageButton>(Resource.Id.img12);
            ImageButton i20 = FindViewById<ImageButton>(Resource.Id.img20);
            ImageButton i21 = FindViewById<ImageButton>(Resource.Id.img21);
            ImageButton i22 = FindViewById<ImageButton>(Resource.Id.img22);       
            TextView turno = FindViewById<TextView>(Resource.Id.txtTurno);
            Button reinicio = FindViewById<Button>(Resource.Id.button1);
            turno.Text = "x";
            void AnalizaMensage(string mensaje)
            {

                string[] respuesta = mensaje.Split(':');
                switch (respuesta[0])
                {
                    case "ganador":
                        resultado.Text = "el ganador es: " + respuesta[1];
                        break;
                    case "continuar":
                        if (turno.Text == "x")
                            turno.Text = "o";
                        else
                            turno.Text = "x";
                        break;
                    case "error":
                        resultado.Text = "error: " + respuesta[1];
                        break;
                    case "resultado":
                        resultado.Text = "ha habido un empate";
                        break;

                }
            }
           
            i00.Click += (sender, e) =>
            {
                string respuesta = Raya.getInstancia().marcar(0, 0, turno.Text[0]);
                if (turno.Text == "x")
                    i00.SetImageResource(Resource.Drawable.X);

                else
                    i00.SetImageResource(Resource.Drawable.O);
                AnalizaMensage(respuesta);
            };
            i01.Click += (sender, e) =>
            {
                string respuesta = Raya.getInstancia().marcar(0, 1, turno.Text[0]);
                if (turno.Text == "x")
                    i01.SetImageResource(Resource.Drawable.X);

                else
                    i01.SetImageResource(Resource.Drawable.O);
                AnalizaMensage(respuesta);
            };
            i02.Click += (sender, e) =>
            {
                string respuesta = Raya.getInstancia().marcar(0, 2, turno.Text[0]);
                if (turno.Text == "x")
                    i02.SetImageResource(Resource.Drawable.X);

                else
                    i02.SetImageResource(Resource.Drawable.O);
                AnalizaMensage(respuesta);
            };
            i10.Click += (sender, e) =>
            {
                string respuesta = Raya.getInstancia().marcar(1, 0, turno.Text[0]);
                if (turno.Text == "x")
                    i10.SetImageResource(Resource.Drawable.X);

                else
                    i10.SetImageResource(Resource.Drawable.O);
                AnalizaMensage(respuesta);
            };
            i11.Click += (sender, e) =>
            {
                string respuesta = Raya.getInstancia().marcar(1, 1, turno.Text[0]);
                if (turno.Text == "x")
                    i11.SetImageResource(Resource.Drawable.X);

                else
                    i11.SetImageResource(Resource.Drawable.O);
                AnalizaMensage(respuesta);
            };
            i12.Click += (sender, e) =>
            {
                string respuesta = Raya.getInstancia().marcar(1, 2, turno.Text[0]);
                if (turno.Text == "x")
                    i12.SetImageResource(Resource.Drawable.X);

                else
                    i12.SetImageResource(Resource.Drawable.O);
                AnalizaMensage(respuesta);
            };
            i20.Click += (sender, e) =>
            {
                string respuesta = Raya.getInstancia().marcar(2, 0, turno.Text[0]);
                if (turno.Text == "x")
                    i20.SetImageResource(Resource.Drawable.X);

                else
                    i20.SetImageResource(Resource.Drawable.O);
                AnalizaMensage(respuesta);
            };
            i21.Click += (sender, e) =>
            {
                string respuesta = Raya.getInstancia().marcar(2, 1, turno.Text[0]);
                if (turno.Text == "x")
                    i21.SetImageResource(Resource.Drawable.X);

                else
                    i21.SetImageResource(Resource.Drawable.O);
                AnalizaMensage(respuesta);
            };
            i22.Click += (sender, e) =>
            {
                string respuesta = Raya.getInstancia().marcar(2, 2, turno.Text[0]);
                if (turno.Text == "x")
                    i22.SetImageResource(Resource.Drawable.X);

                else
                    i22.SetImageResource(Resource.Drawable.O);
                AnalizaMensage(respuesta);
            };
            reinicio.Click += (sender, e) =>
              {
                  Raya.getInstancia().Reiniciar();
                  i00.SetImageResource(Resource.Drawable.vacia);
                  i01.SetImageResource(Resource.Drawable.vacia);
                  i02.SetImageResource(Resource.Drawable.vacia);
                  i10.SetImageResource(Resource.Drawable.vacia);
                  i11.SetImageResource(Resource.Drawable.vacia);
                  i12.SetImageResource(Resource.Drawable.vacia);
                  i20.SetImageResource(Resource.Drawable.vacia);
                  i21.SetImageResource(Resource.Drawable.vacia);
                  i22.SetImageResource(Resource.Drawable.vacia);
                  turno.Text = "x";
                  resultado.Text = "";
              };
        }
    }
}
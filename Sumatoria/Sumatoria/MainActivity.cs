using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace Sumatoria
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
         protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            EditText N = FindViewById<EditText>(Resource.Id.txtN);
            Button button = FindViewById<Button>(Resource.Id.btncalcular);
            RadioButton sumatoria = FindViewById<RadioButton>(Resource.Id.rbtnsumatoria);
            RadioButton factorial = FindViewById<RadioButton>(Resource.Id.rbtnfactorial);
            TextView resultado = FindViewById<TextView>(Resource.Id.txtresultado);
            button.Click += (sender, e) =>
              {
                  int res=0;
                  Operaciones o = new Operaciones();
                  if (sumatoria.Checked==true)
                  {
                     res = o.sumatoria(int.Parse(N.Text));
                  }
                  else if(factorial.Checked==true)
                  {
                      res = o.Factorial(int.Parse(N.Text));
                  }
                  else
                  {
                      res = int.Parse("Introduzca la opcion");
                  }
                  resultado.Text = res.ToString();
              };
        }
    }
}
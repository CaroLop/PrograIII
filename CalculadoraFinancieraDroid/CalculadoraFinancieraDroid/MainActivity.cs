using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System.Collections.Generic;
using static Android.App.ActionBar;

namespace CalculadoraFinancieraDroid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    
    public class MainActivity : AppCompatActivity
    {
        Button btnObtener;
        EditText n;
        LinearLayout textBoxHolder;
        List<EditText> _TextosEdicion;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            btnObtener = FindViewById<Button>(Resource.Id.btnObtener);
            textBoxHolder = FindViewById<LinearLayout>(Resource.Id.lTextos);
            n= FindViewById<EditText>(Resource.Id.textVN);
            btnObtener.Click += btnObtener_Click;

            _TextosEdicion = new List<EditText>();

        }
        void btnObtener_Click(object sender, System.EventArgs e)
        {
            for (int i=1;i<=int.Parse(n.Text);i++)
            {
                var editText = new EditText(this);
                editText.Tag = $"Flujo {i}";

                var layoutParams = new LinearLayout.LayoutParams(LayoutParams.MatchParent, LayoutParams.WrapContent);
                layoutParams.BottomMargin = 6;

                editText.LayoutParameters = layoutParams;

                editText.Hint = $"Introduzca Flujo # {i}";

                //Solo si quieres guardar referencia de ellos para luego tomar su valor.
                _TextosEdicion.Add(editText);

                textBoxHolder.AddView(editText);

            }

            

            
        }
    }
}
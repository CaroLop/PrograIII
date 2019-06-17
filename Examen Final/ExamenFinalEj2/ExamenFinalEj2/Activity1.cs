using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using static Android.App.ActionBar;

namespace ExamenFinalEj2
{
    [Activity(Label = "Activity1")]
    public class Activity1 : Activity
    {
        EntregadelPedido Entrega;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.layout1);
            Button NoRegis = FindViewById<Button>(Resource.Id.btnNoRegis);
            Button Montos = FindViewById<Button>(Resource.Id.btnMonto);
            Button TypesOf = FindViewById<Button>(Resource.Id.btnTiposPedido);
           LinearLayout textBoxHolder = FindViewById<LinearLayout>(Resource.Id.linearLayout1);
            void NoRegistrafo_Click(object sender, System.EventArgs e)
            {
                for (int i = 1; i <= 5; i++)
                {
                    var editText = new TextView(this);
                    editText.Tag = $"Flujo {i}";

                    var layoutParams = new LinearLayout.LayoutParams(LayoutParams.MatchParent, LayoutParams.WrapContent);
                    layoutParams.BottomMargin = 6;

                    editText.LayoutParameters = layoutParams;

                    textBoxHolder.AddView(editText);

                }
            }
        }
    }
}
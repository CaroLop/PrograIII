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

namespace Sumatoria
{
    class Operaciones
    {
        public int sumatoria(int n)
        {
            if (n == 0)
                return 0;
            else
                return sumatoria(n - 1) + n;
        }
        public  int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
                return Factorial(n - 1) * n;
        }
    }
}
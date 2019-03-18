using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Ejercicio5
{
    class Program
    {
        public delegate double Delegatres(int a, int b);
        static void Main(string[] args)
        {
            Boolean Salir = false;
            int opcion = 4;
            double a = 0;
            int c=0, b=0;
            Console.WriteLine("Introduzca los Valores de a y b respectivamente");
            c = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            while (Salir == false)
            {
                Console.Clear();
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicacion");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Salir");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        a = Suma(c, b);
                        Console.WriteLine("Sumar: "+a);
                        break;
                    case 2:
                        a = Resta(c, b);
                        Console.WriteLine("Resta: " + a);
                        break;
                    case 3:
                        a = Multiplicacion(c, b);
                        Console.WriteLine("Multiplicacion: " + a);
                        break;
                    case 4:
                        a = Division(c, b);
                        Console.WriteLine("Division: " + a);
                        break;
                    case 5:
                        Salir = true;
                        break;
                }
                Console.ReadKey();
            }

        }
        static double Suma(int a, int b)
        { return a + b; }
        static double Resta(int a, int b)
        { return a - b; }
        static double Multiplicacion(int a, int b)
        { return a * b; }
        static double Division(int a, int b)
        { return a / b; }

    }
}

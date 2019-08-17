using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaFiguras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para demostrar el concepto de herencia de clases");
            Console.WriteLine("Jerarquía de las figuras geométricas cerradas");

            Figura miFigura = new Figura(); //Inicializa

           /*
            Console.WriteLine("ANTES La figura tiene centro en las coordenadas ({0},{1})",
            miFigura.CentroX, miFigura.CentroY);

            Console.WriteLine("Ingresa la coordenada x del centro de la figura: ");
            miFigura.CentroX = int.Parse(Console.ReadLine()); // convierte a entero

            Console.WriteLine("Ingresa la coordenada y del centro de la figura: ");
            miFigura.CentroY = int.Parse(Console.ReadLine()); // convierte a entero

            Console.WriteLine("La figura tiene centro en las coordenadas ({0},{1})", 
                miFigura.CentroX, miFigura.CentroY);

            Console.WriteLine("\n\nAhota para un triangulo...");

            //Aca se hace la parte del triangulo

            Triangulo miTria = new Triangulo();

            Console.Write("ingresar la coordenada x del triangulo");
            miTria.CentroX = int.Parse(Console.ReadLine());

            Console.Write("ingresar la coordenada y del triangulo");
            miTria.CentroX = int.Parse(Console.ReadLine());

            Console.WriteLine("La figura del triangulo tiene centro en las coordenadas ({0},{1})",
            miTria.CentroX, miTria.CentroY);
           
    */
            Console.WriteLine("\n\nAhota para otro triangulo...");
           
            int x, y, a, b;
            string t;

            Console.Write("ingresar la coordenada x del triangulo: ");
            x = int.Parse(Console.ReadLine());

            Console.Write("ingresar la coordenada y del triangulo: ");
            y = int.Parse(Console.ReadLine());

            Console.Write("ingresar la base del triangulo: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("ingresar  altura  del triangulo: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("ingresar el tipo del triangulo: ");
            t = Console.ReadLine();


            //Triangulo otroTri = new Triangulo(x,y);

            Triangulo otroTri = new Triangulo(t, a, b, x, y);

            Console.WriteLine(otroTri.Info());      
            
            int r;
            Console.WriteLine("\n\nAhora para un circulo...");

            Circulo miCi = new Circulo();

            Console.Write("ingresar la coordenada x del Circulo: ");
            miCi.CentroX = int.Parse(Console.ReadLine());

            Console.Write("ingresar la coordenada y del Circulo: ");
            miCi.CentroX = int.Parse(Console.ReadLine());

            Console.Write("ingresar el radio ");
            r = int.Parse(Console.ReadLine());

           


        }
        // Aca termina el Main
    }
}

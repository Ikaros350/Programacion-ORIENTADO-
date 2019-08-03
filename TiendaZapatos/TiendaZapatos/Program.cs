using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaZapatos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para abastecer una tienda de zapatos");
            Console.WriteLine("Lllenaremos el inventario de la tienda con 1000 zapato");
            Console.WriteLine("Cada zapato tiene tres atributos: color, talla, estilo");
            Console.WriteLine("Tres colores: verde, negro, negra");
            Console.WriteLine("cinco estilos: crocs, sandalias gladiadiora, botas, tenis, alpargatas ");
            Console.WriteLine("Talla desde 34 hasta 45");

            string[] colores = { "verde", "negro", "violeta" };
            string[] estilos = { "crocs", "sadalias gladiadoras", "botas", "tenis", "alpargatas" };


            Zapatos[] inventario = new Zapatos[1000];

            Random aletorio = new Random();

            for (int i = 0; i < inventario.Length; i++)
            {
                inventario[i] = new Zapatos();
                inventario[i].Color = colores[aletorio.Next(colores.Length)];
                inventario[i].Estilo = estilos[aletorio.Next(estilos.Length)];
                inventario[i].Talla = aletorio.Next(34, 46);
            }

            Console.WriteLine("Inventario generado... visulaizado los primeros 10 zapatos: ");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Zapatos No. {0}, estilo: {1}, color {2}, talla{3}"
                    , i + 1, 
                    inventario[i].Color, 
                    inventario[i].Estilo, 
                    inventario[i].Talla);
            }

            //string estiloModa = ObtieneEstiloModa(inventario, estilos);
            //string colorModa = ObtieneColorModa(xxx, yyy);
            //int tallaModa = ObtieneTallaModa(xxx, yyy);
        }

        static string ObtieneEstiloModa(Zapatos[] arregloZapatos, string[] arregloEstilos)
        {
            string resultado = "";

            return resultado;
        }
        static int ObtieneTallaModa(Zapatos[] arregloZapatos, int[] arregloTalla)
        {
            int resultado = 0;

            int tallaMinima = arregloZapatos[0].Talla;
            int tallaMaxima = arregloZapatos[0].Talla;

            for (int i = 0; i < arregloZapatos.Length; i++)
            {
                //Aca pregunto por el Maximo
                if (arregloZapatos[i].Talla > tallaMaxima)
                {
                    tallaMaxima = arregloZapatos[i].Talla;
                }
                //Aca pregunto por el Minimo
                if(arregloZapatos[i].Talla < tallaMinima)
                {
                    tallaMinima = arregloZapatos[i].Talla;
                }
            }
            int cantidadTallas = (tallaMaxima - tallaMinima) + 1;

            int[] contadorTallas = new int[cantidadTallas];

            for (int i = 0; i < contadorTallas.Length; i++)
            {
                contadorTallas[i] = 0;
            }
            //Aqui incrementamos cada contador en la medida que aparezcan un valor de talla
            for (int i = 0; i < arregloZapatos.Length; i++)
            {
                contadorTallas[(arregloZapatos[i].Talla - tallaMinima)]++;
            }
            int maxFrecuencia = contadorTallas[0];
            int posicion = 0;
            for (int i = 0; i < contadorTallas.Length; i++)
            {
                if (contadorTallas[i] > maxFrecuencia)
                {
                    maxFrecuencia = contadorTallas[i];
                    posicion = i;
                }
            }
            resultado = tallaMinima + posicion;

            return resultado;
        }
        static string ObtieneColorModa(Zapatos[] arregloZapatos, string[] arregloColor)
        {
            string resultado = "";

            return resultado;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_de_repaso
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();

            int n = 5;
            int [] Compañeros = new int[n];
            int[] poderporcompañero = new int[n];
            string[] nombre = new string[n];
            

            int artefacto1 = 0;
            int artefacto2 = 0;
            int artefacto3 = 0;
            int totaldecadauno = 0;
            int poderreunido =0 ;

            
            for (int i = 0; i < n; i++)
            {
                
                Console.WriteLine("Nombre del jugador");
               
                nombre[i] = Console.ReadLine();
                if (nombre[i]== "Mike" || nombre[i] == "Lucas" || nombre[i] == "Dustin" || nombre[i] == "Eleven" || nombre[i] == "Dustin" || nombre[i] == "Max")
                {
                    artefacto1 = aleatorio.Next(1, 101);
                    artefacto2 = aleatorio.Next(1, 101);
                    artefacto3 = aleatorio.Next(1, 101);

                    totaldecadauno = artefacto1 + artefacto2 + artefacto3;

                    Console.WriteLine("Artefacto " + artefacto1);
                    Console.WriteLine("Artefacto " + artefacto2);
                    Console.WriteLine("Artefacto " + artefacto3);

                    poderporcompañero[i] = totaldecadauno;
                    Console.WriteLine("Puntos: " + totaldecadauno);

                    Console.WriteLine("Desea continuar? (s/n)");
                    string respuesta = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Unos de los que trajo los artefactos, es uno de los de Will, al llegar sus amigos se dean cuenta de esto y deciden detenerle para evitar que este sea herido, para ello usaron el poder de los artefactos para desaparecerlo, por lo tanto deberan volver a empezar");
                    
                }
        

            }
            for (int i = 0; i < n; i += 1)
            {

                Console.WriteLine("Nombre: " + nombre[i]);
                Console.WriteLine("Puntaje: " + poderporcompañero[i]);
                if (poderporcompañero[i] < 250)
                {
                    Console.WriteLine("No logro la meta");
                }
                else
                {
                    Console.WriteLine("logro la meta");
                }
                poderreunido = +poderporcompañero[i];
            }
            Console.WriteLine("El poder que todos reunieron es de: "+ poderreunido);
            if (poderreunido < 1320)
            {
                Console.WriteLine("Nunca fue liberado");
            }
            else
            {
                Console.WriteLine("Se Salvo will");
            }
                
            Console.WriteLine("Gracias por JUGAR");
        }
    }
}

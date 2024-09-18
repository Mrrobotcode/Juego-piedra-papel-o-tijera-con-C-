using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Xml;

namespace Piedra_papel_o_tijera
{
    internal class Program
    {
        static int perdiste = 0;
        static int ganaste = 0;
        static int empate = 0;
        static int jugaste = 1;
        static void juego()
        {
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("                Bienvenido a Mr.RobotCodeGame                 ");
            Console.WriteLine("--------------------------------------------------------------");
           
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("                Acontinuacion escoge tu arma                  ");
            Console.WriteLine("--------------------------------------------------------------");

            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine(" Vamos a elegir: 0 para piedra, 1 para papel y 2 para tijera  ");
            Console.WriteLine("--------------------------------------------------------------");
            
            int jugador = Convert.ToInt32(Console.ReadLine());
            Random elegir_Random = new Random();
            int num = elegir_Random.Next(0, 2);
            int enemigo = num;
            Console.Clear();

            switch (jugador)
            {
                case 0:
                    Console.WriteLine("------------------------------------------------------");
                    Console.WriteLine("                  Tu eligiste piedra                  ");
                    Console.WriteLine("------------------------------------------------------");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case 1:
                    Console.WriteLine("------------------------------------------------------");
                    Console.WriteLine("                  Tu eligiste papel                   ");
                    Console.WriteLine("------------------------------------------------------");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case 2:
                    Console.WriteLine("------------------------------------------------------");
                    Console.WriteLine("                  Tu eligiste tijera                  ");
                    Console.WriteLine("------------------------------------------------------");
                    Console.ReadLine();
                    Console.Clear();
                    break;
            }

            switch (enemigo)
            {
                case 0:
                    Console.WriteLine("------------------------------------------------------");
                    Console.WriteLine("                  Enemigo eligio piedra               ");
                    Console.WriteLine("------------------------------------------------------");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case 1:
                    Console.WriteLine("------------------------------------------------------");
                    Console.WriteLine("                  Enemigo eligio papel                ");
                    Console.WriteLine("------------------------------------------------------");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case 2:
                    Console.WriteLine("------------------------------------------------------");
                    Console.WriteLine("                  Enemigo eligio tijera               ");
                    Console.WriteLine("------------------------------------------------------");
                    Console.ReadLine();
                    Console.Clear();
                    break;
            }

            if (jugador == 0 && enemigo == 2 || jugador == 1 && enemigo == 0 || jugador == 2 && enemigo == 1)
            {
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("                       Ganaste                        ");
                Console.WriteLine("------------------------------------------------------");
                ganaste++;
                volveraJugar();
            }

            if (enemigo == 0 && jugador == 2 || enemigo == 1 && jugador == 0 || enemigo == 2 && jugador == 1)
            {
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("                       Perdiste                       ");
                Console.WriteLine("------------------------------------------------------");
                perdiste++;
                volveraJugar();
            }

            if (jugador == 0 && enemigo == 0 || jugador == 1 && enemigo == 1 || jugador == 2 && enemigo == 2)
            {
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("                        Empate                        ");
                Console.WriteLine("------------------------------------------------------");
                empate++;
                volveraJugar();
            }
        }

        static void volveraJugar()
        {
            Console.WriteLine("Deseas volver a jugar: si / no");
            string volver = Console.ReadLine();

            if (volver == "si")
            {
                
                Console.Clear();
                jugaste++;
                juego();
            }
            else if (volver == "no")
            {
                Console.WriteLine("Ganaste: " + ganaste + " partidas");
                Console.WriteLine("Perdiste: " + perdiste + " partidas");
                Console.WriteLine("Empatate: " + empate + " partidas");
                Console.WriteLine("Jugaste: " + jugaste + " partidas");
                Console.WriteLine("Gracias por jugar, vuelve pronto");
                Console.ReadLine();
            }
        }
        
        static void Main(string[] args)
        {
            juego();
        }

    }
}
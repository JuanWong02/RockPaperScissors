using System;

namespace RockPaperScissors
{
    class Program
    {

        /// <summary>
        /// Solicita al usuario una opcion a jugar
        /// </summary>
        /// <returns>La opcion seleccionada: 1 - piedra, 2 - papel, 3 - tijera</returns>
        static int SelectOption()
        {
            Console.WriteLine("Selecciona la opcion a jugar:");
            Console.WriteLine("1) Piedra");
            Console.WriteLine("2) Papel");
            Console.WriteLine("3) Tijera");

            int option = Convert.ToInt32(Console.ReadLine());
            return option;
        }

        /// <summary>
        /// Selecciona una opcion aleatoria entre 1, 2 o 3
        /// </summary>
        /// <returns>La opcion seleccionada aleatoriamente</returns>
        static int ComputerChoice()
        {
            Random r = new Random();
            // 1, 2, or 3
            int computerChoice = r.Next(1, 4);
            return computerChoice;
        }
        static void Main(string[] args)
        {
            //Seleccionar opción a jugar (piedra, papel o tijera)
            //1: piedra
            //2: papel
            //3: tijera
           int option = SelectOption();
           Console.WriteLine("Opcion seleccionada: " + option);

           //TODO: La computadora genera su opción a jugar de manera aleatoria (piedra, papel o tijera)
           int computerChoice = ComputerChoice();
           Console.WriteLine("La CPU selecciono: " + computerChoice);

           //TODO: Determinar quién ganó de acuerdo a las opciones seleccionadas, y mostrar al ganador

           //TODO: Jugar 3 partidas, y mencionar quién ganó al final (jugador o computadora)
        }
    }
}

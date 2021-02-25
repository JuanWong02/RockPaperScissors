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
            int opcionCpu = r.Next(1, 4);
            return opcionCpu;
        }

        /// <summary>
        /// Compara los valores de option y opcionCpu para determinar el resultado
        /// </summary>
        /// <param name="option"></param> //opcion seleccionada por jugador
        /// <param name="opcionCpu"></param> // opcion seleccionada por cpu
        static void CheckWinner(int option, int opcionCpu)
        {
            //1: piedra
            //2: papel
            //3: tijera
            // piedra < papel < tijera < piedra
            // 1 < 2 < 3 < 1

            // muestra opcion que escogio el jugador
            switch (option) 
            {
                case 1:  Console.WriteLine("Jugador: Piedra");
                break;

                case 2:  Console.WriteLine("Jugador: Papel");
                break;

                case 3:  Console.WriteLine("Jugador: Tijera");
                break;
            }

            //muestra opcion de la cpu
            switch(opcionCpu)
            {
                case 1:  Console.WriteLine("CPU: Piedra");
                break;

                case 2:  Console.WriteLine("CPU: Papel");
                break;

                case 3:  Console.WriteLine("CPU: Tijera");
                break;
            }


            if (opcionCpu == 1) // si la cpu escoge piedra
            {
                if (option == 1)
                {
                    Console.WriteLine("Es un empate! ambos escogieron piedra"); //ambos escogieron piedra
                }
                else if (option == 2)
                {
                    Console.WriteLine("Has ganado! papel le gana a piedra"); // jugador papel, gana
                }
                else if (option == 3)
                {
                    Console.WriteLine("Has perdido! piedra le gana a tijera"); // jugador tijera, pierde
                }
            }

            else if (opcionCpu == 2) // si la cpu escoge papel
            {
                if (option == 1)
                {

                    Console.WriteLine("Has perdido! papel le gana a piedra"); // jugador piedra, pierde
                }
                else if (option == 2)
                {

                    Console.WriteLine("Es un empate! ambos escogieron papel"); // jugador papel, empate
                }
                else if (option == 3)
                {

                    Console.WriteLine("Has ganado! tijera le gana a papel"); // jugador tijera, gana
                }
            }
            else if (opcionCpu == 3) // si la cpu escoge tijera
            {
                if (option == 1)
                {

                    Console.WriteLine("Has ganado! piedra le gana a tijera"); // jugador piedra, gana
                }
                else if (option == 2)
                {

                    Console.WriteLine("Has perdido tijera le gana a papel"); // jugador papel, pierde
                }
                else if (option == 3)
                {

                    Console.WriteLine("Es un empate! ambos escogieron tijera"); // jugador tijera , empate
                }
            }

        }
        static void Main(string[] args)
        {
            //Seleccionar opción a jugar (piedra, papel o tijera)

            int option = SelectOption();
            Console.WriteLine("Opcion seleccionada: " + option);


            int opcionCpu = ComputerChoice();
            Console.WriteLine("La CPU selecciono: " + opcionCpu);


            CheckWinner(option, opcionCpu);

            // [CANCELED]TODO: Jugar 3 partidas, y mencionar quién ganó al final (jugador o computadora)
        }
    }
}

using System;
using System.Reflection;
using POOActivities.Day_2018_08_09;


namespace POOActivities
{
    public class Exercises
    {
        /// <summary>
        /// Implemente a classe Data utilizada como exemplo na aula teórica,
        /// considerando as operações:
        ///     • Verificar validade da data
        ///     • Adicionar dias a uma data
        ///     • Dizer o dia da data no ano(1 a 366)
        /// </summary>
        public void Ex09_08_1(){
            Date date = new Date();
            string op = "";
            int d;

            while (op != "S")
            {
                Console.Clear();
                Console.WriteLine("a or A - Add days to the date.");
                Console.WriteLine("d or D - Print day on year.");
                Console.WriteLine("u or P - Update the date.");
                Console.WriteLine("v or V - Validate date.");
                Console.WriteLine("s or S - Exit.");
                Console.WriteLine();
                Console.WriteLine(date);
                Console.Write(date.DateIsValid() ? "Date is valid!" : "Date is not valid!");
                Console.WriteLine();
                Console.Write("Option: ");
                op = Console.ReadLine().ToUpper();
                switch (op)
                {
                    case "A":
                        Console.Write("Type the amount of days to add:");
                        while(!int.TryParse(Console.ReadLine(), out d)){
                            Console.Write("Invalid day! Type again:");
                        }
                        date.AddDays(d);
                        break;
                    case "D":
                    case "S":
                        break;
                    case "V":
                        break;
                    default:
                        Console.WriteLine("Invalid Option.");
                        break;

                }
            }
        }

        /// <summary>
        /// Modele e implemente uma classe Relógio. Este relógio deve marcar, além
        /// das horas, o dia e o mês atual.O usuário pode ajustar data e hora a qualquer
        /// momento, ou reinicializar o relógio para as 0h00 de 01/01/2000.
        /// O relógio deve ter métodos que possibilitem a atualização de horas e datas
        /// automaticamente conforme a passagem do tempo.
        /// </summary>
        public void Ex09_08_2(){
            Clock clock = new Clock();
            string op = "";
            int s;

            while (op != "S")
            {
                Console.Clear();
                Console.WriteLine("a or A - Add seconds to the timer.");
                Console.WriteLine("u or U - Update the clock.");
                Console.WriteLine("r or R - Reset the clock.");
                Console.WriteLine("s or S - Exit.");
                Console.WriteLine();
                Console.WriteLine(clock);
                Console.WriteLine();
                Console.Write("Option: ");
                op = Console.ReadLine().ToUpper();
                switch(op){
                    case "A":
                        Console.Write("Type the amount of seconds to add:");
                        while (int.TryParse(Console.ReadLine(), out s)){
                            Console.Write("Invalid day! Type again:");
                        }
                        clock.addSeconds(s);
                        break;
                    case "U":
                    case "S":
                        break;
                    case "R":
                        clock.reset();
                        break;
                    default:
                        Console.WriteLine("Invalid Option.");
                        break;

                }
            }
        }

        /// <summary>
        /// Implemente uma classe Televisão que tenha métodos para ligar e
        /// desligar, aumentar ou diminuir o volume(com mínimo de 0 e máximo de 100) e
        /// subir ou baixar o canal(entre 1 e 83).
        /// </summary>
        public void Ex09_08_3()
        {
            Television television = new Television();
            string op = "";
            int s;

            while (op != "S"){
                Console.Clear();
                Console.WriteLine("on or ON - Turn on the television.");
                Console.WriteLine("off or OFF - Turn off the television.");
                Console.WriteLine("ic or IC - Increase the channel.");
                Console.WriteLine("dc or DC - Decrease the channel.");
                Console.WriteLine("iv or IV - Increase the volume.");
                Console.WriteLine("dv or DV - Decrease the volume.");
                Console.WriteLine("s or S - Exit.");
                Console.WriteLine();
                Console.WriteLine(television);
                Console.WriteLine();
                Console.Write("Option: ");
                op = Console.ReadLine().ToUpper();
                switch (op)
                {
                    case "ON":
                        television.TurnOn();
                        break;
                    case "OFF":
                        television.TurnOff();
                        break;
                    case "IC":
                        television.IncreaseChannel();
                        break;
                    case "DC":
                        television.DecreaseChannel();
                        break;
                    case "IV":
                        television.IncreaseVolume();
                        break;
                    case "DV":
                        television.DecreaseVolume();
                        break;
                    case "S":
                        break;
                    default:
                        Console.WriteLine("Invalid Option.");
                        break;

                }
            }
        }



        /// <summary>
        /// Get from the client and run the desired exercise.
        /// </summary>
        public void Run(){
            ConsoleKeyInfo control;
            string date = "", ex = "", exFunc = "";
            MethodInfo method;

            Console.WriteLine("Welcome to the POO exercises! Type any key to continue.");
            control = Console.ReadKey();

            do
            {
                try
                {
                    if (control.Key == ConsoleKey.Enter || exFunc == "")
                    {
                        Console.Write("Type the day the ex was given: (Ex: 09_08 - August 9th.):");
                        date = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("Type the exercise number:");
                        ex = Console.ReadLine();

                        exFunc = "Ex" + date + "_" + ex;
                    }
                    method = GetType().GetMethod(exFunc);
                    method.Invoke(this, null);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                Console.WriteLine("To try again type any key. (ESC to exit, ENTER to change the exercise.)");
                control = Console.ReadKey();
            } while (control.Key != ConsoleKey.Escape);
        }
    }
}

using System;
using System.Reflection;

namespace POOActivities
{
    public class Exercises
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:POOActivities.Exercises"/> class.
        /// This class was created to call the function names dinamically 
        /// <see cref="T:POOActivities.Exercises.Run"/> function.
        /// </summary>
        public Exercises()
        {
        }

        /// <summary>
        /// Modele e implemente uma classe Relógio. Este relógio deve marcar, além
        /// das horas, o dia e o mês atual.O usuário pode ajustar data e hora a qualquer
        /// momento, ou reinicializar o relógio para as 0h00 de 01/01/2000.
        /// O relógio deve ter métodos que possibilitem a atualização de horas e datas
        /// automaticamente conforme a passagem do tempo.
        /// </summary>
        public void Ex09_08_2()
        {
            Clock clock = new Clock();
            string op = "";
            int s;

            while (op != "s")
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
                        s = int.Parse(Console.ReadLine());
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
        /// Get from the client and run the desired exercise.
        /// </summary>
        public void Run(){
            ConsoleKeyInfo control;
            string date = "", ex = "", exFunc = "";
            MethodInfo method;

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

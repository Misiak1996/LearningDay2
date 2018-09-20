using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Learning day 2
/// </summary>
namespace LearningDay2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {


                PodajImie();
                PodajWiek();
                KoniecProgramu();
            }

        }

        /// <summary>
        /// Metoda czyszczaca ekran
        /// </summary>
        private static void KoniecProgramu()
        {
            Console.ReadKey(); // czeka aż użytkownik wciśnie klawisz
            Console.Clear();
            Console.ResetColor();
        }

        /// <summary>
        /// Metoda odpowiedzialna za wprowadzenie wieku użytkownika
        /// </summary>
        private static void PodajWiek()
        {
            Console.Write("your age? ");
            int age;
            bool CzyZgodnyWiek = int.TryParse(Console.ReadLine(), out age); //Konwertuje sting do inta sprawdzajac przy tym czy podajemy liczbe czy litere


            if (CzyZgodnyWiek == true)
            {
                if (age >= 18)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Jesteś pełnoletni");
                }
                else
                {
                    Console.WriteLine("Jesteś niepełnoletni");
                }

            }
            else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Podałeś zły wiek spróbuj jeszcze raz !");
                    Console.ResetColor();

                    PodajWiek();
                }
        

    
        }


        /// <summary>
        /// Metoda odpowiedzialna za wprowadzenie imienia użytkownika.
        /// </summary>
        private static void PodajImie()
        {
            Console.Write("your name? ");
            string name = Console.ReadLine(); // method downolanding date, name
            Console.WriteLine("Hallo " + name);
        }
    }
}

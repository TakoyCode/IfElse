using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse
{
    internal class Oppgaver
    {
        public void Run()
        {
            Console.WriteLine("Velg hva du har lyst å gjøre!");
            Console.WriteLine("1 - CheckIfEqualGame");
            Console.WriteLine("2 - MultIfEqualAddIfNotGame");
            Console.WriteLine("3 - IsEqualTo30Game");

            int num = Convert.ToInt32(Console.ReadLine());
            if (num == 1) CheckIfEqualGame();
            else if (num == 2) MultIfEqualAddIfNotGame();
            else if (num == 3) IsEqualTo30Game();

            Console.ReadKey();
            Console.WriteLine();
            Run();
        }

        // Oppgave 1: Lag en metode som tar imot to tall og returnerer true dersom tallene er like. 

        void CheckIfEqualGame()
        {
            Console.WriteLine("Skriv inn 2 tall, så kan du se om de er like!");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (CheckIfEqual(num1, num2)){ Console.WriteLine("tallene du sa er like!");}
            else Console.WriteLine("tallene du sa er ikke like");
        }

        bool CheckIfEqual(int number1, int number2)
        {
            if (number1 == number2)return true;
            else return false;
        }

        // Oppgave 2: 
        // Lag en metode som tar imot to tall og returnerer summen av tallene dersom de er ulike, 
        // og returnerer tallene multiplisert med hverandre dersom de er like.

        void MultIfEqualAddIfNotGame()
        {
            Console.WriteLine("Skriv inn 2 tall, så blir tallene ganget med hverandre vis de er like.");
            Console.WriteLine("Eller så blir de plusset sammen om de er ulike");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 == num2)
            {
                Console.WriteLine($"tallene du sa er like, så de ble ganget med hverandre og ble {MultIfEqualAddIfNot(num1, num2)}");
            }
            else
            {
                Console.WriteLine($"tallene du sa er ikke like, så de ble plusset sammen og ble {MultIfEqualAddIfNot(num1, num2)}");
            }
        }

        int MultIfEqualAddIfNot(int num1, int num2)
        {
            if (num1 == num2) return num1 * num2;
            else return num1 + num2;
        }

        // Oppgave 3:
        // Lag en metode som tar inn to int verdier. Dersom en av de, eller summen til int verdiene blir 30,
        // skal metoden returnere true. Ellers returnerer metoden false

        void IsEqualTo30Game()
        {
            Console.WriteLine("Skriv inn 2 tall, så blir de sjekket om en av dem er 30 eller om de til sammen blir til 30");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (IsEqualTo30(num1, num2))
            {
                Console.WriteLine("Ett av tallene dine er 30 eller tallene dine til sammen blir til 30");
            }
            else
            {
                Console.WriteLine("Ingen av tallene dine er 30 og tallene dine satt sammen blir ikke til 30");
            }
        }

        bool IsEqualTo30(int num1, int num2)
        {
           if (num1 == 30 || num2 == 30 || num1 + num2 == 30) return true;
           else return false;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_Dice
{
    class Program
    {
        public static bool Continue()
        {
            Console.WriteLine("Roll again? (y/n)");
            string input = Console.ReadLine();
            
            input.ToLower();
            bool run;
            
            if(input == "n")
            {
                Console.WriteLine("Goodbye");
                run = false;
            }
            else if(input == "y")
            {
                run = true;
            }
            else
            {
                Console.WriteLine("Sorry, that is not a vaild input");
                run = Continue();
            }
            return run;
        }

        public static int DiceRollOne(int diceSides)
        {
            Random rnd = new Random();
            int diceOne = rnd.Next(1, diceSides);
            return diceOne;
        }

        static void Main(string[] args)
        {
            //ask user to enter the number of sides for the pair of dice
            Console.WriteLine("Hello! Please enter the number of sides you would like your dice to have: ");
            int diceSides = int.Parse(Console.ReadLine());

            bool run = true;

            Console.WriteLine(DiceRollOne(diceSides));
            Console.WriteLine(DiceRollOne(diceSides));

            run = Continue();
            //prompt user to roll the dice
            //app rolls two dice and displays result of each
            //ask if user if they want to roll again
        }
    }
}

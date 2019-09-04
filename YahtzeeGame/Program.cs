using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeGame
{
    public class Program
    {
        static void Main(string[] args)
        {

            Dice newDice = new Dice();
           
            int[][] diceResult = newDice.rollDicesThreeTimes();
            int rounds = 1;


            foreach (int[] row in diceResult)
            {
                if (rounds <= 3)
                {
                    Console.WriteLine("Round {0}: ", rounds);
                    rounds++;
                }              
                foreach (var dice in row)
                {
                    Console.WriteLine(dice);
                }
            }

            

        }
    }
}

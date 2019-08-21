using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeGame
{
    class Program
    {
        static void Main(string[] args)
        {

            Dice newDice = new Dice();

            int[][] diceResult = newDice.rollDicesThreeTimes();

            foreach (int[] row in diceResult)
            {
                foreach (var dice in row)
                {
                    Console.WriteLine(dice);
                }
            }


        }
    }
}

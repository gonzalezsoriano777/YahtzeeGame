using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeGame
{
    public class Dice
    {
        Random dice = new Random();
        int[] gameDice = new int[5];

        public void rollDice()
        {
            for(int diceRoll = 0; diceRoll < gameDice.Length; diceRoll++)
            {
                var diceResult = dice.Next(1, 7);
                gameDice[diceRoll] = diceResult;
                Console.WriteLine(gameDice[diceRoll]);
            }

        }
   
    }
}

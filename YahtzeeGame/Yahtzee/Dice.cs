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

        public int[][] rollDicesThreeTimes()
        {

            int firstRoll = 5;
            int secondRoll = 5; 
            int thirdRoll = 5;

            int[][] roll = new int[3][];
            roll[0] = new int[5];
            roll[1] = new int[5];
            roll[2] = new int[5];

            int rollCount = 0;

            while(rollCount < 3)
            {

                for (int d = 1; d < firstRoll; d++)
                {
                    roll[rollCount][d] = dice.Next(1, 7);
                }

                rollCount++;
            }
            return roll;
        }

    }
}

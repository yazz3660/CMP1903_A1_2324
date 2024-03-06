using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {

        Die die1 = new Die();
        Die die2 = new Die();
        Die die3 = new Die();
        int rollNum1;
        int rollNum2;
        int rollNum3;
        int[] rolls;

        public void ExecuteGame()
        {
            // Rolling each dice
            // Time in-between each roll allows for the seed/timestamp for the random number to be different
            rollNum1 = die1.Roll();
            Thread.Sleep(1);
            rollNum2 = die2.Roll();
            Thread.Sleep(1);
            rollNum3 = die3.Roll();
            rolls = new int[] { rollNum1, rollNum2, rollNum3 };
            for (int i = 0; i < rolls.Length; i++)
            {
                Console.WriteLine(rolls[i]);
            }
            Console.WriteLine(TotalOfRolls());
        }


        // Getting the return values of each roll
        public int ValueRoll1()
        {
            return rollNum1;
        }
        public int ValueRoll2()
        {
            return rollNum2;
        }
        public int ValueRoll3()
        {
            return rollNum3;
        }

        public int TotalOfRolls()
        {
            var rollTotal = rollNum1 + rollNum2 + rollNum3;
            return rollTotal;
        }

    }
}

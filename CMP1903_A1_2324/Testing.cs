using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        /*
         * This class should test the Game and the Die class.
         * Create a Game object, call the methods and compare their output to expected output.
         * Create a Die object and call its method.
         * Use debug.assert() to make the comparisons and tests.
         */

        //Method
        public void Test()
        {
            Game testGame = new Game();
            testGame.ExecuteGame();

            if (testGame.TotalOfRolls() < 18)
            {
                if (testGame.TotalOfRolls() > 3)
                {
                    Console.WriteLine("Total Is As Expected: " + testGame.TotalOfRolls());
                }
                else
                {
                    Console.WriteLine("Total Was Less Than 3, Which Is Impossible: " + testGame.TotalOfRolls());
                }
            }
            else
            {
                Console.WriteLine("Total Was Greater Than 18, Which Is Impossible: " + testGame.TotalOfRolls());
            }
            

        }


    }
}

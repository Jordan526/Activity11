using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity11
{
    public class DiceDriver
    {
        public static void Main()
        {

            //initialize Dice class and pass in valid int number. 
            Dice dice1 = new Dice(9);
            Dice dice2 = new Dice(6);
            //example if the number is out of bounds
            //Dice dice3 = new Dice(1);

            //intialize variables to assign each dice roll too and to keep track of the number of rolls.
            int dice1Roll;
            int dice2Roll;
            int numberOfRolls = 0;
            
            //do while loop to catch when "snake eyes" are rolled (double 1's). 
            //Also reports the number of rolls. 
            do
            {
                dice1Roll = dice1.rollDice();
                dice2Roll = dice2.rollDice();

                Console.WriteLine("Rolled: Dice #1 = " + dice1Roll + ", Dice#2 = " + dice2Roll);

                ++numberOfRolls;

            } while (dice1Roll != 1 || dice2Roll != 1);

            //wrting to the console how many number of rolls it took to get snake eyes. 
            Console.WriteLine("\n" +
                "It took " + numberOfRolls + " rolls to get snake eyes!");
        }
    }

}
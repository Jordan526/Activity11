// See https://aka.ms/new-console-template for more information
public class Dice
{
    //intializing private field for the number of sides of the dice
    private int numberOfSides;

    //constructor that takes in an int number of sides. 
    //throws exception if the given number is not within the specific range 4 - 20. 
    public Dice(int numberOfSides)
    {
        if(numberOfSides < 4 || numberOfSides > 20)
        {
            throw new ArgumentException("Should be within the range 4 - 20 (inclusive)");
        }
        this.numberOfSides = numberOfSides;
    }

    //roll dice method that simulates rolling an n number sided dice using a random number. 
    public int rollDice()
    {
        Random randomRoll = new Random();
        int roll = randomRoll.Next(1, numberOfSides + 1);
        return roll;
    }
}
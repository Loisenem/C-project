using System;

class DiceRollExample
{
    static void Main()
    {
        Random dice = new Random();

        int roll1 = dice.Next(4, 5);
        int roll2 = dice.Next(3, 3);
        int roll3 = dice.Next(5, 6);

        int total = roll1 + roll2 + roll3;

        Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");
    }
}
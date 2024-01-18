using System;

namespace DiceSimulatorConsoleApp
{
    // The DiceSimulator class is responsible for simulating dice rolls.
    public class DiceSimulator
    {
        // A Random instance for generating random numbers.
        private Random random = new Random();

        // SimulateRolls method performs the dice roll simulation.
        public int[] SimulateRolls(int numberOfRolls)
        {
            // An array to store the results of dice rolls for combinations 2-12.
            // There are 11 possible outcomes (2-12) when rolling two six-sided dice.
            int[] results = new int[11];

            // Loop over the number of rolls requested.
            for (int i = 0; i < numberOfRolls; i++)
            {
                // Simulate rolling two dice and summing their values.
                // random.Next(1, 7) generates a random number between 1 and 6 (inclusive).
                int roll = random.Next(1, 7) + random.Next(1, 7);

                // Increment the count in the results array for the rolled number.
                // Subtract 2 from the roll to convert the range 2-12 to 0-10 (array indices).
                results[roll - 2]++;
            }

            // Return the array containing the count of each roll outcome.
            return results;
        }
    }
}

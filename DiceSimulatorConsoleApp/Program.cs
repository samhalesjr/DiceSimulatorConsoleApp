using System;

namespace DiceSimulatorConsoleApp
{
    // This class is the main entry point of the dice simulation console application.
    internal class Program
    {
        // The Main method is the entry point of a C# console application.
        private static void Main(string[] args)
        {
            // Display a welcome message to the user.
            Console.WriteLine("Welcome to the dice throwing simulator!");

            // Ask the user for the number of dice rolls they want to simulate.
            Console.Write("How many dice rolls would you like to simulate? ");

            // Read the user's input and convert it to an integer.
            int totalRolls = int.Parse(Console.ReadLine());

            // Create an instance of DiceSimulator to perform the simulation.
            DiceSimulator simulator = new DiceSimulator();

            // Call the SimulateRolls method to perform the dice rolls.
            int[] rollResults = simulator.SimulateRolls(totalRolls);

            // Display the results of the simulation.
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine($"Total number of rolls = {totalRolls}.\n");

            // Iterate through the possible dice roll totals (2 through 12).
            for (int i = 2; i <= 12; i++)
            {
                // Display the number being represented.
                Console.Write($"{i}: ");

                // Calculate the percentage of each roll result.
                int percentage = rollResults[i - 2] * 100 / totalRolls;

                // Display the percentage as a number of asterisks.
                Console.WriteLine(new String('*', percentage));
            }

            // Thank the user and end the program.
            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        }
    }
}

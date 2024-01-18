using System;

namespace DiceSimulatorConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the dice throwing simulator!");

            Console.Write("How many dice rolls would you like to simulate? ");
            int totalRolls = int.Parse(Console.ReadLine());

            DiceSimulator simulator = new DiceSimulator();
            int[] rollResults = simulator.SimulateRolls(totalRolls);

            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine($"Total number of rolls = {totalRolls}.\n");

            for (int i = 2; i <= 12; i++)
            {
                Console.Write($"{i}: ");
                int percentage = rollResults[i - 2] * 100 / totalRolls;
                Console.WriteLine(new String('*', percentage));
            }

            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        }
    }
}

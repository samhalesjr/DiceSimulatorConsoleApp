using System;

namespace DiceSimulatorConsoleApp
{
    public class DiceSimulator
    {
        private Random random = new Random();

        public int[] SimulateRolls(int numberOfRolls)
        {
            int[] results = new int[11]; // For combinations 2-12

            for (int i = 0; i < numberOfRolls; i++)
            {
                int roll = random.Next(1, 7) + random.Next(1, 7);
                results[roll - 2]++;
            }

            return results;
        }
    }
}

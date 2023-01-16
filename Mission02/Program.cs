using System;

namespace Mission02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Importing random class as well as getting the initial number of rolls
            Random rnd = new Random();
            int[] diceArray = new int[11];
            int numberOfRolls = 0;

            Console.WriteLine("Welcome to the dice throwing simulator!\n");
            Console.WriteLine("How many times do you want to role the dice?");
            numberOfRolls = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine("Total number of rolls = " + numberOfRolls + '\n');

            // Generating random numbers between 2-12 as dice roll and added up how many times they occer
            // for each number
            for (int i = 0; i < numberOfRolls; i++)
            {
                int randomNum = rnd.Next(2, 13);
                diceArray[randomNum - 2] += 1;
                
            }
     
            //Printing out each number and the percent of how many times it was rolled
            for (int k = 0; k < 11; k++)
            {
                double percentageNumber = (double)diceArray[k] / (double)numberOfRolls;
                string astrikString = "";
                double numOfAsteriks = Math.Round(percentageNumber * 100);

                for (int j = 0; j < numOfAsteriks; j++)
                {
                    astrikString += "*";
                }

                Console.WriteLine(k + 2 + ": " + astrikString);


            }

            Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");

        }
    }
}

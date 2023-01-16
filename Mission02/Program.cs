using System;

namespace Mission02
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] diceArray = new int[11];
            int numberOfRolls = 0;

            Console.WriteLine("Welcome to the dice throwing simulator!\n");
            Console.WriteLine("How many times do you want to role the dice?");
            numberOfRolls = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine("Total number of rolls = " + numberOfRolls + '\n');


            for (int i = 0; i < numberOfRolls; i++)
            {
                int randomNum = rnd.Next(2, 13);
                diceArray[randomNum - 2] += 1;
                
            }
     

            for (int k = 0; k < 11; k++)
            {
                double percentageNumber = (double)diceArray[k] / (double)numberOfRolls;
                string astrikString = "";
                //percentageNumber = (double)diceArray[k]/(double)numberOfRolls;
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

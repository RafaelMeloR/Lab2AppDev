//RAFAEL MELO 
//6217800

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS1
{
    internal class Population
    {
        private double population;
        private double average;
        private int days;

        // Constructor for the Population class. It validates the provided values and throws exceptions if any of the conditions are not met.
        // If the values are valid, it initializes the private member variables population, average, and days.
        public Population(double population, double average, int days ) 
        {
            try
            {
                if (population <= 2 && average <= 0 && days <= 0)
                {
                    throw new ArithmeticException("The population must be at least 3.\nThe averege must be positive.\nDays must be at leat 1.");
                }
                else if (population <= 2)
                {
                    throw new ArithmeticException("The population must be at least 3.");
                }
                else if (average <= 0)
                {
                    throw new ArithmeticException("The averege must be positive.");
                }
                else if (days <= 0)
                {
                    throw new ArithmeticException("Days must be at leat 1.");
                }
                else 
                {
                    this.population = population;
                    this.average = average;
                    this.days = days;
                }
            }
            catch (ArithmeticException e)
            { 
                Console.WriteLine(e.Message);
            }
        }
        // Method GrowPopulation simulates the growth of a population over a certain number of days.
        // It calculates the daily population growth based on the current population and the average growth rate.
        // It displays the daily population growth and updates the population accordingly.
        // Finally, it displays the total population after the specified number of days.
        // If any of the provided values are greater than 2 (population), greater than 0 (average), or greater than 0 (days),
        // it displays the total population after the specified number of days.
        public void GrowPopulation() 
        {
            double daily= 0;
            for (int n = 1; n < days; n++)
            {
                daily = (population * (average / 100));
                Console.WriteLine("Population "+population+" Day "+n+" poulation growth: "+daily);
                population += daily;
            }
            if(population>2 || average>0 || days >0)
            {
                Console.WriteLine("Total population after " + days + " days :" + population);
            }
            
            Console.ReadLine();
        }
    }
}

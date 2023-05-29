//RAFAEL MELO 
//6217800

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    
    public class AverageRainfall
    {
        private int years;
        private double[,] inches;
        private static double totalInches = 0;

        // Constructor for AverageRainfall class. Initializes years and inches.Calls getAverage().
        // Throws an exception if years is less than 1 and catches any exceptions that occur.
        public AverageRainfall(int years)
        {
            try
            {
                if (years<1)
                { 
                    throw new Exception("Years must be greater than 0");
                }
                this.years = years;
                inches = new double[years, 12];
                getAverage();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

        // Method to calculate average rainfall. Iterates through years and months to collect rainfall data.
        // Prompts the user for rainfall input, validates it, and stores it in the inches array.
        // Calculates the total inches and displays the total months, total inches, and average rainfall per month.
        // Catches any exceptions that occur during input parsing or calculations.

        public void setInches(double inches)
        {
            totalInches += inches;
        }

        public string getAverage() 
        {
           
           int month = years * 12;
           return ("Total month: " + month + "\nRainfall Total Inches :"+ totalInches+"\nAverage Rainfall per month: "+(totalInches/month));
        }
    }
}

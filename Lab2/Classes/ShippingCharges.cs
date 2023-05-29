//RAFAEL MELO 
//6217800
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class ShippingChargesClass
    {
        private double weight;
        private double miles;

        // Constructor for the ShippingCharges class. Initializes the weight and miles with the provided values.
        public ShippingChargesClass(double weight, int miles)
        {
            this.weight = weight;
            this.miles = miles;
        }
        // Property Weight that allows getting and setting the weight value.
        public double Weight 
        {
            get { return this.weight; }
            set { this.weight = value; }
        }
        // Property Miles that allows getting and setting the miles value.
        public double Miles
        {
            get { return this.miles; }
            set { this.miles = value; }
        }
        // Method getShippingCharges calculates the shipping charges based on the weight and distance.
        // It declares variables rate and milesTotal to store the calculated values.
        public double getShippingCharges()
        {
            double rate = 0;
            double milesTotal=Math.Ceiling(miles/500);
            
            if (weight <= 2)
            {
                rate = 1.10*milesTotal;
            }
            else if (weight > 2 && weight <= 6)
            {
                rate = 2.20 * milesTotal;
            }
            else if (weight > 6 && weight <= 10)
            {
                rate = 3.70 * milesTotal;
            }
            else if(weight>10) 
            {
                rate = 4.80 * milesTotal;
            }

            
                return rate;
        }

    }
}

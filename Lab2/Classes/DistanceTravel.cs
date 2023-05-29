//RAFAEL MELO 
//6217800

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS1
{
    internal class DistanceTravel
    {
        private int speed;
        private double hours;

        // Constructor for the DistanceTravel class. Initializes the speed and hours with the provided values.
        public DistanceTravel(int speed, double hours)
        {
            this.speed = speed;
            this.hours = hours;
        }
        // Property Speed that allows getting and setting the speed value.
        public int Speed 
        {
            get { return this.speed; }
            set { this.speed = value; }
        }
        // Property Hours that allows getting and setting the hours value.
        public double Hours
        {
            get { return this.hours; }
            set { this.hours = value; }
        }
        // Method getDistance calculates the distance traveled by multiplying the speed and hours values.
        // It returns the calculated distance as a double value.
        public double getDistance()
        { 
            return this.speed * this.hours;
        }
    }
}

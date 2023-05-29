//RAFAEL MELO 
//6217800
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class TestScores
    {
        private int score1;
        private int score2;
        private int score3;
        private double avg;
        private string letterGrade = "";

        // Constructor for the TestScores class. Initializes the score1, score2, and score3 with the provided values.
        // Calculates the average by summing the scores and dividing by 3.
        public TestScores(int score1, int score2, int score3)
        {
            this.score1 = score1;
            this.score2 = score2;
            this.score3 = score3;
            this.avg = (score1 + score2 + score3) / 3;
        }
        // Property Score1 that allows getting and setting the score1 value.
        public int Score1
        {
            get { return this.score1; }
            set { this.score1 = value; }
        }
        // Property Score2 that allows getting and setting the score2 value.
        public int Score2
        {
            get { return this.score2; }
            set { this.score2 = value; }
        }
        // Property Score3 that allows getting and setting the score3 value.
        public int Score3 
        {
            get { return this.score3; }
            set { this.score3 = value; }
        }
        // Method average returns the calculated average.
        public double average()
        {
            return avg;
        }
        // Method letter determines the letter grade based on the average score.
        // It assigns the corresponding letter grade to the letterGrade variable and returns it.
        public string letter()
        {
            
            if (avg >= 90 && avg <= 100)
            {
                letterGrade = "A";
            }
            else if (avg >= 80 && avg <= 89)
            {
                letterGrade = "B";
            }
            else if (avg >= 70 && avg <= 79)
            {
                letterGrade = "C";
            }
            else if (avg >= 60 && avg <= 69)
            {
                letterGrade = "D";
            }
            else if (avg < 60)
            {
                letterGrade = "F";
            }

            return "letter Grade:"+ letterGrade;
        }
        // Method getSummary returns a summary string that includes the average score and letter grade.
        public string getSummary()
        { 
            return "Score Avg: "+avg+" letter Grade: "+ letterGrade;
        }
      
    }

  
       
}

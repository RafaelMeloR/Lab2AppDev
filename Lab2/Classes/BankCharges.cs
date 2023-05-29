//RAFAEL MELO 
//6217800
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class BankCharges
    {
        private double balance;
        private static int checks=0;
        private readonly double chargeMonthly = 10;
        private readonly double chargeMonthlyifFall = 15;

        // Constructor for the BankCharges class. Initializes the balance with the value of deposit.
        public BankCharges(double deposit) 
        { 
            balance=deposit;
        }

        // Property Balance that allows getting and setting the balance value
        public double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        // Method writeCheck to simulate writing a check. It calls the withdraw method and increments the checks counter.
        public void writeCheck(double withdra)
        {
            withdraw(withdra);
            checks++;
        }

        // Method withdraw to subtract the withdraw amount from the balance.

        public void withdraw(double withdraw) 
        {
            balance = balance - withdraw;
        }

        // Method bankServiceFees calculates the fees based on the number of checks issued (checks) and the balance (balance).
        // The appropriate fee is determined based on the number of checks issued.
        // If the balance is less than 400, an additional monthly fee (chargeMonthlyifFall) is added.
        // The method returns a string with the account balance, checks issued, and total monthly fees.
        public string bankServiceFees() 
        {

            double feesPerChecks = 0;
            if (checks < 20)
            {
                feesPerChecks = checks*0.10;
            }
            else if (checks >= 20 && checks <= 39)
            {
                feesPerChecks = checks * 0.08;
            }
            else if (checks >= 40 && checks <= 59)
            {
                feesPerChecks = checks * 0.06;
            }
            else if (checks >=60)
            {
                feesPerChecks = checks * 0.04;
            }

            if (balance < 400)
            {
                return "Account Balance: "+balance+"\nChecks issued: "+checks+"\nTotal monthly fees: "+(feesPerChecks + chargeMonthly + chargeMonthlyifFall);
            }
            
                return "Account Balance: " + balance + "\nChecks issued: " + checks + "\nTotal monthly fees: " + (feesPerChecks + chargeMonthly);
            
        }
    }
}

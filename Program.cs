using System;

namespace InterestCalculator
{
    class Interest
    {
        public int InterestOverYear(int balance, DateTime date, float annualInterestRate)
        {
            int year = date.Year;
            int interestPeriod = year - DateTime.Now.Year;

            int monthlyInterestRate = (int)annualInterestRate / 12;

            int interestAccumulated = (monthlyInterestRate * balance) * interestPeriod;

            return interestAccumulated;
        }

        public int InterestOverMonths(int balance, int monthsPassed, float annualInterestRate)
        {
            int monthlyInterestRate = (int)annualInterestRate / 12;

            int monthlyInterestAccumluated = (monthlyInterestRate * balance) * monthsPassed;

            int interestPlusBalance = monthlyInterestAccumluated + balance;

            return interestPlusBalance;

        }




    }

    class Program
    {
        static void Main(string[] args)
        {
            Interest interestOverYear = new Interest();
            int showInterest = interestOverYear.InterestOverYear(2000, 1, 0.5f);
            Console.WriteLine(showInterest);
        }
    }
}

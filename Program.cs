using System;

namespace InterestCalculator
{
    class Interest
    {
        public float InterestOverYear(int balance, int yearOfInterest, float annualInterestRate)
        {
            int interestPeriod = yearOfInterest - DateTime.Now.Year;

            int monthlyInterestRate = (int)annualInterestRate / 12;

            int interestAccumulated = (monthlyInterestRate * balance) * interestPeriod;

            return (float)interestAccumulated;
        }

        public float InterestOverMonths(int balance, int monthsPassed, float annualInterestRate)
        {

            int interestPeriod = monthsPassed - DateTime.Now.Month;

            int monthlyInterestRate = (int)annualInterestRate / 12;

            int monthlyInterestAccumluated = (monthlyInterestRate * balance) * interestPeriod;

            return (float)monthlyInterestAccumluated;

        }


        class Program
        {
            static void Main(string[] args)
            {
                Interest interestOverYear = new Interest();
                float showInterest = interestOverYear.InterestOverYear(2000, 2008, 0.5f);
                Console.WriteLine(showInterest);
            }
        }
    }
}

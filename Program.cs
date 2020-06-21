using System;

namespace CheckLowAndHighRates
{
    class Program
    {
        static void Main()
        {
            const double LOW_RATE = 5.65;
            const double HIGH_RATE = 49.99;

            double hourlyRatePay;

            Console.Write("Enter the hourly rate of pay:");
            hourlyRatePay = Convert.ToDouble(Console.ReadLine());

            if (hourlyRatePay <= LOW_RATE)
                Console.WriteLine("Error: The rate of pay {0} is lower than {1}",
                    hourlyRatePay.ToString("C") ,LOW_RATE.ToString("C"));
            else if (hourlyRatePay >= HIGH_RATE)
                Console.WriteLine("Error: The rate of pay {0} is higher than {1}",
                    hourlyRatePay.ToString("C"), HIGH_RATE.ToString("C"));
            else
                Console.WriteLine("Rate of pay entered: {0}", hourlyRatePay.ToString("C"));
        }
    }
}

// Author: Michael Anderson

// First assignment calculates monthly payment 

using System;

namespace ContinentalUniversityHR
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatePayments();
        }

        static void CalculatePayments()
        {
            Console.WriteLine("Welcome to the Continental University Human Resource System!");

            // Input from the user
            Console.Write("Enter the Salary ($): ");
            double salary = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Retirement Contribution Rate (%): ");
            double retirementRate = Convert.ToDouble(Console.ReadLine()) / 100;

            Console.Write("Enter the TSA ($): ");
            double tsa = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Tax Withholding Rate (%): ");
            double taxWithholdingRate = Convert.ToDouble(Console.ReadLine()) / 100;

            Console.Write("Enter the Health Insurance Premium ($): ");
            double healthInsurance = Convert.ToDouble(Console.ReadLine());

            // Calculations
            double retirementContribution = salary * retirementRate;
            double taxableIncome = salary - retirementContribution - tsa - healthInsurance;
            double taxWithheld = taxableIncome * taxWithholdingRate;
            double netPay = taxableIncome - taxWithheld;

            // Output results
            Console.WriteLine($"\nRetirement:     ${retirementContribution:F2}");
            Console.WriteLine($"Taxable Income: ${taxableIncome:F2}");
            Console.WriteLine($"Tax Withheld:   ${taxWithheld:F2}");
            Console.WriteLine($"Net Pay:        ${netPay:F2}");
        }
    }
}

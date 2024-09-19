using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user for input
        Console.Write("Enter the estimated number of hours for the job: ");
        double hours = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the estimated number of miles involved in the move: ");
        double miles = Convert.ToDouble(Console.ReadLine());

        // Calculate the total moving fee
        double baseRate = 200;
        double hourlyRate = 150;
        double mileageRate = 2;

        double totalFee = baseRate + (hourlyRate * hours) + (mileageRate * miles);

        // Display the results
        Console.WriteLine($"Total moving fee: ${totalFee:F2}");
    }
}
using System;

namespace BMICalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the BMI Calculator!");

            bool continueCalculating = true;

            Console.WriteLine("\n----------------------------------------\n");

            while (continueCalculating)
            {
                // Prompt for weight
                Console.Write("Enter your weight in kilograms (e.g., 70,5): ");
                double weightKg = Convert.ToDouble(Console.ReadLine());

                // Prompt for height
                Console.Write("Enter your height in meters (e.g., 1,75): ");
                double heightMeters = Convert.ToDouble(Console.ReadLine());

                // Calculate BMI
                double bmi = weightKg / (heightMeters * heightMeters);

                Console.WriteLine($"Your BMI is: {bmi:F2}");

                // Interpretation
                if (bmi < 18.5)
                    Console.WriteLine("You are underweight.");
                else if (bmi >= 18.5 && bmi < 24.9)
                    Console.WriteLine("You are in the normal weight range.");
                else if (bmi >= 25 && bmi < 29.9)
                    Console.WriteLine("You are overweight.");
                else
                    Console.WriteLine("You are obese.");

                Console.WriteLine("\n----------------------------------------\n");

                // Ask if the user wants to continue
                Console.Write("Do you want to calculate another BMI? (yes/no): ");
                string response = Console.ReadLine().ToLower();

                Console.WriteLine("\n----------------------------------------\n");

                continueCalculating = (response == "yes" || response == "y");
            }

            Console.WriteLine("Thank you for using the BMI Calculator!");
        }
    }
}

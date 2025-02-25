namespace RepetitionWork
{
    internal class Program
    {
        static void Main(string[] args)


        {

            // Opgave 1 - Studie-info
            
            {


                Console.WriteLine("Are you a student? (yes/no):");
                string studentInput = Console.ReadLine();
                bool isStudent = studentInput == "yes";

                Console.WriteLine("Your Age:");
                int age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Your Height:");
                double height = double.Parse(Console.ReadLine());

                Console.WriteLine("Your Weight:");
                float weight = float.Parse(Console.ReadLine());

                Console.WriteLine("Your name:");
                string name = Console.ReadLine();
                char initial = name[0];

                Console.Clear();
                Console.WriteLine($"Age: {age}, Height: {height}, Initial {initial}, Name: {name}, Is Student: {isStudent}");

            }


            // Opgave 2 - Temperatur
            
                        {

                            Console.Clear();
                            Console.WriteLine("Temperature Converter");
                            Console.WriteLine("1. Celsius to Fahrenheit");
                            Console.WriteLine("2. Fahrenheit to Celsius");
                            Console.Write("Choose an option: ");
                            string tempchoice = Console.ReadLine();

                            if (tempchoice == "1")
                            {
                                Console.Clear();
                                Console.WriteLine("You have chosen Celcius to Fahrenheit\n Write the temperature in Celcius");
                                int celcius = Convert.ToInt32(Console.ReadLine());


                                int CtoF = celcius * (9 / 5) + 32;
                                Console.WriteLine($"{celcius}°C is equal to {CtoF}");
                            }



                            else if (tempchoice == "2")
                            {
                                Console.Clear();
                                Console.Write("You have chosen Fahrenheit to Celcius\n Write the temperature in Fahrenheit");
                                int fahrenheit = Convert.ToInt32(Console.ReadLine());


                                int FtoC = (fahrenheit - 32) * 5 / 9;
                                Console.WriteLine($"{fahrenheit} is equal to {FtoC}°C");

                            }

                        z
                            else
                            {
                                Console.Write("Invalid input. Please enter a valid number.");
                            }
                        }

            
            // Opgave 3 - BMI
            
                        Console.WriteLine("You've selected the BMI-calculator.");

                        Console.WriteLine("Your Height (in meters): ");
                        double height = double.Parse(Console.ReadLine());

                        Console.WriteLine("Your Weight (in kg): ");
                        float weight = float.Parse(Console.ReadLine());

                        double bmi = weight / (height * height);

                        if (bmi < 18.5)
                            Console.WriteLine($"Your bmi is {bmi} which puts you in the Underweight category.");

                        if (bmi < 24.9 && bmi > 18.5)
                            Console.WriteLine($"Your bmi is {bmi} which puts you in the Normal Weight category.");

                        if (bmi < 29.9 && bmi > 24.9)
                            Console.WriteLine($"Your bmi is {bmi} which puts you in the Overweight category.");

                        if (bmi > 29.9)
                            Console.WriteLine($"Your bmi is {bmi} which puts you in the Obese category.");
           

            // Opgave 3 - BMI

        }
    }
}

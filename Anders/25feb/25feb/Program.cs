using System.Runtime.ExceptionServices;

namespace _25feb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("==== Hovedmenu ====");
                Console.WriteLine("1. Hovedmenu 1:  Variable and data structures");
                Console.WriteLine("2. Hovedmenu 2: Control Structure");
                Console.WriteLine("3. Hovedmenu 3: Functions and methods");
                Console.WriteLine("4. Afslut programmet");
                Console.Write("Vælg en hovedmenu (1-4): ");

                int mainMenuInput;
                bool isValidMainInput = int.TryParse(Console.ReadLine(), out mainMenuInput);

                if (isValidMainInput)
                {
                    switch (mainMenuInput)
                    {
                        case 1:
                            Hovedmenu1();
                            break;
                        case 2:
                            Hovedmenu2();
                            break;
                        case 3:
                            Hovedmenu3();
                            break;
                        case 4:
                            running = false; // Afslut programmet
                            break;
                        default:
                            Console.WriteLine("Ugyldigt input! Indtast et tal mellem 1-4.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Ugyldigt input! Indtast et tal mellem 1-4.");
                }

                Console.WriteLine("\nTryk på en tast for at fortsætte...");
                Console.ReadLine();
            }
        }

        // Hovedmenu 1 med underopgaver
        static void Hovedmenu1()
        {
            Console.Clear();
            Console.WriteLine("==== Hovedmenu 1 ====");
            Console.WriteLine("1. Opgave 1.1");
            Console.WriteLine("2. Opgave 1.2");
            Console.WriteLine("3. Opgave 1.3");
            Console.WriteLine("4. Opgave 1.4");
            Console.WriteLine("5. Opgave 1.5");
            Console.WriteLine("6. Opgave 1.6");
            Console.WriteLine("7. Tilbage til hovedmenu!");
            Console.Write("Vælg en opgave (1-7): ");

            int subInput;
            bool isValidSubInput = int.TryParse(Console.ReadLine(), out subInput);

            if (isValidSubInput)
            {
                switch (subInput)
                {
                    case 1:
                        Console.WriteLine("Du valgte: Opgave 1.1");
                        Opgave1_1();
                        break;
                    case 2:
                        Console.WriteLine("Du valgte: Opgave 1.2");
                        Opgave1_2();
                        break;
                    case 3:
                        Console.WriteLine("Du valgte: Opgave 1.3");
                        Opgave1_3();
                        break;
                    case 4:
                        Console.WriteLine("Du valgte: Opgave 1.4");
                        Opgave1_4();
                        break;
                    case 5:
                        Console.WriteLine("Du valgte: Opgave 1.5");
                        Opgave1_5();
                        break;
                    case 6:
                        Console.WriteLine("Du valgte: Opgave 1.6");
                        Opgave1_6();
                        break;
                    case 7:
                        // Tilbage til hovedmenu
                        break;
                    default:
                        Console.WriteLine("Ugyldigt input! Indtast et tal mellem 1-7.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Ugyldigt input!");
            }
        }

        // Hovedmenu 2 med underopgaver
        static void Hovedmenu2()
        {
            Console.Clear();
            Console.WriteLine("==== Hovedmenu 2 ====");
            Console.WriteLine("1. Opgave 2.7");
            Console.WriteLine("2. Opgave 2.8");
            Console.WriteLine("3. Opgave 2.9");
            Console.WriteLine("4. Opgave 2.10");
            Console.WriteLine("5. Opgave 2.11");
            Console.WriteLine("6. Opgave 2.12");
            Console.WriteLine("7. Opgave 2.13");
            Console.WriteLine("8. Opgave 2.14");
            Console.WriteLine("9. Opgave 2.15");
            Console.WriteLine("10. Opgave 2.16");
            Console.WriteLine("11. Tilbage til hovedmenu");
            Console.Write("Vælg en opgave (1-11): ");

            int subInput;
            bool isValidSubInput = int.TryParse(Console.ReadLine(), out subInput);

            if (isValidSubInput)
            {
                switch (subInput)
                {
                    case 1:
                        Console.WriteLine("Du valgte: Opgave 2.1");
                        Opgave2_1();
                        break;
                    case 2:
                        Console.WriteLine("Du valgte: Opgave 2.2");
                        Opgave2_2();
                        break;
                    case 3:
                        Console.WriteLine("Du valgte: Opgave 2.3");
                        Opgave2_3();
                        break;
                    case 4:
                        Console.WriteLine("Du valgte: Opgave 2.4");
                        Opgave2_4();
                        break;
                    case 5:
                        Console.WriteLine("Du valgte: Opgave 2.5");
                        Opgave2_5();
                        break;
                    case 6:
                        Console.WriteLine("Du valgte: Opgave 2.6");
                        Opgave2_6();
                        break;
                    case 7:
                        Console.WriteLine("Du valgte: Opgave 2.7");
                        Opgave2_7();
                        break;
                    case 8:
                        Console.WriteLine("Du valgte: Opgave 2.8");
                        Opgave2_8();
                        break;
                    case 9:
                        Console.WriteLine("Du valgte: Opgave 2.9");
                        Opgave2_9();
                        break;
                    case 10:
                        Console.WriteLine("Du valgte: Opgave 2.10");
                        Opgave2_10();
                        break;
                    default:
                        Console.WriteLine("Ugyldigt input! Indtast et tal mellem 1-4.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Ugyldigt input!");
            }
        }

        // Hovedmenu 3 med underopgaver
        static void Hovedmenu3()
        {
            Console.Clear();
            Console.WriteLine("==== Hovedmenu 3 ====");
            Console.WriteLine("1. Opgave 3.17");
            Console.WriteLine("2. Opgave 3.18");
            Console.WriteLine("3. Opgave 3.19");
            Console.WriteLine("4. Opgave 3.20");
            Console.WriteLine("5. Opgave 3.21");
            Console.WriteLine("6. Opgave 3.22");
            Console.WriteLine("7. Tilbage til hovedmenu");
            Console.Write("Vælg en opgave (1-7): ");

            int subInput;
            bool isValidSubInput = int.TryParse(Console.ReadLine(), out subInput);

            if (isValidSubInput)
            {
                switch (subInput)
                {
                    case 1:
                        Console.WriteLine("Du valgte: Opgave 3.1");
                        Opgave3_1();
                        break;
                    case 2:
                        Console.WriteLine("Du valgte: Opgave 3.2");
                        Opgave3_2();
                        break;
                    case 3:
                        Console.WriteLine("Du valgte: Opgave 3.3");
                        Opgave3_3();
                        break;
                    case 4:
                        // Tilbage til hovedmenu
                        break;
                    default:
                        Console.WriteLine("Ugyldigt input! Indtast et tal mellem 1-4.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Ugyldigt input!");
            }
        }

        // Metoder til opgaver under Hovedmenu 1
        static void Opgave1_1()
        {
            Console.WriteLine("Udskriver Opgave 1.1");
            // Opgave 1
            int age = 25;
            double height = 1.75;
            double weight = 70.5;
            char initial = 'A';
            string name = "Alice";
            bool student = true;
            Console.WriteLine($"Age: {age}, height: {height}, Weight: {weight}, Initial: {initial}, Name: {name}, Is Student: {student}");
        }

        static void Opgave1_2()
        {
            Console.WriteLine("Udskriver Opgave 1.2");
            // Opgave 2
            Console.WriteLine("Skriver du Celcius eller Fahrenheit? (C/F)");
            string c_f = Console.ReadLine();
            Console.WriteLine("Hvad vil du konvertere?");
            double grader = Convert.ToDouble(Console.ReadLine());
            double konverteret;
            if (c_f == "C")
            {
                konverteret = grader * 1.8 + 32;
                Console.WriteLine($"{grader}°{c_f} er {konverteret}°F");
            }
            else
            {
                konverteret = (grader - 32) / 1.8;
                Console.WriteLine($"{grader}°{c_f} er {konverteret}°C");
            }
        }

        static void Opgave1_3()
        {
            Console.WriteLine("Udskriver Opgave 1.3");
            Console.Write("Hvad er din vægt?");
            double vægt = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hvad er din højde?");
            double højde = Convert.ToDouble(Console.ReadLine());
            double bmi = (vægt / (højde * højde)*10000);
            if (bmi < 18.5) {
                Console.WriteLine("Undervægtig");
            }
            else if (bmi > 18.5 && bmi <= 24.9)
            {
                Console.WriteLine("Normalvægtig");
            }
            else if (bmi >= 25 && bmi <= 29.9)
            {
                Console.WriteLine("Overvægtig");
            }
            else if (bmi >= 30)
            {
                Console.WriteLine("Du er fandme FED!");
            }
        }


        static void Opgave1_4()
        {
            int sum = 10 + 5;
            int difference = 10 - 5;
            int product = 10 * 5;
            int quotient = 4 / 2;
            int remainder = 1 % 2;
            Console.WriteLine($"Sum: {sum}, Difference: {difference}, Product: {product}, Quotient: {quotient}, Remainder: {remainder}");
        }

        static void Opgave1_5()
        {
            double radius = Convert.ToDouble(Console.ReadLine());
            double areal = Math.PI * (radius * radius);
            double omkreds = 2 * Math.PI * radius;
            Console.WriteLine($"Areal: {areal}, omkreds: {omkreds}");
        }

        static void Opgave1_6()
        {
            Console.Write("Skriv første tal: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Skriv andet tal: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Is Equal: {a == b}, Is Not Equal: {a != b}, Is Greater: {a > b}, Is Less: {a < b}, Is Greater Or Equal: {a >= b}, Is Less Or Equal: {a <= b}");
        }


        // Metoder til opgaver under Hovedmenu 2
        static void Opgave2_1()
        {
            Console.WriteLine("Udskriver Opgave 2.1");
            Console.Write("Skriv et tal: ");
            int number = int.Parse(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine("Tallet er positivt.");
            }
            else if (number < 0)
            {
                Console.WriteLine("Tallet er negativt.");
            }
            else
            {
                Console.WriteLine("Tallet er nul.");
            }

            Console.Write("Indtast et årstal: ");
            int year = int.Parse(Console.ReadLine());

            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
            {
                Console.WriteLine($"{year} er et skudår.");
            }
            else
            {
                Console.WriteLine($"{year} er IKKE et skudår.");
            }
        }

        static void Opgave2_2()
        {
            Console.WriteLine("Udskriver Opgave 2.2");
            Console.Write("Indtast en karakter (A, B, C, D, F");
            char grade = char.ToUpper(Console.ReadKey().KeyChar);
            if (grade == 'A' || grade == 'B' || grade == 'C' || grade == 'D')
            {
                Console.WriteLine("Bestået.");
            }
            else if (grade == 'F')
            {
                Console.WriteLine("DU HAR DUMPET!!");
            }
            else
            {
                Console.WriteLine("Ugyldig karakter.");
            }
        }

        static void Opgave2_3()
        {
            Console.WriteLine("Henviser til opgave 2_1");
            Opgave2_1();
            // Implementer opgave 2.3 her
        }

        static void Opgave2_4()
        {
            Console.Write("Indtast et tal mellem 1-7: ");
            int dagNr = int.Parse(Console.ReadLine());

            switch (dagNr)
            {
                case 1:
                    Console.WriteLine("Mandag");
                    break;
                case 2:
                    Console.WriteLine("Tirsdag");
                    break;
                case 3:
                    Console.WriteLine("Onsdag");
                    break;
                case 4:
                    Console.WriteLine("Torsdag");
                    break;
                case 5:
                    Console.WriteLine("Fredag");
                    break;
                case 6:
                    Console.WriteLine("Lørdag");
                    break;
                case 7:
                    Console.WriteLine("Søndag");
                    break;
                default:
                    Console.WriteLine("Ugyldigt input!");
                    break;
            }
        }

        static void Opgave2_5()
        {
            Console.Write("Indtast et tal mellem 1-12: ");
            int månedNr = int.Parse(Console.ReadLine());

            switch (månedNr)
            {
                case 1:
                    Console.WriteLine("Januar");
                    break;
                case 2:
                    Console.WriteLine("Februar");
                    break;
                case 3:
                    Console.WriteLine("Marts");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("Maj");
                    break;
                case 6:
                    Console.WriteLine("Juni");
                    break;
                case 7:
                    Console.WriteLine("Juli");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("Oktober");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;
                default:
                    Console.WriteLine("Ugyldigt input!");
                    break;
            }
        }

        static void Opgave2_6()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(+i);
            }
        }

        static void Opgave2_7()
        {
            int i = 0;
            while (i <= 10)
            {
                Console.WriteLine(+i);
                i++;
            }
        }

        static void Opgave2_8()
        {
            int i = 0;
            do
            {
                Console.WriteLine(+i);
                i++;
            } while (i <= 10);
        }

        static void Opgave2_9()
        {
            Console.WriteLine("Vælg et tal, hvor vi beregner summen af alle tal op til det valgte tal: ");
            int i = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (i > 0)
            {
                sum = sum + i;
                i--;
            }
            Console.WriteLine($"Summen af alle tal op til {i}: {sum}");
        }

        static void Opgave2_10()
        {
            Console.WriteLine("Vælg et tal, hvor vi beregner beregner fakultet af det tal: ");
            int tal = Convert.ToInt32(Console.ReadLine());
            int faktorial = 1;

            for (int i = 1; i <= tal; i++)
            {
                faktorial = faktorial * i;
            }
            Console.WriteLine($"Faktoriale tal er: {faktorial}");
        }

        // Metoder til opgaver under Hovedmenu 3
        static void Opgave3_1()
        {
            Console.WriteLine("Udskriver Opgave 3.1");
            // Implementer opgave 3.1 her
        }

        static void Opgave3_2()
        {
            Console.WriteLine("Udskriver Opgave 3.2");
            // Implementer opgave 3.2 her
        }

        static void Opgave3_3()
        {
            Console.WriteLine("Udskriver Opgave 3.3");
            // Implementer opgave 3.3 her
        }
    }
}



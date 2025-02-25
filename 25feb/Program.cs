using System;

class Program

{


    static void Main(string[] args)

    {

    CreateMenu();
    int.TryParse(Console.ReadLine(), out int valg);

    switch(valg)
    {
        case 1:
        VariableAndDataStructures();
        break;

        case 2:
        ControlStructure();
        break;

        case 3:
        FunctionsAndMethods();
        break;

        case 0:
        Environment.Exit(0);
        break;

        default:
        Console.WriteLine("DER FINDES IKKE EN SKID HER");
        break;
    }



    }

    static void CreateMenu()
    {
        
        // Overmenu opgave emnerne i menuen med tilhørende tal til undermenuerne over menu 1, variable og datatyper (1-6 opgaver) overmenu 2 kontrolstruktur (7-16) overmenu 3 funktioner og 
        // metoder 17-22 
        Console.WriteLine("Vælg en opgave"); 
        Console.WriteLine("1. Variable og datatyper");
        Console.WriteLine("2. Kontrolstruktur");
        Console.WriteLine("3. Funktioner og metoder");
        Console.WriteLine("0. Exit");

    }


  static void VariableAndDataStructures() {
    while (true) {
        Console.WriteLine("Vælg en opgave");
        Console.WriteLine("1. Opgave 1");
        Console.WriteLine("2. Opgave 2");
        Console.WriteLine("3. Opgave 3");
        Console.WriteLine("4. Opgave 4");
        Console.WriteLine("5. Opgave 5");
        Console.WriteLine("6. Opgave 6");
        Console.WriteLine("0. Tilbage");

        int.TryParse(Console.ReadLine(), out int valgopg1);

        switch (valgopg1) {
            case 1:
                int age = 25;
                float height = 1.75f; // Tilføj 'f' for at angive float
                double weight = 70.5;
                string name = "Alice";
                bool isStudent = true;
                char initials = name.Substring(0, 1)[0];
                Console.WriteLine($"Navn er {name}, initialer {initials},  alder er {age}, højde er {height}, vægt er {weight}, hun er studerende {isStudent}");
                break;

            case 2:
                Console.WriteLine("1. Celsius til Fahrenheit");
                Console.WriteLine("2. Fahrenheit til Celsius");
                int tempValg = int.Parse(Console.ReadLine());
                if (tempValg == 1) {
                    Console.WriteLine("Indtast en temperatur i Celsius:");
                    double celsius = double.Parse(Console.ReadLine());
                    double fahrenheit = (celsius * 9.0 / 5.0) + 32;
                    Console.WriteLine($"Temperaturen i Fahrenheit er {fahrenheit}");
                } else if (tempValg == 2) {
                    Console.WriteLine("Indtast en temperatur i Fahrenheit:");
                    double fahrenheit = double.Parse(Console.ReadLine());
                    double celsius = (fahrenheit - 32) * 5.0 / 9.0;
                    Console.WriteLine($"Temperaturen i Celsius er {celsius}");
                }
                break;

            case 3:
                Console.WriteLine("Indtast din vægt i kg:");
                double w = double.Parse(Console.ReadLine());
                Console.WriteLine("Indtast din højde i meter: fx 1,80");
                double h = double.Parse(Console.ReadLine());
                double bmi = w / (h * h);
                Console.WriteLine($"Din BMI er {bmi}");
                break;

            case 4:
                //Brug de aritmetiske operatører til at udføre grundlæggende matematiske operationer. Udskriv resultaterne.
                int a = 10;
                int b = 20;
                Console.WriteLine("A og B er 10 og 20");
                Console.WriteLine($"a + b = {a + b}");
                Console.WriteLine($"a - b = {a - b}");
                Console.WriteLine($"a * b = {a * b}");
                Console.WriteLine($"a / b = {a / b}");
                Console.WriteLine($"a % b = {a % b}");
                break;

            case 5:
                //Skriv et program, der beregner arealet og omkredsen af en cirkel baseret på en given radius. Brug aritmetiske operatører.
                Console.WriteLine("Indtast radius af cirklen:");
                double radius = double.Parse(Console.ReadLine());
                double area = Math.PI * radius * radius;
                double circumference = 2 * Math.PI * radius;
                Console.WriteLine($"Arealet af cirklen er {area}");
                Console.WriteLine($"Omkredsen af cirklen er {circumference}");
                break;

            case 6:
                //Brug logiske og sammenligningsoperatører til at evaluere udtryk og udskriv resultaterne.
                int x = 10;
                int y = 20;
                Console.WriteLine($"x == y: {x == y}");
                Console.WriteLine($"x != y: {x != y}");
                Console.WriteLine($"x > y: {x > y}");
                Console.WriteLine($"x < y: {x < y}");
                break;
            case 0:
                return; // Gå tilbage til hovedmenuen
            default:
                Console.WriteLine("Der findes ikke en skid her");
                break;
        }
    }
}

    static void ControlStructure() {
        while (true) {
            Console.WriteLine("Vælg en opgave");
            Console.WriteLine("7. Opgave 7");
            Console.WriteLine("8. Opgave 8");
            Console.WriteLine("9. Opgave 9");
            Console.WriteLine("10. Opgave 10");
            Console.WriteLine("11. Opgave 11");
            Console.WriteLine("12. Opgave 12");
            Console.WriteLine("13. Opgave 13");
            Console.WriteLine("14. Opgave 14");
            Console.WriteLine("15. Opgave 15");
            Console.WriteLine("16. Opgave 16");
            Console.WriteLine("0. Tilbage");

            int.TryParse(Console.ReadLine(), out int valgopg2);

            switch (valgopg2) {
                case 7:
                //Skriv et program, der tjekker om et tal er positivt, negativt eller nul ved hjælp af et if-else udsagn.
                Console.WriteLine("Indtast et tal:");
                int num = int.Parse(Console.ReadLine());
                if (num > 0) {
                    Console.WriteLine("Tallet er positivt");
                } else if (num < 0) {
                    Console.WriteLine("Tallet er negativt");
                } else {
                    Console.WriteLine("Tallet er nul");
                }

                break;
                case 8:
                //Skriv et program, der ved hjælp af metoder kontrollerer om en given karakter (A, B, C, D, F) er bestået eller ikke bestået.
                Console.WriteLine("Indtast karakter:");
                char grade = char.Parse(Console.ReadLine());
                if(grade == 'A' || grade == 'B' || grade == 'C' || grade == 'D') {
                    Console.WriteLine("Bestået");
                } else if(grade == 'F') {
                    Console.WriteLine("Ikke bestået");
                } else {
                    Console.WriteLine("Ugyldig karakter");
                }
                break;
                case 9:
                Console.WriteLine("Indtast et år:");
                int year = int.Parse(Console.ReadLine());

                Console.WriteLine($"Tjekker om {year} er et skudår...\n");

                // Tjekker om året kan deles med 4
                Console.WriteLine($"{year} % 4 = {year % 4}  → {(year % 4 == 0 ? "Kan deles med 4 " : "Kan ikke deles med 4")}");
                    
                // Tjekker om året kan deles med 100
                Console.WriteLine($"{year} % 100 = {year % 100}  → {(year % 100 == 0 ? "Kan deles med 100" : "Kan ikke deles med 100")}");

                // Tjekker om året kan deles med 400
                Console.WriteLine($"{year} % 400 = {year % 400}  → {(year % 400 == 0 ? "Kan deles med 400" : "Kan ikke deles med 400")}");

                if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                {
                    Console.WriteLine($"{year} er et skudår");
                }
                else
                {
                    Console.WriteLine($"{year} er IKKE et skudår.");
                }

                break;
                case 10:
                //Skriv et program, der udskriver navnet på en ugedag baseret på et tal (1-7) ved hjælp af switch-case udsagn.
                Console.WriteLine("Indtast et tal mellem 1-7:");
                int day = int.Parse(Console.ReadLine());
                switch (day) {
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
                        Console.WriteLine("Ugyldigt tal");
                        break;
                }
                break;
                case 11:
                    Console.WriteLine("Indtast et tal mellem 1-12:");
                int month = int.Parse(Console.ReadLine());
                switch (month) {
                    case 1:
                        Console.WriteLine("Januar: Årets første måned, ofte kold og med sne i mange lande. Navnet kommer fra den romerske gud Janus, der havde to ansigter – et der så fremad, og et der så tilbage.");
                        break;
                    case 2:
                        Console.WriteLine("Februar: Den korteste måned, kendt for fastelavn og valentinsdag. Navnet kommer fra det latinske ord februa, der betyder renselse.");
                        break;
                    case 3:
                        Console.WriteLine("Marts: Forårets komme begynder så småt. Navnet kommer fra den romerske krigsgud Mars.");
                        break;
                    case 4:
                        Console.WriteLine("April: Kendt for påske og for at være en måned med omskifteligt vejr. Navnet kommer fra det latinske ord aperire, der betyder at åbne (blomsterne springer ud).");
                        break;
                    case 5:
                        Console.WriteLine("Maj: Foråret er i fuld gang, og naturen blomstrer. Navnet kommer fra den romerske gudinde Maia.");
                        break;
                    case 6:
                        Console.WriteLine("Juni: Sommerens begyndelse, ofte med varmt vejr og lange dage. Navnet kommer fra den romerske gudinde Juno.");
                        break;
                    case 7:
                        Console.WriteLine("Juli: Højsommer, mange holder ferie. Navnet kommer fra Julius Cæsar.");
                        break;
                    case 8:
                        Console.WriteLine("August: Stadig sommer, men dagene begynder at blive kortere. Navnet kommer fra kejser Augustus.");
                        break;
                    case 9:
                        Console.WriteLine("September: Efterårets begyndelse, bladene begynder at skifte farve. Navnet kommer fra det latinske ord septem, der betyder syv (september var den syvende måned i den gamle romerske kalender).");
                        break;
                    case 10:
                        Console.WriteLine("Oktober: Efteråret er i fuld gang, og det kan være blæsende og regnfuldt. Navnet kommer fra det latinske ord octo, der betyder otte.");
                        break;
                    case 11:
                        Console.WriteLine("November: En mørk og ofte trist måned, hvor mange tænker på de døde. Navnet kommer fra det latinske ord novem, der betyder ni.");
                        break;
                    case 12:
                        Console.WriteLine("December: Årets sidste måned, kendt for jul og nytår. Navnet kommer fra det latinske ord decem, der betyder ti.");
                        break;
                    default:
                        Console.WriteLine("Ugyldigt tal");
                        break;
                }
                break;
                case 12:
                //Skriv et program, der udskriver tallene fra 1 til 10 ved hjælp af en for-løkke.

                Console.WriteLine("Udskriver tallene 1-10 ved hjælp af et forloop:");
                for (int i = 1; i <= 10; i++) {
                    Console.WriteLine(i);
                }  
                break;
                case 13:
                //Skriv et program, der udskriver tallene fra 1 til 10 ved hjælp af en while-løkke.
                Console.WriteLine("Udskriver tallene 1-10 ved hjælp af et whileloop:");
                int j = 1;
                while (j <= 10) {
                    Console.WriteLine(j);
                    j++;
                }
                break;
                case 14:
                   //Skriv et program, der udskriver tallene fra 1 til 10 ved hjælp af en while-løkke.
                Console.WriteLine("Udskriver tallene 1-10 ved hjælp af et dowhileloop:");
                int k = 1;
                do {
                    Console.WriteLine(k);
                    k++;
                } while (k <= 10);
                break;
                case 15:
                // Skriv et program der beregner summen af alle tal til og med et givent tal.
                Console.WriteLine("Indtast et tal:");
                int n = int.Parse(Console.ReadLine());
                int sum = 0;
                for(int i = 0; i <= n; i++) {
                    sum += i;
                }
                Console.WriteLine($"Summen af alle tal til og med {n} er {sum}");
                break;
    
                case 16:
                // Skriv et program, der beregner fakultet af et tal ved hjælp af en for-løkke.
                Console.WriteLine("Indtast et tal:");
                int num2 = int.Parse(Console.ReadLine());
                int factorial = 1;
                for(int i = 1; i <= num2; i++) {
                    factorial *= i;
                }
                Console.WriteLine($"Fakultet af {num2} er {factorial}");
                break;
                case 0:
                return; // Gå tilbage til hovedmenuen
                default:
                Console.WriteLine("Der findes ikke en skid her");
                break;

            }

        }

    }

    static void FunctionsAndMethods() {
        while (true) {
            Console.WriteLine("Vælg en opgave");
            Console.WriteLine("17. Opgave 17");
            Console.WriteLine("18. Opgave 18");
            Console.WriteLine("19. Opgave 19");
            Console.WriteLine("20. Opgave 20");
            Console.WriteLine("21. Opgave 21");
            Console.WriteLine("22. Opgave 22");
            Console.WriteLine("0. Tilbage");

            int.TryParse(Console.ReadLine(), out int valgopg3);

            switch (valgopg3) {
                case 17:
                //Skriv en metode, der tager to tal som parametre og returnerer deres sum. Kald metoden og udskriv resultatet.
                Console.WriteLine("Indtast to tal:");
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int sum = calculateSum(a, b);
                Console.WriteLine($"Summen af {a} og {b} er {sum}");
                break;
                case 18:
                Console.WriteLine("Indtast en streng:");
                string str = Console.ReadLine();
                string reversed = returnStringReversed(str);
                Console.WriteLine($"Den omvendte streng er {reversed}");
                break;
                case 19:
                Console.WriteLine("Indtast en streng:");
                string str2 = Console.ReadLine();
                string vocals = returnVocalsInString(str2);
                Console.WriteLine($"Vokalerne i strengen er {vocals}");
                break;
                case 20:
                //Skriv overloadede metoder, der beregner arealet af en firkant og en cirkel. Kald metoderne og udskriv resultaterne.
                Console.WriteLine("1. Firkant");
                Console.WriteLine("2. Cirkel");
                int choice1 = int.Parse(Console.ReadLine());
                switch (choice1) {
                    case 1:
                        Console.WriteLine("Indtast længde af firkanten:");
                        double l_f = double.Parse(Console.ReadLine());
                        Console.WriteLine("Indtast bredden af firkanten:");
                        double w_f = double.Parse(Console.ReadLine());
                        double areaRectangle = calculateArea(l_f, w_f);
                        Console.WriteLine($"Arealet af firkanten er {areaRectangle}");
                        break;
                    case 2:
                        Console.WriteLine("Indtast radius af cirklen:");
                        double r_c = double.Parse(Console.ReadLine());
                        double areaCircle = calculateArea(r_c);
                        Console.WriteLine($"Arealet af cirklen er {areaCircle}");
                        break;
                    default:
                        Console.WriteLine("Ugyldigt valg");
                        break;
                }
                break;
                case 21:
                //Skriv overloadede metoder, der beregner volumen af en kube og en cylinder. Kald metoderne og udskriv resultaterne.
                Console.WriteLine("1. Kube");
                Console.WriteLine("2. Cylinder");
                int choice2 = int.Parse(Console.ReadLine());
                switch (choice2) {
                    case 1:
                        Console.WriteLine("Indtast længde af kuben:");
                        double l_k = double.Parse(Console.ReadLine());
                        Console.WriteLine("Indtast højden af kuben:");
                        double h_k = double.Parse(Console.ReadLine());
                        Console.WriteLine("Indtast bredden af kuben:");
                        double b_k = double.Parse(Console.ReadLine());
                        double volumeCube = calculateVolume(l_k, h_k, b_k);
                        Console.WriteLine($"Volumen af kuben er {volumeCube}");
                        break;
                    case 2:
                        Console.WriteLine("Indtast radius af cylinderen:");
                        double r_c = double.Parse(Console.ReadLine());
                        Console.WriteLine("Indtast højden af cylinderen:");
                        double h_c = double.Parse(Console.ReadLine());
                        double volumeCylinder = calculateVolume(r_c, h_c);
                        Console.WriteLine($"Volumen af cylinderen er {volumeCylinder}");
                        break;
                    default:
                        Console.WriteLine("Ugyldigt valg");
                        break;
                }

                break;
                case 22:
                //Skriv overloadede metoder, der beregner arealet af en trekant og en rektangel. Kald metoderne og udskriv resultaterne.
                Console.WriteLine("1. Trekant");
                Console.WriteLine("2. Rektangel");
                int choice3 = int.Parse(Console.ReadLine());
                switch (choice3) {
                    case 1:
                        Console.WriteLine("Indtast højden af trekanten:");
                        double h_t = double.Parse(Console.ReadLine());
                        Console.WriteLine("Indtast basen af trekanten:");
                        double b_t = double.Parse(Console.ReadLine());
                        double areaTriangle = calculateArea2(h_t, b_t, "trekant");
                        // Skriv som et decimal tal med 2 decimaler
                        Console.WriteLine($"Arealet af trekanten er {areaTriangle}");
                        break;
                    case 2:
                        Console.WriteLine("Indtast længden af rektanglet:");
                        double l_r = double.Parse(Console.ReadLine());
                        Console.WriteLine("Indtast bredden af rektanglet:");
                        double w_r = double.Parse(Console.ReadLine());
                        double areaRectangle = calculateArea2(l_r, w_r, "rektangel");
                        Console.WriteLine($"Arealet af rektanglet er {areaRectangle}");
                        break;
                    default:
                        Console.WriteLine("Ugyldigt valg");
                        break;
                }
                break;
                case 0:
                return; // Gå tilbage til hovedmenuen
                default:
                Console.WriteLine("Der findes ikke en skid her");
                break;

            }

        }
    }

    static int calculateSum(int a, int b) {
        return a + b;
    }

    static string returnStringReversed(string str) {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);

        // kan alternativt laves med et forloop lidt som vi så sidst
        // string reversed = "";
        // for(int i = str.Length - 1; i >= 0; i--) {
        //     reversed += str[i];
        // }
    }

    static string returnVocalsInString(string str) {
      
      string vocals = "aeiouyæøå";
      string result = "";
      for ( int i = 0; i < str.Length; i++) {
        if(vocals.Contains(str[i].ToString().ToLower())) {
          result += str[i];
    
        }
      }
      return result;

    }

    static double calculateArea(double length, double width) {
        return length * width;
    }

    static double calculateArea(double radius) {
        return Math.PI * Math.Pow(radius, 2);
    }

   static double calculateArea2(double a, double b, string type) {
    if (type == "trekant")
        return (a * b) / 2;
    else if (type == "rektangel")
        return a * b;
    else
        throw new ArgumentException("Ugyldig figur");
    
    }
    static double calculateVolume(double length, double width, double height) {
        return length * width * height;
    }

    static double calculateVolume(double radius, double height) {
        return Math.PI * Math.Pow(radius, 2) * height;
    }


}

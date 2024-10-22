namespace undervisning_22._10;

class Program
{
    static void Main(string[] args)
    {
        int[] positiveNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        List<string> names = new List<string>()
        {"Lars", "Jakob", "Eirik", "BAX", "Trym Magnus", "Sjaman Durek", "Harald Hårfagre"};

        Names genericNames = new Names()
        {
            Name = "Leif"
        };

        Console.WriteLine(genericNames.Name);
        
            
        // For = bruke for spesifikke, foreach = bruke for å få ut alle
        for(int i = 0; i < positiveNumbers.Length; i++)
        {
            Console.WriteLine(positiveNumbers[i]);
        }

        names.Add("Ida");
        names.Add("Jon");

        foreach(string name in names)
        {
            Console.WriteLine(name);
        }

        //string? userInput = Console.ReadLine();

        Console.WriteLine("Hva heter du? ");

        string? userInput = Console.ReadLine();

        //string expectedName = "Jørgen";
         //string expectedAge = "";

        // if (Convert.ToDouble(userInput) >= 18)
        // {
        //     Console.WriteLine($"Du kan komme inn på nattklubben");
        // }
        // else
        // {
        //     Console.WriteLine("Du får ikke komme inn!");
        // }

        switch (userInput.ToLower())
        {
            case "hei":
                Console.WriteLine("Hei der!");
                break;

            case "ha det":
                Console.WriteLine("Ha det!");
                break;

            case "fakta":
                Console.WriteLine("Factoid betyr ikke en liten og sann fakt, men usann informasjon presentert som faktum.");
                break;

            default:
               Console.WriteLine("Okay");
                break;
        }
            // eksempel på en lang string
            string longString = @"""
            test
            ""It is a truth universally acknowledged that a single man in possesion of a good fortune must be in want of a wife";
            Console.WriteLine(longString);
    }
}

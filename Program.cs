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

        string expectedName = "Jørgen";
        if (userInput == expectedName)
        {
            Console.WriteLine($"Hei {expectedName}");

        }
        else
        {
            Console.WriteLine("Nå lyger du, det er ikke det du heter!");
        }


    }
}

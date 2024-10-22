namespace undervisning_22._10;

class Program
{
    static void Main(string[] args)
    {
        int[] positiveNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

        string[] names = {"Lars", "Jakob", "Eirik", "BAX", "Trym Magnus", "Sjaman Durek", "Harald Hårfagre"};

        // For = bruke for spesifikke, foreach = bruke for å få ut alle
        for(int i = 0; i < 5; i++)
        {
            Console.WriteLine(positiveNumbers[i]);
        }
    }
}

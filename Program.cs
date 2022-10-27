internal class Program
{
    private static void Main(string[] args)
    {
        string[] cibiPreferiti = { "Riso alla zucca", "Insalata di mare", "Torta al cioccolato", "Bistecca", "Pizza"};

        // Array intero

        for (int i = 0; i < cibiPreferiti.Length; i++)

        { Console.WriteLine($"{cibiPreferiti[i]}  "); };

        // Primo in classifica

        for (int i = 0; i < 1; i++)

        { Console.WriteLine(cibiPreferiti[0]);};
      

        // Ultimo in classifica

        for (int i = 0; i < 1; i++)

       
        Console.WriteLine(cibiPreferiti[cibiPreferiti.Length - 1]);


    }
}
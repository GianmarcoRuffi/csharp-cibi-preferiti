using System;

internal class Program
{
    private static void Main(string[] args)
    {
        string[] cibiPreferiti = { "Riso alla zucca", "Insalata di mare", "Torta al cioccolato", "Bistecca", "Pizza"};

        // Array lista intera

        //for (int i = 0; i < cibiPreferiti.Length; i++)

        //{ Console.WriteLine($"{cibiPreferiti[i]}  "); };


        for (int i = 0; i < cibiPreferiti.Length; i++)
        {
            Console.WriteLine(String.Format("{0} = {1}", i, cibiPreferiti[i]));
        }

        // Primo in classifica

        for (int i = 0; i < 1; i++)

        { Console.WriteLine(cibiPreferiti[0]);};
      

        // Ultimo in classifica

        for (int i = 0; i < 1; i++)

       
        Console.WriteLine(cibiPreferiti[cibiPreferiti.Length - 1]);


    }
}
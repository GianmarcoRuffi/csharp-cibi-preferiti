﻿using System;

internal class Program
{
    private static void Main(string[] args)
    {



        /////////////////////////////////////////////////////////// Inizio Snacks/////////////////////////////////////////////////////////////////////////////////////



        //Snack 2


        Console.WriteLine("Inserisci una parola:");
        string Word1 = Console.ReadLine();
        Console.WriteLine("Inserisci un'altra parola:");
        string Word2 = Console.ReadLine();

        if (Word1.Length > Word2.Length)
        {
            Console.WriteLine(Word2 + " " +  Word1);
        }
        else
        {
            Console.WriteLine(Word1 + " " + Word2);
        }


        //Snack 1

        int Number1, Number2;
        Console.WriteLine("Inserisci il primo numero:");
        Number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Inserisci il secondo numero:");
        Number2 = Convert.ToInt32(Console.ReadLine());

        if (Number1 > Number2)
        {
            Console.Write("Il numero maggiore è: " + Number1);
        }
        else
        {
            Console.Write("Il numero maggiore è: " + Number2);
        }

        //
        //int Result;
        //Result = Number1 + Number2;
        //Console.WriteLine("Sum of two Numbers:" + Result.ToString());
        //Console.ReadLine();



        //////////////////////////////////////////////////////////////// Fine snacks //////////////////////////////////////////////




        //dichiaro l'array

        string[] cibiPreferiti = { "Riso alla zucca", "Insalata di mare", "Torta al cioccolato", "Bistecca", "Pizza", "Tortellini"};

        //dichiaro la lunghezza dell'array

        Console.WriteLine();
        



        int result = cibiPreferiti.GetLength(0);
        Console.WriteLine("Totale dei cibi preferiti: {0}", result);


        // Array dichiaro la lista intera con relativa posizione

        Console.WriteLine();
        Console.WriteLine("Classifica dei cibi:");

        for (int i = 0; i < cibiPreferiti.Length; i++)

        {
            Console.Write(i + 1 + " - ");
            Console.WriteLine(String.Format(cibiPreferiti[i]));
            
        }

        // Primo in classifica

        Console.WriteLine();

        for (int i = 0; i < 1; i++)

        { Console.WriteLine("Cibo preferito in cima: {0}", cibiPreferiti[0]);};


        // Ultimo in classifica

        Console.WriteLine();

        for (int i = 0; i < 1; i++)

       
        Console.WriteLine("Cibo preferito in fondo: {0}", cibiPreferiti[cibiPreferiti.Length - 1]);


        // Mediano in classifica

        //Console.WriteLine();

        //for (int i = 0; i < 1; i++)


        //    Console.WriteLine("Cibo preferito in mezzo: {0}", cibiPreferiti[cibiPreferiti.Length/2]);
        //Console.WriteLine();
        //Console.WriteLine("Cibo preferito in mezzo: {0}", cibiPreferiti[cibiPreferiti.Length / 2 - 1]);


        // Mediano in classifica corretto

        if (cibiPreferiti.Length % 2 == 0)

        {

            //pari 
            int medianaSuperiore = cibiPreferiti.Length / 2;
            int medianaInferiore = medianaSuperiore - 1;
            Console.WriteLine("La mediana è: {0} e {1} " , cibiPreferiti[medianaInferiore], cibiPreferiti[medianaSuperiore]);
        }

        else
        {
            //pari 
            int mediana = cibiPreferiti.Length / 2;
            Console.WriteLine("La mediana è: {0}" + cibiPreferiti[mediana]);

        }


       




    }
}
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        /////////////////////////////////////////////SNACKS 28/10/2022//////////////////////////////////////////////////////////
        ///

        //Snack 2

        // Creazione della funzione pari / dispari

        string pariDispari(int num)
        {
            if (num % 2 == 0)
                return "Pari";
            return "Dispari";
        }

        // Richiesta all'utente

        Console.WriteLine("Inserisci un numero:");
        int num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Hai inserito un numero: " + pariDispari(num));

        return;

        //Snack 1

        // Inserimento delle parole
        Console.WriteLine("Inserisci due parole:");
        string word1 = Console.ReadLine();
        string word2 = Console.ReadLine();

        // Richiamo della funzione
        string pickedWord = compareWords(word1, word2);
        Console.WriteLine(pickedWord);



        // Funzione di comparazione delle due parole
        string compareWords(string word1, string word2)
        {
            if (word1.Length == word2.Length)
                return word1 + " " + word2;
            else if (word1.Length > word2.Length)
                return word1;
            else
                return word2;
        }

        return;




        /////////////////////////////////////////////FINE SNACKS 28/10/2022//////////////////////////////////////////////////////////


        /////////////////////////////////////////////////////////// Inizio Snacks////////////////////////////////////////////////////////////////////////////////////////
        ///


        //Snack10
//        Console.WriteLine("Inserisci un numero");
//      int N = Convert.ToInt32(Console.ReadLine());
//       Random random = new Random();
//       for (int i = 0; i < N; i++)
//{
//        int[] array = new int[10];
//    Console.WriteLine("Array numero" + (i + 1) + "è: ");
//    for (int j = 0; j < 10; j++)
//    {
//        array[j] = random.Next(1, 100);
//        Console.Write(array[j] + "  ");
//    }
//    Console.WriteLine();



//            return;

    //Snack9
//int[] numeri = new int[50];
//int somma = 0;
//while (0 < 50)
//{
//    Console.WriteLine("Inserisci un numero");
//    somma += Convert.ToInt32(Console.ReadLine());
//}


//}

//        //Snack 8

//        //Initialize array   
//        int[] arr = new int[] { 4, 15, 20, 30, 50 };
//        int somma = 0;

//        Console.WriteLine("Somma dei numeri in posizione dispari: ");
//        //Loop through the array by incrementing value of i by 2   
//        for (int i = 0; i < arr.Length; i = i + 2)
//        {
//            somma += (arr[i]);
            
//        }

//        Console.WriteLine(somma);

//        return;


        //Snack 7

       //int[] oddNumbers = new int[6];
       //int index = 0;
       //for(int i=0; i<oddNumbers.Length; i++)
       // {
       // Console.WriteLine("Inserisci un numero:");
       // int numero = Convert.ToInt32(Console.ReadLine());
       //  if(numero%2 != 0)
       //   {
       //    oddNumbers[index] = numero;
       //     index++;
       //         }
       // }

       // return;




       // //Snack 6

       // // Create and initialize array
       // string[] guests = {"Anthony", "Mark", "Theodore"};

       // Console.WriteLine("Inserisci il tuo nome:");
       // string nome = Console.ReadLine();

       // if (Array.Exists(guests, element => element == nome))
       // {
       //     Console.WriteLine("Benvenuto alla festa!");
       // }
       // else
       // {
       //     Console.WriteLine("Spiacente il tuo nome non compare nella lista.");
       // }

       // return;





       // //Snack 5

       // int operatorNumber;
       // Console.WriteLine("Inserisci un numero:");
       // operatorNumber = Convert.ToInt32(Console.ReadLine());
       

       // if (operatorNumber % 2 == 0)
       // {
       //     Console.Write("Numero pari:" + operatorNumber);
       // }
       // else
       // {
       //     Console.Write("Il numero successivo é: " + (operatorNumber + 1) );
       // }

       // return;

       // //Snack 4

       // double sum = 0, avg = 0;
       // double[] numbers = { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
       // for (int i = 0; i < numbers.Length; i++)
       // {
       //     sum += numbers[i];
       // }
       // avg = sum / numbers.Length;
       // Console.WriteLine("Somma: " + sum);
       // Console.WriteLine("Media : " + avg);


       // //Snack 3

       // int Sum = 0, Value;

       // Console.WriteLine("Inserisci 10 volte dei numeri:");
       // for (int i = 0; i <= 9; i++)
       // {
       //     Console.WriteLine("Inserisci un numero: ");
       //     Value = Convert.ToInt32(Console.ReadLine());
       //     Sum += Value;
       // }
       // Console.WriteLine("Totale: " + Sum);



       // //Snack 2


       // Console.WriteLine("Inserisci una parola:");
       // string Word1 = Console.ReadLine();
       // Console.WriteLine("Inserisci un'altra parola:");
       // string Word2 = Console.ReadLine();

       // if (Word1.Length > Word2.Length)
       // {
       //     Console.WriteLine(Word2 + " " +  Word1);
       // }
       // else
       // {
       //     Console.WriteLine(Word1 + " " + Word2);
       // }


       // //Snack 1

       // int Number1, Number2;
       // Console.WriteLine("Inserisci il primo numero:");
       // Number1 = Convert.ToInt32(Console.ReadLine());
       // Console.WriteLine("Inserisci il secondo numero:");
       // Number2 = Convert.ToInt32(Console.ReadLine());

       // if (Number1 > Number2)
       // {
       //     Console.Write("Il numero maggiore è: " + Number1);
       // }
       // else
       // {
       //     Console.Write("Il numero maggiore è: " + Number2);
       // }

       // //
      



       // //////////////////////////////////////////////////////////////// Fine snacks //////////////////////////////////////////////




       // //dichiaro l'array

       // string[] cibiPreferiti = { "Riso alla zucca", "Insalata di mare", "Torta al cioccolato", "Bistecca", "Pizza", "Tortellini"};

       // //dichiaro la lunghezza dell'array

       // Console.WriteLine();
        



       // int result = cibiPreferiti.GetLength(0);
       // Console.WriteLine("Totale dei cibi preferiti: {0}", result);


       // // Array dichiaro la lista intera con relativa posizione

       // Console.WriteLine();
       // Console.WriteLine("Classifica dei cibi:");

       // for (int i = 0; i < cibiPreferiti.Length; i++)

       // {
       //     Console.Write(i + 1 + " - ");
       //     Console.WriteLine(String.Format(cibiPreferiti[i]));
            
       // }

       // // Primo in classifica

       // Console.WriteLine();

       // for (int i = 0; i < 1; i++)

       // { Console.WriteLine("Cibo preferito in cima: {0}", cibiPreferiti[0]);};


       // // Ultimo in classifica

       // Console.WriteLine();

       // for (int i = 0; i < 1; i++)

       
       // Console.WriteLine("Cibo preferito in fondo: {0}", cibiPreferiti[cibiPreferiti.Length - 1]);


       // // Mediano in classifica

       // //Console.WriteLine();

       // //for (int i = 0; i < 1; i++)


       // //    Console.WriteLine("Cibo preferito in mezzo: {0}", cibiPreferiti[cibiPreferiti.Length/2]);
       // //Console.WriteLine();
       // //Console.WriteLine("Cibo preferito in mezzo: {0}", cibiPreferiti[cibiPreferiti.Length / 2 - 1]);


       // // Mediano in classifica corretto

       // if (cibiPreferiti.Length % 2 == 0)

       // {

       //     //pari 
       //     int medianaSuperiore = cibiPreferiti.Length / 2;
       //     int medianaInferiore = medianaSuperiore - 1;
       //     Console.WriteLine("La mediana è: {0} e {1} " , cibiPreferiti[medianaInferiore], cibiPreferiti[medianaSuperiore]);
       // }

       // else
       // {
       //     //pari 
       //     int mediana = cibiPreferiti.Length / 2;
       //     Console.WriteLine("La mediana è: {0}" + cibiPreferiti[mediana]);

       // }


       




    }
}
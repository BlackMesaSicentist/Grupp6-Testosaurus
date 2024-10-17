using System;

using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

class Program

{

    static List<string> inventory = new List<string>();


    static void Main(string[] args)

    {

        Console.WriteLine("Välkommen till Fabrikshanteringssystemet!");



        while (true)

        {

            Console.WriteLine("\nVälj en åtgärd:");

            Console.WriteLine("1. Lägg till produkt"); //Angelica

            Console.WriteLine("2. Visa inventarie"); //David

            Console.WriteLine("3. Ta bort produkt"); //Alex

            Console.WriteLine("4. Sök produkt"); //Adam

            Console.WriteLine("5. Avsluta");



            string val = Console.ReadLine();

            switch (val)

            {

                case "1":

                    LäggTillProdukt();

                    break;

                case "2":

                    VisaInventarie();

                    break;

                case "3":

                    TaBortProdukt();

                    break;

                case "4":

                    SokProdukt();

                    break;

                case "5":

                    return;

                default:

                    Console.WriteLine("Ogiltigt val. Försök igen.");

                    break;

            }

        }

    }

    static void LäggTillProdukt()

    {

        // TODO: Implementera metod för att lägga till produkt

        Console.Clear(); //Tar bort menyn

        //Tar in information från användaren
        Console.WriteLine("Ange produktnamn:");
        String name = Console.ReadLine().ToLower();

        //lägger till i lager
        inventory.Add(name);

        //meddelar användaren om lyckat genomförande
        Console.WriteLine("Din produkt har lagts till!\n");

        Console.WriteLine("Tryck enter för att komma tillbaka till menyn");
        Console.ReadLine();


    }

    static void VisaInventarie()

    {

        // TODO: Implementera metod för att visa inventarie

    }

}

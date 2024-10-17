using System;

using System.Collections.Generic;
using System.ComponentModel;

class Program

{

    static List<string> inventory = new List<string>();

    static void Main(string[] args)

    {
        //Manually created prdocuts in inventory, gets positions [0] and [1]
        inventory.Add("SlussMaskin");
        inventory.Add("Borgar");

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

    static void TaBortProdukt(List<Program>inventory)
    {
        int i = 0; // Todo: ta bort exempel på index att retunera // int i = SearchProduct(inventory) //Så skulle man kunna kalla på metoden i remove metoden
        //Insert search here, return either and int for position or directly that position
        inventory.Remove(inventory[i]); // if remove specific position 

        
    }

}

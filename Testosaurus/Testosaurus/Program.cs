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

                    SokProdukt(inventory);

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
        if (name != null)
        {
            inventory.Add(name);
        //meddelar användaren om lyckat genomförande
            Console.WriteLine("Din produkt har lagts till!\n");
        }
        else
        {
            Console.WriteLine("Ej gilltig sökning, försök igen:");
            String nameAgain = Console.ReadLine().ToLower();
            inventory.Add(nameAgain);
        }

        Console.WriteLine("Tryck enter för att komma tillbaka till menyn");
        Console.ReadLine();
    }

    static void VisaInventarie()

    {
        if (inventory.Count == 0)
        {
            Console.WriteLine("No inventory");
        }
        else
        {
            foreach (var item in inventory)
                Console.WriteLine($"{item}");
        }

    }

    static void TaBortProdukt(List<Program> inventory)
    {
        int i = 0; // Todo: ta bort exempel på index att retunera 
        int i = SokProdukt(inventory);
        //Så skulle man kunna kalla på metoden i remove metoden
        //Insert search here, return either and int for position or directly that position
        inventory.Remove(inventory[i]); // if remove specific position 


    }


    // Sökfunktion - utförd av Adam
    static void SokProdukt(List<string> inventory)
    {
        // Skapar UI och input för start sökningen
        Console.WriteLine("Produktsökning\nSkriv det som ska sökas efter");
        string searchQuery = Console.ReadLine().Trim().ToLower();


        // Om sökningen är tom så kommer ett meddelande att visas och man kan skriva in en ny sökning
        while (string.IsNullOrEmpty(searchQuery))
        {
            searchQuery.Trim().ToLower();
            Console.WriteLine("Sök får inte vara tom\nSkriv i ny sökning:");
            searchQuery = Console.ReadLine().Trim().ToLower();
        }

        // Söker igenom inventory för att hitta produkter som innehåller namn med passande söktext
        var searchResults = inventory.Where(item => item.ToLower().Contains(searchQuery));

        // Om produkter hittades så körs detta
        if (searchResults.Any())
        {
            // Visar resultaten som hittades
            Console.WriteLine("Sökresultat\n");
            // Hämtar och visar produkternas namn kategori och pris
            foreach (var item in searchResults)
            {
                Console.WriteLine($"Produktnamn: {item}");
            }

        }
        // Om inga produkter hitades så körs och ett meddelade visas att inga produkter hittades
        else
        {
            Console.WriteLine("Ingen produkt hittades");
        }
        // Gå till menyn
        Console.WriteLine("Tryck enter för att komma till menyn");
        Console.ReadLine();
    }

}

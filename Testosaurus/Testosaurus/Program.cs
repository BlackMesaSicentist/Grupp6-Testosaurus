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

            Console.WriteLine("1. Lägg till produkt");

            Console.WriteLine("2. Visa inventarie");

            Console.WriteLine("4. Sök Produkt");

            Console.WriteLine("3. Avsluta");



            string val = Console.ReadLine();

            switch (val)

            {

                case "1":

                    LäggTillProdukt();

                    break;

                case "2":

                    VisaInventarie();

                    break;

                case "4":
                    SökProdukt(); 
                    break;

                case "3":

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

    }

    static void VisaInventarie()

    {

        // TODO: Implementera metod för att visa inventarie

    }


    // Sökfunktion - utförd av Adam
    static void SökProdukt(List<(Product, /*StorageLocation,*/ int)> inventory)
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
        var searchResults = inventory.Where(item => item.Item1.Name.ToLower().Contains(searchQuery));

        // Om produkter hittades så körs detta
        if (searchResults.Any())
        {
            // Visar resultaten som hittades
            Console.WriteLine("Sökresultat\n");
            // Hämtar och visar produkternas namn kategori och pris
            foreach (var item in searchResults)
            {
                Console.WriteLine($"Produktnamn: {item.Item1.Name}, Kategori: {item.Item1.Category}, Pris: {item.Item3}");
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

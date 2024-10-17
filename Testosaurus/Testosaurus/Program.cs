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

                    //TaBortProdukt();

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
    //Ta bort produkt av Alex Bullerjahn
    static void TaBortProdukt()
    {
        Console.Clear (); //Rensar consol
        String? search; //String för att kunna söka på produkt
        Boolean searchResults = false; //Boolean för loop om den hittar eller inte hittar
        Console.Write("Skriv in en produkt som du vill ta bort: ");

        while (searchResults == false) //Loop som säkrar att man inte lämnar en tom sökning
        {
            search = Console.ReadLine(); //Sökning

            if (search == "") { Console.WriteLine("Det finns ingen produkt som saknar tecken \nFörsök igen"); continue; } //Om den saknar tecken så börjar loopen om
            else
            {
                for (int index = 0; index < inventory.Count;) //Sökfunktion som räknar upp platser med index
                {
                    searchResults = inventory[index].Contains(search); //Kollar om den har hittat något
                    if (searchResults == true) //Om den hittar så tar den bort
                    {
                        Console.WriteLine($"Du har taigt bort produkt: {inventory[index]} \nTryck på enter för att återvända till huvudmenyn");
                        inventory.RemoveAt(index);
                        Console.ReadKey();
                        break;
                    }    
                }
                if (searchResults == false)  // Om den inte hittar så får man detta svar och återvänder till meny
                { 
                    Console.WriteLine("Kan inte hitta en produkt med det namnet \nTryck på enter för att återvända till huvudmenyn");
                    Console.ReadKey();
                    break;
                }
            }
        }
    }


    // Sökfunktion - utförd av Adam
    static void SokProdukt(List<string> inventory)
    {
        // Skapar UI och input för start sökningen
        Console.WriteLine("Produktsökning\nSkriv det som ska sökas efter");
        string searchQuery = Console.ReadLine().Trim().ToLower();


        // Om sökningen är tom så kommer ett meddelande att visas och man kan skriva in en ny sökning
        while (string.IsNullOrWhiteSpace(searchQuery))
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

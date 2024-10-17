using System;

using System.Collections.Generic;
using System.ComponentModel;

class Program

{

    static List<string> inventory = new List<string>();
    

    static void Main(string[] args)

    {
        inventory.Add("SlussMaskin");
        inventory.Add("Borgar");

        Console.WriteLine("Välkommen till Fabrikshanteringssystemet!");



        while (true)

        {

            Console.WriteLine("\nVälj en åtgärd:");

            Console.WriteLine("1. Lägg till produkt");

            Console.WriteLine("2. Visa inventarie");

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

    static void RemoveProduct(List<Program>inventory)
    {
        int i = 0; // Todo: ta bort exempel på index att retunera // int i = SearchProduct(inventory) //Så skulle man kunna kalla på metoden i remove metoden
        //Insert search here, return either and int for position or directly that position
        inventory.Remove(inventory[i]); // if remove specific position 

        
    }

}

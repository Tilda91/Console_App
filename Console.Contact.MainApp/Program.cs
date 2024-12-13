using System;
using System.Collections.Generic;

namespace MainApp
{
     public class Program
    {
        static void Main(string[] args)
        {
            string filePath = "kontakter.json";
            var kontaktService = new KontaktService(filePath);

            var kontakter = kontaktService.LaddaKontakter();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("---- MENY KONTAKTLISTA ----");
                Console.WriteLine("\nA. Visa kontaktlistan");
                Console.WriteLine("B. Skapa ny kontakt");
                Console.WriteLine("Q. Avsluta");
                Console.WriteLine("\n------------------------");
                Console.Write("\nVälj ett alternativ: ");

                var input = Console.ReadLine()?.ToUpper();
                    
                switch (input)
                {
                    case "A":
                    
                        VisaKontaktLista(kontakter);

                        break;

                    case "B":
                        
                        Console.Clear();
                        var nyKontakt = kontaktService.SkapaKontakt();
                        kontakter.Add(nyKontakt);
                        kontaktService.SparaKontakter(kontakter);

                        break;

                    case "Q":
                        Console.WriteLine("Tack för denna gången, programmet Avslutas ....");
                        return;

                    default:
                        Console.WriteLine("Ogiltigt val. Försök igen.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void VisaKontaktLista(List<KontaktModel> kontakter)
        {
            Console.Clear();
            if (kontakter.Count == 0)
            {
                Console.WriteLine("KOntaktlistan är tom, inga sparade kontakter finns.");
            }
            else
            {
                foreach (var kontakt in kontakter)
                {
                    Console.WriteLine(kontakt);
                }
            }
            Console.WriteLine("\nTryck på valfri tangent för att återgå till menyn.");
            Console.ReadKey();
        }
    }
}

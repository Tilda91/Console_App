using Business.Services;
using System;
using System.Collections.Generic;

namespace MainApp
{
    public class KontaktService
    {
        private readonly FileService _fileService;

        public KontaktService(string filePath)
        {
            _fileService = new FileService(filePath);
        }
        public List<KontaktModel> LaddaKontakter() => _fileService.LaddaKontakter();
        public void SparaKontakter(List<KontaktModel> kontakter) => _fileService.SaveKontakter(kontakter);
        public KontaktModel SkapaKontakt()

        {
 
            var kontakt = new KontaktModel
              
            {
                Förnamn = LäsaInData("Förnamn"),
                Efternamn = LäsaInData("Efternamn"),
                Email = LäsaInData("E-mail"),
                Telefonnummer = LäsaInData("Telefonnummer"),
                Gatuadress = LäsaInData("Gatuadress"),
                Postnummer = LäsaInData("Postnummer"),
                Ort = LäsaInData("Ort")
            };

            Console.WriteLine("KOntaken har sparats till listan.");
            Console.WriteLine("\nTryck på valfri tangent för att återgå till menyn.");
            Console.ReadKey();

            return kontakt;
        }

        // Denna Hjälpmetod är genererad av ChatGpt 
        // Istället för att repetera Console.Write och Console.ReadLine för varje fält så används hjälpmetoden
        //Den tar in fältnamnet som parameter och returnerar det användaren skriver in (läsa in data från användaren)

        private static string LäsaInData(string fält)
        {
            Console.Clear();
            Console.Write($"Ange {fält}: ");
            return Console.ReadLine();
        }
    }
}

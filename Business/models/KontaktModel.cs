using System;
using System.Reflection.Emit;

namespace MainApp
{
    public class KontaktModel
        {
            public Guid Id { get; private set; }
            public string Förnamn { get; set; }
            public string Efternamn { get; set; }
            public string Email { get; set; }
            public string Telefonnummer { get; set; }
            public string Gatuadress { get; set; }
            public string Postnummer { get; set; }
            public string Ort { get; set; }

        public KontaktModel()
        {
            Id = IdGenerator.GenerateGuidId(); 
        }



        public override string ToString()
        {
            return $"ID: {Id}\nNamn: {Förnamn} {Efternamn}\nE-mail: {Email}\nTelefon: {Telefonnummer}\nAdress: {Gatuadress}, {Postnummer} {Ort}\n";
        }
    }
  
}
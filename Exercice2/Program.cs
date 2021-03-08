using System;

namespace Exercice2
{
    class Program
    {
        static void Main(string[] args)
        {
            String nom = "Mohamed";
            float[] notes = { 10f, 15.5f, 9f, 14.36f };
            Stagiaire stagiaire = new Stagiaire(nom, notes);
            
            Console.WriteLine(stagiaire.CalculerMoyenne());
            Console.WriteLine(stagiaire.TrouverMax());
            Console.WriteLine(stagiaire.TrouverMin());
        }
    }
}

using System;

namespace Exercice3
{
    class Program
    {
        static void Main(string[] args)
        {
            Adresse a1 = new Adresse("les fars", "casa", "2400");
            Adresse a2 = new Adresse("nakhil", "rabat", "9400");
            Adresse a3 = new Adresse("akid alam", "casa", "2500");
            Adresse a4 = new Adresse("Guiliz", "marrakech", "8700");
            Adresse a5 = new Adresse("ouad bacha", "safi", "8900");

            Adresse[] tab1 = { a3, a5 };
            Personne p1 = new Personne("mohamed", 'M', tab1);

            Adresse[] tab2 = { a3, a2 };
            Personne p2 = new Personne("youssef", 'M', tab2);

            Adresse[] tab3 = { a1, a4 };
            Personne p3 = new Personne("mohamed", 'M', tab3);

            ListPersonnes lp = new ListPersonnes();
            lp.Personnes[0] = p1;
            lp.Personnes[1] = p2;
            lp.Personnes[2] = p3;

            Console.WriteLine(lp.FindByNom("mohamed"));

            Console.WriteLine(lp.FindByNom("youssef"));

            Console.WriteLine(lp.FindByCodePostal("8700"));

            Console.WriteLine(lp.FindByCodePostal("2800"));

        }
    }
}

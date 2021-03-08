using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice3
{
    public class Personne
    {
        public string Nom { get; set; }
        public char Sexe { get; set; }
        public Adresse[] Adresses { get; set; }

        /// <summary>
        /// Constructeur de la classe Personne
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="sexe"></param>
        /// <param name="adresses"></param>
        public Personne(string nom, char sexe, Adresse[] adresses)
        {
            this.Nom = nom;
            this.Sexe = sexe;
            this.Adresses = adresses;
        }

        public override string ToString()
        {
            return this.Nom;
        }

    }
}

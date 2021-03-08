using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice4
{
    public class MaDate
    {
        public int Jour { get; set; }
        public int Mois { get; set; }
        public int Annee { get; set; }

        /// <summary>
        /// Constructeur de la classe MaDate
        /// </summary>
        /// <param name="jour"></param>
        /// <param name="mois"></param>
        /// <param name="annee"></param>
        public MaDate(int jour, int mois, int annee)
        {
            this.Jour = jour;
            this.Mois = mois;
            this.Annee = annee;
        }

        public override string ToString()
        {
            return String.Format("{0}//{1}//{2}", this.Jour, this.Mois, this.Annee);
        }

        public void AjouterUnJour()
        {
            DateTime dt = new DateTime(this.Annee, this.Mois, this.Jour);

            dt.AddDays(1);

            this.Annee = dt.Year;
            this.Mois = dt.Month;
            this.Jour = dt.Day;
        }

        public void AjouterPlusieursJours(int n)
        {
            for(int i=0; i < n; i++)
            {
                this.AjouterUnJour();
            }
        }

        public void AjouterUnMois()
        {
            AjouterPlusieursJours(30);
        }

    }
}

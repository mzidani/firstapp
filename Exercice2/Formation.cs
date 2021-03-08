using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercice2
{
    public class Formation
    {
        public string Intitule { get; set; }
        public int NbrJours { get; set; }
        public Stagiaire[] Stagiaires { get; set; }

        /// <summary>
        /// Constructeur de la class Formation
        /// </summary>
        /// <param name="intitule"></param>
        /// <param name="nbrJours"></param>
        /// <param name="stagiaires"></param>
        public Formation(string intitule, int nbrJours, Stagiaire[] stagiaires)
        {
            this.Intitule = intitule;
            this.NbrJours = nbrJours;
            this.Stagiaires = stagiaires;
        }

        /// <summary>
        /// Calcul la moyenne des moyennes des stagiaire dans la formations
        /// </summary>
        /// <returns>moyenne de la formation</returns>
        public float CalculerMoyenneFormation()
        {
            float sum = 0;
            foreach(Stagiaire s in this.Stagiaires)
            {
                sum += s.CalculerMoyenne();
            }
            return sum / this.Stagiaires.Length;
        }

        /// <summary>
        /// Trouver le stagiaire avec la meilleur moyenne 
        /// </summary>
        /// <returns>Index de ce stagiaire</returns>
        public int GetIndexMax()
        {
            int index = 0;
            float max = 0;
            for(int i = 0; i < this.Stagiaires.Length; i++)
            {
                if(max < this.Stagiaires[i].CalculerMoyenne())
                {
                    max = this.Stagiaires[i].CalculerMoyenne();
                    index = i;
                }
            }
            return index;
        }

        /// <summary>
        /// Trouver le stagiaire avec la meilleur moyenne 
        /// </summary>
        /// <returns>Nom de ce stagiaire</returns>
        public string AfficherNomMax()
        {
            return this.Stagiaires[this.GetIndexMax()].Nom;
        }

        /// <summary>
        /// Trouver le stagiaire avec la meilleur moyenne 
        /// </summary>
        /// <returns>La note minimale de ce stagiaire</returns>
        public float AfficherMinMax()
        {
            return this.Stagiaires[this.GetIndexMax()].TrouverMin();
        }

        /// <summary>
        /// Trouver le stagiaire par nom
        /// </summary>
        /// <param name="nom"></param>
        /// <returns>Moyenne de ce stagiaire</returns>
        public float TrouverMoyenneParNom(string nom)
        {
            return Stagiaires.FirstOrDefault(s => s.Nom == nom).CalculerMoyenne();
        }

    }
}

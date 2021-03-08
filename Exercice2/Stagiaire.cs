using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice2
{
    public class Stagiaire
    {
        public string Nom { get; set; }
        public float[] Notes { get; set; }

        /// <summary>
        /// Constructeur par parametre de Stagiaire
        /// </summary>
        /// <param name="nom">Nom du stagiaire</param>
        /// <param name="notes">Notes du stagiare</param>
        public Stagiaire(string nom, float[] notes)
        {
            this.Nom = nom;
            this.Notes = notes;
        }

        /// <summary>
        /// Calcul de moyenne
        /// </summary>
        /// <returns>La moyenne du stagiaire</returns>
        public float CalculerMoyenne()
        {
            float sum = 0f;
            for(int i = 0; i < this.Notes.Length; i++)
            {
                sum += this.Notes[i];
            }

            return sum / this.Notes.Length;
        }

        /// <summary>
        /// Trouver le max des notes
        /// </summary>
        /// <returns>le max</returns>
        public float TrouverMax()
        {
            float max = 0f;

            for (int i = 0; i < this.Notes.Length; i++)
            {
                if(max < this.Notes[i])
                {
                    max = this.Notes[i];
                }
            }

            return max;
        }

        /// <summary>
        /// Trouver le min des notes
        /// </summary>
        /// <returns>le min</returns>
        public float TrouverMin()
        {
            float min = this.Notes[0];

            for (int i = 1; i < this.Notes.Length; i++)
            {
                if (min > this.Notes[i])
                {
                    min = this.Notes[i];
                }
            }

            return min;
        }
    }
}

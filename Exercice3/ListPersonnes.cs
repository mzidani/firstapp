using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercice3
{
    public class ListPersonnes
    {
        public Personne[] Personnes { get; set; }

        /// <summary>
        /// Constructeur de la classe ListPersonnes
        /// </summary>
        public ListPersonnes()
        {
            this.Personnes = new Personne[10];
        }

        /// <summary>
        /// Trouve la personne avec le nom
        /// </summary>
        /// <param name="nom"></param>
        /// <returns>L'objet de la personne trouvée</returns>
        public Personne FindByNom(string nom)
        {
            return this.Personnes.FirstOrDefault(p => p.Nom == nom);
        }

        /// <summary>
        /// Verifier si une personne possede au moins une adresse avec le code postal donné
        /// </summary>
        /// <param name="cp"></param>
        /// <returns>true or false</returns>
        public bool FindByCodePostal(string cp)
        {
            return this.Personnes.Any(p => p.Adresses.Any(a => a.CodePostale == cp));
        }

        /// <summary>
        /// Calculer nombre des personnes ayant dans une des adresses la ville donnés
        /// </summary>
        /// <param name="ville"></param>
        /// <returns>Le nombre trouvé</returns>
        public int CountPersonneVille(string ville)
        {
            return this.Personnes.Count(p => p.Adresses.Any(a => a.Ville == ville));
        }

        /// <summary>
        /// Changer le nom d'une personne
        /// </summary>
        /// <param name="oldNom"></param>
        /// <param name="newNom"></param>
        public void EditPersonneNom(string oldNom, string newNom)
        {
            this.Personnes.Where(p => p.Nom == oldNom).ToList().ForEach(p => p.Nom = newNom);
        }

        /// <summary>
        /// Changer les villes d'une personne
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="newVille"></param>
        public void EditPersonneVille(string nom, string newVille)
        {
            this.Personnes.Where(p => p.Nom == nom).ToList().ForEach(p => p.Adresses.ToList().ForEach(a => a.Ville = newVille));
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice3
{
    public class Adresse
    {
        public string Rue { get; set; }
        public string Ville { get; set; }
        public string CodePostale { get; set; }

        /// <summary>
        /// Constructeur de la classe Adresse
        /// </summary>
        /// <param name="rue"></param>
        /// <param name="ville"></param>
        /// <param name="codePostale"></param>
        public Adresse(string rue, string ville, string codePostale)
        {
            this.Rue = rue;
            this.Ville = ville;
            this.CodePostale = codePostale;
        }
    }
}

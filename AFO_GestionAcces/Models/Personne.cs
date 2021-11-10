using System.Collections.Generic;

namespace AFO_GestionAcces.Models
{
    public class Personne
    {
        public int? Badge { get; set; }

        public int? ID { get; set; }

        public string Nom { get; set; }

        public string Prenom { get; set; }

        public string NomPrenom { get { return Nom + " " + Prenom; } }
    }
}

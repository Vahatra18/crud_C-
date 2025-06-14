using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud.Models
{
    internal class Voiture
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public string Marque { get; set; }
        public string Modele { get; set; }

        // Constructeur sans paramètre (utile pour les lectures de BDD)
        public Voiture() { }

        // Constructeur avec paramètres (utile pour la création rapide d'objet)
        public Voiture(string numero, string marque, string modele)
        {
            Numero = numero;
            Marque = marque;
            Modele = modele;
        }

        // Autre constructeur avec Id si besoin
        public Voiture(int id, string numero, string marque, string modele)
        {
            Id = id;
            Numero = numero;
            Marque = marque;
            Modele = modele;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIntra
{
    public abstract class Personne
    {
        //Déclaration d'abttribut
        private string _Nom;
        private string _Prenom;
        private string _Genre;
        public Personne(string pNom, string pPrenom,string pGenre)
        {
            this.Nom = pNom;
            this.Prenom = pPrenom;
            this.Genre = pGenre;
        }
        //Propriété de la classe
        public string Nom
        {
            get { return _Nom; }
            set
            {
                if (value != "")
                {
                    _Nom = value;
                }
                else
                {
                    throw new Exception("Le nom ne doit pas être vide");
                }
            }
        }
        public string Prenom
        {
            get { return _Prenom; }
            set
            {
                if(value != "")
                {
                    _Prenom = value;
                }
                else
                {
                    throw new Exception("Le prénom ne doit pas être vide");
                }
            }
        }
        public string Genre
        {
            get { return _Genre; }
            set
            {
                if(value == "M" || value == "F")
                {
                    _Genre = value;
                }
                else
                {
                    throw new Exception("Le genre doit être M ou F");
                }
            }
        }
        public override string ToString()
        {
            return this.Nom + "\t" + this.Prenom + "\t" + this.Genre;
        }
    }
}

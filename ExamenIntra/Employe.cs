using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIntra
{
    public abstract class Employe:Personne
    {
        private int _Numero;
        public Employe(string pNom, string pPrenom,string pGenre, int pNumero): base(pNom, pPrenom, pGenre)
        {
            this.Numero = pNumero;
        }
        //déclaration des propriétes
        public int Numero
        {
            get { return _Numero; }
            set
            {
                if(value > 0)
                {
                    _Numero = value;
                }
                else
                {
                    throw new Exception("Le numéro doit être >0");
                }
            }
        }
        //les méthodes
        public abstract double CalculerSalaire();

        public override string ToString()
        {
            return base.ToString() + "\t" + this.Numero;;
        }
    }
}

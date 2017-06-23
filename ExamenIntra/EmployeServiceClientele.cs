using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIntra
{
   
    public class EmployeServiceClientele : Employe, IPeutInteragirAvecClient
    {
        //attribut privée
        private double _Taux;
        private int _NBheure=0;
        private string _Commande="Pas de commande pour l'instant.";
        public EmployeServiceClientele(string pNom, string pPrenom, string pGenre, int pNumero, double pTaux) : base(pNom, pPrenom, pGenre, pNumero)
        {
            this.Taux = pTaux;

        }

        //Propriétés de la classe
        public double Taux
        {
            get { return _Taux; }
            set
            {
                if(value >= 10)
                {
                    _Taux = value;
                }
                else
                {
                    throw new Exception("Le taux doit être >=10");
                }
            }

        }
        public int NBHeure
        {
            get { return _NBheure; }
            set
            {
                if(value >= 0)
                {
                    _NBheure = value;
                }
                else
                {
                    throw new Exception("Le nombre d'heure doit être >=0");
                }
            }
        }

        string IPeutInteragirAvecClient.Commande
        {
            get
            {

                return _Commande;
            }
        }

        public override double CalculerSalaire()
        {
            return this.Taux * this.NBHeure;
        }

        string IPeutInteragirAvecClient.DonneLaFacture()
        {
            string stResults = "Voici la facture poure la commande suivante \n\t" + this._Commande;
            this._Commande = "Pas de commande pour l'instant.";
            return stResults;
        }

        string IPeutInteragirAvecClient.PrendLaCommande(string pCommande)
        {
            
            _Commande = pCommande;
            return "La commande " + pCommande + "est notée.";
        }

        public override string ToString()
        {
            return "EmployeServiceClientele \t" +base.ToString()+"\t" + this.CalculerSalaire();
        }
    }
}

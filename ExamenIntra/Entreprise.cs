using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIntra
{

    public class Entreprise
    {
        private Dictionary<int, Employe> ListeEmploye = new Dictionary<int, Employe>();

        public Entreprise(string pNom, string pAdresse)
        {
            this.Nom = pNom;
            this.Adresse = pAdresse;
        }
        public string Nom { get; set; }
        public string Adresse { get; set; }

        //les méthodes
        public bool AjouterEmploye(Employe emp)
        {
            bool boValidation = true;
            try
            {
                ListeEmploye.Add(emp.Numero, emp);
            }
            catch
            {
                boValidation = false;
                return boValidation;
            }
            return boValidation;
        }
        public bool SupprimerEmploye(int numero)
        {
            bool boValidation = false;

            //try
            //{
            //    ListeEmploye.Remove(numero);
            //}
            //catch
            //{
            //    boValidation = false;
            //    return boValidation;
            //}
            //return boValidation;
            boValidation = ListeEmploye.ContainsKey(numero);

            if (boValidation == true)
            {
                
                ListeEmploye.Remove(numero);
                return boValidation;
            }
            return boValidation;
        }
        public Employe ChercherEmploye(int numero)
        {
            bool boValidation = ListeEmploye.ContainsKey(numero) ;
           
            if (boValidation == true)
            {
                Employe EmployeTrouver;

                return  EmployeTrouver = ListeEmploye[numero]; ;
            }
            return null;

        }
        public override string ToString()
        {
            double doMasseSalarial = 0;
            string stResult = "";
            foreach(Employe x in ListeEmploye.Values)
            {
                stResult += x.ToString() + "\n";
                doMasseSalarial += x.CalculerSalaire();
            }
            return this.Nom + "\n" + this.Adresse + "\n" + stResult + "\n Masse salarial: " + doMasseSalarial;
        }
        public string EmployeInformatiqueToString()
        {
            string stResult = "";
            foreach(Employe x in ListeEmploye.Values)
            {
                if(x is EmployeInformatique)
                stResult += x.ToString() + "\n";
            }
            return stResult;
        }
        public string EmployeServiceClienteleToString()
        {
            string stResult = "";
            foreach (Employe x in ListeEmploye.Values)
            {
                if(x is EmployeServiceClientele)
                stResult += x.ToString() + "\n";
            }
            return stResult;
        }
        public string CommandesEnAttente()
        {
            string stResult = "";
            foreach (Employe x in ListeEmploye.Values)
            {
                if(x is IPeutInteragirAvecClient)
                stResult += x.Nom +": "+((IPeutInteragirAvecClient)x).Commande+"\n";
            }
            return stResult;
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenIntra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Entreprise Mcdo = new Entreprise("Mcdo Gatineau", "Gatineau");

        private void btnAjouterEMP_Click(object sender, EventArgs e)
        {
        

            EmployeInformatique emp1 = new EmployeInformatique("Alpha", "Bravo", "M", 10321, 5500);
            EmployeInformatique emp2 = new EmployeInformatique("Hotte", "Sylvain", "M", 10234, 4000);

            EmployeServiceClientele emp3 = new EmployeServiceClientele("Betty", "Sandie", "F", 36210, 3000);
            EmployeServiceClientele emp4 = new EmployeServiceClientele("Charlie", "Delta", "M", 32151, 36500);

            //AJouton un nombre heure pour emp3
            emp3.NBHeure = 5;

            Mcdo.AjouterEmploye(emp1);
            Mcdo.AjouterEmploye(emp2);
            Mcdo.AjouterEmploye(emp3);
            Mcdo.AjouterEmploye(emp4);
            
    

        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            Employe employechercher;
         try
            {
                employechercher = Mcdo.ChercherEmploye(int.Parse(txtNumEMP.Text));
                if (employechercher != null)
                {
                    rtbResults.Text = employechercher.ToString();
                }
                else
                {
                    rtbResults.Text = "cet employé n'existe pas";
                }
            }
            catch (Exception  ex)
            {
                MessageBox.Show(ex.Message);
            }
        
          
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            Employe EMPSupprimer = Mcdo.ChercherEmploye(int.Parse(txtNumEMP.Text));
            if (Mcdo.SupprimerEmploye(Convert.ToInt16(txtNumEMP.Text)) == true)
            {
                rtbResults.Text = "L'employé suivante à été supprimer: \n" + EMPSupprimer.ToString();
            }
            else
            {
                rtbResults.Text = "cet employé n'existe pas";
            }

        }

        private void btnAfficherEMP_Click(object sender, EventArgs e)
        {
            rtbResults.Text= Mcdo.ToString();
        }

        private void btnCommander_Click(object sender, EventArgs e)
        {
            Employe Service = Mcdo.ChercherEmploye(int.Parse(txtNumEMP.Text));
            if (Service != null)
            {

                if (Service is IPeutInteragirAvecClient)
                {
                    rtbResults.Text= ((IPeutInteragirAvecClient)Service).PrendLaCommande(txtCommande.Text);
                }
                else
                {
                    rtbResults.Text = "Cet Employé ne peux pas prendre de commande";
                }
            }
            else
            {
                rtbResults.Text = "cet employé n'existe pas";
            }

        }

        private void btnRecevoirFacture_Click(object sender, EventArgs e)
        {
            Employe Service = Mcdo.ChercherEmploye(int.Parse(txtNumEMP.Text));
            if (Service != null)
            {
               
                if (Service is IPeutInteragirAvecClient)
                {
                    rtbResults.Text = ((IPeutInteragirAvecClient)Service).DonneLaFacture();
                }
                else
                {
                    rtbResults.Text = "Cet Employé ne peux pas prendre de commande";
                }
             
            }
            else
            {
                rtbResults.Text = "cet employé n'existe pas";
            }

        }

        private void btnAfficherEMPinfo_Click(object sender, EventArgs e)
        {
          rtbResults.Text=  Mcdo.EmployeInformatiqueToString();
        }

        private void btnAfficherEMPSerCli_Click(object sender, EventArgs e)
        {
           rtbResults.Text= Mcdo.EmployeServiceClienteleToString();
        }

        private void btnAfficherCommandesAttentes_Click(object sender, EventArgs e)
        {
          rtbResults.Text=  Mcdo.CommandesEnAttente();
        }
    }
}

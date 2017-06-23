using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIntra
{
    public interface IPeutInteragirAvecClient
    {
        string Commande { get; }
        string PrendLaCommande(string pCommande);
        string DonneLaFacture();                                         
    }
}

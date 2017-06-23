using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIntra
{
    public class EmployeInformatique : Employe
    {
        private double _SalaireMensuel;
        public EmployeInformatique(string pNom, string pPrenom, string pGenre, int pNumero, double pSalaireMensuel) : base(pNom, pPrenom, pGenre, pNumero)
        {
            this.SalaireMensuel = pSalaireMensuel;
        }
        public double SalaireMensuel
        {
            get { return _SalaireMensuel; }
            set
            {
                if(value >= 1600)
                {
                    _SalaireMensuel = value;
                }
                else
                {
                    throw new Exception("Le salaire doit être >=1600");
                }
            }
        }
        public override double CalculerSalaire()
        {
            return this.SalaireMensuel;
        }
        public override string ToString()
        {
            return "EmployeInformatique\t"+base.ToString() + "\t" + this.CalculerSalaire();
        }
    }
}

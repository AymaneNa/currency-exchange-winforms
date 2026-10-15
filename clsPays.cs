using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Fin_de_session
{
    public class clsPays
    {
        private string nom;
        private string monnaie;
        private double valeur;

        public clsPays()
        {
            nom = "Non défini";
            monnaie = "Non défini";
            valeur = 0;
        }

        public void Creer(string nomPays, string Monnaie, double val)
        {
            nom = nomPays;
            monnaie = Monnaie;
            valeur = val;
        }

        public string Afficher()
        {
            string info = "";
            info = "Nom du pays : " + nom + "\n Monnaie : " + monnaie + "\n Valeur en CAD : " + valeur;
            return info;
        }

        public clsPays(string nom, string monnaie, double valeur)
        {
            this.nom = nom;
            this.monnaie = monnaie;
            this.valeur = valeur;
        }

        public string Nom { get => nom; set => nom = value; }
        public string Monnaie { get => monnaie; set => monnaie = value; }
        public double Valeur { get => valeur; set => valeur = value; }


        public double GetValeurCanada(double montant)
        {
            return montant * valeur;
        }


      
    }
}

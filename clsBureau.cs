using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Fin_de_session
{
    public class clsBureau
    {
        private string numero;
        private string nom;
        private string adresse;
        private List<clsPays> pays;
        private string statut;

        public clsBureau()
        {
            numero = "Non défini";
            nom = "Non défini";
            adresse = "Non défini";
            pays = new List<clsPays>();
            statut = "Non défini";
        }


        public string Numero { get => numero; }
        public string Nom { get => nom; set => nom = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public List<clsPays> Pays { get => pays; set => pays = value; }
        public string Statut { get => statut; set => statut = value; }

        // == Méthodes ==
        public clsPays TrouverPays(string nomPays)
        {
            foreach (clsPays unPays in pays)
            {
                if (unPays.Nom == nomPays)
                {
                    return unPays;
                }
            }
            return null;
        }
        public void Creer(string numero, string nom, string adresse, List<clsPays> listePays, string statut)
        {
            this.numero = numero;
            this.nom = nom;
            this.adresse = adresse;
            pays = listePays;
            this.statut = statut;
        }

        public string Afficher()
        {
            string info = "";
            foreach (clsPays pays in pays)
            {

                info = pays.Nom + " - " + pays.Monnaie + " - " + pays.Valeur + " CAD";
            }
            return info;
        }

        public void Fermer()
        {
            statut = "Fermé";
        }


    }
}

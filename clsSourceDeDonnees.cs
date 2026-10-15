using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Fin_de_session
{
    public static class clsSourceDeDonnees
    {
        public static List<clsPays> GetTousLesPays()
        {
            List<clsPays> listePays = new List<clsPays>();

            StreamReader fichier = new StreamReader("PaysDb.txt");
            while (!fichier.EndOfStream)
            {
                string nom = fichier.ReadLine();
                string monnaie = fichier.ReadLine();
                double valeur = Convert.ToDouble(fichier.ReadLine(), CultureInfo.InvariantCulture);

                clsPays unPays = new clsPays(nom, monnaie, valeur);
                listePays.Add(unPays);
            }
            fichier.Close();

            return listePays;
        }

        public static void SaveTousLesPays(List<clsPays> pays)
        {
            StreamWriter fichier = new StreamWriter("PaysDb.txt");

            foreach (clsPays unPays in pays)
            {
                fichier.WriteLine(unPays.Nom);
                fichier.WriteLine(unPays.Monnaie);
                fichier.WriteLine(unPays.Valeur.ToString());
            }

            fichier.Close();
        }
    }

}

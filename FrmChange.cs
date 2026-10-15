
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace Projet_Fin_de_session
{

    public partial class FrmChange : Form
    {
        clsBureau monbureau;
        decimal tauxCAD = 1m;

        public FrmChange()
        {
            InitializeComponent();
        }

        private void FrmChange_Load(object sender, EventArgs e)
        {
            lblDate.Text = "Montréal, Aujourd'hui " + DateTime.Today.ToLongDateString();
            RemplirLesDevises();
            RemplirCombobox();
            AfficherTaux();
        }

        private void RemplirLesDevises()
        {
            monbureau = new clsBureau();

            List<clsPays> listeDevises = new List<clsPays>();
            listeDevises = clsSourceDeDonnees.GetTousLesPays();

           monbureau.Creer("001", "Bureau central", "Montréal", listeDevises, "Ouvert");
        }

        private void RemplirCombobox()
        {
            cboChoixPays.Items.Clear();

            foreach (clsPays paysActuel in monbureau.Pays)
            {
                cboChoixPays.Items.Add(paysActuel.Nom + " - " + paysActuel.Monnaie);
            }

            if (cboChoixPays.Items.Count > 0)
            {
                cboChoixPays.SelectedIndex = 0;
            }
        }

        private void AfficherTaux()
        { 

            clsPays Payschoisi= monbureau.Pays[cboChoixPays.SelectedIndex];

            decimal versDev = tauxCAD / (decimal)Payschoisi.Valeur;
            decimal versCAD = (decimal)Payschoisi.Valeur / tauxCAD;

            lblTauxActuelles.Text = "1 Dollar canadien = " + versDev.ToString("0.00") + " " + Payschoisi.Monnaie + "\n" +
                                    "1 " + Payschoisi.Monnaie + " = " + versCAD.ToString("0.00") + " Dollar canadien";

            lblCADversDev.Text = Payschoisi.Monnaie;
            lblDevversCAD.Text = "Dollar canadien";
        }

        

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (txtMontant.Text == "")
            {
                MessageBox.Show("Veuillez entrer un montant.");
                return;
            }

            decimal montant = Convert.ToDecimal(txtMontant.Text, CultureInfo.InvariantCulture);

            clsPays Payschoisi = monbureau.Pays[cboChoixPays.SelectedIndex];

            if ((double)Payschoisi.Valeur == 0)
            {
                MessageBox.Show("Taux de change invalide (valeur = 0).");
                return;
            }

            decimal result;
            string info;
            

            if (radCADversDev.Checked)
            {
                result = montant / (decimal)Payschoisi.Valeur;
                info = result.ToString("0.00") + " " + Payschoisi.Monnaie;
            }
            else 
            {
                result = Convert.ToDecimal(Payschoisi.GetValeurCanada((double)montant));
                info = result.ToString("0.00") + " Dollar canadien";
            }

            lblResultat.Text = info;
        }



        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
            monbureau.Fermer();
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cboChoixPays_SelectedIndexChanged(object sender, EventArgs e)
        {
            AfficherTaux();
        }

        private void btnReccomencer_Click(object sender, EventArgs e)
        {
            txtMontant.Text = "";
            lblResultat.Text = "";
            lblTauxActuelles.Text = "";
            radCADversDev.Checked = true;
            if (cboChoixPays.Items.Count > 0)
            {
                cboChoixPays.SelectedIndex = 0;
            }
            AfficherTaux();
        }
    }
}



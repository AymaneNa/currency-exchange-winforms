using Projet_Fin_de_session;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace ProjetFinDeSession
{
    public partial class frmAdmin : Form
    {
        List<clsPays> listeDesPays;
        clsPays paysSelectionne;
        bool modif= false;

        public frmAdmin()
        {
            InitializeComponent();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            listeDesPays = clsSourceDeDonnees.GetTousLesPays();
            RemplirListepays();
            Ajout();
        }

        private void RemplirListepays()
        {
            lstpays.Items.Clear();
            foreach (clsPays pays in listeDesPays)
            {
                lstpays.Items.Add(pays.Nom);
            }
            lblpopup.Text = "Pays 0 sur un total de " + listeDesPays.Count;
        }

        private void lstpays_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = lstpays.SelectedIndex;
            if (i >= 0)
            {
                paysSelectionne = listeDesPays[i];
                txtNomPays.Text = paysSelectionne.Nom;
                txtMonnaie.Text = paysSelectionne.Monnaie;
                txtValeur.Text = paysSelectionne.Valeur.ToString();

                lblpopup.Text = "Pays " + (i + 1) + " sur un total de " + listeDesPays.Count;
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            txtNomPays.Focus();
            modif = true;
            paysSelectionne = null;
            txtNomPays.Clear();
            txtMonnaie.Clear();
            txtValeur.Clear();
            Modif();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (paysSelectionne == null) return;
            modif= true;
            Modif();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (paysSelectionne == null) return;

            listeDesPays.Remove(paysSelectionne);
            paysSelectionne = null;
            RemplirListepays();
            txtNomPays.Clear();
            txtMonnaie.Clear();
            txtValeur.Clear();
            lblpopup.Text = "Pays 0 sur un total de " + listeDesPays.Count;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Ajout();
            if (paysSelectionne != null)
            {
                txtNomPays.Text = paysSelectionne.Nom;
                txtMonnaie.Text = paysSelectionne.Monnaie;
                txtValeur.Text = paysSelectionne.Valeur.ToString();

                int index = lstpays.SelectedIndex;
                lblpopup.Text = "Pays " + (index + 1) + " sur un total de " + listeDesPays.Count;
            }
            else
            {
                txtNomPays.Clear();
                txtMonnaie.Clear();
                txtValeur.Clear();
                lblpopup.Text = "Pays 0 sur un total de " + listeDesPays.Count;
            }
        }

        private void btnSauvgarder_Click(object sender, EventArgs e)
        {
            double valeur = Convert.ToDouble(txtValeur.Text, CultureInfo.InvariantCulture);

            if (paysSelectionne == null)
            {
                clsPays pays= new clsPays(txtNomPays.Text, txtMonnaie.Text, valeur);
                listeDesPays.Add(pays);
            }
            else
            {
                paysSelectionne.Nom = txtNomPays.Text;
                paysSelectionne.Monnaie = txtMonnaie.Text;
                paysSelectionne.Valeur = valeur;
            }

            clsSourceDeDonnees.SaveTousLesPays(listeDesPays);
            RemplirListepays();
            Ajout();
            lblpopup.Text = "Pays 0 sur un total de " + listeDesPays.Count;
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ajout()
        {
            btnAjouter.Visible = true;
            btnModifier.Visible = true;
            btnSupprimer.Visible = true;
            btnSauvgarder.Visible = false;
            btnAnnuler.Visible = false;
            txtNomPays.Enabled = true;
            txtMonnaie.Enabled = true;
            txtValeur.Enabled = true;
        }

        private void Modif()
        {
            btnAjouter.Visible = false;
            btnModifier.Visible = false;
            btnSupprimer.Visible = false;
            btnSauvgarder.Visible = true;
            btnAnnuler.Visible = true;
            txtNomPays.Enabled = true;
            txtMonnaie.Enabled= true;
            txtValeur.Enabled = true;
        }
    }
}

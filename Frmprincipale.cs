
using ProjetFinDeSession;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_Fin_de_session
{
    public partial class Frmprincipale: Form
    {
        public Frmprincipale()
        {
            InitializeComponent();
        }

        private void quittezToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string msg = "Voulez vous vraiment quitter ce programme ?";
            string titre = "Fermeture de l'application";
            if (MessageBox.Show(msg, titre, MessageBoxButtons.OKCancel,
            MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Application.Exit();

            }
        }

        private void mnuChange_Click(object sender, EventArgs e)
        {
            FrmChange FC = new FrmChange();
            FC.MdiParent = this;
            FC.Show();
        }

        private void mnuAdmin_Click(object sender, EventArgs e)
        {
            frmAdmin Fc= new frmAdmin();
            Fc.MdiParent = this;
            Fc.Show();
        }
    }
}

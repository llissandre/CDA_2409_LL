using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Age
{
    /// <summary>
    ///Classe de la fenêtre principale, qui permet de calculer et d'afficher l'age d'une personne
    ///</summary>
    public partial class frmMain : Form
    {
        private const String MESSAGE = "Bonjour {0}, vous avez {1} ans";
        private const String TITRE = "Age";

        /// <summary>
        /// Constructeur de la classe
        /// </summary>
        public frmMain()
        {
            InitializeComponent();
        }

        #region Partie 1 - Calcul et affichage

        private void btFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCalculer_Click(object sender, EventArgs e)
        {
            DateTime dtNaiss;
            DateTime dtJour;
            long nbAns;

            //Calcul de l'age
            //Dans cette version, on ne gère pas la validité de la date
            dtNaiss = Convert.ToDateTime(txtDtNaiss.Text);

            dtJour = DateTime.Today;
            nbAns = dtJour.Year - dtNaiss.Year;

            if ((dtNaiss.Month > dtJour.Month) || (dtNaiss.Month == dtJour.Month && dtNaiss.Day > dtJour.Day))
            {
                nbAns--;
            }

            //Affichage de l'age
            MessageBox.Show(String.Format(MESSAGE, txtNom.Text, nbAns), TITRE, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion Partie 1 - Calcul et affichage
    }
}

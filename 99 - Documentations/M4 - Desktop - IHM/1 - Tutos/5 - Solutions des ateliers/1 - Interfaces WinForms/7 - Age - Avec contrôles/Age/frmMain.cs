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
    ///     Classe de la fenêtre principale, qui permet de calculer et d'afficher l'age d'une personne
    ///
    ///     - Ajout d'un ToolTip
    ///     - Gestion du grisage / dégrisage
    ///     
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

            //Calcule de l'age
            dtNaiss = DateTime.Parse(txtDtNaiss.Text);
            dtJour = DateTime.Today;
            nbAns = dtJour.Year - dtNaiss.Year;

            if ((dtNaiss.Month > dtJour.Month) || (dtNaiss.Month == dtJour.Month && dtNaiss.Day > dtJour.Day))
            {
                nbAns--;
            }

            //Affichage de l'age
            MessageBox.Show(String.Format(MESSAGE, txtNom.Text, nbAns), TITRE, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        #region Partie 2 - Gestion des champs vides

        private void txtNom_TextChanged(object sender, EventArgs e)
        {
            Grisage();
        }

        private void txtDtNaiss_TextChanged(object sender, EventArgs e)
        {
            Grisage();
        }

        //Une alternative à KeyPress : positionner txtNom.CharacterCasing = CharacterCasing.Upper 
        private void txtNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            // On passe le caractère en majuscule
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        #endregion

        #region Fonctions perso

        /// <summary>
        /// Gestion Grisage 
        /// </summary>
        private void Grisage()
        {
            DateTime dtNaiss;

            // On teste que les champs soient renseignés et que la date de naissance soit valide et antérieure à la date du jour
            if (String.IsNullOrWhiteSpace(txtNom.Text) ||
                String.IsNullOrWhiteSpace(txtDtNaiss.Text) ||
                !DateTime.TryParse(txtDtNaiss.Text, out dtNaiss) ||
                dtNaiss >= DateTime.Today)
            {
                btCalculer.Enabled = false;
            }
            else
            {
                btCalculer.Enabled = true;
            }
        }

        #endregion

    }
}

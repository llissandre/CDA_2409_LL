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
    ///
    ///     - Ajout d'un ToolTip
    ///     - Gestion du grisage / dégrisage
    ///     - Gestion d'un texte par défaut. Événements 'Enter' et 'Leave' des champs texte.
    ///     - Gestion et sauvegarde des paramètres
    ///     
    ///</summary>
    public partial class frmMain : Form
    {
        private const String MESSAGE = "Bonjour {0}, vous avez {1} ans";
        private const String TITRE = "Age";
        private const String TXT_NOM_VIDE = "Saisir le nom";
        private const String TXT_DTNAISS_VIDE = "Saisir la date (jj/mm/aaaa)";   

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

        private void txtNom_Enter(object sender, EventArgs e)
        {
            if ( String.Compare(txtNom.Text, TXT_NOM_VIDE,true) == 0 )
            {
                txtNom.Text = String.Empty;
            }
        }

        private void txtNom_Leave(object sender, EventArgs e)
        {
            if ( String.IsNullOrEmpty(txtNom.Text) )
            {
                txtNom.Text = TXT_NOM_VIDE;
            }
        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {
            Grisage();
        }
       
        private void txtDtNaiss_Enter(object sender, EventArgs e)
        {
            if (String.Compare(txtDtNaiss.Text, TXT_DTNAISS_VIDE, true) == 0)
            {
                txtDtNaiss.Text = String.Empty;
            }
        }

        private void txtDtNaiss_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtDtNaiss.Text))
            {
                txtDtNaiss.Text = TXT_DTNAISS_VIDE;
            }
        }

        private void txtDtNaiss_TextChanged(object sender, EventArgs e)
        {
            Grisage();
        }

#endregion

#region Partie 3 - Gestion des paramètres

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Lecture des paramètres
            txtNom.Text = Properties.Settings.Default.Nom;
            txtDtNaiss.Text = Properties.Settings.Default.DtNaiss;

            if (String.IsNullOrEmpty(txtNom.Text))
            {
                txtNom.Text = TXT_NOM_VIDE;
            }

            if (String.IsNullOrEmpty(txtDtNaiss.Text))
            {
                txtDtNaiss.Text = TXT_DTNAISS_VIDE;
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Écriture des paramètres
            Properties.Settings.Default.Nom = txtNom.Text;
            Properties.Settings.Default.DtNaiss = txtDtNaiss.Text;

            // Sauvegarde des paramètres
            Properties.Settings.Default.Save();
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
            if (String.IsNullOrEmpty(txtNom.Text) || txtNom.Text == TXT_NOM_VIDE ||
                 String.IsNullOrEmpty(txtDtNaiss.Text) || txtDtNaiss.Text == TXT_DTNAISS_VIDE ||
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

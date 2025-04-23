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
    ///     - Gestion d'un texte par défaut. Événements 'Enter' et 'Leave' des champs texte
    ///     - Gestion et sauvegarde des paramètres
    ///     - Remplacer le champ 'txtDate' par un contrôle DateTimePicker & gérer les touches par défaut (Enter et Escape)
    ///     
    ///</summary>
    public partial class frmMain : Form
    {
        private const String MESSAGE = "Bonjour {0}, vous avez {1} ans";
        private const String TITRE = "Age";
        private const String TXT_NOM_VIDE = "Saisir le nom";

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
            dtNaiss = dtpNaiss.Value;
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
            if (String.Compare(txtNom.Text, TXT_NOM_VIDE, true) == 0)
            {
                txtNom.Text = String.Empty;
            }
        }

        private void txtNom_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNom.Text))
            {
                txtNom.Text = TXT_NOM_VIDE;
            }
        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {
            Grisage();
        }

        #endregion

        #region Partie 3 - Gestion des paramètres

        private void frmMain_Load(object sender, EventArgs e)
        {
            //Limites de validité des dates
            dtpNaiss.MinDate = new DateTime(2015, 1, 1);
            dtpNaiss.MaxDate = DateTime.Today;

            //Lecture des paramètres
            txtNom.Text = Properties.Settings.Default.Nom;
            dtpNaiss.Value = (Properties.Settings.Default.DtNaiss > dtpNaiss.MinDate) ? Properties.Settings.Default.DtNaiss : dtpNaiss.MinDate;

            if (String.IsNullOrEmpty(txtNom.Text))
            {
                txtNom.Text = TXT_NOM_VIDE;
            }

            // Positionnement de la fenêtre à l'écran
            if (Properties.Settings.Default.Position != Point.Empty)
            {
                this.Location = Properties.Settings.Default.Position;
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Écriture des paramètres
            Properties.Settings.Default.Nom = txtNom.Text;
            Properties.Settings.Default.DtNaiss = dtpNaiss.Value;

            // Coordonnées de la fenêtre à l'écran
            Properties.Settings.Default.Position = this.Location;

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
            if (String.IsNullOrEmpty(txtNom.Text) || txtNom.Text == TXT_NOM_VIDE)
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

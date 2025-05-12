using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Images
{
    /// <summary>
    /// 
    ///     1 - Rechercher un fichier Image sur le DD et afficher son chemin dans 'TxtNomFic'. 
    ///         Les fichiers image pris en compte seront de types : BMP; JPG; GIF; PNG; ICO
    ///         
    ///     2 - Ajouter le ferichi dans la liste des fichiers (lstbxImages). On doit gèrer les 
    ///         grisages des boutons 'btAjouter', 'btSupprimer' et 'btVider'
    ///         
    ///     3 - Empêcher l'utilisateur de mettre 2x le même fichier (avec le même chemin) dans
    ///         la ListBox (lstbxImages)
    ///         
    ///     4 - Afficher l'image (Contrôle PictureBox)
    ///         
    /// </summary>
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            // Appel de la fonction qui gère les grisages
            GestionGrisages();
        }

        #region Recherche des fichiers sur le DD

        private void BtRecherche_Click(object sender, EventArgs e)
        {
            // On ré-initialise la propriété 'FileName' à vide
            OFDImage.FileName = String.Empty;

            // On ré-initialise le champ 'TxtNomFic' à vide avant la recherche
            txtNomFic.Text = String.Empty;

            DialogResult resultat = OFDImage.ShowDialog();

            //Test si l'utilisateur a cliqué sur 'Ouvrir'
            if (resultat == DialogResult.OK)
            {
                txtNomFic.Text = OFDImage.FileName;
            }
        }

        #endregion

        #region Actions sur les boutons 'btAjouter', 'btSupprimer' et 'btVider'

        private void btAjouter_Click(object sender, EventArgs e)
        {
            if (txtNomFic.Text.Length > 0)
            {
                // Ajout du chemin de l'image dans la lstbxImages
                lstbxImages.Items.Add(txtNomFic.Text);
            }

            // Appel de la fonction qui gère les grisages
            GestionGrisages();
        }

        private void btSupprimer_Click(object sender, EventArgs e)
        {
            // On teste si il y a un élément sélectionné dans la lstbxImages
            if (lstbxImages.SelectedIndex != -1)
            {
                // On supprime l'élément sélectionné dans la lstbxImages
                lstbxImages.Items.RemoveAt(lstbxImages.SelectedIndex);
            }

            // Appel de la fonction qui gère les grisages
            GestionGrisages();
        }

        private void btVider_Click(object sender, EventArgs e)
        {
            // On vide la lstbxImages
            lstbxImages.Items.Clear();

            // On vide le picBxImage et on le redimensionne pour supprimer les scrollBar
            picBxImage.Image = null;

            // Appel de la fonction qui gère les grisages
            GestionGrisages();
        }

        #endregion

        #region Gestion des actions sur 'txtNomFic' et 'lstbxImages'

        private void TxtNomFic_TextChanged(object sender, EventArgs e)
        {
            // Appel de la fonction qui gère les grisages
            GestionGrisages();
        }

        private void lstbxImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Appel de la fonction qui gère les grisages
            GestionGrisages();

            // On affiche l'image dans le 'picBxImage' si il y en a une de sélectionnée dans la 'lstbxImages'
            if (lstbxImages.SelectedItem != null)
            {
                picBxImage.Load(lstbxImages.SelectedItem.ToString());
            }
            else
            {
                // On vide le picBxImage
                picBxImage.Image = null;
            }
        }

        #endregion

        #region Fonctions perso

        private void GestionGrisages()
        {
            btAjouter.Enabled = (txtNomFic.Text.Length > 0 && !lstbxImages.Items.Contains(txtNomFic.Text));
            btSupprimer.Enabled = (lstbxImages.SelectedIndex != -1);
            btVider.Enabled = (lstbxImages.Items.Count > 0);
        }

        #endregion

    }
}

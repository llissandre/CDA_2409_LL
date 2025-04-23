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
    ///     2 - Ajouter le fichier dans la liste des fichiers (lstbxImages). On doit gèrer les 
    ///         grisages des boutons 'btAjouter', 'btSupprimer' et 'btVider'
    ///         
    ///     3 - Empêcher l'utilisateur de mettre 2x le même fichier (avec le même chemin) dans
    ///         la ListBox (lstbxImages)
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
            // On teste si le champ 'txtNomFic' est renseigné
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
        }

        #endregion

        #region Fonctions perso

        private void GestionGrisages()
        {
            bool trouve = false;

            // Détection des doublons la plus simple mais ne peut pas tenir compte de la casse
            //trouve = lstbxImages.Items.Contains(txtNomFic.Text);

            // Parcourir tous les items pour voir si il existe déjà dans la collection. Cette méthode
            // permet de tenir compte de la casse            
            //foreach (string item in lstbxImages.Items)
            //{
            //    if (String.Compare(item, txtNomFic.Text, true) == 0)
            //    {
            //        trouve = true;
            //        break;
            //    }
            //}

            // Avec cette méthode on ne cherche que le nom du fichier (pas son chemin)
            string nomFicText = Path.GetFileName(txtNomFic.Text);
            foreach (string item in lstbxImages.Items)
            {
                string nomFicList = Path.GetFileName(item);
                if (String.Compare(nomFicText, nomFicList, true) == 0)
                {
                    trouve = true;
                    break;
                }
            }

            // Si le champ 'txtNomFic' est renseigné on dégrise le bouton 'Ajouter'
            btAjouter.Enabled = (txtNomFic.Text.Length > 0 && !trouve);

            // Si un élément est sélectionné dans la liste 'lstbxImages' on dégrise le bouton 'Supprimer'
            btSupprimer.Enabled = (lstbxImages.SelectedIndex != -1);

            // S'il reste des éléments dans la liste 'lstbxImages' on dégrise le bouton 'Vider'
            btVider.Enabled = (lstbxImages.Items.Count != 0);
        }

        #endregion

    }
}

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
    ///     2 - Ajouter le fichier dans la liste des fichiers (lstbxImages). On doit gérer les 
    ///         boutons 'Ajouter', 'Supprimer' et 'Vider'
    ///         
    /// </summary>
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
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
                //Ajout du chemin de l'image dans la lstbxImages
                lstbxImages.Items.Add(txtNomFic.Text);                
            }
        }

        private void btSupprimer_Click(object sender, EventArgs e)
        {
            // On teste si il y a un élément sélectionné dans la lstbxImages
            if (lstbxImages.SelectedIndex != -1)
            {
                // On supprime l'élément sélectionné dans la lstbxImages
                lstbxImages.Items.RemoveAt(lstbxImages.SelectedIndex);
            }

            // Autre méthode en travaillant avec l'objet sélectionné
            //if (lstbxImages.SelectedItem != null)
            //{
            //    // On supprime l'élément sélectionné dans la lstbxImages
            //    lstbxImages.Items.Remove(lstbxImages.SelectedItem);
            //}
        }

        private void btVider_Click(object sender, EventArgs e)
        {
            // On vide la lstbxImages
            lstbxImages.Items.Clear();
        }

        #endregion

    }
}

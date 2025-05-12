using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections.Specialized;

namespace Images
{
    /// <summary>
    /// 
    ///     1 - Rechercher un fichier Image sur le DD et afficher son chemin dans 'TxtNomFic'. 
    ///         Les fichiers image pris en compte seront de types : BMP; JPG; GIF; PNG; ICO
    ///         
    ///     2 - Ajouter le fichier dans la liste des fichiers (lstbxImages). On doit gérer les 
    ///         grisages des boutons 'btAjouter', 'btSupprimer' et 'btVider'
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
                // Ajout du chemin de l'image dans la lstbxImages
                lstbxImages.Items.Add(txtNomFic.Text);

                // Appel de la fonction qui gère les grisages
                GestionGrisages();
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

        #region Sauvegarde/Restauration de la listbox dans les paramètres

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            //A la fermeture de la fenêtre, le contenu de la lstbxImages est sauvegardé dans les paramètres (settings)
            //afin que l'utilisateur retrouve les images qu'il a sélectionnées précédemment

            //Le paramètre déclaré dans les settings afin de sauvegarder les items de la lstbxImages est du type StringCollection 
            StringCollection collection = new StringCollection();

            //On utilise un tableau pour recopier les items dans la lstbxImages dans la StringCollection 
            string[] tableau = new string[lstbxImages.Items.Count];
            lstbxImages.Items.CopyTo(tableau, 0);
            collection.AddRange(tableau);

            Properties.Settings.Default.lstImagesCollection = collection;

            Properties.Settings.Default.Save();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //Au chargement de la fenêtre, on lit les paramètres utilisateur (settings) pour initialiser la lstbxImages
            if (Properties.Settings.Default.lstImagesCollection != null)
            {
                //On convertit la StringCollection en tableau
                string[] tableau = new string[Properties.Settings.Default.lstImagesCollection.Count];
                Properties.Settings.Default.lstImagesCollection.CopyTo(tableau, 0);
                //On ajoute tous les éléments du tableau aux items de la lstbxImages
                lstbxImages.Items.AddRange(tableau);
            }

            // Appel de la fonction qui gère les grisages
            GestionGrisages();
        }

        #endregion Sauvegarde/Restauration de la listbox dans les paramètres

        #region Fonctions perso

        private void GestionGrisages()
        {
            //if (txtNomFic.Text.Length > 0)
            //{
            //    btAjouter.Enabled = true;
            //}
            //else
            //{
            //    btAjouter.Enabled = false;
            //}

            // Si le champ 'txtNomFic' est renseigné on dégrise le bouton 'Ajouter'
            btAjouter.Enabled = (txtNomFic.Text.Length > 0);



            //if (lstbxImages.SelectedIndex == -1)
            //{
            //    btSupprimer.Enabled = false;
            //}
            //else
            //{
            //    btSupprimer.Enabled = true;
            //}

            // Si un élément est sélectionné dans la liste 'lstbxImages' on dégrise le bouton 'Supprimer'
            btSupprimer.Enabled = (lstbxImages.SelectedIndex != -1);


            //if (lstbxImages.Items.Count == 0)
            //{
            //    btVider.Enabled = false;
            //}
            //else
            //{
            //    btVider.Enabled = true;
            //}

            // Si il reste des éléments dans la liste 'lstbxImages' on dégrise le bouton 'Vider'
            btVider.Enabled = (lstbxImages.Items.Count != 0);
        }

        #endregion

    }
}

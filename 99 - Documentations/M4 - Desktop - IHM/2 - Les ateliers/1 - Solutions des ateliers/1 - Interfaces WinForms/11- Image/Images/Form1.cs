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
    /// </summary>
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region Actions utilisateur

        private void BtRecherche_Click(object sender, EventArgs e)
        {
            // On ré-initialise la propriété 'FileName' à vide
            OFDImage.FileName = String.Empty;

            //Restaure le dernier dossier ouvert par l'utilisateur 
            OFDImage.RestoreDirectory = true;

            OFDImage.Filter = "Images | *.BMP; *.JPG; *.GIF; *.PNG; | Icônes | *.ico";

            // On ré-initialise le champ 'TxtNomFic' à vide avant la recherche
            TxtNomFic.Text = String.Empty;

            DialogResult resultat = OFDImage.ShowDialog();

            //Test si l'utilisateur a cliqué sur 'Ouvrir'
            if (resultat == DialogResult.OK)
            {
                TxtNomFic.Text = OFDImage.FileName;
            }
        }

        #endregion
    }
}

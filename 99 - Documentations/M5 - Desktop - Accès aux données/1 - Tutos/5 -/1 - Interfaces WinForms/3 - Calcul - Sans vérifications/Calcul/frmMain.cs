using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcul
{
    /// <summary>
    /// Réalisation d'une calculatrice permettant d'effectuer une addition
    /// 
    ///     1 - Réalisation de l'interface
    ///     2 - Mise en place de l'algorithme de calcul 
    ///     
    /// </summary>
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        // Click sur le bouton 'btResultat'
        private void btResultat_Click(object sender, EventArgs e)
        {
            long somme = Convert.ToInt32(txtNb1.Text) + Convert.ToInt32(txtNb2.Text);
            lblResult.Text = somme.ToString();
        }

        private void btCE_Click(object sender, EventArgs e)
        {
            // Réinitialisation des champs à vide
            txtNb1.Clear();
            txtNb2.Clear();
            lblResult.Text = String.Empty;

            // On remet le focus sur le premier champ
            txtNb1.Focus();
        }

        private void frmMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            // La touche 'C' permet de simuler le bouton CE. Pour capturer les touches, même
            // si un autre contrôle à le focus, il faut pacer lea propriété 'KeyPreview' de
            // la fenêtre à True
            if (e.KeyChar == 'C' || e.KeyChar == 'c')
            {
                // Cette touche est supprimée de l'affichage
                e.Handled = true;

                // On simule le click sur le bouton 'btCE'
                btCE.PerformClick();
            }
        }
    }
}

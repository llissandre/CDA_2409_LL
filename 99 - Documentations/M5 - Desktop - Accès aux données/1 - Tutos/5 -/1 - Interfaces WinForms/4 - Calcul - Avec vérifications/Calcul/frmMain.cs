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
    ///     3 - Gestion des erreurs 
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
            decimal nb1;
            decimal nb2;

            // Conversion du premier nombre en long
            if (!decimal.TryParse(txtNb1.Text, out nb1))
            {
                // On affiche un message d'erreur à l'utilisateur
                MessageBox.Show("Saisie invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // On efface le champ de saisie et on se repositionne dessus
                txtNb1.Text = "";
                txtNb1.Focus();
                return;
            }

            // Conversion du deuxième nombre en long
            if (!decimal.TryParse(txtNb2.Text, out nb2))
            {
                // On affiche un message d'erreur à l'utilisateur
                MessageBox.Show("Saisie invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // On efface le champ de saisie et on se repositionne dessus
                txtNb2.Text = "";
                txtNb2.Focus();
                return;
            }

            // On calcule la somme et on l'affiche dans le label
            decimal Res = nb1 + nb2;
            lblResult.Text = Res.ToString();
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

            // On transforme le '.' en ','
            if (e.KeyChar == '.')
                e.KeyChar = ',';

            // On accepte uniquement les nombres, la virgule et le retour arrière pour corriger
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtNb1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',' && txtNb1.Text.Contains(','))
                e.Handled = true;
        }

        private void txtNb2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',' && txtNb2.Text.Contains(','))
                e.Handled = true;
        }
    }
}

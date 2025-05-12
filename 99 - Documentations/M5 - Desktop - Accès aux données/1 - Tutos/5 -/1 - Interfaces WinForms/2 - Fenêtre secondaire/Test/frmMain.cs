using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    /// <summary>
    /// Fenêtre mère qui va lancer une fenêtre fille et récupérer des données à la fermeture
    /// de cette fenêtre fille.
    /// </summary>
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btFen2_Click(object sender, EventArgs e)
        {
            // Création de la fenêtre secondaire, avec un appel automatique de la 
            // méthode Dispose à la sortie du bloc de code
            using (frmFille fen2 = new frmFille())
            {
                // On change la couleur de la fenêtre secondaire
                fen2.BackColor = Color.Aqua;

                // On change le titre de la fenêtre secondaire
                fen2.Text = txtTitreFen2.Text;

                // On change l'opacité de la fenêtre principale
                this.Opacity = 0.5;

                // On affiche la fenêtre secondaire de façon modale. Le code se poursuivra
                // à la fermeture de la fenêtre secondaire
                DialogResult res = fen2.ShowDialog();

                // Après la fermeture de la fenêtre secondaire, on change l'opacité de
                // la fenêtre principale
                this.Opacity = 1;

                // Si l'utilisateur a cliqué sur le bouton 'Valider'
                if (res == DialogResult.OK)
                {
                    // On récupère et on affiche le contenu de la Textbox 'txtFen2' qui se
                    // trouve sur la fenêtre secondaire. Cela est permis car cette Textbox
                    // est déclarée 'Internal' dans sa propriété 'Modifier'
                    txtTitreFen2.Text = fen2.txtFen2.Text;
                }
                else
                {
                    // Si la fenêtre secondaire c'est fermée autrement que par le bouton
                    // 'Valider', on vide la Textbox 'txtTitreFen2'
                    txtTitreFen2.Clear();
                }
            }
        }
    }
}

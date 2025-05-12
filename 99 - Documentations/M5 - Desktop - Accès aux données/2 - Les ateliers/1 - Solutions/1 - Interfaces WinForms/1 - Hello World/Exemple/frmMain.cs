using System;
using System.Windows.Forms;

namespace Exemple
{
    /// <summary>
    /// Premiere interface pour découvrir présentant les composants les plus utilisés
    /// </summary>
    public partial class frmMain : Form
    {
        const string TITRE = "Fermeture";
        const string MESSAGE = "Confirmez vous la fermeture de l'application ?";

        ///// <summary>
        ///// Constructeur de la fenêtre. Il appelle la méthode 'InitializeComponent' qui permet de créer les contrôles posés sur la fenêtre et
        ///// d’initialiser les propriétés
        ///// </summary>
        public frmMain()
        {
            // Méthode générée automatiquement par l'IDE
            // Elle permet de créer et d'initialiser les composants (bouton, label) présents sur la fenêtre
            InitializeComponent();
        }

        private void btQuitter_Click(object sender, EventArgs e)
        {
            // 'this' représente l'objet dans lequel on se trouve (ici frmMain)
            // On appelle une méthode de cet objet (ici 'Close()')
            // Cette méthode va demander la fermeture de la fenêtre
            this.Close();
        }

        // Événement généré à la fermeture de la fenêtre (juste avant la fermeture)
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            // On demande confirmation de la fermeture de l'application
            DialogResult retour = MessageBox.Show(MESSAGE, 
                                                  TITRE, 
                                                  MessageBoxButtons.YesNo, 
                                                  MessageBoxIcon.Question, 
                                                  MessageBoxDefaultButton.Button2);

            if (retour == DialogResult.No)
            {                
                e.Cancel = true; //On annule ainsi la fermeture de la fenêtre 
            }
        }
    }
}

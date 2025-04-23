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
    /// Fenêtre fille qui possède une Textbox déclarée 'Internal' et donc accessible
    /// à partir d'une autre fenêtre.
    /// </summary>
    public partial class frmFille : Form
    {
        public frmFille()
        {
            InitializeComponent();
        }

        private void btValider_Click(object sender, EventArgs e)
        {
            // On indique à la fenêtre mère que l'on a cliqué sur le bouton 'Valider'
            this.DialogResult = DialogResult.OK;

            // On ferme la fenêtre
            this.Close();
        }

        private void btAnnuler_Click(object sender, EventArgs e)
        {
            // On indique à la fenêtre mère que l'on a cliqué sur le bouton 'Annuler'
            this.DialogResult = DialogResult.Cancel;

            // On ferme la fenêtre
            this.Close();
        }
    }
}

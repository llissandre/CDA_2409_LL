using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Utilisateurs
{
    /// <summary>
    /// 
    ///     1 - Afficher la table Utilisateurs.
    ///     
    /// </summary>
    public partial class frmMain : Form
    {
        DB _db;
        BindingList<Utilisateur> _utilisateurs;

        public frmMain()
        {
            InitializeComponent();
            InitializeBinding();

            _db = new();
            btActualiser.PerformClick();
        }

        private void btActualiser_Click(object sender, EventArgs e)
        {
            Utilisateur current = BSUtilisateurs.Current as Utilisateur;

            _utilisateurs.Clear();
            var utilisateurs = _db.GetUtilisateurs();
            foreach (Utilisateur utilisateur in utilisateurs)
                _utilisateurs.Add(utilisateur);

            if (current is not null)
                BSUtilisateurs.Position = _utilisateurs.IndexOf(_utilisateurs.Where(u => u.Id == current.Id).FirstOrDefault());
        }

        private void btAjouter_Click(object sender, EventArgs e)
        {
            // On peut tester si l'utilisateur existe en local
            //if (_utilisateurs.Where(u => u.Nom == txtNom.Text && u.Prenom == txtPrenom.Text && u.DtNaiss == dtpNaiss.Value).Count() > 0)
            //    return;
                
            var id = _db.InsertIfNotExistUtilisateur(txtNom.Text, txtPrenom.Text, dtpNaiss.Checked ? dtpNaiss?.Value : null);
            btActualiser.PerformClick();
            BSUtilisateurs.Position = _utilisateurs.IndexOf(_utilisateurs.Where(u => u.Id == id).FirstOrDefault());
        }

        private void btSupprimer_Click(object sender, EventArgs e)
        {
            Utilisateur current = BSUtilisateurs.Current as Utilisateur;

            if (current is not null)
            {
                if (MessageBox.Show($"Confirmez vous la suppression de l'utilisateur {current.Nom} ?", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    // Requête classique
                    //var nb = _db.DeleteUtilisateur(current.Id);
                    //btActualiser.PerformClick();

                    // Requête optimiste
                    var nb = _db.DeleteOptimistUtilisateur(current.Id, current.Nom, current.Prenom);

                    if (nb == 0)
                    {
                        MessageBox.Show("Vous ne possédez pas les dernières valeurs", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    btActualiser.PerformClick();
                }
            }
        }

        private void btModifier_Click(object sender, EventArgs e)
        {
            Utilisateur current = BSUtilisateurs.Current as Utilisateur;

            if (current is not null)
            {
                // Requête classique
                //var nb = _db.UpdateUtilisateur(current.Id, txtNom.Text, txtPrenom.Text, dtpNaiss.Value);
                //btActualiser.PerformClick();

                // Requête optimiste
                var nb = _db.UpdateOptimistUtilisateur(current.Id, txtNom.Text, txtPrenom.Text, dtpNaiss.Checked ? dtpNaiss.Value : null, current.Nom, current.Prenom, current.DtNaiss);

                if (nb == 0)
                {
                    MessageBox.Show("Vous ne possédez pas les dernières valeurs", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                btActualiser.PerformClick();
            }
        }
        private void InitializeBinding()
        {
            _utilisateurs = new BindingList<Utilisateur>();
            BSUtilisateurs.DataSource = _utilisateurs;
            dgvUtilisateurs.DataSource = BSUtilisateurs;
            txtNom.DataBindings.Add("Text", BSUtilisateurs, "Nom", false, DataSourceUpdateMode.Never);
            txtPrenom.DataBindings.Add("Text", BSUtilisateurs, "Prenom", false, DataSourceUpdateMode.Never);
            dtpNaiss.DataBindings.Add("Text", BSUtilisateurs, "DtNaiss", false, DataSourceUpdateMode.Never);
        }
    }
}

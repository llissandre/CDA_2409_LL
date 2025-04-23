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
            var nb = _db.InsertUtilisateur(txtNom.Text, txtPrenom.Text, dtpNaiss.Value);
            btActualiser.PerformClick();
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

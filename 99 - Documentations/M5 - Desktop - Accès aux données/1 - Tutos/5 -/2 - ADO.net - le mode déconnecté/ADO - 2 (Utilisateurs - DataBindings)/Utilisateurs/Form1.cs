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
        }

        private void btActualiser_Click(object sender, EventArgs e)
        {
            // Sauvegarde du current
            Utilisateur current = BSUtilisateurs.Current as Utilisateur;

            // Remplissage de la liste
            _utilisateurs.Clear();
            var utilisateurs = _db.GetUtilisateurs();
            foreach (Utilisateur utilisateur in utilisateurs)
                _utilisateurs.Add(utilisateur);

            // On se repositionne sur le current
            if (current is not null)
                BSUtilisateurs.Position = _utilisateurs.IndexOf(_utilisateurs.Where(u => u.Id == current.Id).FirstOrDefault());
        }


        private void InitializeBinding()
        {
            // DataBindings
            _utilisateurs = new BindingList<Utilisateur>();
            BSUtilisateurs.DataSource = _utilisateurs;
            dgvUtilisateurs.DataSource = BSUtilisateurs;
            lbxUtilisateurs.DataSource = BSUtilisateurs;
            lbxUtilisateurs.DisplayMember = "Nom";
            txtUtilisateurs.DataBindings.Add("Text", BSUtilisateurs, "Prenom", false, DataSourceUpdateMode.Never);
            dtpUtilisateurs.DataBindings.Add("Text", BSUtilisateurs, "DtNaiss", false, DataSourceUpdateMode.Never);
            cbxUtilisateurs.DataSource = BSUtilisateurs;
            cbxUtilisateurs.DisplayMember = "Id";

            // Colonnes DataGridView
            dgvUtilisateurs.Columns["Id"].Visible = false;
            dgvUtilisateurs.Columns["DtNaiss"].HeaderText = "Date de naissance";
            dgvUtilisateurs.Columns["DtNaiss"].DefaultCellStyle.Format = "D";
        }

        private void BSUtilisateurs_CurrentChanged(object sender, EventArgs e)
        {
            Utilisateur current = BSUtilisateurs.Current as Utilisateur;

            if (current != null)
                this.Text = $"{current.Prenom} - {current.Nom}";
        }
    }
}

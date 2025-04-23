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
            _utilisateurs = new BindingList<Utilisateur>();
            BSUtilisateurs.DataSource = _utilisateurs;
            dgvUtilisateurs.DataSource = BSUtilisateurs;
        }
    }
}

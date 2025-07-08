using System.ComponentModel;
using System.Text.Json;

namespace Departements
{
    public partial class Form1 : Form
    {
        API _api;
        BindingList<Departement> _blstDepartements;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _api = new();
            InitializeBinding();
        }

        private async void btDepartements_Click(object sender, EventArgs e)
        {
            await ActualiserDepartementsAsync();
        }

        private async Task ActualiserDepartementsAsync()
        {
            // Sauvegarde du current
            Departement current = bsDepartements.Current as Departement;

            // Remplissage de la liste
            try
            {
                var departements = await _api.CallRESTAsync("https://geo.api.gouv.fr/departements");

                _blstDepartements.Clear();
                foreach (Departement d in departements)
                    _blstDepartements.Add(d);

                // On se repositionne sur le current
                if (current is not null)
                    bsDepartements.Position = _blstDepartements.IndexOf(_blstDepartements.Where(d => d.code == current.code).FirstOrDefault());
            }
            catch (Exception ex) 
            { 
                MessageBox.Show("Erreur d'accès à l'API", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeBinding()
        {
            _blstDepartements = new();
            bsDepartements.DataSource = _blstDepartements;

            lbxDepartements.DataSource = bsDepartements;
            lbxDepartements.DisplayMember = "nom";
        }
    }
}
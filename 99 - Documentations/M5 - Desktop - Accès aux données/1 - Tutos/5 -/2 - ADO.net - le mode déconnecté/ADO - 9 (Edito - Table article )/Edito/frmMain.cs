using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edito
{
    public partial class frmMain : Form
    {
        DB _db;
        BindingList<Article> _articles;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            InitializeBinding();
            _db = new();
            btArticleActualiser.PerformClick();
        }

        private void tabEdito_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabEdito.SelectedTab == tabArticles)
            {
                btArticleActualiser.PerformClick();
            }
        }

        #region Articles

        private void btArticleActualiser_Click(object sender, EventArgs e)
        {
            // Sauvegarde du current
            Article current = BSArticles.Current as Article;

            // Remplissage de la liste
            _articles.Clear();
            var articles = _db.GetArticles();
            foreach (Article a in articles)
                _articles.Add(a);

            // On se repositionne sur le current
            if (current is not null)
                BSArticles.Position = _articles.IndexOf(_articles.Where(u => u.IdArticle == current.IdArticle).FirstOrDefault());
        }

        private void btArticleAjouter_Click(object sender, EventArgs e)
        {
            var id = _db.InsertArticle(txtTitreArticle.Text, txtCorpsArticle.Text, string.IsNullOrWhiteSpace(txtAuteurArticle.Text) ? null : txtAuteurArticle.Text);
            btArticleActualiser.PerformClick();
            BSArticles.Position = _articles.IndexOf(_articles.FirstOrDefault(u => u.IdArticle == id));
        }

        private void btArticleModifier_Click(object sender, EventArgs e)
        {
            Article current = BSArticles.Current as Article;

            if (current is not null)
            {
                // Requête classique
                var nb = _db.UpdateArticle(current.IdArticle, txtTitreArticle.Text, txtCorpsArticle.Text, string.IsNullOrWhiteSpace(txtAuteurArticle.Text) ? null : txtAuteurArticle.Text);
                btArticleActualiser.PerformClick();
            }
        }

        private void btArticleSupprimer_Click(object sender, EventArgs e)
        {
            Article current = BSArticles.Current as Article;

            if (current is not null)
            {
                if (MessageBox.Show($"Confirmez vous la suppression de l'article {current.Titre} ?", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    // Requête classique
                    var nb = _db.DeleteArticle(current.IdArticle);
                    btArticleActualiser.PerformClick();
                }
            }

        }

        #endregion Articles

        private void InitializeBinding()
        {
            _articles = new BindingList<Article>();
            BSArticles.DataSource = _articles;
            dgvArticles.DataSource = BSArticles;
            txtTitreArticle.DataBindings.Add("Text", BSArticles, "Titre", false, DataSourceUpdateMode.Never);
            txtCorpsArticle.DataBindings.Add("Text", BSArticles, "Corps", false, DataSourceUpdateMode.Never);
            txtAuteurArticle.DataBindings.Add("Text", BSArticles, "Auteur", false, DataSourceUpdateMode.Never);
        }
    }
}

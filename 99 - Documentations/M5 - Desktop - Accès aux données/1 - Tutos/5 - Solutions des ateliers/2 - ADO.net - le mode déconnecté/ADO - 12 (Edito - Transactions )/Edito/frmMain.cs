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
        BindingList<Journal> _journaux;

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
            else if (tabEdito.SelectedTab == tabJournaux)
            {
                btJournalActualiser.PerformClick();
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
                    // Suppression de l'article si il n'est pas dans la table composition
                    var nb = _db.DeleteArticleIfNotComposition(current.IdArticle);

                    if (nb == 0)
                    {
                        MessageBox.Show($"L'article {current.Titre} est utilisé dans un journal", "Supprimer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    btArticleActualiser.PerformClick();
                }
            }
        }

        #endregion Articles

        #region Journaux

        private void btJournalActualiser_Click(object sender, EventArgs e)
        {
            // Sauvegarde du current
            Journal current = BSJournaux.Current as Journal;

            // Remplissage de la liste
            _journaux.Clear();
            var journaux = _db.GetJournaux();
            foreach (Journal j in journaux)
                _journaux.Add(j);

            // On se repositionne sur le current
            if (current is not null)
                BSJournaux.Position = _journaux.IndexOf(_journaux.Where(u => u.IdJournal == current.IdJournal).FirstOrDefault());
        }

        private void btJournalAjouter_Click(object sender, EventArgs e)
        {
            var id = _db.InsertJournal(txtTitreJournal.Text, dtpDtParutionJournal.Checked ? dtpDtParutionJournal.Value : null);
            btJournalActualiser.PerformClick();
            BSJournaux.Position = _journaux.IndexOf(_journaux.FirstOrDefault(u => u.IdJournal == id));
        }

        private void btJournalModifier_Click(object sender, EventArgs e)
        {
            Journal current = BSJournaux.Current as Journal;

            if (current is not null)
            {
                // Requête classique
                var nb = _db.UpdateJournal(current.IdJournal, txtTitreJournal.Text, dtpDtParutionJournal.Checked ? dtpDtParutionJournal.Value : null);
                btJournalActualiser.PerformClick();
            }
        }

        private void btJournalSupprimer_Click(object sender, EventArgs e)
        {
            Journal current = BSJournaux.Current as Journal;

            if (current is not null)
            {
                if (MessageBox.Show($"Confirmez vous la suppression du journal {current.Titre} ?", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    // Suppression du journal en cascade
                    var nb = _db.DeleteJournalCascade(current.IdJournal);

                    btJournalActualiser.PerformClick();
                }
            }
        }

        #endregion Journaux

        private void InitializeBinding()
        {
            _articles = new BindingList<Article>();
            BSArticles.DataSource = _articles;
            dgvArticles.DataSource = BSArticles;
            txtTitreArticle.DataBindings.Add("Text", BSArticles, "Titre", false, DataSourceUpdateMode.Never);
            txtCorpsArticle.DataBindings.Add("Text", BSArticles, "Corps", false, DataSourceUpdateMode.Never);
            txtAuteurArticle.DataBindings.Add("Text", BSArticles, "Auteur", false, DataSourceUpdateMode.Never);

            _journaux = new BindingList<Journal>();
            BSJournaux.DataSource = _journaux;
            dgvJournaux.DataSource = BSJournaux;
            txtTitreJournal.DataBindings.Add("Text", BSJournaux, "Titre", false, DataSourceUpdateMode.Never);
            dtpDtParutionJournal.DataBindings.Add("Text", BSJournaux, "DtParution", false, DataSourceUpdateMode.Never);
        }
    }
}

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
        BindingList<Journal> _journauxCompo;
        BindingList<Article> _articlesInJournal;
        BindingList<Article> _articlesNotInJournal;

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
            else if (tabEdito.SelectedTab == tabCompositions)
            {
                btJournalCompositionActualiser.PerformClick();
            }
        }

        #region Articles

        private async void btArticleActualiser_Click(object sender, EventArgs e)
        {
            await ActualiserArticleAsync();
        }

        private async void btArticleAjouter_Click(object sender, EventArgs e)
        {
            var id = await _db.InsertArticleAsync(txtTitreArticle.Text, txtCorpsArticle.Text, string.IsNullOrWhiteSpace(txtAuteurArticle.Text) ? null : txtAuteurArticle.Text);
            await ActualiserArticleAsync();
            BSArticles.Position = _articles.IndexOf(_articles.FirstOrDefault(u => u.IdArticle == id));
        }

        private async void btArticleModifier_Click(object sender, EventArgs e)
        {
            Article current = BSArticles.Current as Article;

            if (current is not null)
            {
                // Requête classique
                var nb = await _db.UpdateArticleAsync(current.IdArticle, txtTitreArticle.Text, txtCorpsArticle.Text, string.IsNullOrWhiteSpace(txtAuteurArticle.Text) ? null : txtAuteurArticle.Text);
                await ActualiserArticleAsync();
            }
        }

        private async void btArticleSupprimer_Click(object sender, EventArgs e)
        {
            Article current = BSArticles.Current as Article;

            if (current is not null)
            {
                if (MessageBox.Show($"Confirmez vous la suppression de l'article {current.Titre} ?", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    // Suppression de l'article si il n'est pas dans la table composition
                    var nb = await _db.DeleteArticleIfNotCompositionAsync(current.IdArticle);

                    if (nb == 0)
                    {
                        MessageBox.Show($"L'article {current.Titre} est utilisé dans un journal", "Supprimer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    await ActualiserArticleAsync();
                }
            }
        }

        private async Task ActualiserArticleAsync()
        {
            // Sauvegarde du current
            Article current = BSArticles.Current as Article;

            // Remplissage de la liste            
            var articles = await _db.GetArticlesAsync();
            _articles.Clear();
            foreach (Article a in articles)
                _articles.Add(a);

            // On se repositionne sur le current
            if (current is not null)
                BSArticles.Position = _articles.IndexOf(_articles.Where(u => u.IdArticle == current.IdArticle).FirstOrDefault());
        }

        #endregion Articles

        #region Journaux

        private async void btJournalActualiser_Click(object sender, EventArgs e)
        {
            await ActualiserJournalAsync();
        }              

        private async void btJournalAjouter_Click(object sender, EventArgs e)
        {
            var id = await _db.InsertJournalAsync(txtTitreJournal.Text, dtpDtParutionJournal.Checked ? dtpDtParutionJournal.Value : null);
            await ActualiserJournalAsync();
            BSJournaux.Position = _journaux.IndexOf(_journaux.FirstOrDefault(u => u.IdJournal == id));
        }

        private async void btJournalModifier_Click(object sender, EventArgs e)
        {
            Journal current = BSJournaux.Current as Journal;

            if (current is not null)
            {
                // Requête classique
                var nb = await _db.UpdateJournalAsync(current.IdJournal, txtTitreJournal.Text, dtpDtParutionJournal.Checked ? dtpDtParutionJournal.Value : null);
                await ActualiserJournalAsync();
            }
        }

        private async void btJournalSupprimer_Click(object sender, EventArgs e)
        {
            Journal current = BSJournaux.Current as Journal;

            if (current is not null)
            {
                if (MessageBox.Show($"Confirmez vous la suppression du journal {current.Titre} ?", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    // Suppression du journal en cascade
                    var nb = await _db.DeleteJournalCascadeAsync(current.IdJournal);

                    await ActualiserJournalAsync();
                }
            }
        }

        private async Task ActualiserJournalAsync()
        {
            // Sauvegarde du current
            Journal current = BSJournaux.Current as Journal;

            // Remplissage de la liste            
            var journaux = await _db.GetJournauxAsync();
            _journaux.Clear();
            foreach (Journal j in journaux)
                _journaux.Add(j);

            // On se repositionne sur le current
            if (current is not null)
                BSJournaux.Position = _journaux.IndexOf(_journaux.Where(u => u.IdJournal == current.IdJournal).FirstOrDefault());
        }

        #endregion Journaux

        #region Composition

        private async void BSJournauxCompo_CurrentChanged(object sender, EventArgs e)
        {
            var journal = BSJournauxCompo.Current as Journal;

            if (journal != null)
            {
                // Remplissage de la liste des articles contenus                
                var articlesIn = await _db.GetArticlesInJournalAsync(journal.IdJournal);
                _articlesInJournal.Clear();
                foreach (Article a in articlesIn)
                    _articlesInJournal.Add(a);

                // Remplissage de la liste des articles exclus                
                var articlesNotIn = await _db.GetArticlesNotInJournalAsync(journal.IdJournal);
                _articlesNotInJournal.Clear();
                foreach (Article a in articlesNotIn)
                    _articlesNotInJournal.Add(a);
            }
        }

        private async void btJournalCompositionActualiser_Click(object sender, EventArgs e)
        {
            await ActualiserJournalComposition();
        }

        private async void btJournalCompositionExclure_Click(object sender, EventArgs e)
        {
            Journal currentJournal = BSJournauxCompo.Current as Journal;
            Article currentArticle = BSArticlesInJournal.Current as Article;

            if (currentJournal != null && currentArticle != null)
            {
                var nb = await _db.DeleteCompositionAsync(currentJournal.IdJournal, currentArticle.IdArticle);
            }

            await ActualiserJournalComposition();
        }

        private async void btJournalCompositionInclure_Click(object sender, EventArgs e)
        {
            Journal currentJournal = BSJournauxCompo.Current as Journal;
            Article currentArticle = BSArticlesNotInJournal.Current as Article;

            if (currentJournal != null && currentArticle != null)
            {
                var nb = await _db.InsertCompositionAsync(currentJournal.IdJournal, currentArticle.IdArticle);
            }

            await ActualiserJournalComposition();
        }

        private async Task ActualiserJournalComposition()
        {
            // Sauvegarde du current
            Journal current = BSJournauxCompo.Current as Journal;

            // Remplissage de la liste            
            var journaux = await _db.GetJournauxAsync();
            _journauxCompo.Clear();
            foreach (Journal j in journaux)
                _journauxCompo.Add(j);

            // On se repositionne sur le current
            if (current is not null)
                BSJournauxCompo.Position = _journauxCompo.IndexOf(_journauxCompo.Where(u => u.IdJournal == current.IdJournal).FirstOrDefault());
        }

        #endregion Composition
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

            _journauxCompo = new BindingList<Journal>();
            BSJournauxCompo.DataSource = _journauxCompo;
            dgvJournalComposition.DataSource = BSJournauxCompo;
            _articlesInJournal = new BindingList<Article>();
            BSArticlesInJournal.DataSource = _articlesInJournal;
            dgvArticlesInJournal.DataSource = BSArticlesInJournal;
            _articlesNotInJournal = new BindingList<Article>();
            BSArticlesNotInJournal.DataSource = _articlesNotInJournal;
            dgvArticlesNotInJournal.DataSource = BSArticlesNotInJournal;
        }
    }
}

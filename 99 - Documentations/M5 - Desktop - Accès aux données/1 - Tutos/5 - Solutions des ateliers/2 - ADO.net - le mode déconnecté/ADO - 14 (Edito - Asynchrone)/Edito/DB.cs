using Dapper;
using Edito.Properties;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edito
{
    internal class DB
    {
        private readonly MySqlConnection _dbConnection;
        private readonly SemaphoreSlim _semaphore = new(1, 1);

        public DB()
        {
            _dbConnection = new(Settings.Default.EditoConnectionString);            
        }

        #region Articles

        public async Task<IEnumerable<Article>> GetArticlesAsync()
        {
            try
            {
                await OpenConnectionAsync();
                var q = "SELECT * from Article";
                return await _dbConnection.QueryAsync<Article>(q);
            }
            finally { await CloseConnectionAsync(); }
        }

        public async Task<int> InsertArticleAsync(string titre, string corps, string auteur)
        {
            try
            {
                await OpenConnectionAsync();
                var q = "INSERT INTO Article (Titre,Corps,Auteur) VALUES (@titre, @corps, @auteur); SELECT LAST_INSERT_ID()";
                var result = await _dbConnection.QueryAsync<int>(q, new { titre, corps, auteur });
                return result.Single();
            }
            finally { await CloseConnectionAsync(); }
        }

        public async Task<int> UpdateArticleAsync(int id, string titre, string corps, string auteur)
        {
            try
            {
                await OpenConnectionAsync();
                var q = "UPDATE Article SET Titre = @titre, Corps = @corps, Auteur = @auteur WHERE IDArticle = @id";
                var result = await _dbConnection.ExecuteAsync(q, new { id, titre, corps, auteur });
                return result;
            }
            finally { await CloseConnectionAsync(); }
        }

        public async Task<int> DeleteArticleIfNotCompositionAsync(int id)
        {
            try
            {
                await OpenConnectionAsync();
                var q = "DELETE from Article WHERE IDArticle = @id AND NOT EXISTS (SELECT IDArticle FROM composition where IDArticle = @id)";
                var result = await _dbConnection.ExecuteAsync(q, new { id });
                return result;
            }
            finally { await CloseConnectionAsync(); }
        }

        #endregion Articles

        #region Journaux

        public async Task<IEnumerable<Journal>> GetJournauxAsync()
        {
            try
            {
                await OpenConnectionAsync();
                var q = "SELECT * from Journal";
                return await _dbConnection.QueryAsync<Journal>(q);
            }
            finally { await CloseConnectionAsync(); }
        }

        public async Task<int> InsertJournalAsync(string titre, DateTime? dtParution)
        {
            try
            {
                await OpenConnectionAsync();
                var q = "INSERT INTO Journal (Titre,DtParution) VALUES (@titre, @dtParution); SELECT LAST_INSERT_ID()";
                var result = await _dbConnection.QueryAsync<int>(q, new { titre, dtParution });
                return result.Single();
            }
            finally { await CloseConnectionAsync(); }
        }

        public async Task<int> UpdateJournalAsync(int id, string titre, DateTime? dtParution)
        {
            try
            {
                await OpenConnectionAsync();
                var q = "UPDATE Journal SET Titre = @titre, DtParution = @dtParution WHERE IDJournal = @id";
                var result = await _dbConnection.ExecuteAsync(q, new { id, titre, dtParution });
                return result;
            }
            finally { await CloseConnectionAsync(); }
        }

        public async Task<int> DeleteJournalCascadeAsync(int id)
        {
            try
            {
                await OpenConnectionAsync();

                using (var tran = await _dbConnection.BeginTransactionAsync())
                {
                    var q = "DELETE from Composition WHERE IDJournal = @id";
                    var result = await _dbConnection.ExecuteAsync(q, new { id }, tran);

                    q = "DELETE from Journal WHERE IDJournal = @id";
                    result = await _dbConnection.ExecuteAsync(q, new { id }, tran);

                    await tran.CommitAsync();

                    return result;
                }
            }
            finally { await CloseConnectionAsync(); }
        }

        #endregion Journaux

        #region Composition

        public async Task<IEnumerable<Article>> GetArticlesInJournalAsync(int idJournal)
        {
            try
            {
                await OpenConnectionAsync();
                var q = @"SELECT IDArticle, Titre, Corps, Auteur
                          FROM article
                          WHERE (IDArticle IN (SELECT IDArticle FROM composition WHERE (IDJournal = @idJournal)))";
                return await _dbConnection.QueryAsync<Article>(q, new {idJournal});
            }
            finally { await CloseConnectionAsync(); }
        }

        public async Task<IEnumerable<Article>> GetArticlesNotInJournalAsync(int idJournal)
        {
            try
            {
                await OpenConnectionAsync();
                var q = @"SELECT IDArticle, Titre, Corps, Auteur
                          FROM article
                          WHERE (IDArticle NOT IN (SELECT IDArticle FROM composition WHERE (IDJournal = @idJournal)))";
                return await _dbConnection.QueryAsync<Article>(q, new { idJournal });
            }
            finally { await CloseConnectionAsync(); }
        }

        public async Task<int> InsertCompositionAsync(int idJournal, int idArticle)
        {
            try
            {
                await OpenConnectionAsync();
                var q = "INSERT INTO Composition (IDJournal, IDArticle) VALUES (@idJournal, @idArticle)";
                var result = await _dbConnection.ExecuteAsync(q, new { idJournal, idArticle });
                return result;
            }
            finally { await CloseConnectionAsync(); }
        }

        public async Task<int> DeleteCompositionAsync(int idJournal, int idArticle)
        {
            try
            {
                await OpenConnectionAsync();
                var q = "DELETE from Composition WHERE IDJournal = @idJournal AND IDArticle = @idArticle";
                var result = await _dbConnection.ExecuteAsync(q, new { idJournal, idArticle });
                return result;
            }
            finally { await CloseConnectionAsync(); }
        }

        private async Task OpenConnectionAsync()
        {
            await _semaphore.WaitAsync();
            await _dbConnection.OpenAsync();
        }

        private async Task CloseConnectionAsync()
        {
            await _dbConnection.CloseAsync();
            _semaphore.Release();
        }

        #endregion Composition
    }
}

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

        public DB()
        {
            _dbConnection = new(Settings.Default.EditoConnectionString);            
        }

        #region Articles

        public IEnumerable<Article> GetArticles()
        {
            try
            {
                _dbConnection.Open();
                var q = "SELECT * from Article";
                return _dbConnection.Query<Article>(q);
            }
            finally { _dbConnection.Close(); }
        }

        public int InsertArticle(string titre, string corps, string auteur)
        {
            try
            {
                _dbConnection.Open();
                var q = "INSERT INTO Article (Titre,Corps,Auteur) VALUES (@titre, @corps, @auteur); SELECT LAST_INSERT_ID()";
                var result = _dbConnection.Query<int>(q, new { titre, corps, auteur });
                return result.Single();
            }
            finally { _dbConnection.Close(); }
        }

        public int UpdateArticle(int id, string titre, string corps, string auteur)
        {
            try
            {
                _dbConnection.Open();
                var q = "UPDATE Article SET Titre = @titre, Corps = @corps, Auteur = @auteur WHERE IDArticle = @id";
                var result = _dbConnection.Execute(q, new { id, titre, corps, auteur });
                return result;
            }
            finally { _dbConnection.Close(); }
        }

        public int DeleteArticle(int id)
        {
            try
            {
                _dbConnection.Open();
                var q = "DELETE from Article WHERE IDArticle = @id";
                var result = _dbConnection.Execute(q, new { id });
                return result;
            }
            finally { _dbConnection.Close(); }
        }

        #endregion Articles

        #region Journaux

        public IEnumerable<Journal> GetJournaux()
        {
            try
            {
                _dbConnection.Open();
                var q = "SELECT * from Journal";
                return _dbConnection.Query<Journal>(q);
            }
            finally { _dbConnection.Close(); }
        }

        public int InsertJournal(string titre, DateTime? dtParution)
        {
            try
            {
                _dbConnection.Open();
                var q = "INSERT INTO Journal (Titre,DtParution) VALUES (@titre, @dtParution); SELECT LAST_INSERT_ID()";
                var result = _dbConnection.Query<int>(q, new { titre, dtParution });
                return result.Single();
            }
            finally { _dbConnection.Close(); }
        }

        public int UpdateJournal(int id, string titre, DateTime? dtParution)
        {
            try
            {
                _dbConnection.Open();
                var q = "UPDATE Journal SET Titre = @titre, DtParution = @dtParution WHERE IDJournal = @id";
                var result = _dbConnection.Execute(q, new { id, titre, dtParution });
                return result;
            }
            finally { _dbConnection.Close(); }
        }

        public int DeleteJournal(int id)
        {
            try
            {
                _dbConnection.Open();
                var q = "DELETE from Journal WHERE IDJournal = @id";
                var result = _dbConnection.Execute(q, new { id });
                return result;
            }
            finally { _dbConnection.Close(); }
        }

        #endregion Journaux
    }
}

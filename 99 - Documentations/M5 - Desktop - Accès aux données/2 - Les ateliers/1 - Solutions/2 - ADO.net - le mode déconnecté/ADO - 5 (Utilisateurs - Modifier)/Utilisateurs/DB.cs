
using Dapper;
using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilisateurs.Properties;

namespace Utilisateurs
{
    internal class DB
    {
        private readonly MySqlConnection _dbConnection;

        public DB()
        {
            _dbConnection = new(Settings.Default.dl09ConnectionString);
        }

        public IEnumerable<Utilisateur> GetUtilisateurs() 
        {
            try
            {
                _dbConnection.Open();
                var q = "SELECT * from Utilisateurs";
                return _dbConnection.Query<Utilisateur>(q);
            }
            finally { _dbConnection.Close(); }            
        }

        public int InsertUtilisateur(string nom, string prenom, DateTime dtNaiss)
        {
            try
            {
                _dbConnection.Open();
                var q = "INSERT INTO Utilisateurs (Nom,Prenom,DtNaiss) VALUES (@nom, @prenom, @dtNaiss)";
                var result = _dbConnection.Execute(q, new { nom, prenom, dtNaiss });
                return result;
            }
            finally { _dbConnection.Close(); }
        }

        public int DeleteUtilisateur(int id)
        {
            try
            {
                _dbConnection.Open();
                var q = "DELETE from Utilisateurs WHERE @Id = id";
                var result = _dbConnection.Execute(q, new { id });
                return result;
            }
            finally { _dbConnection.Close(); }
        }

        public int DeleteOptimistUtilisateur(int id, string nom, string prenom)
        {
            try
            {
                _dbConnection.Open();
                var q = "DELETE from Utilisateurs WHERE @Id = id and @Nom = nom and @Prenom = prenom";
                var result = _dbConnection.Execute(q, new { id, nom, prenom });
                return result;
            }
            finally { _dbConnection.Close(); }
        }

        public int UpdateUtilisateur(int id, string nom, string prenom, DateTime dtNaiss)
        {
            try
            {
                _dbConnection.Open();
                var q = "UPDATE Utilisateurs SET Nom = @nom, Prenom = @prenom, DtNaiss = @dtNaiss WHERE Id = @id";
                var result = _dbConnection.Execute(q, new { id, nom, prenom, dtNaiss });
                return result;
            }
            finally { _dbConnection.Close(); }
        }

        public int UpdateOptimistUtilisateur(int id, string nom, string prenom, DateTime dtNaiss, string oldNom, string oldPrenom, DateTime oldDtNaiss)
        {
            try
            {
                _dbConnection.Open();
                var q = "UPDATE Utilisateurs SET Nom = @nom, Prenom = @prenom, DtNaiss = @dtNaiss WHERE Id = @id and Nom = @oldNom and Prenom = @oldPrenom and DtNaiss = @oldDtNaiss";
                var result = _dbConnection.Execute(q, new { id, nom, prenom, dtNaiss, oldNom, oldPrenom, oldDtNaiss });
                return result;
            }
            finally { _dbConnection.Close(); }
        }
    }
}

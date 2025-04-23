
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
    }
}

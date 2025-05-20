using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCar
{
    public class Engine
    {
        /// <summary>
        /// Attributs privés
        /// </summary>
        private bool _isRunning;
        private FuelType _fuelType;


        // Constructeurs par défaut
        //public Engine()
        //{
        //    _isRunning = false;
        //    _fuelType = FuelType.Diesel;
        //}
        public Engine()
            : this(false, FuelType.Diesel) { }

        // Constructeurs classique
        public Engine(bool isRunning, FuelType fuelType)
        {
            _isRunning = isRunning;
            _fuelType = fuelType;
        }

        // Constructeur par clonage
        public Engine(Engine newEngine)
            : this(newEngine._isRunning, newEngine._fuelType) { }

        // Propriétés
        /// <summary>
        /// Démarrer le moteur
        /// </summary>
        /// <returns></returns>
        public bool StartEngine()
        {
            if (!_isRunning)
            {
                _isRunning = true;
                //Engine started
                return true;
            }
            else
            {
                //Engine is already running
                return false;
            }
        }

        /// <summary>
        /// Arrêter le moteur
        /// </summary>
        /// <returns></returns>
        public bool StopEngine()
        {
            if (_isRunning)
            {
                _isRunning = false;
                //Engine stopped
                return true;
            }
            else
            {
                //Engine is already stopped
                return false;
            }
        }
    }
}

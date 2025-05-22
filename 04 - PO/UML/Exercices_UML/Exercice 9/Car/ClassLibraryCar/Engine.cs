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
        /// Private attributes
        /// </summary>
        private bool _isRunning;
        private EngineFuelType _fuelType;

        /// <summary>
        /// Default constructors
        /// </summary>
        //public Engine()
        //{
        //    _isRunning = false;
        //    _fuelType = FuelType.Diesel;
        //}
        public Engine()
            : this(false, EngineFuelType.Diesel) { }

        /// <summary>
        /// Classic constructor
        /// </summary>
        /// <param name="isRunning"></param>
        /// <param name="fuelType"></param>
        public Engine(bool isRunning, EngineFuelType fuelType)
        {
            if (isRunning != true && isRunning != false)
                throw new ArgumentException("IsRunning must be true or false");

            _isRunning = isRunning;
            _fuelType = fuelType;
        }


        public Engine(EngineFuelType fuelType)
            : this(false, fuelType)
        {
            _fuelType = fuelType;
        }

        /// <summary>
        /// Constructor by cloning
        /// </summary>
        /// <param name="newEngine"></param>
        public Engine(Engine newEngine)
            : this(newEngine._isRunning, newEngine._fuelType) { }

        /// <summary>
        /// Propertie
        /// Start the engine
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
            //Engine is already running
            throw new Exception("Engine is already running");
        }

        /// <summary>
        /// Propertie
        /// Stop the engine
        /// </summary>
        /// <returns></returns>
        public bool StopEngine(Wheel lfw, Wheel rfw)
        {
            if (_isRunning)
            {
                if (lfw._isSpinning && rfw._isSpinning)
                {
                    StopDrivingWheels(lfw, rfw);
                }
                //Engine stopped
                _isRunning = false;
                return true;
            }
            //Engine is already stopped
            throw new Exception("Engine is already stopped");
        }

        /// <summary>
        /// Propertie
        /// Drive the wheels
        /// </summary>
        /// <param name="lfw">left wheel</param>
        /// <param name="rfw">right wheel</param>
        /// <returns></returns>
        public bool DriveWheels(Wheel lfw, Wheel rfw)
        {
            //Check if the engine is running
            if (_isRunning)
                //Move wheels
                return lfw.Move() && rfw.Move();

            //Engine is not running
            throw new Exception("Engine is not running");
        }

        /// <summary>
        /// Propertie
        /// Stop training the wheels
        /// </summary>
        /// <param name="lfw">left wheel</param>
        /// <param name="rfw">right wheel</param>
        /// <returns></returns>
        public bool StopDrivingWheels(Wheel lfw, Wheel rfw)
        {
            //Check if the engine is running
            if (_isRunning)
            {
                //Check if the wheels are spinning
                if (lfw._isSpinning && rfw._isSpinning)
                    //Stop wheels
                    return lfw.Stop() && rfw.Stop();

                //Wheels are already stopped
                throw new Exception("Wheels are already stopped");
            }
            //Engine is not running
            throw new Exception("Engine is not running");
        }

        /// <summary>
        /// Propertie ToString()
        /// La méthode toString est définie dans la classe Object; en conséquence toutes les classes C# en hérite.
        /// Lorsqu'on définit une classe, il peut être très utile de redéfinir la méthode toString afin de donner une description satisfaisante des objets de cette classe.
        /// Beaucoup de classes de l'API redéfinissent la m�thode toString.
        /// </summary>
        /// <returns>La fonction renvoie une chaîne de caractères servant � décrire l'objet concerné.</returns>
        public override string ToString()
        {
            return base.ToString() + ", Engine " + (_isRunning ? "Running" : "Stopped;")
            + " Fuel type: " + _fuelType;
        }
    }
}

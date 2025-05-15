using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCar
{
    public class Engine
    {
        private bool _isRunning;
        private FuelType _fuelType;

        public Engine() { }

        public Engine(bool isRunning, FuelType fuelType)
        {
            _isRunning = isRunning;
            _fuelType = fuelType;
        }

        public Engine(Engine newEngine)
            : this(newEngine._isRunning, newEngine._fuelType) { }

        public bool StartEngine()
        {
            if (!_isRunning)
            {
                _isRunning = true;
                Console.WriteLine("Engine started.");
                return true;
            }
            else
            {
                Console.WriteLine("Engine is already running.");
                return false;
            }
        }

        public bool StopEngine()
        {
            if (_isRunning)
            {
                _isRunning = false;
                Console.WriteLine("Engine stopped.");
                return true;
            }
            else
            {
                Console.WriteLine("Engine is already stopped.");
                return false;
            }
        }
    }

}

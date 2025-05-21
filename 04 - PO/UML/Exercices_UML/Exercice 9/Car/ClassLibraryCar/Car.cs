using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCar
{
    public class Car
    {
        /// <summary>
        /// Private attributes
        /// </summary>
        private string _brand;
        private string _model;
        private Wheel? _spareWheel;
        private Wheel _rightFrontWheel;
        private Wheel _leftFrontWheel;
        private Wheel _rightRearWheel;
        private Wheel _leftRearWheel;
        private Engine _engineUsed;

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="brand"></param>
        /// <param name="model"></param>
        /// 
        public Car()
            : this("Peugeot", "106", 16, 0, EngineFuelType.Diesel) { }

        /// <summary>
        /// Classic constructors
        /// </summary>
        /// <param name="brand"></param>
        /// <param name="model"></param>
        /// <param name="spareWheel"></param>
        /// <param name="rightFrontWheel"></param>
        /// <param name="leftFrontWheel"></param>
        /// <param name="rightRearWheel"></param>
        /// <param name="leftRearWheel"></param>
        /// <param name="engineUsed"></param>
        public Car(string brand, string model, Wheel? spareWheel, Wheel rightFrontWheel, Wheel leftFrontWheel, Wheel rightRearWheel, Wheel leftRearWheel, Engine engineUsed)
        {
            _brand = brand;
            _model = model;
            _spareWheel = spareWheel;
            _rightFrontWheel = rightFrontWheel;
            _leftFrontWheel = leftFrontWheel;
            _rightRearWheel = rightRearWheel;
            _leftRearWheel = leftRearWheel;
            _engineUsed = engineUsed;
        }

        /// <summary>
        /// Classic constructor with default values
        /// </summary>
        /// <param name="brand"></param>
        /// <param name="model"></param>
        /// <param name="wheelSize"></param>
        /// <param name="wheelWear"></param>
        /// <param name="fuelType"></param>
        private Car(string brand, string model, int wheelSize, float wheelWear, EngineFuelType fuelType)
        {
            _brand = brand;
            _model = model;
            _spareWheel = new Wheel(wheelSize, wheelWear);
            _rightFrontWheel = new Wheel(wheelSize, wheelWear);
            _leftFrontWheel = new Wheel(wheelSize, wheelWear);
            _rightRearWheel = new Wheel(wheelSize, wheelWear);
            _leftRearWheel = new Wheel(wheelSize, wheelWear);
            _engineUsed = new Engine(fuelType);
        }

        /// <summary>
        /// Constructor by cloning
        /// </summary>
        /// <param name="carToClone"></param>
        public Car(Car carToClone)
            : this(carToClone._brand, 
                  carToClone._model, 
                  carToClone._spareWheel==null?null:
                  new Wheel(carToClone._spareWheel), 
                  new Wheel(carToClone._rightFrontWheel), 
                  new Wheel(carToClone._leftFrontWheel), 
                  new Wheel(carToClone._rightRearWheel), 
                  new Wheel(carToClone._leftRearWheel), 
                  new Engine(carToClone._engineUsed)) { }


        public bool MoveForward()
        {

        }

        public bool Start()
        {

        }

        public bool ToSlowDown()
        {

        }

        public bool Stop()
        {

        }
    }
}

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
        private Car(string brand, string model, Wheel? spareWheel, Wheel rightFrontWheel, Wheel leftFrontWheel, Wheel rightRearWheel, Wheel leftRearWheel, Engine engineUsed)
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
        /// Hybrid classic constructor
        /// </summary>
        /// <param name="brand"></param>²
        /// <param name="model"></param>
        /// <param name="wheelSize"></param>
        /// <param name="wheelWear"></param>
        /// <param name="fuelType"></param>
        public Car(string brand, string model, int wheelSize, float wheelWear, EngineFuelType fuelType)
            :this(brand, model, 
                 new Wheel(wheelSize, wheelWear), 
                 new Wheel(wheelSize, wheelWear), 
                 new Wheel(wheelSize, wheelWear), 
                 new Wheel(wheelSize, wheelWear), 
                 new Wheel(wheelSize, wheelWear),
                 new Engine(fuelType))
        {  }

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

        /// <summary>
        /// Start the engine
        /// </summary>
        /// <returns></returns>
        public bool Start()
        {
            return _engineUsed.StartEngine();
        }

        /// <summary>
        /// Move the car forward
        /// </summary>
        /// <returns></returns>
        public bool MoveForward()
        {
            return _engineUsed.DriveWheels(_leftFrontWheel, _rightFrontWheel);
        }

        /// <summary>
        /// Slow down the car
        /// </summary>
        /// <returns></returns>
        public bool ToSlowDown()
        {
            return _engineUsed.StopDrivingWheels(_leftFrontWheel, _rightFrontWheel);
        }

        /// <summary>
        /// Stop the engine
        /// </summary>
        /// <returns></returns>
        public bool Stop()
        {
            return _engineUsed.StopEngine(_leftFrontWheel, _rightFrontWheel);
        }

        /// <summary>
        /// Propertie ToString()
        /// La méthode toString est définie dans la classe Object; en conséquence toutes les classes C# en hérite.
        /// Lorsqu'on définit une classe, il peut être très utile de redéfinir la méthode toString afin de donner une description satisfaisante des objets de cette classe.
        /// Beaucoup de classes de l'API redéfinissent la m�thode toString.
        /// </summary>
        /// <returns>La fonction renvoie une chaîne de caractères servant à décrire l'objet concerné.</returns>
        public override string ToString()
        {
            return base.ToString() + ", "
            + _rightFrontWheel.ToString() + ", "
            + _leftFrontWheel.ToString() + ", "
            + _rightRearWheel.ToString() + ", "
            + _leftRearWheel.ToString() + ", "
            + _engineUsed.ToString() + ", "
            + (_spareWheel == null ? "No spare wheel" : _spareWheel?.ToString());
        }
    }
}

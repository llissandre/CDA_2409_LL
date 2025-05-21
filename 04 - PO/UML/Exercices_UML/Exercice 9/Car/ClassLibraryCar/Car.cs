//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ClassLibraryCar
//{
//    public class Car
//    {
//        /// <summary>
//        /// Private attributes
//        /// </summary>
//        private string _brand;
//        private string _model;
//        private Wheel _spareWheel;
//        private Wheel _rightFrontWheel;
//        private Wheel _leftFrontWheel;
//        private Wheel _rightRearWheel;
//        private Wheel _leftRearWheel;
//        private Engine _engineUsed;

//        /// <summary>
//        /// Default constructor
//        /// </summary>
//        /// <param name="brand"></param>
//        /// <param name="model"></param>
//        public Car()
//            : this() { }

//        /// <summary>
//        /// Classic constructor
//        /// </summary>
//        /// <param name="brand"></param>
//        /// <param name="model"></param>
//        /// <param name="spareWheel"></param>
//        /// <param name="rightFrontWheel"></param>
//        /// <param name="leftFrontWheel"></param>
//        /// <param name="rightRearWheel"></param>
//        /// <param name="leftRearWheel"></param>
//        /// <param name="engineUsed"></param>
//        public Car(string brand, string model, Wheel spareWheel, Wheel rightFrontWheel, Wheel leftFrontWheel, Wheel rightRearWheel, Wheel leftRearWheel, Engine engineUsed)
//        {
//            _brand = brand;
//            _model = model;
//            _spareWheel = spareWheel;
//            _rightFrontWheel = rightFrontWheel;
//            _leftFrontWheel = leftFrontWheel;
//            _rightRearWheel = rightRearWheel;
//            _leftRearWheel = leftRearWheel;
//            _engineUsed = engineUsed;
//        }

//        /// <summary>
//        /// Constructor by cloning
//        /// </summary>
//        /// <param name="newCar"></param>
//        public Car(Car newCar)
//            : this(newCar._brand, newCar._model, newCar._spareWheel, newCar._rightFrontWheel, newCar._leftFrontWheel, newCar._rightRearWheel, newCar._leftRearWheel, newCar._engineUsed) { }


//        public bool MoveForward()
//        {

//        }

//        public bool Start()
//        {

//        }

//        public bool Stop()
//        {

//        }
//    }
//}

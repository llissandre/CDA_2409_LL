using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCar
{
    public class Car
    {
        private string _brand;
        private string _model;
        private int _wheelSize;
        private float _wheelWear;
        private FuelType _engineType;

        public Car() { }

        public Car(string brand, string model, int wheelSize, float wheelWear, FuelType engineType)
        {
            _brand = brand;
            _model = model;
            _wheelSize = wheelSize;
            _wheelWear = wheelWear;
            _engineType = engineType;
        }

        public Car(Car newCar)
            : this(newCar._brand, newCar._model, newCar._wheelSize, newCar._wheelWear, newCar._engineType) { }

        public bool MoveForward() {
        
        }

        public bool Start() {

        }
        
        public bool Stop() {

        }
    }
}

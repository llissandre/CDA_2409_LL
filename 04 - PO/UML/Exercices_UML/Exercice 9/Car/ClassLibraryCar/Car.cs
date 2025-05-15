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


        public Car() { }

        public Car(string brand, string model, int wheelSize, float wheelWear, FuelType engineType)
        {
            _brand = brand;
            _model = model;
        }
    }
}

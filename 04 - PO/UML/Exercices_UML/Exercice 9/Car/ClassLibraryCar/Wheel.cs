using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCar
{
    public class Wheel
    {
        private int _size;
        private float _wear;
        private bool _isSpinning;

        public Wheel() { }

        public Wheel(int size, float wear, bool isSpinning)
        {
            _size = size;
            _wear = wear;
            _isSpinning = isSpinning;
        }

        //public Wheel(Wheel newWheel)
        //{
        //    _size = newWheel._size;
        //    _wear = newWheel._wear;
        //    _isSpinning = newWheel._isSpinning;
        //}

        public Wheel(Wheel newWheel)
            : this(newWheel._size, newWheel._wear, newWheel._isSpinning) { }

        public bool move()
        {
            if (_isSpinning)
            {
                Console.WriteLine("The wheel is moving.");
                return true;
            }
            else
            {
                Console.WriteLine("The wheel is not moving.");
                return false;
            }
        }
    }
}

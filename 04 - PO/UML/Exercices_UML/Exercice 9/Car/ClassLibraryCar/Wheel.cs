using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCar
{
    public class Wheel
    {
        /// <summary>
        /// Attributs privés
        /// </summary>
        private int _size;
        private float _wear;
        private bool _isSpinning;

        // Constructeur par défaut
        public Wheel()
        : this(16, 0, false) { }

        // Constructeur classique
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

        // Constructeur par clonage
        public Wheel(Wheel newWheel)
            : this(newWheel._size, newWheel._wear, newWheel._isSpinning) { }

        // Propriétés
        /// <summary>
        /// Faire tourner la roue
        /// </summary>
        /// <returns></returns>
        public bool Move()
        {
            if (!_isSpinning)
            {
                _isSpinning = true;
                //The wheel is moving
                return true;
            }
            else
            {
                //The wheel is already spinning
                return false;
            }
        }

        /// <summary>
        /// Arrêter la rotation de la roue
        /// </summary>
        /// <returns></returns>
        public bool Stop()
        {
            if (_isSpinning)
            {
                _isSpinning = false;
                //The wheel is stopped
                return true;
            }
            else
            {
                //The wheel is already spinning
                return false;
            }
        }
    }
}

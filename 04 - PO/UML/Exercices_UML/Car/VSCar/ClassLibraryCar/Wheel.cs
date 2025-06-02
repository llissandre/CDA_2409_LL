namespace ClassLibraryCar
{
    public class Wheel
    {
        /// <summary>
        /// Private attributes
        /// </summary>
        private int _size;
        private float _wear;
        public bool _isSpinning;

        /// <summary>
        /// Default constructor
        /// </summary>
        public Wheel()
        : this(16, 0) { }

        /// <summary>
        /// Classic constructor
        /// </summary>
        /// <param name="size"></param>
        /// <param name="wear"></param>
        /// <param name="isSpinning"></param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public Wheel(int size, float wear, bool isSpinning)
        {
            if (size < 13)
                throw new ArgumentOutOfRangeException("Size must be over or equal 13");

            if (wear < 0 || wear > 1)
                throw new ArgumentOutOfRangeException("Wear must be between 0 and 1");
            
            if (isSpinning != false)
                throw new ArgumentException("IsSpinning must be false");

            _size = size;
            _wear = wear;
            _isSpinning = isSpinning;
        }

        /// <summary>
        /// Hybrid classic constructor
        /// </summary>
        /// <param name="size"></param>
        /// <param name="wear"></param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public Wheel(int size, float wear)
            :this(size, wear, false)
        {
            if (size < 13)
                throw new ArgumentOutOfRangeException("Size must be over or equal 13");

            if (wear < 0 || wear > 1)
                throw new ArgumentOutOfRangeException("Wear must be between 0 and 1");
            
            _size = size;
            _wear = wear;
        }

        /// <summary>
        /// Constructors by cloning
        /// </summary>
        /// <param name="wheelToClone"></param>
        //public Wheel(Wheel wheelToClone)
        //{
        //    _size = wheelToClone._size;
        //    _wear = wheelToClone._wear;
        //    _isSpinning = wheelToClone._isSpinning;
        //}
        public Wheel(Wheel wheelToClone)
            : this(wheelToClone._size, wheelToClone._wear) { }

        /// <summary>
        /// Propertie
        /// Spin the wheel
        /// </summary>
        /// <returns></returns>
        public bool Move()
        {
            if (!_isSpinning)
            {
                //The wheel is moving
                _isSpinning = true;
                return true;
            }
            
                //The wheel is already spinning
                return false;
        }

        /// <summary>
        /// Propertie
        /// Stop the wheel from rotating
        /// </summary>
        /// <returns></returns>
        public bool Stop()
        {
            if (_isSpinning)
            {
                //The wheel is stopped
                _isSpinning = false;
                return true;
            }

                //The wheel is already stopped
                return false;
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
            return $"Size: {_size}, Wear: {_wear}, Is Spinning: {_isSpinning}";
        }

        //Renvoie le nom et le chemin de la classe, et une chaîne de caractères servant à décrire l'objet concerné.
        //return base.ToString() + " : Size : " + _size + ", Wear : " + _wear + ", Is Spinning : " + _isSpinning;
    }
}

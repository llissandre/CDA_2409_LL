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
        : this(16, 0, false) { }

        /// <summary>
        /// Classic constructor
        /// </summary>
        /// <param name="size"></param>
        /// <param name="wear"></param>
        /// <param name="isSpinning"></param>
        public Wheel(int size, float wear, bool isSpinning)
        {
            if (size < 13)
                throw new ArgumentOutOfRangeException("Size must be over or equal 13");

            if (wear < 0 || wear > 1)
                throw new ArgumentOutOfRangeException("Wear must be between 0 and 1");
            
            if (isSpinning != true || isSpinning != false || isSpinning == null)
                throw new ArgumentException("IsSpinning must be true or false");

            _size = size;
            _wear = wear;
            _isSpinning = isSpinning;
        }

        /// <summary>
        /// Constructors by cloning
        /// </summary>
        /// <param name="newWheel"></param>
        //public Wheel(Wheel newWheel)
        //{
        //    _size = newWheel._size;
        //    _wear = newWheel._wear;
        //    _isSpinning = newWheel._isSpinning;
        //}
        public Wheel(Wheel newWheel)
            : this(newWheel._size, newWheel._wear, newWheel._isSpinning) { }

        /// <summary>
        /// Propertie
        /// Spin the wheel
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
        /// Propertie
        /// Stop the wheel from rotating
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

        /// <summary>
        /// Propertie ToString()
        /// La méthode toString est définie dans la classe Object; en conséquence toutes les classes C# en hérite.
        /// Lorsqu'on définit une classe, il peut être très utile de redéfinir la méthode toString afin de donner une description satisfaisante des objets de cette classe.
        /// Beaucoup de classes de l'API redéfinissent la m�thode toString.
        /// </summary>
        /// <returns>La fonction renvoie une chaîne de caractères servant � décrire l'objet concerné.</returns>
        public override string ToString()
        {
            return $"Size: {_size}, Wear: {_wear}, Is Spinning: {_isSpinning}";
        }

        //Renvoie le nom et le chemin de la classe, et une cha�ne de caract�res servant � d�crire l'objet concern�.
        //return base.ToString() + " : Size : " + _size + ", Wear : " + _wear + ", Is Spinning : " + _isSpinning;
    }
}

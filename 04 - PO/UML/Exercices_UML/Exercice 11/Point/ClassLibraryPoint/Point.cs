namespace ClassLibraryPoint
{
    public class Point
    {
        /// <summary>
        /// Attributes of the Point class.
        /// </summary>
        private float _abscissa;
        private float _ordonate;

        /// <summary>
        /// Getters for the attributes of the Point class.
        /// </summary>
        public float Abscissa { get => _abscissa; }
        public float Ordonate { get => _ordonate; }

        //public float _abscissa { get; private set; }
        //public float _ordonate { get; private set; }


        /// <summary>
        /// Default constructor that initializes the point with given coordinates
        /// </summary>
        public Point() : this(0, 0)
        {
        }

        /// <summary>
        /// Classic constructor
        /// </summary>
        /// <param name="abscissa"></param>
        /// <param name="ordonate"></param>
        public Point(float abscissa, float ordonate)
        {
            _abscissa = abscissa;
            _ordonate = ordonate;
        }

        /// <summary>
        /// Clone constructor
        /// </summary>
        /// <param name="pointToClone"></param>
        //public Point(Point pointToClone)
        //{
        //    _abscissa = pointToClone._abscissa;
        //    _ordonate = pointToClone._ordonate;
        //}
        public Point(Point pointToClone)
            : this(pointToClone._abscissa, pointToClone._ordonate)
        { }

        /// <summary>
        /// Method to indicate the position of the point
        /// </summary>
        /// <returns></returns>
        public string IndicatePosition()
        {
            return "Abscisse : " + _abscissa +
                " , Ordonnée : " + _ordonate;
        }

        /// <summary>
        /// Method to move the point by abscissa and ordonate
        /// </summary>
        /// <param name="abscissa"></param>
        /// <param name="ordonate"></param>
        /// <returns></returns>
        public void Move(float abscissa, float ordonate)
        {
            _abscissa += abscissa;
            _ordonate += ordonate;
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
            return base.ToString() +
                " , Abscisse : " + _abscissa +
                " , Ordonnée : " + _ordonate;
        }

        /// <summary>
        /// Method to move the point by the ordonate
        /// </summary>
        /// <returns></returns>
        public Point SymmetricalYAxis()
        {
            Point pointSymmetricalYAxis = new Point(-_abscissa, _ordonate);
            return pointSymmetricalYAxis;
        }

        /// <summary>
        /// Method to build the point by the abscissa
        /// </summary>
        /// <returns></returns>
        public Point SymmetricalXAxis()
        {
            Point pointSymmetricalXAxis = new Point(_abscissa, -_ordonate);
            return pointSymmetricalXAxis;
        }

        /// <summary>
        /// Method to build the point the abscissa and ordonate
        /// </summary>
        /// <returns></returns>
        public Point SymmetricalOrigin()
        {
            Point pointSymmetricalYOrigin = SymmetricalYAxis();
            Point pointSymmetricalXOrigin = pointSymmetricalYOrigin.SymmetricalXAxis();
            return pointSymmetricalXOrigin;
        }

        /// <summary>
        /// Method to swap the coordinates of the point
        /// </summary>
        /// <returns></returns>
        public void SwapCoordinates()
        {
            float temp = _ordonate;
            _ordonate = _abscissa;
            _abscissa = temp;
        }
    }
}
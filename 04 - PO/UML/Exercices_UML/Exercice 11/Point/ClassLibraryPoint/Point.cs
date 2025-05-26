namespace ClassLibraryPoint
{
    public class Point
    {
        /// <summary>
        /// Attributes of the Point class.
        /// </summary>
        public float _abscissa { get; private set; }
        public float _ordonate { get; private set; }

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
        public Point(Point pointToClone)
        {
            _abscissa = pointToClone._abscissa;
            _ordonate = pointToClone._ordonate;
        }

        /// <summary>
        /// Method to indicate the position of the point
        /// </summary>
        /// <returns></returns>
        public Point IndicatePosition()
        {
            return new Point(_abscissa, _ordonate);
        }

        /// <summary>
        /// Method to move the point by abscissa and ordonate
        /// </summary>
        /// <param name="abscissa"></param>
        /// <param name="ordonate"></param>
        /// <returns></returns>
        public Point Move(float abscissa, float ordonate)
        {
            _abscissa += abscissa;
            _ordonate += ordonate;
            return this;
        }

        /// <summary>
        /// Method to move the point by the ordonate
        /// </summary>
        /// <returns></returns>
        public Point SymmetricalYAxis()
        {
            return new Point(-_abscissa, _ordonate);
        }

        /// <summary>
        /// Method to build the point by the abscissa
        /// </summary>
        /// <returns></returns>
        public Point SymmetricalXAxis() {
            return new Point(_abscissa, -_ordonate);
        }

        /// <summary>
        /// Method to build the point the abscissa and ordonate
        /// </summary>
        /// <returns></returns>
        public Point SymmetricalOrigin()
        {
            return 
        }
    }

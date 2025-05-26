using ClassLibraryPoint;

// -------------- //
// INSTANCIATIONS //
// -------------- //

Point point1 = new Point();
point1.GetHashCode();
Point point2 = new Point(10, 20);
point2.GetHashCode();
Point point3 = new Point(point2);
point3.GetHashCode();

// ------------- //
// TESTS MANUELS //
// ------------- //

point1.IndicatePosition();
point2.IndicatePosition();
point3.IndicatePosition();

point1.Move(-5, -15);
point2.Move(-5, -15);
point1.IndicatePosition();
point2.IndicatePosition();

point1.ToString();
point2.ToString();
point3.ToString();

point1.SymmetricalYAxis();
point2.SymmetricalXAxis();
point3.SymmetricalYAxis();

point3.SymmetricalOrigin();

point1.SwapCoordinates();
point1.IndicatePosition();
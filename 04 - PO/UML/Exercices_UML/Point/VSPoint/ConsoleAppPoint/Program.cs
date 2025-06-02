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

//point1.ToString();
//point2.ToString();
//point3.ToString();

Point p1SymmetricalYAxis = point1.SymmetricalYAxis();
p1SymmetricalYAxis.IndicatePosition();
Point p1SymmetricalXAxis = point2.SymmetricalXAxis();
p1SymmetricalXAxis.IndicatePosition();
Point p2SymmetricalYAxis = point3.SymmetricalYAxis();
p2SymmetricalYAxis.IndicatePosition();

Point p1SymmetricalOrigin = point3.SymmetricalOrigin();
p1SymmetricalOrigin.IndicatePosition();

point1.SwapCoordinates();
point1.IndicatePosition();
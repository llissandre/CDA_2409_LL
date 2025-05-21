using ClassLibraryCar;

namespace ConsoleAppCar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // -------------- //
            // INSTANCIATIONS //
            // -------------- //

            Wheel wfr = new Wheel();
            wfr.GetHashCode();
            Wheel wfl = new Wheel(16, 0.5f, true);
            wfl.GetHashCode();
            Wheel wrr = new Wheel(wfr);
            wrr.GetHashCode();
            Wheel wrl = new Wheel(wfl);
            wrl.GetHashCode();


            // ------------- //
            // TESTS MANUELS //
            // ------------- //

            wrr.Move();
            wrr.Move();
            wrr.Stop();
            wrr.ToString();




        }
    }
}
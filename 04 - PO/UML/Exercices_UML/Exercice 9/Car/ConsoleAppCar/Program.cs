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
            Wheel wfl = new Wheel(16, 0.5f, true);
            Wheel wrr = new Wheel(wfr);
            Wheel wrl = new Wheel(wfl);


        }
    }
}
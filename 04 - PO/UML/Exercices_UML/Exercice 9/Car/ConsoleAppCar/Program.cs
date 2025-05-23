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

            Wheel rfw = new Wheel();
            rfw.GetHashCode();
            Wheel lfw = new Wheel(16, 0.5f, false);
            lfw.GetHashCode();
            Wheel rrw = new Wheel(rfw);
            rrw.GetHashCode();
            Wheel lrw = new Wheel(lfw);
            lrw.GetHashCode();


            Engine engine1 = new Engine();
            engine1.GetHashCode();
            Engine engine2 = new Engine(false, EngineFuelType.Electric);
            engine2.GetHashCode();
            Engine engine3 = new Engine(engine1);
            engine3.GetHashCode();
            Engine engine4 = new Engine(EngineFuelType.Hybrid);
            engine4.GetHashCode();


            Car car1 = new Car();
            car1.GetHashCode();
            Car car2 = new Car("Peugeot", "208", 16, 0.5f, EngineFuelType.Diesel);
            car2.GetHashCode();
            Car car3 = new Car("Citroën", "C3", null, new Wheel(16, 0.5f, false), new Wheel(16,0), new Wheel(16,0.25f), new Wheel(16,0.1f), new Engine(EngineFuelType.Hybrid));
            car3.GetHashCode();
            Car car4 = new Car("Citroën", "C5", new Wheel(16,0), new Wheel(16, 0.5f), new Wheel(16,0), new Wheel(16,0.25f), new Wheel(16,0.1f), new Engine(EngineFuelType.Hybrid));
            car4.GetHashCode();
            Car car5 = new Car(car2);
            car5.GetHashCode();

            // ------------- //
            // TESTS MANUELS //
            // ------------- //

            rfw.Move();
            //lfw.Move();
            rfw.Move();
            //rfw.ToString();
            rfw.Stop();
            rfw.Stop();
            //lfw.Stop();
            //rfw.ToString();
            //lfw.ToString();

            //engine1.StartEngine();
            ////engine1.StartEngine();
            //engine1.DriveWheels(lfw, rfw);
            //engine1.StopEngine(lfw, rfw);
            ////engine1.StopEngine(lfw, rfw);
            //rfw.ToString();
            //lfw.ToString();
            //engine1.ToString();

            ////engine2.StopDrivingWheels(lfw, rfw);
            //engine2.StartEngine();
            //engine2.DriveWheels(lfw, rfw);
            //engine2.StopDrivingWheels(lfw, rfw);
            //engine2.StopEngine(lfw, rfw);
            //engine2.ToString();

            //car1.Start();
            //car3.Start();
            //car1.MoveForward();
            //car3.MoveForward();
            //car1.ToSlowDown();
            //car1.Stop();
            //car3.Stop();
        }
    }
}
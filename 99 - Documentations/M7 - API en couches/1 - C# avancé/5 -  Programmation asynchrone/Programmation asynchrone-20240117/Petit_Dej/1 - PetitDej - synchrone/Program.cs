using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace PetitDej
{
    class Program
    {
        //How to make a breakfast
        //        1 - Pour a cup of coffee.
        //        2 - Heat a pan, then fry two eggs.
        //        3 - Fry three slices of bacon
        //        4 - Toast two pieces of bread.
        //        5 - Add butter and jam to the toast.
        //        6 - Pour a glass of orange juice.

        internal class Bacon { }
        internal class Coffee { }
        internal class Toast { }
        internal class Egg { }
        internal class Juice { }

        static void Main(string[] args)
        {
            //Etape 1 - Synchroneous breakfast (version séquentielle)

            //The computer will block on each statement until the work is complete before moving on to the next statement
            //The later tasks wouldn't be started until the earlier tasks had been completed
            //It would take much longer to create the breakfast, and some items would have gotten cold before being served.

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Coffee cup = PourCoffee();
            Console.WriteLine("coffee is ready");

            Egg eggs = FryEggs(2);
            Console.WriteLine("Eggs are ready");

            Bacon bacon = FryBacon(3);
            Console.WriteLine("Bacon is ready");

            Toast toast = ToastBread(2);
            ApplyButter(toast);
            ApplyJam(toast);
            Console.WriteLine("Toast is ready");

            Juice oj = PourOJ();
            Console.WriteLine("Orange juice is ready"); 

            Console.WriteLine("Breakfast is ready!");
            stopwatch.Stop();

            Console.WriteLine(stopwatch.ElapsedMilliseconds);
        }

        static Coffee PourCoffee()
        {
            return new Coffee();
        }

        static Egg FryEggs(int nb)
        {
            Console.WriteLine("Warming the egg pan...");
            Task.Delay(3000).Wait();
            Console.WriteLine($"cracking {nb} eggs");
            Console.WriteLine("cooking the eggs ...");
            Task.Delay(3000).Wait();
            Console.WriteLine("Put eggs on plate");
            return new Egg();
        }

        static Bacon FryBacon(int slices)
        {
            Console.WriteLine($"putting {slices} slices of bacon in the pan");
            Console.WriteLine("cooking first side of bacon...");
            Task.Delay(3000).Wait();
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("flipping a slice of bacon");
            }
            Console.WriteLine("cooking the second side of bacon...");
            Task.Delay(3000).Wait();
            Console.WriteLine("Put bacon on plate");

            return new Bacon();
        }

        static Toast ToastBread(int slices)
        {
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("Putting a slice of bread in the toaster");
            }
            Console.WriteLine("Start toasting...");
            Task.Delay(3000).Wait();
            Console.WriteLine("Remove toast from toaster");
            return new Toast();
        }

        static void ApplyButter(Toast toast)
        {
            Console.WriteLine("Putting butter on the toast");
        }

        static void ApplyJam(Toast toast)
        {
            Console.WriteLine("Putting jam on the toast");
        }

        static Juice PourOJ()
        {
            Console.WriteLine("Pouring orange juice");
            return new Juice();
        }

    }
}

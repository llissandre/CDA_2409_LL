using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace PetitDej
{
    // Asynchronous programming with async and await
    // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/async/
    class Program
    {

        internal class Bacon { }
        internal class Coffee { }
        internal class Toast { }
        internal class Egg { }
        internal class Juice { }

        static async Task Main(string[] args)
        {
            //Etape 3 - Code asynchrone non bloquant (start tasks concurrently)

            //This code may be similar to code in a web application that makes requests to different microservices
            //then combines the results into a single page

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            //You start all the asynchronous tasks at once            
            //Each Task object represents each work in progress 

            Task<Egg> eggsTask = FryEggsAsync(2);            
            Task<Bacon> baconTask = FryBaconAsync(3);            
            Task<Toast> toastTask = ToastBreadAsync(2);

            Coffee cup = PourCoffee();
            Console.WriteLine("coffee is ready");

            Juice oj = PourOJ();
            Console.WriteLine("Orange juice is ready");

            //You await each task only when you need the results
            Toast toast = await toastTask;
            ApplyButter(toast);
            ApplyJam(toast);
            Console.WriteLine("toast is ready");            

            //you can move the await statements for the bacon and eggs to the end of the method, before serving breakfast
            Egg eggs = await eggsTask;
            Console.WriteLine("eggs are ready");
            
            Bacon bacon = await baconTask;
            Console.WriteLine("bacon is ready");

            Console.WriteLine("Breakfast is ready!");

            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds);

            Console.ReadKey();
        }

        static Coffee PourCoffee()
        {
            return new Coffee();
        }

        static async Task<Egg> FryEggsAsync(int nb)
        {
            Console.WriteLine("Warming the egg pan...");
            await Task.Delay(3000);
            Console.WriteLine($"cracking {nb} eggs");
            Console.WriteLine("cooking the eggs ...");
            await Task.Delay(3000);
            Console.WriteLine("Put eggs on plate");
            return new Egg();
        }

        static async Task<Bacon> FryBaconAsync(int slices)
        {
            Console.WriteLine($"putting {slices} slices of bacon in the pan");
            Console.WriteLine("cooking first side of bacon...");
            await Task.Delay(3000);
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("flipping a slice of bacon");
            }
            Console.WriteLine("cooking the second side of bacon...");
            await Task.Delay(3000);
            Console.WriteLine("Put bacon on plate");
            return new Bacon();
        }

        static async Task<Toast> ToastBreadAsync(int slices)
        {
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("Putting a slice of bread in the toaster");
            }
            Console.WriteLine("Start toasting...");
            await Task.Delay(3000);
            Console.WriteLine("Remove toast from toaster");
            return new Toast();
        }

        static void ApplyButter(Toast toast)
        {
            Console.WriteLine("Apply Butter");
            
        }
        static void ApplyJam(Toast toast)
        {
            Console.WriteLine("Apply Jam");
        }

        static Juice PourOJ()
        {
            return new Juice();
        }

    }
}

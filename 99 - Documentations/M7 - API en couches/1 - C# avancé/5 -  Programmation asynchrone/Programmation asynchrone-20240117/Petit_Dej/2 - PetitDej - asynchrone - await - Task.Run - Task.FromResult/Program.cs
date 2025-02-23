using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace PetitDej
{
    class Program
    {
        // Asynchronous programming with async and await       
        internal class Bacon { }
        internal class Coffee { }
        internal class Toast { }
        internal class Egg { }
        internal class Juice { }
        static async Task Main(string[] args)
        {
            //Etape 2-1 : Code asynchrone non bloquant (Don't block, await instead)
            //   Les méthodes synchrones sont réutilisées dans les méthodes asynchrones
            //   Task.Run et Task.FromResult


            //The method bodies of the FryEggsAsync, FryBaconAsync, and ToastBreadAsync have all been updated 
            //to return Task<Egg>, Task<Bacon>, and Task<Toast> respectively.
            //The methods are renamed from their original version to include the "Async" suffix.

            //The await keyword provides a non-blocking way to start a task, then continue execution when that task completes.

            //The total elapsed time is roughly the same as the initial synchronous version.           

            //This code doesn't block while the eggs or the bacon are cooking.
            //This code won't start any other tasks though.
            //You'd still put the toast in the toaster and stare at it until it pops.
            //But at least, you'd respond to anyone that wanted your attention.
            //In a restaurant where multiple orders are placed, the cook could start another breakfast while the first is cooking.

            //Le cuisinier pourrait répondre à quiconque demande son attention            

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Coffee cup = PourCoffee();
            Console.WriteLine("coffee is ready");

            Egg eggs = await FryEggsAsync(2);
            Console.WriteLine("eggs are ready");

            Bacon bacon = await FryBaconAsync(3);
            Console.WriteLine("bacon is ready");

            Toast toast = await ToastBreadAsync(2);
            ApplyButter(toast);
            ApplyJam(toast);
            Console.WriteLine("toast is ready");

            Juice oj = PourOJ();
            Console.WriteLine("Orange juice is ready");

            Console.WriteLine("Breakfast is ready!");

            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds);

            Console.ReadKey();
        }

        static Coffee PourCoffee()
        {
            return new Coffee();
        }

        //Méthode asynchrone 
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

        //Méthode asynchrone qui utilise la méthode synchrone
        static async Task<Egg> FryEggsAsync(int nb)
        {
            //Task.FromResult crée une tache à partir du résultat de la méthode synchrone 
            return await Task.FromResult(FryEggs(nb));
        }

        //Méthode synchrone
        static Bacon FryBacon(int slices)
        {
            Console.WriteLine($"Putting {slices} slices of bacon in the pan");
            Console.WriteLine("cooking first side of bacon...");
            Task.Delay(3000).Wait();
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("Flipping a slice of bacon");
            }
            Console.WriteLine("Cooking the second side of bacon...");
            Task.Delay(3000).Wait();
            Console.WriteLine("Putting bacon on plate");

            return new Bacon();
        }

        //Méthode asynchrone qui utilise la méthode correspondante synchrone
        static async Task<Bacon> FryBaconAsync(int slices)
        {
            //Task.Run exécute une action (lambda) 
            return await Task.Run(() => FryBacon(slices));
        }

        //Méthode synchrone
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


        //Méthode asynchrone
        static async Task<Toast> ToastBreadAsync(int slices)
        {
            return await Task.FromResult(ToastBread(slices));
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

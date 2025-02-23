using System;
using System.Collections.Generic;
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
            //Etape 5 - Code asynchrone non bloquant (Task.WhenAll)

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Coffee cup = PourCoffee();
            Console.WriteLine("Coffee is ready");

            //You start all the asynchronous tasks at once
            Task<Egg> eggsTask = FryEggsAsync(2);
            Task<Bacon> baconTask = FryBaconAsync(3);
            Task<Toast> toastTask = MakeToastWithButterAndJamAsync(2);

            Juice oj = PourOJ();
            Console.WriteLine("Orange juice is ready");           

            List<Task> tasks = new List<Task>() { eggsTask, baconTask, toastTask };
          
            //The series of await statements can be improved by using methods of the Task class
            //WhenAll returns a Task that completes when all the tasks in its argument list have completed

            await Task.WhenAll(eggsTask, baconTask, toastTask);

            //Pour récupérer les résultats de chacune des taches
            Egg eggs = eggsTask.Result;
            Bacon bacon = baconTask.Result;
            Toast toast = toastTask.Result;

            Console.WriteLine("eggs are ready");
            Console.WriteLine("bacon is ready");
            Console.WriteLine("toast is ready");

            Console.WriteLine("Breakfast is ready!");

            stopwatch.Stop();
            Console.WriteLine($"Temps : {stopwatch.ElapsedMilliseconds}");

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

        //Une méthode qui est composée de taches asynchrone et synchrone est asynchrone 
        //La méthode contient le mot clé async dans sa signature pour indiquer au compilateur qu'elle contient un await 
        //Par convention, le nom des methodes async se termine par async
        static async Task<Toast> MakeToastWithButterAndJamAsync(int nb)
        {
            Toast toast = await ToastBreadAsync(nb); //Attend que le pain soit grillé avant de continuer
            ApplyButter(toast);
            ApplyJam(toast);
            return toast;
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

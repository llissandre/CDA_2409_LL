using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace TAP_Example
{
    // Exemple : Task-based Asynchroneous Pattern (TAP)
    
    class Program
    {
        static async Task Main(string[] args)
        {
            int length = await GetUrlContentLengthAsync();

            Console.WriteLine(length);

            Console.ReadKey();
        }

        //A savoir : quand une méthode contient un await, elle doit être marquée avec le mot clé async
        //Convention de nommage : suffixer les méthodes asynchrones par Async
        public static async Task<int> GetUrlContentLengthAsync()
        {
            var client = new HttpClient();
            
            //Une méthode asynchrone retourne une Task<TResult> pour pouvoir suivre son état
            //TResult désigne le type du résultat attendu
            Task<string> getStringTask = client.GetStringAsync("https://amio-millau.fr/");

            DoIndependentWork();

            //await = non bloquant, on n'attend pas le résultat, retour à l'appelant
            //La récupération du résultat et l'affectation se feront quand la tache sera terminée
            //En arrière-plan, await installe un rappel sur la tâche à l’aide d’une continuation
            //Ce rappel reprendra la méthode asynchrone au point d’interruption
            string contents = await getStringTask;

            return contents.Length;
        }

        static void DoIndependentWork()
        {
            Console.WriteLine("Working...");
        }
    }
}

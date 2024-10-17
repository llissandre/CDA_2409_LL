namespace CalculDuNombreDePersonnes
{
    internal class Program
    {

        static int age;
        static int iterator;
        static string[] monTableau = new string[20];
        static bool vrai;


        static string[] calculLeNbDeJeunes(string phrase)
        {
            iterator = 0;
            do
            {
                do
                {
                    Console.Write("Saisir un nombre entier : ");
                    vrai = int.TryParse(Console.ReadLine(), out age);
                }
                while (!vrai);

                monTableau[iterator] = age.ToString();
                iterator++;
            }
            while (iterator < 20);

            return monTableau;
        }


        static void Main(string[] args)
        {
            string[] monTableauDAges = new string[20];

            monTableauDAges = calculLeNbDeJeunes("");

            iterator = 0;

            foreach (string monTableauDAge in monTableauDAges)
            {
                age = int.Parse(monTableauDAge);

                if (age < 20)
                {
                    iterator++;
                }
            }

            Console.WriteLine();
            Console.Write($"Nombre de jeunes : {iterator}.");
            Console.WriteLine();
        }
    }
}

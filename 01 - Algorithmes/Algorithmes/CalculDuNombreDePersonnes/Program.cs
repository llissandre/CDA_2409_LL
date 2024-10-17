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
            int moinsDe20Ans;
            string[] monTableauDAges = new string[20];
            int plusDe20Ans;

            //iterator = 0;
            moinsDe20Ans = 0;
            monTableauDAges = calculLeNbDeJeunes("");
            plusDe20Ans = 0;


            foreach (string monTableauDAge in monTableauDAges)
            {
                age = int.Parse(monTableauDAge);

                if (age < 20)
                {
                    moinsDe20Ans++;
                }
                else
                {
                    plusDe20Ans++;
                }
            }

            if (moinsDe20Ans == monTableauDAges.Length)
            {
                Console.WriteLine();
                Console.WriteLine("TOUTES LES PERSONNES ONT MOINS DE 20 ANS !");
            }
            else if (plusDe20Ans == monTableauDAges.Length)
            {
                Console.WriteLine();
                Console.WriteLine("TOUTES LES PERSONNES ONT PLUS DE 20 ANS !");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"Il y a {moinsDe20Ans} personnes de moins de 20 ans et {plusDe20Ans} personnes de plus de 20 ans.");
            }

            //Console.WriteLine();
            //Console.Write($"Nombre de jeunes : {iterator}.");
            //Console.WriteLine();
        }
    }
}

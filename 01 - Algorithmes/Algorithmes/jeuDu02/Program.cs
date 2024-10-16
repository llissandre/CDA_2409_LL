namespace jeuDu02
{
    internal class Program
    {


        static int nombre;
        static string saisie;

        static int choisirUnNombreEntre0Et2(string phrase)
        {
            do
            {
                Console.Write("Choisir entre 0, 1 et 2 : ");
                saisie = Console.ReadLine() ?? "";
            }
            while (!int.TryParse(saisie, out nombre) || nombre > 2);

            return nombre;
        }

        static int choixDeLOrdinateur(string phrase)
        {
            Console.Write("Choix de l'ordinateur :");
            Random computer = new Random();
            nombre = computer.Next(0, 3);
            Console.WriteLine(nombre);
            Console.WriteLine();

            return nombre;
        }


        static void Main(string[] args)
        {
            int joueur;
            int computer;
            int pointsJoueur;
            int pointsComputer;

            pointsJoueur = 0;
            pointsComputer = 0;

            do
            {
                joueur = choisirUnNombreEntre0Et2("");

                computer = choixDeLOrdinateur("");

                if (Math.Abs(computer - joueur) == 2)
                {
                    if (computer > joueur)
                    {
                        pointsComputer++;
                    }
                    else
                    {
                        pointsJoueur++;
                    }
                }

                if (Math.Abs(computer - joueur) == 1)
                {
                    if (computer > joueur)
                    {
                        pointsJoueur++;
                    }
                    else
                    {
                        pointsComputer++;
                    }
                }
            }
            while (joueur >= 0 && pointsComputer < 10 && pointsJoueur < 10);

            Console.WriteLine($"Score du joueur : {pointsJoueur}");
            Console.WriteLine($"Score du computer : {pointsComputer}");
            Console.WriteLine();
        }
    }
}

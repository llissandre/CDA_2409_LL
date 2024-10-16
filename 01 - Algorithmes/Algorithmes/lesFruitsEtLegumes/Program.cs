namespace lesFruitsEtLegumes
{
    internal class Program
    {
        static double prix;
        static string saisie;
        static bool vrai;


        static string saisieNomslegumes(string phrase)
        {
            vrai = false;

            do
            {
                Console.Write("Saisir le nom du légumes : ");
                saisie = Console.ReadLine();

                if (saisie != "")
                {
                    vrai = true;
                }
            } while (!vrai);

            return saisie;
        }

        static double saisiePrix(string phrase)
        {

            do
            {
                Console.Write("Saisir le prix : ");
                saisie = Console.ReadLine() ?? "";
                vrai = double.TryParse(saisie, out prix);
            }
            while (!vrai);

            return prix;
        }

        static void Main(string[] args)
        {
            string fruitOuLegume;
            int iterateur;
            string[] monTableauD1FruitOuD1Legume;
            double prix;

            iterateur = 0;
            List<string[]> monTableauDeFruitsEtLegumes = new(); ;


            do
            {
                monTableauD1FruitOuD1Legume = new string[2];
                fruitOuLegume = saisieNomslegumes("");
                prix = saisiePrix("");

                monTableauD1FruitOuD1Legume[0] = fruitOuLegume;
                monTableauD1FruitOuD1Legume[1] = prix.ToString();

                monTableauDeFruitsEtLegumes.Add(monTableauD1FruitOuD1Legume);
                Console.WriteLine();
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            foreach (string[] _monTableauD1FruitOuD1Legume in monTableauDeFruitsEtLegumes)
            {
                Console.WriteLine($"1 kilogramme de {_monTableauD1FruitOuD1Legume[iterateur]} coute {_monTableauD1FruitOuD1Legume[iterateur + 1]} euros.");
            }

            iterateur = 0;

            foreach (string[] _monTableauD1FruitOuD1Legume in monTableauDeFruitsEtLegumes)
            {
                if
                    Console.WriteLine($"Légume le moins cher au kilo : {_monTableauD1FruitOuD1Legume[iterateur]}.");
            }
        }
    }

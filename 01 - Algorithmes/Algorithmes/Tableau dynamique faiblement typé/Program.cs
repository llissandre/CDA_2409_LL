using System.Collections;

namespace Tableau_dynamique_faiblement_typé
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CollectionBase faiblement typée
            ArrayList utilisateurs = new ArrayList();
            utilisateurs.Add(2);
            utilisateurs.Add("Toto");
            utilisateurs.Add(new DateTime());

            try
            {
                int entier = (int)utilisateurs[0];
            }
            catch (Exception ex)
            {
                // gestion de l'erreur
            }

            int? entier2 = utilisateurs[0] as int?;

            if (entier2 == null)
            {
            }

            if (utilisateurs[0] is int entier3)
            {
            }

            Object tata = 0;
            Object toto = "essai";
        }
    }
}

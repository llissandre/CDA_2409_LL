//affiche sur la console : "Quelle est votre ancienneté dans la compagnie ?"
Console.Write("Quelle est votre ancienneté dans la compagnie ? ");

//récupère l'âge donné par l'utilisateur et le range dans la 
//variable Age
int Anciennetee = int.Parse(Console.ReadLine());

if (Anciennetee >= 5)
{
    //affiche sur la console : "Quel âge avez-vous ?"
    Console.Write("Quel âge avez-vous ? ");

    //récupère l'âge donné par l'utilisateur et le range dans la 
    //variable Age
    int Age = int.Parse(Console.ReadLine());

    if (Age >= 25)
    {
        Console.Write("Depuis combien d'années avez-vous eu le permis ?");

        //récupère la durée donnée par l'utilisateur et la range dans la 
        //variable Annees
        int Annees = int.Parse(Console.ReadLine());

        if (Annees >= 2)
        {
            Console.Write("Combien avez-vous eu d'accidents ?");

            //récupère la durée donnée par l'utilisateur et la range dans la 
            //variable Accidents
            int Accidents = int.Parse(Console.ReadLine());

            if (Accidents == 0)
            {
                Console.WriteLine("Vous bénéficiez du tarif bleu");
            }
            else if (Accidents == 1)
            {
                Console.WriteLine("Vous bénéficiez du tarif vert");
            }
            else if (Accidents == 2)
            {
                Console.WriteLine("Vous bénéficiez du tarif orange");
            }
            else
            {
                Console.WriteLine("Votre adhésion est refusée");
            }
        }
        else
        {
            Console.Write("Combien avez-vous eu d'accidents ?");

            //récupère la durée donnée par l'utilisateur et la range dans la 
            //variable Accidents
            int Accidents = int.Parse(Console.ReadLine());

            if (Accidents == 0)
            {
                Console.WriteLine("Vous bénéficiez du tarif orange");
            }
            else if (Accidents == 1)
            {
                Console.WriteLine("Vous bénéficiez du tarif vert");
            }
            else
            {
                Console.WriteLine("Votre adhésion est refusée");
            }
        }
    }
    else
    {
        Console.Write("Depuis combien d'années avez-vous eu le permis ?");

        //récupère la durée donnée par l'utilisateur et la range dans la 
        //variable Annees
        int Annees = int.Parse(Console.ReadLine());

        if (Annees >= 2)
        {
            Console.Write("Combien avez-vous eu d'accidents ?");

            //récupère la durée donnée par l'utilisateur et la range dans la 
            //variable Accidents
            int Accidents = int.Parse(Console.ReadLine());

            if (Accidents == 0)
            {
                Console.WriteLine("Vous bénéficiez du tarif orange");
            }
            else if (Accidents == 1)
            {
                Console.WriteLine("Vous bénéficiez du tarif vert");
            }
            else
            {
                Console.WriteLine("Votre adhésion est refusée");
            }
        }
        else
        {
            Console.Write("Combien avez-vous eu d'accidents ?");

            //récupère la durée donnée par l'utilisateur et la range dans la 
            //variable Accidents
            int Accidents = int.Parse(Console.ReadLine());

            if (Accidents == 0)
            {
                Console.WriteLine("Vous bénéficiez du tarif orange");
            }
            else
            {
                Console.WriteLine("Votre adhésion est refusée");
            }
        }
    }
}
else
{
    //affiche sur la console : "Quel âge avez-vous ?"
    Console.Write("Quel âge avez-vous ? ");

    //récupère l'âge donné par l'utilisateur et le range dans la 
    //variable Age
    int Age = int.Parse(Console.ReadLine());
    if (Age >= 25)
    {
        Console.Write("Depuis combien d'années avez-vous eu le permis ?");

        //récupère la durée donnée par l'utilisateur et la range dans la 
        //variable Annees
        int Annees = int.Parse(Console.ReadLine());

        if (Annees >= 2)
        {
            Console.Write("Combien avez-vous eu d'accidents ?");

            //récupère la durée donnée par l'utilisateur et la range dans la 
            //variable Accidents
            int Accidents = int.Parse(Console.ReadLine());

            if (Accidents == 0)
            {
                Console.WriteLine("Vous bénéficiez du tarif vert");
            }
            else if (Accidents == 1)
            {
                Console.WriteLine("Vous bénéficiez du tarif bleu");
            }
            else if (Accidents == 2)
            {
                Console.WriteLine("Vous bénéficiez du tarif rouge");
            }
            else
            {
                Console.WriteLine("Votre adhésion est refusée");
            }
        }
        else
        {
            Console.Write("Combien avez-vous eu d'accidents ?");

            //récupère la durée donnée par l'utilisateur et la range dans la 
            //variable Accidents
            int Accidents = int.Parse(Console.ReadLine());

            if (Accidents == 0)
            {
                Console.WriteLine("Vous bénéficiez du tarif rouge");
            }
            else if (Accidents == 1)
            {
                Console.WriteLine("Vous bénéficiez du tarif orange");
            }
            else
            {
                Console.WriteLine("Votre adhésion est refusée");
            }
        }
    }
    else
    {
        Console.Write("Depuis combien d'années avez-vous eu le permis ?");

        //récupère la durée donnée par l'utilisateur et la range dans la 
        //variable Annees
        int Annees = int.Parse(Console.ReadLine());

        if (Annees > 2)
        {
            Console.Write("Combien avez-vous eu d'accidents ?");

            //récupère la durée donnée par l'utilisateur et la range dans la 
            //variable Accidents
            int Accidents = int.Parse(Console.ReadLine());

            if (Accidents == 0)
            {
                Console.WriteLine("Vous bénéficiez du tarif rouge");
            }
            else if (Accidents == 1)
            {
                Console.WriteLine("Vous bénéficiez du tarif orange");
            }
            else
            {
                Console.WriteLine("Votre adhésion est refusée");
            }
        }
        else
        {
            Console.Write("Combien avez-vous eu d'accidents ?");

            //récupère la durée donnée par l'utilisateur et la range dans la 
            //variable Accidents
            int Accidents = int.Parse(Console.ReadLine());

            if (Accidents == 0)
            {
                Console.WriteLine("Vous bénéficiez du tarif rouge");
            }
            else
            {
                Console.WriteLine("Votre adhésion est refusée");
            }
        }
    }
}
// permet de laisser la fenêtre de la console ouverte
Console.ReadLine();
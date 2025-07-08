//déclaration la valeur des chaines de caractères c1 et c2
string c1 = "valeur de c1";
string c2 = "valeur de c2";

//affichage des 2 variables avant la permutation
Console.WriteLine("Avant la permutation");
//affiche sur la console : "La valeur de c1 est : "
//et la chaine de caractère c1
Console.WriteLine("La valeur de c1 est : " + c1);
//affiche sur la console : "La valeur de c1 est : "
//et la chaine de caractère c2
Console.WriteLine("La valeur de c2 est : " + c2);

//déclaration la valeur des chaines de caractères c3
//la valeur de la variable c1 est provisoirement
//"assignée" à la variable temporaire Tmp
string Tmp = c1;
//la valeur de la variable c2 est "assignée" à la
//variable c1
c1 = c2;
//la valeur de la variable c3 est "assignée" à la
//variable c2
c2 = Tmp;

//permet de créer un saut de ligne entre les deux réponses
Console.WriteLine(" ");

//affichage des 2 variables après la permutation
Console.WriteLine("Après la permutation");
//affiche sur la console : "La nouvelle valeur de c1
//est : " et la chaine de caractère c1
Console.WriteLine("La nouvelle valeur de c1 est : " + c1);
//affiche sur la console : "La nouvelle valeur de c2
//est : " et  et la chaine de caractère c2
Console.WriteLine("La nouvelle valeur de c2 est : " + c2);

//permet de laisser la fenêtre de la console ouverte
Console.ReadLine();
// See https://aka.ms/new-console-template for more information
using SystemeFichier_CDA07.Elements;
using SystemeFichier_CDA07.Gestionnaire;

Console.WriteLine("Hello, World!");


Dossier racine = new Dossier();
racine.Nom = "RACINE";

GestionnaireDeFichier gestionnaireDeFichier = new GestionnaireDeFichier(racine);
gestionnaireDeFichier.creeerNouveauFichier().Nom = "le fichier";
Dossier dossier1 = gestionnaireDeFichier.creeerNouveauDossier();
dossier1.Nom = "dossier_1";
Console.WriteLine("----");
foreach (Element element in gestionnaireDeFichier.getContenuDossierCourant())
{
    Console.WriteLine(element.Nom);   
}
gestionnaireDeFichier.descendreDansDossierEnfant(dossier1);
Console.WriteLine("----");
foreach (Element element in gestionnaireDeFichier.getContenuDossierCourant())
{
    Console.WriteLine(element.Nom);
}

gestionnaireDeFichier.creeerNouveauFichier().Nom = "le fichier 2";
Console.WriteLine("----");
foreach (Element element in gestionnaireDeFichier.getContenuDossierCourant())
{
    Console.WriteLine(element.Nom);
}



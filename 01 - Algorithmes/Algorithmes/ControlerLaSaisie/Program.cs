﻿// See https://aka.ms/new-console-template for more information

using System.Security.Cryptography.X509Certificates;

string prenom;
int longueurPrenom;
int nombreDEssais;

nombreDEssais = 0;

do
{
    Console.WriteLine("Saisissez votre prénom, qui doit être composé d'au moins deux lettres :");
    prenom = Console.ReadLine();
    longueurPrenom = prenom.Length;
    nombreDEssais++;
}
while (longueurPrenom < 2);

Console.WriteLine($"Bonjour {prenom}");
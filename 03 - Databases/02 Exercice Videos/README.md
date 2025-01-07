Dix sites de streaming vidéo (location/vente) se sont regroupés pour mettre en commun les films dont ils disposent et ont fondé un club. 

À la suite d’une rencontre avec les représentants de ce club, il ressort que chaque site membre du club disposera du catalogue commun relié à une base de données centrale et qu’il faudra pouvoir prendre en compte les éléments suivants :

1.	Un client qui s’inscrit au club renseigne son nom et prénom et peut alimenter son compte en Euros.
2.	Les films loués par un client sont accessibles 3 jours depuis n’importe quel site membre.
3.	Plusieurs vidéos peuvent contenir le même film (version différentes).
4.	Un film est rattaché à un ou plusieurs genres cinématographique (nom et type de public) et est caractérisé par sa durée, son réalisateur et la liste des acteurs principaux.
5.	Une location n’est permise que si le client dispose d’assez de fonds sur son compte.
6.	La consultation d’un client permettra d’obtenir son nom, prénom, solde du compte, son nombre de location en cours, la liste des vidéos qu’il a actuellement loués avec la position de lecture actuelle.
7.	La consultation d’un genre permettra d’obtenir la liste des films de ce genre disponibles dans le catalogue.
8.	Périodiquement, on veut obtenir une liste de remboursement ; on veut pour chaque vidéo louée et non-lue dans le délai de 3 jours :
    a.	Nom du client, date de l’emprunt, identifiant et titre du (des) vidéo(s) concerné(s).


# Travail à réaliser 

- Établir le dictionnaire des données
- Repérer les dépendances fonctionnelles simples
- Identifier et formaliser les règles de gestion
- Modéliser le MCD
- Exporter le modèle logique
- Créer le script de création de la base de données
- Implémeneter les requêtes SQL demandées


## Contexte de la démonstration collective

L'analyse (dictionnaire des données, dépendances et règles de gestion) prend en considération tous les éléments de la demande initiale. 

Le résultat de l'anaylse est disponible dans le document [00-videos-analyse.docx](./00-videos-analyse.docx)

A partir du MCD, ne seront pris en considération que les films, les acteurs et les réalisateurs.

**Fichiers**

- [Modèle conceptuel des données (Fichier Looping)](./02-MCD-films-acteurs-realisateurs.loo)
- [Script de création de la base de données]()


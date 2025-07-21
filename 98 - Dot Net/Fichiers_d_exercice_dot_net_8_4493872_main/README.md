# L'essentiel de .Net 8

Ce dossier Repository est lié au cours `L'essentiel de .Net 8`. Le cours entier est disponible sur [LinkedIn Learning][lil-course-url].

![L'essentiel de .Net 8][lil-thumbnail-url] 

Ce cours est intégré à GitHub Codespaces, un environnement de développement instantané « dans le nuage » qui offre toutes les fonctionnalités de votre IDE préféré sans nécessiter de configuration sur une machine locale. Avec Codespaces, vous pouvez vous exercer à partir de n'importe quelle machine, à tout moment, tout en utilisant un outil que vous êtes susceptible de rencontrer sur votre lieu de travail. Consultez la vidéo "Utilisation de Codespaces GitHub dans le cadre de ce cours" pour savoir comment démarrer.    

Si vous êtes développeuse ou développeur .Net, découvrez ce cours pour créer et gérer des applications en environnement .NET 8. Je partage mon expérience en C# afin de mettre en place un premier projet de développement et de prendre en main les données texte, date, expressions régulières et objets. Vous allez voir comment structurer vos applications, amorcer une application web, garantir la persistance, faire communiquer les applications entre elles et tirer parti du contrôle de l'état du programme.

## Instructions

Ce dossier Repository a des branches pour chacune des vidéos du cours. Vous pouvez utiliser le menu des Branches sur GitHub afin d’accéder aux passages qui vous intéressent. Vous pouvez également rajouter `/tree/BRANCH_NAME` à l’URL afin d’accéder à la branche qui vous intéresse. 

Pour utiliser GitHub Codespaces et faire apparaître l'environnement du cours dans votre navigateur, il vous suffit de cliquer sur :

- Fork à droite du nom du dépôt, pour faire votre fork de ce dépôt,
- le bouton <> Code, pour faire sélectionner l'onglet Codespaces,
- le bouton Create codespace on main, pour initier et faire apparaître un codespace.

Ce dépôt possède une ou deux branches par leçon (vidéo de cours). Vous pouvez naviguer dans les versions grâce au menu d'accès aux branches accessible en cliquant sur le nom de branche en bas à gauche de VisualStudio Code.

## Branches

Les branches sont structurées de manière à correspondre aux vidéos du cours. La convention de nommage est : `CHAPITRE#_VIDEO#`. Par exemple, la branche nommée`02_03` correspond au second chapitre, et à la troisième vidéo de ce chapitre. Certaines branches ont un état de départ et de fin.  
La branche `02_03_d` correspond au code du début de la vidéo.  
La branche `02_03_f` correspond au code à la fin de la vidéo.  

En changeant de branche, après avoir fait des changements, il se peut que vous ayez ce message :

    erreur : Vos changements locaux sur les fichiers suivants seront écrasés par le basculement (checkout) : [fichiers]
    Validez (commit) vos changement ou réservez (stash) les avant de changer de branche.

Pour résoudre ce problème :
	
- Ajoutez vos changements avec la commande : `git add .`
- Validez les avec commande: `git commit -m "un message"`

## Installation

Si vous n'utilisez pas GitHub Codespaces :

1. Pour utiliser ces fichiers d’exercice, vous avez besoin de : 
   - SDK .Net 8
   - Visual Studio Code muni des extensions officielles .Net
   - ou Microsoft Visual Studio version récente
2. Clonez ce dossier Repository sur votre machine locale (Mac), CMD (Windows), ou sur un outil GUI tel que SourceTree. 


### Formateur

**Sylvain Labasse** 

Retrouvez mes autres formations sur [LinkedIn Learning][lil-URL-trainer].

[0]: # (Replace these placeholder URLs with actual course URLs)
[lil-course-url]: https://www.linkedin.com/learning/l-essentiel-de-dot-net-8
[lil-thumbnail-url]: https://media.licdn.com/dms/image/D560DAQGPr1tqAtiAHA/learning-public-crop_675_1200/0/1705337370628?e=2147483647&v=beta&t=1FqPyDfkuLyCahBKX71TMBKwcZLSywG9soG7ao6NWaY
[lil-URL-trainer]: https://www.linkedin.com/learning/instructors/sylvain-labasse

[1]: # (End of FR-Instruction ###############################################################################################)

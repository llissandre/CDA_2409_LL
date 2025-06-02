### Principe de la couverture de code
La couverture de code est une mesure utilisée pour déterminer le taux de code source exécuté lorsqu’une suite de tests est lancée. Pour essayer de limiter les bugs, les tests doivent couvrir une large proportion de code.

Il y a plusieurs indicateurs de couverture de code :

- **Couverture des fonctions (ou méthodes)** : est-ce que toutes les méthodes du code ont été appelées par les tests ?

- **Couverture des instructions** : est-ce que les tests sont passés sur chaque ligne de code ?

- **Couverture des chemins d’exécution** : est-ce que l’on est passé dans toutes les branches de notre code ? Par exemple, l’instruction  if  génère deux branches de code : une dans laquelle la condition évaluée est vraie, une autre où la condition est fausse.

- **Couverture des points de tests** : est-ce que chaque condition sur le test d’une variable a été couverte ?

En général, la plupart des outils proposent la couverture des instructions et des chemins d’exécution. Et la métrique la plus fiable est celle des chemins d’exécution, c’est celle que vous devez privilégier.


#### Les différents outils de mesure
Il existe plusieurs outils permettant de mesurer la couverture de code. Nous allons passer en revue les plus connus.

**Visual Studio** possède un outil de mesure de code.

Il existe aussi **DotCover**, qui est l’outil de **Jetbrains**.

Un autre outil assez connu est **NCover**.

Une dernière option serait **OpenCover**.

Il s’agit d’un outil open source sous licence MIT. C’est celui que nous allons utiliser dans ce cours, sachant qu’il ne fonctionne que sous Windows et que nous allons donc installer également des extensions pour pouvoir l’utiliser correctement. Le projet se trouve sur github, mais vous n'avez pas besoin de le cloner, il suffira de référencer le bon package Nuget.

OpenCover est le moteur d’analyse de la couverture de code. Il nous faut maintenant une interface permettant de lire les résultats de l’analyse. Avec Visual Studio 2017, nous pouvons installer l’extension AxoCover : https://marketplace.visualstudio.com/items?itemName=axodox1.AxoCover&showQnADialog=true
>Visual Studio doit être fermé pendant cette installation.
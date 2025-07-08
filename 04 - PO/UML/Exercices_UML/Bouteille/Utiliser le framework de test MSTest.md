#### Cycle de vie d’un test

Nous sommes presque prêts à écrire un test pour notre jeu. Mais comment l’écrire proprement ?

En général, un test se décompose en trois partie, suivant le schéma « **AAA** », qui correspond aux mots anglais « Arrange, Act, Assert », que l’on peut traduire en français par « Arranger, Agir, Auditer » :

- **Arranger** : il s’agit dans un premier temps de définir les objets, les variables nécessaires au bon fonctionnement de son test (initialiser les variables, initialiser les objets à passer en paramètres de la méthode à tester, etc.).

- **Agir** : ensuite, il s’agit d’exécuter l’action que l’on souhaite tester (en général, exécuter la méthode que l’on veut tester, etc.)

- **Auditer** : et enfin de vérifier que le résultat obtenu est conforme à nos attentes.

>Assert.Fail()  permet de faire échouer le test et fait partie de ce que l’on appelle “les assertions”. 


#### Given When Then

AAA n’est pas le seul schéma qui existe pour structurer ses tests. Given When Then (que l’on peut traduire par : “étant donné que … lorsque … alors …) est un schéma issu de la méthodologie **BDD** qui est souvent considérée comme une évolution de TDD.

>BDD veut dire "Behavior Driven Development", que l’on peut traduire par "Développement Dirigé par le Comportement".

L’idée est que le test puisse devenir compréhensible par des non-développeurs grâce à une formulation représentant le scénario à tester.

- Given : décrit l’état du système avant que l’on démarre le comportement du scénario à tester. Il s’agit des préconditions du test.

- When : correspond au comportement que l’on veut tester.

- Then : sert à décrire les changements que l’on attend à la suite de l’exécution du comportement.

Vous voyez, ces trois phases sont assez proches de AAA.

En général, le schéma qui est retenu comporte une phase supplémentaire en fin de test, où l'on va remettre le système dans son état initial, tel qu’il était avant l’exécution du test.

>Ceci est particulièrement valable pour les tests qui modifient l’état du système, par exemple les tests d'intégration.
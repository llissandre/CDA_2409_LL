Les caractéristiques d’un bon test


1. Un test doit avoir une forte probabilité de montrer des régressions

Cela se traduit notamment par le fait de tester un nombre important de lignes et de fonctionnalités. Mais pas seulement ! Ce n’est pas toujours qu’une question de lignes, mais aussi de signification. Tester du code métier, c’est bien, mais tester du code trivial n'a pas d'intérêt.


2. Un test doit avoir une probabilité faible de montrer des faux positifs

Un faux positif correspond à un test qui échoue alors que la fonctionnalité testée est opérationnelle. Le test ne devrait pas échouer, il s’agit d’une fausse alarme.


3. Un test doit apporter un feedback rapide

C’est très important, car plus on a un retour rapide, moins on perd de temps à partir dans la mauvaise direction.
Il faut donc que l’intégralité des tests puisse s’exécuter très rapidement.


4. Un test doit avoir un coût de maintenance réduit

En général, c’est fortement lié à la taille du test. Plus il y a de lignes de codes dans un test, plus la maintenance sera compliquée et prendra du temps.
Il est plus facile de lire du code ou de le modifier lorsqu’il y a peu de lignes.
Écrivez des tests simples, qui ne testent pas énormément de choses. Il vaut mieux écrire 5 petits tests qu’un gros test qui teste 5 choses. Cela sera plus simple de déterminer celui qui échoue et simplifiera le code global.
Tester le code à ses extrémités, comme une boîte noire, permet de réduire la maintenance.
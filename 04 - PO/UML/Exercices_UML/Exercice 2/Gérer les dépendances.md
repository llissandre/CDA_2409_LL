##### Cela peut se faire de plusieurs façons :
- soit en écrivant une fausse classe simulant ce comportement ;
- soit en utilisant un framework de simulacres.


Les différents types de bouchons :

En entreprise ou dans des articles sur internet, vous allez très souvent voir le terme "bouchon" pour indiquer quelque chose qui va simuler un comportement.
Pour être précis, il faudrait utiliser le terme doublure de test, que l’on trouve plus fréquemment en anglais avec la terminologie “tests doubles”.
Il existe plusieurs types de doublures de tests, dont notamment les bouchons et les simulacres (en anglais respectivement stubs et mocks). Il existe aussi le concept de fantôme(dummy) et de substitut(fake).
Il est très facile de mélanger les différents termes et d’abuser un peu de la terminologie. Beaucoup de personnes utilisent les différents mots de manière interchangeable. Ce n’est pas trop grave lorsque l’on débute, mais chaque type de doublure de test a un but précis, dont la différence peut être parfois subtile.

Les frameworks de simulacre :

Un framework de simulacre permet de bouchonner le code dont notre développement dépend afin de pouvoir le tester unitairement, sans dépendance et isolé du reste du système.
Cela veut dire que, dans notre test, nous allons remplacer la lecture de cette information complexe par une fausse méthode qui renvoie toujours qu’il fait beau. Cependant, ceci doit se faire sans modifier notre application, sinon cela n’a pas d’intérêt. Voilà à quoi servent ces frameworks de simulacre.
Il en existe plusieurs, plus ou moins complexes. Citons par exemple Moq (prononcez « moque-you ») qui est un framework open source et gratuit. Certains sont payants et fournissent des outils très puissants lorsqu’il s’agit de tester du code legacy qui a été écrit sans penser à la testabilité.
L’intérêt de Moq est qu’il est simple d’accès et qu'il est gratuit.


Quand vous aurez de l’expérience avec les tests, vous y reviendrez naturellement. Ce qui est important pour vous, aujourd’hui, c’est de comprendre que le but final d’une doublure de test est de simuler des dépendances (que ce soient un composant complet, une classe, une méthode, etc.) afin de simplifier l’écriture des tests.
**En français, Développement dirigé par les tests** 

L’idée est simple :
- Lorsque l'on souhaite développer une nouvelle fonctionnalité, on commence par écrire le test qui vérifie son fonctionnement. Dans un deuxième temps, la fonctionnalité est développée pour que le test soit validé.

Le principe consiste ensuite à travailler en petits cycles itératifs où l’on va :
- Écrire le minimum de code possible pour faire passer le test ;
- Enrichir la base de tests avec un nouveau test ;
- Écrire à nouveau le minimum de code pour faire passer le test ;
- Et ainsi de suite…

### Principes du TDD :

#### 1 - Écrire un test :
La première chose à faire, lorsque l’on a besoin d’une nouvelle fonctionnalité, est d’écrire un test. Cela implique de comprendre la fonctionnalité que l’on doit développer, ce qui est une très bonne chose.

#### 2 - Exécuter le test :
Il faut ensuite exécuter le test que l'on vient d'écrire.

#### 3 - Écrire le minimum de code :
Ensuite, on écrit le minimum de code permettant de faire passer le test, et seulement le minimum. Si le code écrit n’est pas beau, ou fait passer le test de manière inélégante, ce n’est pas grave. On relance tous les tests pour s’assurer que tout fonctionne.
Note : écrire le minimum de code permet de respecter les bonnes pratiques KISS et YAGNI.
KISS correspond à Keep It Simple Stupid (ou des variantes) et incite à garder le code simple.
YAGNI (you ain't gonna need it) peut être traduit par “tu n’en auras pas besoin”. 

#### 4 - Remanier le code
Dans cette phase, nous avons l’opportunité d’améliorer le code que nous avons écrit. Cela permet de voir s’il ne peut pas être simplifié, mieux écrit, rendu générique. On retire les duplications, on renomme des variables, des méthodes, des classes, etc., afin que le code soit bien propre et exprime clairement son intention. On peut séparer les responsabilités, extraire potentiellement des patrons de conception, etc.
En bref : on améliore le code !

#### 5 - On recommence à l'étape 1 !
Le cycle recommence. Si la fonctionnalité que l’on a écrite peut être mieux couverte par d'autres tests, si l’on doit introduire d'autres cas pour tester la fonctionnalité, alors on écrit un nouveau test. Puis on écrit du code pour le faire passer, on améliore le code, on écrit un nouveau test, etc.

>**Les bénéfices du TDD :**
>
>Nous avons donc un cycle vertueux, qui améliore notre base de tests, nous rend plus confiants dans notre code et le rend plus propre, plus robuste et plus facile à maintenir.
>On appelle en général ce cycle red/green/refactor.
>"Red" (rouge) correspond à la couleur du test lorsqu'il échoue.
>"Green" (vert) quand le test passe, bien sûr.
>"Refactor" indique la phase de remaniement de code. Nous en reparlerons lorsque nous choisirons un framework de test.
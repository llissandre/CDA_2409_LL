### Les différentes assertions

L’écriture des assertions est différente en fonction du framework de test choisi, mais globalement, on arrivera à faire les mêmes choses, avec des syntaxes différentes.

Pour vérifier que le test s’est bien comporté, on va en général comparer les résultats des méthodes ou objets aux valeurs que l’on est censé obtenir.

Telle propriété est égale à telle valeur, tel booléen doit être vrai, etc.

Cela se fait avec la classe  Assert  de MSTest.

Assert.Fail(), comme son nom l’indique, va faire échouer le test explicitement. Nous nous en sommes servi dans l’exemple précédent, mais il a des remplaçants bien plus pratiques.

- Assert.AreEqual(1, 1); // égalité entre entier
- Assert.AreEqual(3.14, 6.28  /2 ); // égalité entre double
- Assert.AreEqual("une chaine", "une " + "chaine"); // égalité entre chaînes
- Assert.AreNotEqual(1, 2); // inégalité
- Assert.IsFalse(1 == 2); // booléen vaut faux
- Assert.IsTrue(1 <= 2); // booléen vaut vrai
- Jeu jeu1 = new Jeu();
- Jeu jeu2 = jeu1;
- Assert.AreSame(jeu1, jeu2); // les références de l'objet sont identiques
- jeu2 = new Jeu();
- Assert.AreNotSame(jeu1, jeu2); // les références ne sont pas identiques
- Assert.IsInstanceOfType(jeu1, typeof(Jeu)); // comparaison de type
- Assert.IsNotInstanceOfType(jeu1, typeof(De)); // différence de type
- Assert.IsNotNull(jeu); // différence à null
- jeu1 = null;
- Assert.IsNull(jeu1); // comparaison à null

Toutes ces assertions sont correctes et illustrent les différents types de comparaisons qui existent dans le framework MSTest.

>À noter que, dans la pratique, on se sert beaucoup de  Assert.AreEqual , ou  Assert.IsTrue , ou  Assert.IsFalse . La vérification de booléen nous permet de vérifier toutes sortes de choses à partir du moment où l'on est capable de faire l’opération booléenne en code.


### Améliorez la lisibilité des assertions

Nous avons vu que le framework MSTest mettait à notre disposition de nombreuses possibilités de vérifications via la classe  Assert.

Mais nous pouvons faire encore plus lisible, et ceci très facilement. Il suffit d'ajouter une petite bibliothèque gratuite, que l’on trouvera sur le gestionnaire de package : Nuget.

Il s’agit de Fluent Assertions.

Ce package Nuget contient un ensemble de méthodes d’extensions nous permettant d’écrire nos assertions dans un style qui se rapproche du langage naturel.

>On appelle ce type d’écriture : Fluent.


### Vérifiez les exceptions

Un cas particulier des vérifications est la vérification des exceptions.

Il peut arriver que l’on veuille s’assurer que, dans une situation limite, une exception est bien levée.
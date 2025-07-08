# Gestion des pays

Démonstration HTML/CSS/JS

## Fonctionnalités : 

- Exploiter les données soumises dans un formulaire
- Créer et exploiter un objet littéral
- Charger et exploiter un objet JSON
- Charger et exploiter un tableau JSON

## Travail à réaliser


### Partie 1 : Récolte des données

Dans le fichier "**assets/1-ajouter.js**": 

1. Remplacer le titre de la balise H1 par "Ajouter un pays" (en utilisant JS uniquement).
2. Récolter et exploiter les données soumises par le formulaire de la page "**1-ajouter.html**".

Lorsque l'utilisateur clique sur le bouton "**Ajouter**", faire les vérifications suivantes : 

- Le **code pays**:
     - contient exactement **2** lettres non accentuées.
- Le **nom du pays**: 
    - ne contient que des lettres non accentuées.   
    - contient au moins **4** lettres.

En cas d'erreur dans la saisie, afficher un message d'erreur explicite dans l'élément HTML ayant pour identifiant "**result**".

Si aucune erreur n'est soulevée: 
- Formatter les données : 
    - *Code Pays*: tout mettre en majuscules
    - *Nom Pays*: 1ère lettre en majuscule, le reste en minuscules.
- stocker les données saisies dans un objet littéral respectant le format suivant : 

```js
let nouveauPays = { 
    country_code: "", 
    country_name: "" 
}
```

Par exemple, si l'utilisateur saisit le code Pays "**BE**" et le nom de pays "**Belgique**", l'objet correspondra à : 

```js
let nouveauPays = { 
    country_code: "BE", 
    country_name: "Belgique" 
}
```


### Partie 2 : Charger et exploiter un objet 

Dans le fichier "**assets/2-gerer-objet.js**", exploiter les données de l'objet stocké dans la variable `laFrance` et les afficher dans une balise `<article>` dans le **main** de la page "**2-gerer-objet.html**". 

**Résultat attendu :** 

```html
<main>
    <article>
        <p>Pays 1 : France (FR)</p>
    </article>
</main>
```

Une fois cette partie terminée, à la suite du script, faire la même chose en chargeant les données du fichier "**data/belgique.json**". Le 2nd pays s'affiche en dessous du 1er.

**Résultat attendu :** 

```html
<main>
    <article>
        <p>Pays 1 : France (FR)</p>
    </article>
    <article>
        <p>Pays 2 : Belgique (BE)</p>
    </article>
</main>
```


### Partie 3 : Charger et exploiter une collection

Dans le fichier "**assets/3-gerer-collection.js**", charger et exploiter les données du fichier JSON "**data/collectionPays.json**" et les afficher dans le tableau HTML prévu à cet effet dans le tableau `<table>` de la page "**3-gerer-collection.html**". 

**Résultat attendu :**

```html
<table id="tousLesPays">
    <thead>
        <tr>
            <th>Code Pays</th>
            <th>Nom Pays</th>
        </tr>
    </thead>
    <tbody id="mesPays">
        <tr>
            <td>AD</td>
            <td>Andorra</td>
        </tr>
        <tr>
            <td>AE</td>
            <td>United Arab Emirates</td>
        </tr>
        <tr>
            <td>AF</td>
            <td>Afghanistan</td>
        </tr>
        <!-- etc... -->
    </tbody>
</table>
```

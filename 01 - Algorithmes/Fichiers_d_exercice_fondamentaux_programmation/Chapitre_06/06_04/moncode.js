// Chapitre 06_04 _ Utiliser les propriétés et les méthodes d'un objet

let chien = {
    nom : "Rex",
    couleur : "Blanc",
    age: 5,
    aboie: function() {
        return "Wouaf!";
    }
}

console.log ( chien.couleur );
console.log( chien.aboie() );

// Chapitre 06_06 _ Comprendre les notions de classes et d'objet

// Création de la classe
class Voiture {
    constructor(arg1, arg2) {
        this.marque = arg1;
        this.couleur = arg2;
    }
    decrire() {
        return this.marque + " est une super voiture";
    }
}
  

// Création d'objets depuis une classe
let vehicule1 = new Voiture('Toyota', 'Blanc');
let vehicule2 = new Voiture('Suzuki', 'Bleu');
let vehicule3 = new Voiture('Renault', 'Gris');

console.log( vehicule1 );
console.log( vehicule1.marque );
console.log( vehicule1.decrire() );
  
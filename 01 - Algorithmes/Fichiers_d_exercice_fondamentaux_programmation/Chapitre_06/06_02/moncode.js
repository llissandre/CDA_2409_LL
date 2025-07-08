// Chapitre 06_02 _ Parcourir des tableaux

let superHero = ["Batman", "Iron Man", "Flash"];

// Exemple 1
console.log( superHero[0] );
console.log( superHero[1] );
console.log( superHero[2] );


// Exemple 2
for (let i = 0; i < superHero.length; i++) {
    console.log(superHero[i]);
};


// Exemple 3
superHero.forEach(function(elementTableau){
    console.log(elementTableau);
});

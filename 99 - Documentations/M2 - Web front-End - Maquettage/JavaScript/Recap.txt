
/*
  Déclarations Affectations
*/
const nomdeLaConstante = 3; // Définir une constante
let nomdeLavariable = "Test" // Définir une variable

/*
  TYPES
*/
//String / Number / Boolean / Object / Array
let myString = "test"; let myString2 = 'test'; let myString3= `multilignes`;
let myNumber = 4;
let myBoolean = true; //|| false;

let myArray = [myString, myNumber, myBoolean];

let myObject = 
{
  nom : "Belugou",
  prenom : "Fabien"
};


/*
  BOUCLES
*/
for(let i = 0; i < 10; i++) {

}

do {

}while(i > 10);


while(i > 10) {
  i--;
}


myArray.forEach(function(personne) {

});

myArray.forEach((personne) => {

})

/*
  CONDITIONS
*/
//> < >= <= ! || &&  == 
if(true) {

}
else if (false) {

}
else {

}

switch (key) {
  case value:
    
    break;

  default:
    break;
}
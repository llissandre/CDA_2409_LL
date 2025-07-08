import { Pays } from './Pays.js';

const monTitre = document.getElementById('titre'); // plus rapide que querySelector
const monBouton = document.getElementById('validate');
const inputCodePays = document.getElementById("codePays");
const inputNomPays = document.getElementById("nomPays");
const divResult = document.getElementById("result");

// Modifier le titre
monTitre.textContent = 'Ajouter un pays';

monBouton.addEventListener('click', (event) => {
    event.preventDefault();
    divResult.textContent = '';
 
    let codePays = inputCodePays.value;
    let nomPays = inputNomPays.value;

    try {
        let monPays = new Pays(codePays, nomPays);
    } 
    catch(error) {
        console.error(error);
        divResult.textContent = error;
    }
});
import { collectionCars } from './data/cars.js';

const inputCarName = document.getElementById('carName');
const btnValidate = document.getElementById('validate');
const result = document.getElementById('result');

let collectionCars = [];

// async function fetchCars() {
//         try {
//             const response = await fetch('./data/cars.json');
//             if (!response.ok) {
//                 throw new Error('La réponse n\'est pas OK');
//             }
//             collectionCars = await response.json();
//         }
//         catch (erreur) {
//             console.error('Un problème est survenu lors de la récupération :', erreur);
//             collectionCars = [];
//         }
//     }

const display = (resultat) => {
    result.textContent = '';
    resultat.forEach(element => {
        result.classList.remove('alertInput');
        result.innerHTML +=
            `
                <ul>
                <li><b>Identifiant : </b> ${element.car_id}</li >
                <li><b>Nom : </b>${element.car_name}</li>
                <li><b>Année : </b>${element.car_model}</li>
                <li><b>Pays d\'origine : </b>${element.car_origin}</li>
                </ul >
                `
            ;
    });
}

const validate = (e) => {
    e.preventDefault();

    let resultat = collectionCars.filter((element) =>
        element.car_name.trim().toLowerCase().includes(inputCarName.value.trim().toLowerCase()));

    if (inputCarName.value.trim() === '') {
        result.classList.add('alertInput');
        result.textContent = 'Veuillez saisir un terme de recherche'
    }
    else if (resultat.length === 0) {
        result.classList.add('alertInput');
        result.textContent = 'Aucune correspondance n\'a été trouvée'
    }
    else {
        display(resultat);
    }
}

// fetchCars();
btnValidate.addEventListener('click', validate);
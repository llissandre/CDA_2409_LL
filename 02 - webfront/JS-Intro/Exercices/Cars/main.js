import { collectionCars } from './data/cars.js';

const form = document.querySelector('form');
const inputCarName = document.getElementById('carName');
const btnValidate = document.getElementById('validate');
const result = document.getElementById('result');


// async function fetchCars() {
//         try {
//             const response = await fetch('./data/cars.json');
//             if (!response.ok) {
//                 throw new Error('La réponse n\'est pas OK');
//             }
//             data = await response.json();
//         }
//         catch (erreur) {
//             console.error('Un problème est survenu lors de la récupération :', erreur);
//             data = [];
//         }
//     }

const display = () => {
    result.textContent = '';
    collectionCars.map((element) => {
        if (inputCarName.value === '') {
            result.classList.add('alertInput');
            result.textContent = 'Veuillez saisir un terme de recherche'
        }

        else if (element.car_name.trim().toLowerCase().includes(inputCarName.value.toLowerCase()) || String(element.car_model.trim()).includes(inputCarName.value) || element.car_origin.trim().toLowerCase().includes(inputCarName.value.toLowerCase())) {
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
        }
    });
}

const validate = (e) => {
    e.preventDefault();

    display();
}

// fetchCars();
btnValidate.addEventListener('click', validate);
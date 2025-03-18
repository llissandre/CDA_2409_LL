let data = [];

const affichage = document.querySelector('#affichage');
const inputCarName = document.getElementById('carName');
const btnValidate = document.getElementById('validate');
const result = document.getElementById('result');


async function fetchCars() {
    try {
        const response = await fetch('./data/cars.json');
        if (!response.ok) {
            throw new Error('La réponse n\'est pas OK');
        }
        data = await response.json();
    }
    catch (erreur) {
        console.error('Un problème est survenu lors de la récupération :', erreur);
        data = [];
    }
}

const display = () => {
    result.textContent = '';
    data.map((element) => {
        if (inputCarName.value === '') {
            result.classList.add('alertInput');
            result.textContent = 'Vous devez saisir un thème de recherche !'
}

        else if (element.car_name.toLowerCase().includes(inputCarName.value.toLowerCase())) {
            result.classList.remove('alertInput');
            result.innerHTML += '<div></br></div>';
            result.innerHTML += '<div><b>Identifiant : </b>' + element.car_id + '</div>';
            result.innerHTML += '<div><b>Nom : </b>' + element.car_name + '</div>';
            result.innerHTML += '<div><b>Année : </b>' + element.car_model + '</div>';
            result.innerHTML += '<div><b>Pays d\'origine : </b>' + element.car_origin + '</div>';
            result.innerHTML += '<div></br></div>';
        }
    });

}

const validate = (e) => {
    e.preventDefault();

    display();
}

fetchCars();
btnValidate.addEventListener('click', validate);
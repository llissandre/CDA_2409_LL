const b = document.querySelector('document.body')
const form = document.querySelector('form');
const searchInput = document.querySelector('#searchInput');
const cityList = document.querySelector('#cityList');
const btnValidate = document.querySelector('#btnValidate');
const informations = document.querySelector('#informations');

let zipData = [];

async function fetchZipcodes() {
    try {
        const response = await fetch('./assets/json/zipcodes.json');
        if (!response.ok) {
            throw new Error('La réponse n\'est pas OK');
        }
        zipData = await response.json();

    }
    catch (error) {
        console.error('Un problème est survenu lors de la récupération :', error);
    }
}

const search = () => {
    const input = searchInput.value;
    const dataList = document.getElementById('cityList');
    dataList.innerHTML = '';

    if (input.length >= 2 && zipData.length > 0) {
        const filtered = zipData.filter(city => city.codePostal.includes(input));

        filtered.forEach(city => {
            const option = document.createElement('option');
            option.value = city.codePostal;
            option.textContent = city.nomCommune + city.codePostal;
            dataList.append(option);
        });
    }
}

const displayCityInfos = () => {
    if (zipData.lenght !== 0) {
        const city = zipData.find(city => city.codePostal === searchInput.value);

        if (city) {
            informations.innerHTML =
                `
                <h2> ${city.nomCommune}</h2>
                <p><strong>Code postal : </strong>${city.codePostal}</p>
                <p><strong>Nom de la commune : </strong>${city.codeCommune}</p>
                <p><strong>Le libellé acheminement : </strong>${city.libelleAcheminement}</p>
                `;
        }
    }
}

const validate = (e) => {
    e.preventDefault();
    informations.textContent = '';
    zipData.forEach(element => {
        if (searchInput.value == element.codePostal) {

            const ul = document.createElement('ul');
            ul.innerHTML = '<li>Code postal : ' + element.codePostal + '</li>';
            ul.innerHTML += '<li>Code de la commune : ' + element.codeCommune + '</li>';
            ul.innerHTML += '<li>Nom de la commune : ' + element.nomCommune + '</li>';
            ul.innerHTML += '<li>Libellé acheminement : ' + element.libelleAcheminement + '</li>';
            informations.append(ul);

            // let ul = `
            // <ul>
            //     <li>Code postal : ${element.codePostal}</li>
            //     <li>Code de la commune : ${element.codeCommune}</li>
            //     <li>Nom de la commune : ${element.nomCommune}</li>
            //     <li>Libellé acheminement : ${element.libelleAcheminement}</li>
            // </ul>
            // `;
            // informations.innerHTML += ul;
        }

        // else if (element.codePostal.contains(searchInput.value)) {

        // }

    });
};

fetchZipcodes();
btnValidate.addEventListener('click', validate);
searchInput.addEventListener('input', search);
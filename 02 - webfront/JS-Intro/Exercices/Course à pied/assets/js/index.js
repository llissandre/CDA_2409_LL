const filet = document.querySelector('#filet');
const headers = document.querySelector('#headers')
const myTable = document.querySelector('#myTable');
const participants = document.querySelector('#participants');
const winner = document.querySelector('#winner');
const checkboxCountries = document.querySelector('#checkboxCountries');

async function fetchCourse() {
    try {
        const response = await fetch('./assets/json/resultat10000metres.json');
        if (!response.ok) {
            throw new Error('La réponse n\'est pas OK');
        }
        data = await response.json();
        afficher();
    }
    catch (error) {
        console.error('Un problème est survenu lors de la récupération :', error);
    }
}

function afficher() {
    const titleHead = ['Pays', 'Nom', 'Prénom', 'Temps final', 'Écart temps'];

    const trTHead = document.createElement('tr');

    const thead = myTable.createTHead();
    const tbody = myTable.createTBody();

    myTable.append(thead);
    thead.append(trTHead);

    titleHead.forEach((th) => {
        const thTHead = document.createElement('th');
        thTHead.innerText = th;
        trTHead.append(thTHead);
    });

    data.sort((a, b) => {
        const na = a.pays.toLowerCase();
        const nb = b.pays.toLowerCase();

        if (na > nb) {
            return 1;
        }
        if (nb > na) {
            return -1;
        }
        else {
            return 0;
        }
    });

    data.forEach((c) => {
        let country = document.createElement('div');
        const checkboxInput = document.createElement('input');
        const checkboxLabel = document.createElement('label');

        country.setAttribute('id', 'country')

        checkboxInput.type = 'checkbox';
        checkboxInput.id = c.pays;
        checkboxInput.name = c.pays;

        checkboxLabel.setAttribute('for', c.pays);
        checkboxLabel.innerText = c.pays;

        country.append(checkboxInput, checkboxLabel);
        checkboxCountries.append(country);

        checkboxInput.addEventListener('change', (e) => {
            console.log(e);
            // checkboxInput.classList.add('checked');

        });
    });

    data.sort((a, b) => a.temps - b.temps);

    participants.innerText = data.length + ' participants';
    winner.innerText = ' Gagnant : ' + data[0].nom;

    data.forEach((element) => {

        const trTBody = tbody.insertRow();
        let cellCountry = trTBody.insertCell();
        cellCountry.innerText = element.pays;
        let cellLastname = trTBody.insertCell();
        cellLastname.innerText = String(element.nom).split(' ')[0].charAt(0).toUpperCase() + String(element.nom).split(' ')[0].slice(1).toLowerCase();
        let cellFirstname = trTBody.insertCell();
        cellFirstname.innerText = String(element.nom).split(' ')[1].charAt(0).toUpperCase() + String(element.nom).split(' ')[1].slice(1).toLowerCase();
        let cellFinalTime = trTBody.insertCell();
        cellFinalTime.innerText = Math.floor(element.temps / 60) + 'min' + Number(element.temps % 60) + 's';

    })
}

// checkbox.addEventListener = ('change', () => {

// });

fetchCourse();
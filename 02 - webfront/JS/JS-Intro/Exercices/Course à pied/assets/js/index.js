let data = [];
let countriesChecked = [];

const filet = document.querySelector('#filet');
const headers = document.querySelector('#headers')
const myTable = document.querySelector('#myTable');
const participants = document.querySelector('#participants');
const winner = document.querySelector('#winner');
const avgTime = document.querySelector('#avgTime');
const checkboxCountries = document.querySelector('#checkboxCountries');
const countries = document.querySelectorAll('#countries');
const tbody = myTable.createTBody();

async function fetchRace() {
    try {
        const response = await fetch('./assets/json/resultat10000metres.json');
        if (!response.ok) {
            throw new Error('La réponse n\'est pas OK');
        }
        data = await response.json();
        display();
        displayTable(data);
        displayCheckbox();
    }
    catch (error) {
        console.error('Un problème est survenu lors de la récupération :', error);
        data = [];
    }
}

const display = () => {
    const titleHead = ['Pays', 'Nom', 'Prénom', 'Temps final', 'Écart temps'];

    const trTHead = document.createElement('tr');

    const thead = myTable.createTHead();

    myTable.append(thead);
    thead.append(trTHead);

    titleHead.forEach((th) => {
        const thTHead = document.createElement('th');
        thTHead.innerText = th;
        trTHead.append(thTHead);
    });

    data.sort((a, b) => a.temps - b.temps);

    const sum = data.reduce((sum, a) => sum + a.temps, 0);
    const avgT = sum / data.length;

    participants.innerText = data.length + ' participants';
    const username = data[0].nom.split(' ')[1] + ' ' + data[0].nom.split(' ')[0];
    winner.innerText = ' Gagnant : ' + username;
    avgTime.innerText = 'Temps moyens : ' + Math.floor(avgT / 60) + ' minutes et ' + Math.round(avgT % 60) + ' secondes';
}

const displayCheckbox = () => {
    // Pour trier les checkbox Pays
    // data.sort((a, b) => {
    //     const na = a.pays.toLowerCase();
    //     const nb = b.pays.toLowerCase();

    //     if (na > nb) {
    //         return 1;
    //     }
    //     if (nb > na) {
    //         return -1;
    //     }
    //     else {
    //         return 0;
    //     }
    // });

    // Pour trier les checkbox Pays
    data.sort((a, b) => a.pays.localeCompare(b.pays));

    data.forEach((c) => {
        let country = document.createElement('div');
        const checkboxInput = document.createElement('input');
        const checkboxLabel = document.createElement('label');

        // country.setAttribute('id', 'country')
        country.id = 'country';

        checkboxInput.type = 'checkbox';
        checkboxInput.id = c.pays;
        checkboxInput.name = c.pays;

        checkboxLabel.setAttribute('for', c.pays);
        checkboxLabel.innerText = c.pays;

        country.append(checkboxInput, checkboxLabel);
        checkboxCountries.append(country);

        checkboxInput.addEventListener('change', (e) => {
            if (e.target.checked) {
                countriesChecked.push(checkboxInput.name);
            }
            else {
                let myIndex = countriesChecked.indexOf(checkboxInput.name);
                countriesChecked.splice(myIndex, 1);
            }

            if (countriesChecked.length === 0) {
                displayTable(data);
            }
            else {
                filteredData = data.filter(p => countriesChecked.includes(p.pays));
                displayTable(filteredData);
            }
        });
    });
};

const displayTable = (data) => {
    tbody.innerText = '';
    data.sort((a, b) => a.temps - b.temps);

    const winnerSTime = data[0].temps;

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
        let cellTimeDifference = trTBody.insertCell();
        cellTimeDifference.innerText = "+" + (element.temps - winnerSTime) + 's';
    });
}

fetchRace();
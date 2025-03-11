const filet = document.querySelector('#filet');
const myTable = document.querySelector('#myTable');
const participants = document.querySelector('#participants');
const winner = document.querySelector('#winner');

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
    const titleHead = ['Pays', 'Nom', 'Prénom', 'Temps final'];

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

    data.sort((a, b) => a.temps - b.temps);

    data.forEach((element) => {
        const trTBody = tbody.insertRow();
        let cellCountry = trTBody.insertCell();
        cellCountry.innerText = element.pays;
        let cellLastname = trTBody.insertCell();
        cellLastname.innerText = String(element.nom).split(' ')[0].charAt(0).toUpperCase() + String(element.nom).split(' ')[0].slice(1).toLowerCase();
        let cellFirstname = trTBody.insertCell();
        cellFirstname.innerText = String(element.nom).split(' ')[1].charAt(0).toUpperCase() + String(element.nom).split(' ')[1].slice(1).toLowerCase();
        let cellFinalTime = trTBody.insertCell();
        cellFinalTime.innerText = Math.floor(element.temps/60) + 'min' + Number(element.temps%60) + 's';
        
    })
}


fetchCourse();
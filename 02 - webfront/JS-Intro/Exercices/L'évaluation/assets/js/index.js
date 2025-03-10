async function fetchEvaluation() {
    try {
        const response = await fetch('./assets/json/eval.json');
        if (!response.ok) {
            throw new Error('La réponse n\'est pas OK');
        }
        return await response.json();
    }
    catch (error) {
        console.error('Un problème est survenu lors de la récupération :', error);
    }
}

const titleHead = ['Nom', 'Prénom', 'Note'];

const body = document.querySelector('body');
const classMyTable = document.querySelector('.myTable');
const myTable = document.querySelector('#myTable');

const trTHead = document.createElement('tr');
const myDivul = document.createElement('div')
const myul = document.createElement('ul');

myDivul.setAttribute('class', 'myDivulClass')
myul.setAttribute('id', 'ulId')

const thead = myTable.createTHead();
const tbody = myTable.createTBody();

myTable.append(thead);
thead.append(trTHead);
body.append(myDivul);
myDivul.append(myul);

titleHead.forEach((th) => {
    const thTHead = document.createElement('th');
    thTHead.innerText = th;
    trTHead.append(thTHead);
});

fetchEvaluation().then(resultats => {
    let nbEtudiants = 0;
    tbody.innerText = '';

    resultats.sort((a, b) => b.grade - a.grade)

    resultats.forEach((element) => {
        nbEtudiants++;
        const trTBody = tbody.insertRow();
        let cellNom = trTBody.insertCell();
        cellNom.innerText = element.fullname.split(' ')[0];
        let cellPrenom = trTBody.insertCell();
        cellPrenom.innerText = element.fullname.split(' ')[1];
        let cellGrade = trTBody.insertCell();
        cellGrade.innerText = element.grade;
    });

    ulId.innerHTML = '<li>' + 'Nombre d\'étudiants : ' + nbEtudiants + '</li>';
    ulId.innerHTML += '<li>' + 'Nombre : ' + nbEtudiants + '</li>';
});


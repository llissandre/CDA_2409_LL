const filet = document.querySelector('#filet');
const lastnameFirstnameInput = document.querySelector('#lastnameFirstnameInput');
const gradeInput = document.querySelector('#gradeInput');
const btnValider = document.querySelector('#btnValider');
const classMyTable = document.querySelector('.myTable');
const myTable = document.querySelector('#myTable');
const regexUsername = /^[a-zA-Z-]{2,}$/;

let data = [];
let failingGrade = 12;

async function fetchEvaluation() {
    try {
        const response = await fetch('./assets/json/eval.json');
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

const myDivul = document.createElement('div')
const myul = document.createElement('ul');
let nbEtudiants;

function afficher() {

    const trTHead = document.createElement('tr');

    myDivul.setAttribute('class', 'myDivulClass');
    myul.setAttribute('id', 'ulId');

    const titleHead = ['Nom', 'Prénom', 'Note'];
    titleHead.push('Obtenu');

    const thead = myTable.createTHead();
    const tbody = myTable.createTBody();

    myTable.append(thead);
    thead.append(trTHead);
    filet.append(myDivul);
    myDivul.append(myul);

    titleHead.forEach((th) => {
        const thTHead = document.createElement('th');
        thTHead.innerText = th;
        trTHead.append(thTHead);
    });


    data.sort((a, b) => b.grade - a.grade);
    nbEtudiants = data.length;
    let sum = data.reduce((sum, a) => sum + a.grade, 0);
    let avgClasse = sum / nbEtudiants;
    let overAvg = data.filter(a => a.grade >= 10);
    let overAvgGrades = data.filter(a => a.grade >= avgClasse);

    data.forEach((element) => {
        const trTBody = tbody.insertRow();
        let cellLastname = trTBody.insertCell();
        cellLastname.innerText = String(element.fullname).split(' ')[0].charAt(0).toUpperCase() + String(element.fullname).split(' ')[0].slice(1).toLowerCase();
        let cellFirstname = trTBody.insertCell();
        cellFirstname.innerText = String(element.fullname).split(' ')[1].charAt(0).toUpperCase() + String(element.fullname).split(' ')[1].slice(1).toLowerCase();
        let cellGrade = trTBody.insertCell();
        cellGrade.innerText = element.grade;
        let cellObtenu = trTBody.insertCell();
        element.grade >= failingGrade ? cellObtenu.innerText = 'Oui' : cellObtenu.innerText = 'non';
    });

    ulId.innerHTML =
        `
        <li>Nombre d\'étudiants : ${nbEtudiants}</li>
        <li>Moyenne de la classe : ${(avgClasse).toFixed(2)}</li>
        <li>Nombre d"étudiants au-dessus de la moyenne : ${overAvg.length}</li>
        <li>Nombre d"étudiants au-dessus de la moyenne des notes de la classe: ${overAvgGrades.length}</li>
        <li>Note éliminatoire : ${failingGrade}</li>
    `;
};

btnValider.addEventListener('click', (e) => {
    e.preventDefault();

    btnValider.style.backgroundColor
    let usernameInput = lastnameFirstnameInput.value.trim();
    let lastname = usernameInput.split(' ')[0];
    let firstname = usernameInput.split(' ')[1];
    grade = Number(gradeInput.value);
    fullname = lastname + ' ' + firstname;

    if (regexUsername.test(lastname) && lastname !== undefined && regexUsername.test(firstname) && firstname !== undefined && grade >= 0 && grade <= 20) {

        data.push({ fullname, grade });
        myTable.innerText = '';
        
        afficher();
    }
});

fetchEvaluation();
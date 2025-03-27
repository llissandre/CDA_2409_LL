


const filet = document.querySelector('#filet');
const lastnameFirstnameInput = document.querySelector('#lastnameFirstnameInput');
const gradeInput = document.querySelector('#gradeInput');
const btnValidate = document.querySelector('#btnValider');
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
        display();
    }
    catch (error) {
        console.error('Un problème est survenu lors de la récupération :', error);
    }
}

let nbEtudiants;

const display = () => {

    myDivul.setAttribute('class', 'myDivulClass');

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
}

const validate = () => {
    e.preventDefault();

    let usernameInput = lastnameFirstnameInput.value.trim();
    let lastname = usernameInput.split(' ')[0];
    let firstname = usernameInput.split(' ')[1];
    grade = Number(gradeInput.value);
    fullname = lastname + ' ' + firstname;

    if (regexUsername.test(lastname) && lastname !== undefined && regexUsername.test(firstname) && firstname !== undefined && grade >= 0 && grade <= 20) {

        data.push({ fullname, grade });
        myTable.innerText = '';
        
        display();
    }
}

fetchEvaluation();
btnValidate.addEventListener('click', validate);
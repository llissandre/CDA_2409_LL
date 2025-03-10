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
const filet = document.querySelector('#filet');

const trTHead = document.createElement('tr');
const myDivul = document.createElement('div')
const myul = document.createElement('ul');
const myForm = document.createElement('form');

myForm.setAttribute('id', 'myFormId');
myDivul.setAttribute('class', 'myDivulClass');
myul.setAttribute('id', 'ulId');

const thead = myTable.createTHead();
const tbody = myTable.createTBody();

myTable.append(thead);
classMyTable.before(myForm);
thead.append(trTHead);
filet.append(myDivul);
myDivul.append(myul);

myForm.innerHTML = `
        <legend>Ajouter une note</legend>
        <div id="inputs">
            <div id="labelmyFormDiv">
                <label for="lastnameFirstnameInput">Nom Prénom : </label><br>
                <label for="gradeInput">Note : </label><br>
            </div>
            <div id="InputmyFormDiv">
                <input type="text" id="lastnameFirstnameInput" name="lastnameFirstname"><br>
                <input type="text" id="gradeInput" name="grade"><br>
            </div>
        </div>
        <input type="button" id="btnValider" value="Ajouter">
`;

titleHead.forEach((th) => {
    const thTHead = document.createElement('th');
    thTHead.innerText = th;
    trTHead.append(thTHead);
});

fetchEvaluation().then(resultats => {
    tbody.innerText = '';
    resultats.sort((a, b) => b.grade - a.grade);

    let nbEtudiants = resultats.length;
    let sum = resultats.reduce((sum, a) => sum + a.grade, 0);
    let avgClasse = sum / nbEtudiants;
    let overAvg = resultats.filter(a => a.grade >= 10);
    let overAvgGrades = resultats.filter(a => a.grade >= avgClasse);
    let failingGrade = 12;

    console.log(avgClasse);
    console.log(sum);

    resultats.forEach((element) => {
        const trTBody = tbody.insertRow();
        let cellNom = trTBody.insertCell();
        cellNom.innerText = element.fullname.split(' ')[0];
        let cellPrenom = trTBody.insertCell();
        cellPrenom.innerText = element.fullname.split(' ')[1];
        let cellGrade = trTBody.insertCell();
        cellGrade.innerText = element.grade;
    });

    ulId.innerHTML = `
        <li>Nombre d\'étudiants : ${nbEtudiants}</li>
        <li>Moyenne de la classe : ${(avgClasse).toFixed(2)}</li>
        <li>Nombre d"étudiants au-dessus de la moyenne : ${overAvg.length}</li>
        <li>Nombre d"étudiants au-dessus de la moyenne des notes de la classe: ${overAvgGrades.length}</li>
        <li>Note éliminatoire : ${failingGrade}</li>
        `;

    // ulId.innerHTML = '<li>' + 'Nombre d\'étudiants : ' + nbEtudiants + '</li>';
    // ulId.innerHTML += '<li>' + 'Nombre : ' + (avgGrades / nbEtudiants).toFixed(2) + '</li>';
});


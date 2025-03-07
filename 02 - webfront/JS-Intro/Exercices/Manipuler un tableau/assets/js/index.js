const myTable = document.createElement('table');
const regexUsername = /^[a-zA-Z]{2,}$/;

const people = ['Mike Dev', 'John Makenzie', 'Léa Grande'];

const inscrit = document.querySelector('#inscrit');
const filet = document.querySelector('#filet');
const divAddId = document.querySelector('#divAddId')
const divTabId = document.querySelector('#divTab');
const myTableId = document.querySelector('#myTable');
const divTab = document.createElement('div');
const divAdd = document.createElement('div');
const form = document.createElement('form');
const pAddEntete = document.createElement('p');
const pAddResultat = document.createElement('p');
const formAdd = document.createElement('form');
const labelPrenomAdd = document.createElement('label');
const labelNomAdd = document.createElement('label');
const inputPrenomAdd = document.createElement('input');
const inputNomAdd = document.createElement('input');
const btnAjouterAdd = document.createElement('input');

divAdd.setAttribute('id', 'divAddId');
labelPrenomAdd.setAttribute('type', 'text');
labelPrenomAdd.setAttribute('for', 'PrenomAdd');
labelNomAdd.setAttribute('type', 'text');
labelNomAdd.setAttribute('for', 'NomAdd');
inputPrenomAdd.setAttribute('type', 'text');
inputPrenomAdd.setAttribute('id', 'PrenomAdd');
inputNomAdd.setAttribute('type', 'text');
inputNomAdd.setAttribute('id', 'NomAdd');
btnAjouterAdd.setAttribute('type', 'submit');

inscrit.before(divAdd);

pAddEntete.textContent = 'Ajouter une personne';
labelPrenomAdd.textContent = 'Prénom: ';
labelNomAdd.textContent = 'Nom: ';
btnAjouterAdd.value = 'Ajouter';
pAddResultat.textContent = '';

divAdd.append(pAddEntete);
divAdd.append(form);
form.append(labelPrenomAdd);
form.append(inputPrenomAdd);
form.append(labelNomAdd);
form.append(inputNomAdd);
form.append(btnAjouterAdd);
divAdd.append(pAddResultat);

const ajouter = (e) => {
    e.preventDefault();
    const prenom = String(inputPrenomAdd.value).charAt(0).toUpperCase() + String(inputPrenomAdd.value).slice(1).toLowerCase();
    const nom = String(inputNomAdd.value).charAt(0).toUpperCase() + String(inputNomAdd.value).slice(1).toLowerCase();
    const username = prenom + ' ' + nom;

    if (regexUsername.test(prenom) && regexUsername.test(nom)) {
        if (!people.includes(username)) {
            people.push(username);
            pAddResultat.textContent = username + ' ajouté !';
        }
    }

    inputPrenomAdd.value = '';
    inputNomAdd.value = '';
    
    personnes();
};

const personnes = () => {
    myTable.innerText = '';
    inscrit.innerText = '';

    if (people.length > 0) {
        const thead = myTable.createTHead();
        const tbody = myTable.createTBody();
        const tr = document.createElement('tr');
        const thNom = document.createElement('th');
        const thPrenom = document.createElement('th');
        const thEmail = document.createElement('th');
        const thSupprimer = document.createElement('th');


        thNom.textContent = 'Nom';
        thPrenom.textContent = 'Prénom';
        thEmail.textContent = 'Email';
        thSupprimer.textContent = 'Supprimer';

        divTab.setAttribute('id', 'divTabId');
        myTable.setAttribute('id', 'myTableId');

        filet.append(divTab);
        divTab.append(myTable);
        myTable.append(thead);
        thead.append(tr);
        tr.append(thNom);
        tr.append(thPrenom);
        tr.append(thEmail);
        tr.append(thSupprimer);
        myTable.append(tbody);

        people.forEach((element) => {
            // for (let i = 0; i < people.length; i++) {
            const peoplelist = document.createElement('li');
            const trpeople = document.createElement('tr');
            const tdlastname = document.createElement('td');
            const tdfirstname = document.createElement('td');
            const tdemail = document.createElement('td');
            const tddelete = document.createElement('td');

            peoplelist.textContent = element;
            tdlastname.textContent = element.split(' ')[1];
            tdfirstname.textContent = element.split(' ')[0];
            tdemail.textContent = element.split(' ')[0].toLowerCase() + '.' + element.split(' ')[1].toLowerCase() + '@example.com';
            tddelete.innerHTML = '<p id = "i" class="delete">X</p>';

            inscrit.append(peoplelist);
            tbody.append(trpeople);
            trpeople.append(tdlastname);
            trpeople.append(tdfirstname);
            trpeople.append(tdemail);
            trpeople.append(tddelete);
        });

        const deletecl = document.querySelectorAll('.delete');

        deletecl.forEach((element, i) => {
            element.addEventListener('click', (e) => {
                if (e.target.classList.contains('checked')) {
                    people.splice(i, 1)
                    personnes();
                }
                else {
                    e.target.classList.add('checked');
                    e.target.innerHTML = '';
                }
            });
        });
    }
}

personnes();
btnAjouterAdd.addEventListener('click', ajouter);

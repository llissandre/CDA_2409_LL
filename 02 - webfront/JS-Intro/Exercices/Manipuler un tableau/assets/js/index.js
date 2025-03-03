const people = ['Mike Dev', 'John Makenzie', 'Léa Grande'];
const inscrit = document.querySelector('#inscrit');
const filet = document.querySelector('#filet');
const divAddId = document.querySelector('#divAddId')

const table = document.createElement('table');

const divAdd = document.createElement('div');
const form = document.createElement('form');
const pAddEntete = document.createElement('p');
const pAddResultat = document.createElement('p');
const formAdd = document.createElement('form');
const labelPrenomAdd = document.createElement('label');
const labelNomAdd = document.createElement('label');
const inputPrenomAdd = document.createElement('input');
const inputNomAdd = document.createElement('input');
const inputAjouterAdd = document.createElement('input');

divAdd.setAttribute('id', 'divAddId');
labelPrenomAdd.setAttribute('type', 'text');
labelNomAdd.setAttribute('type', 'text');
inputPrenomAdd.setAttribute('type', 'text');
inputNomAdd.setAttribute('type', 'text');
inputAjouterAdd.setAttribute('type', 'submit');

inscrit.before(divAdd);

pAddEntete.textContent = 'Ajouter une personne';
labelPrenomAdd.textContent = 'Prénom: ';
labelNomAdd.textContent = 'Nom: ';
inputAjouterAdd.value = 'Ajouter';
pAddEntete.textContent += 'ajouté !';

divAdd.append(pAddEntete);
divAdd.append(form);
form.append(labelPrenomAdd);
form.append(inputPrenomAdd);
form.append(labelNomAdd);
form.append(inputNomAdd);
form.append(inputAjouterAdd);
divAdd.append(pAddResultat);

// const personnes = () => {
//     table.innerText = '';
//     inscrit.innerText = '';

//     if (people.length > 0) {
//         const divTab = document.createElement('div');
//         const divTabId = document.querySelector('#divTab');
//         const tableId = document.querySelector('#table');
//         const thead = document.createElement('thead');
//         const tr = document.createElement('tr');
//         const thNom = document.createElement('th');
//         const thPrenom = document.createElement('th');
//         const thEmail = document.createElement('th');
//         const thSupprimer = document.createElement('th');
//         const tbody = document.createElement('tbody');


//         thNom.textContent = 'Nom';
//         thPrenom.textContent = 'Prénom';
//         thEmail.textContent = 'Email';
//         thSupprimer.textContent = 'Supprimer';

//         divTab.setAttribute('id', 'divTabId');
//         table.setAttribute('id', 'tableId');

//         filet.append(divTab);
//         divTab.append(table);
//         table.append(thead);
//         thead.append(tr);
//         tr.append(thNom);
//         tr.append(thPrenom);
//         tr.append(thEmail);
//         tr.append(thSupprimer);
//         table.append(tbody);

//         people.forEach((element, i) => {
//             // for (let i = 0; i < people.length; i++) {
//             const peoplelist = document.createElement('li');
//             const trpeople = document.createElement('tr');
//             const tdlastname = document.createElement('td');
//             const tdfirstname = document.createElement('td');
//             const tdemail = document.createElement('td');
//             const tddelete = document.createElement('td');

//             peoplelist.textContent = element;

//             tdlastname.textContent = element.split(' ')[1];
//             tdfirstname.textContent = element.split(' ')[0];
//             tdemail.textContent = element.split(' ')[0].toLowerCase() + '.' + element.split(' ')[1].toLowerCase() + '@example.com';
//             tddelete.innerHTML = `<p id="${i}" class="delete">X</p>`;

//             inscrit.append(peoplelist);
//             tbody.append(trpeople);
//             trpeople.append(tdlastname);
//             trpeople.append(tdfirstname);
//             trpeople.append(tdemail);
//             trpeople.append(tddelete);
//         });

//         const deletecl = document.querySelectorAll('.delete');

//         deletecl.forEach((element, i) => {
//             element.addEventListener('click', (e) => {
//                 if (e.target.classList.contains('checked')) {
//                     people.splice(i, 1)
//                     personnes();
//                 }
//                 else {
//                     e.target.classList.add('checked');
//                     e.target.innerHTML = ' ';
//                 }
//             });
//         });
//     }
// }

// personnes();

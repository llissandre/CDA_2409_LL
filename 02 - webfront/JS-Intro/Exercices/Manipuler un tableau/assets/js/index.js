const b = document.body;
const people = ['Mike Dev', 'John Makenzie', 'Léa Grande'];
const inscrit = document.querySelector('#inscrit');
const filet = document.querySelector('#filet');
// const tableau = document.querySelector('#tableau');
// const table = document.querySelector('#table');
// const tbody = document.querySelector('tbody')


for (let i = 0; i < people.length; i++) {

    let ul = document.createElement('li');
    ul.textContent = people[i];
    inscrit.appendChild(ul);
}

const divTab = document.createElement('div');
const divTabId = document.querySelector('#divTab');
const table = document.createElement('table');
const tableId = document.querySelector('#table');
const thead = document.createElement('thead');
const tr = document.createElement('tr');
const thNom = document.createElement('th');
const thPrenom = document.createElement('th');
const thEmail = document.createElement('th');
const thSupprimer = document.createElement('th');
const tbody = document.createElement('tbody');

thNom.textContent = 'Nom';
thPrenom.textContent = 'Prénom';
thEmail.textContent = 'Email';
thSupprimer.textContent = 'Supprimer';

divTab.setAttribute('id', 'divTab');
table.setAttribute('id', 'table');

filet.append(divTab);
divTab.append(table);
table.append(thead);
thead.append(tr);
tr.append(thNom);
tr.append(thPrenom);
tr.append(thEmail);
tr.append(thSupprimer);
table.append(tbody);

for (let i = 0; i < people.length; i++) {
    let tr = document.createElement('tr');
    tbody.appendChild(tr);
    
    for (let j = 0; j < 2; j++) {
        let td = document.createElement('td');
        // let firstname = people[i].split(' ')[j];
        // let lastname = people[i].split(' ')[j];
        td.textContent = people[i].split(' ')[j];
        tr.appendChild(td);
    }


}





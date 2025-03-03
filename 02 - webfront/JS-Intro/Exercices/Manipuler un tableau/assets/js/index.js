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
    const trpeople = document.createElement('tr');
    const tdlastname = document.createElement('td');
    const tdfirstname = document.createElement('td');
    const tdemail = document.createElement('td');
    const tddelete = document.createElement('td');

    tdlastname.textContent = people[i].split(' ')[1];
    tdfirstname.textContent = people[i].split(' ')[0];
    tdemail.textContent = people[i].split(' ')[0].toLowerCase() + '.' + people[i].split(' ')[1].toLowerCase() + '@example.com';
    tddelete.innerHTML = '<p id="delete">X</p>';


    tbody.append(trpeople);
    trpeople.append(tdlastname);
    trpeople.append(tdfirstname);
    trpeople.append(tdemail);
    trpeople.append(tddelete);
}

const deleteid = document.querySelector('#delete');

deleteid.addEventListener('click', (e) => {
    if (e.target.classList.contains('checked')) {
        e.target.remove();
    }
    else {
        e.target.classList.add('checked');
    }

});

// for (let j = 0; j < 2; j++) {
//     let td = document.createElement('td');
//     // let firstname = people[i].split(' ')[j];
//     // let lastname = people[i].split(' ')[j];
//     td.textContent = people[i].split(' ')[j];
//     tr.appendChild(td);
// }




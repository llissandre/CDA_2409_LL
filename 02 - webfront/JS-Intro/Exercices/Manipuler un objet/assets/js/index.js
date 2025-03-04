const tableau = [];
const myEmployee = {
    lastname: 'Doe',
    firstname: 'John',
    birthday: '1981-11-12',
    salary: 2150
};

const table = document.querySelector('#myTable');
const tbody = document.querySelector('tbody');
// const trMyEmployee = document.querySelector('tr');
// const tdLastname = document.createElement('td');
// const tdFirstname = document.createElement('td');
// const tdEmail = document.createElement('td');
// const tdBirthday = document.createElement('td');
// const tdSalary = document.createElement('td');

const regexNomPrenom = /^[a-zA-Z]{2,}$/;
const row = tbody.insertRow(-1);
tableau.push(myEmployee);

tableau.forEach(element => {
    let cellLastname = row.insertCell();
    cellLastname.textContent = element.lastname;
    let cellFirstname = row.insertCell();
    cellFirstname.textContent = element.firstname;
    let cellBirthday = row.insertCell();
    cellBirthday.textContent = element.birthday;
    let cellEmail = row.insertCell();
    cellEmail.textContent = `${String(element.firstname).charAt(0).toLowerCase()}${String(element.firstname).slice(1)}.${String(element.lastname).charAt(0).toLowerCase()}${String(element.lastname).slice(1)}@example.com`;
    let cellSalary = row.insertCell();
    cellSalary.textContent = element.salary + ' €';
});

// for (i = 0; i < tableau.length; i++) {
//     let cellLastname = row.insertCell();
//     cellLastname.textContent = tableau[i].lastname;
//     let cellFirstname = row.insertCell();
//     cellFirstname.textContent = tableau[i].firstname;
//     let cellBirthday = row.insertCell();
//     cellBirthday.textContent = tableau[i].birthday;
//     let cellEmail = row.insertCell();
//     cellEmail.textContent = `${String(tableau[i].firstname).charAt(0).toLowerCase()}${String(tableau[i].firstname).slice(1)}.${String(tableau[i].lastname).charAt(0).toLowerCase()}${String(tableau[i].lastname).slice(1)}@example.com`;
//     let cellSalary = row.insertCell();
//     cellSalary.textContent = tableau[i].salary + ' €';
// }

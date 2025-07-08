const myEmployee = {
    lastname: 'Doe',
    firstname: 'John',
    birthday: '1981-11-12',
    salary: 2150
};

const rowThead = document.createElement('tr');
const lastnameTh = document.createElement('th');
const firstnameTh = document.createElement('th');
const birthdayTh = document.createElement('th');
const emailTh = document.createElement('th');
const salaryTh = document.createElement('th');
const rowTbody = document.createElement('tr');

// const lastnameTd = document.createElement('td');
// const firstnameTd = document.createElement('td');
// const birthdayTd = document.createElement('td');
// const emailTd = document.createElement('td');
// const salaryTd = document.createElement('td');

const regex = /^[a-zA-Z]{2,}$/;
const myTable = document.querySelector('#myTable');
const lastnameInput = document.querySelector('#lastname');
const firstnameInput = document.querySelector('#firstname');
const birthdayInput = document.querySelector('#birthday');
const salaryInput = document.querySelector('#salary');
const btnEnregistrer = document.querySelector('#btnEnregistrer');

const thead = myTable.createTHead();
const tbody = myTable.createTBody();

lastnameInput.value = myEmployee.lastname;
firstnameInput.value = myEmployee.firstname;
birthdayInput.value = myEmployee.birthday;
salaryInput.value = myEmployee.salary;

const afficher = () => {
    const tableau = [];
    tbody.textContent = '';

    const row = tbody.insertRow();
    tableau.push(myEmployee);

    tableau.forEach(element => {
        let cellLastname = row.insertCell();
        cellLastname.textContent = element.lastname;
        let cellFirstname = row.insertCell();
        cellFirstname.textContent = element.firstname;
        let cellBirthday = row.insertCell();
        cellBirthday.textContent = element.birthday;
        let cellEmail = row.insertCell();
        cellEmail.textContent = element.firstname.toLowerCase() + '.' + element.lastname.toLowerCase() + '@example.com';
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
    //     cellEmail.textContent = String(tableau[i].firstname).toLowerCase() + '.' + String(tableau[i].lastname).toLowerCase() + '@example.com';
    //     let cellSalary = row.insertCell();
    //     cellSalary.textContent = tableau[i].salary + ' €';
    // }

    lastnameTh.textContent = 'Nom';
    firstnameTh.textContent = 'Prénom';
    birthdayTh.textContent = 'Date de naissance';
    emailTh.textContent = 'Email';
    salaryTh.textContent = 'Salaire';

    // lastnameTd.textContent = myEmployee.lastname;
    // firstnameTd.textContent = myEmployee.firstname;
    // birthdayTd.textContent = myEmployee.birthday;
    // emailTd.textContent = myEmployee.firstname.toLowerCase() + '.' + myEmployee.lastname.toLowerCase()} + '@example.com';
    // salaryTd.textContent = myEmployee.salary + ' €';

    thead.append(rowThead);
    rowThead.append(lastnameTh);
    rowThead.append(firstnameTh);
    rowThead.append(birthdayTh);
    rowThead.append(emailTh);
    rowThead.append(salaryTh);

    // tbody.append(rowTbody);
    // rowTbody.append(lastnameTd);
    // rowTbody.append(firstnameTd);
    // rowTbody.append(birthdayTd);
    // rowTbody.append(emailTd);
    // rowTbody.append(salaryTd);  
}

const modifier = (e) => {
    e.preventDefault();

    if (regex.test(firstnameInput.value) && regex.test(lastnameInput.value) && new Date() > new Date(birthdayInput.value) && salaryInput.value >= myEmployee.salary) {
        myEmployee.firstname = firstnameInput.value;
        myEmployee.lastname = lastnameInput.value;
        myEmployee.birthday = birthdayInput.value;
        myEmployee.salary = salaryInput.value;

        afficher();
    }
};

afficher();
btnEnregistrer.addEventListener('click', modifier);
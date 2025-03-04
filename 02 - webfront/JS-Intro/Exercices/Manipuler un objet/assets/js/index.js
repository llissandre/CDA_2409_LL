const tableau = [];
const myEmployee = {
    lastname: 'Doe',
    firstname: 'John',
    birthday: '1981-11-12',
    salary: 2150
};


// const row = document.createElement('tr');
// const firstnameTd = document.createElement('td');
// const lastnameTd = document.createElement('td');
// const birthdayTd = document.createElement('td');
// const emailTd = document.createElement('td');
// const salaryTd = document.createElement('td');

const regex = /^[a-zA-Z]{2,}$/;
const tbody = document.querySelector('tbody');
const firstnameInput = document.querySelector('#firstname');
const lastnameInput = document.querySelector('#lastname');
const birthdayInput = document.querySelector('#birthday');
const salaryInput = document.querySelector('#salary');
const btnEnregistrer = document.querySelector('#btnEnregistrer');

firstnameInput.value = myEmployee.firstname;
lastnameInput.value = myEmployee.lastname;
birthdayInput.value = myEmployee.birthday;
salaryInput.value = myEmployee.salary;

const afficher = () => {
    // firstnameTd.textContent = myEmployee.firstname;
    // lastnameTd.textContent = myEmployee.lastname;
    // birthdayTd.textContent = myEmployee.birthday;
    // emailTd.textContent = `${myEmployee.firstname.toLowerCase()}.${myEmployee.lastname.toLowerCase()}@example.com`;
    // salaryTd.textContent = myEmployee.salary + ' €';

    // tbody.append(row);
    // row.append(firstnameTd);
    // row.append(lastnameTd);
    // row.append(birthdayTd);
    // row.append(emailTd);
    // row.append(salaryTd);

    tableau.pop();
    const row = tbody.insertRow();
    tableau.push(myEmployee);

    // tableau.forEach(element => {
    //     let cellLastname = row.insertCell();
    //     cellLastname.textContent = element.lastname;
    //     let cellFirstname = row.insertCell();
    //     cellFirstname.textContent = element.firstname;
    //     let cellBirthday = row.insertCell();
    //     cellBirthday.textContent = element.birthday;
    //     let cellEmail = row.insertCell();
    //     cellEmail.textContent = `${element.firstname.toLowerCase()}.${element.lastname.toLowerCase()}@example.com`;
    //     let cellSalary = row.insertCell();
    //     cellSalary.textContent = element.salary + ' €';
    // });

    // for (i = 0; i < tableau.length; i++) {
    let cellLastname = row.insertCell();
    cellLastname.textContent = tableau[0].lastname;
    let cellFirstname = row.insertCell();
    cellFirstname.textContent = tableau[0].firstname;
    let cellBirthday = row.insertCell();
    cellBirthday.textContent = tableau[0].birthday;
    let cellEmail = row.insertCell();
    cellEmail.textContent = `${String(tableau[0].firstname).toLowerCase()}.${String(tableau[0].lastname).toLowerCase()}@example.com`;
    let cellSalary = row.insertCell();
    cellSalary.textContent = tableau[0].salary + ' €';
    // }
}

const modifier = (e) => {
    e.preventDefault();
    if (regex.test(firstnameInput.value) && regex.test(lastnameInput.value) && new Date() > new Date(birthdayInput.value) && salaryInput.value >= myEmployee.salary) {
        //  if (regex.test(firstnameInput.value) && regex.test(lastnameInput.value) && new Date() > new Date(birthdayInput.value) && salaryInput.value >= myEmployee.salary) {       
        myEmployee.firstname = firstnameInput.value;
        myEmployee.lastname = lastnameInput.value;
        myEmployee.birthday = birthdayInput.value;
        myEmployee.email = `${firstnameInput.value.toLowerCase()}.${lastnameInput.value.toLowerCase()}@example.com`;
        myEmployee.salary = salaryInput.value;
        afficher();
    }
};

afficher();
btnEnregistrer.addEventListener('click', modifier);
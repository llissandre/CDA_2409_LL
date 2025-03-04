const tableau = [];
const myEmployee = {
    lastname: 'Doe',
    firstname: 'John',
    birthday: '1981-11-12',
    salary: 2150
};

const regexNomPrenom = /^[a-zA-Z]{2,}$/;

const afficher = () => {
    const tbody = document.querySelector('tbody');
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
        cellEmail.textContent = `${element.firstname.toLowerCase()}.${element.lastname.toLowerCase()}@example.com`;
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
}


const firstnameInput = document.querySelector('#firstname');
const lastnameInput = document.querySelector('#lastname');
const birthdayInput = document.querySelector('#birthday');
const salaryInput = document.querySelector('#salary');
const enregistrer = document.querySelector('#enregistrer');

firstnameInput.value = myEmployee.firstname;
lastnameInput.value = myEmployee.lastname;
birthdayInput.value = myEmployee.birthday;
salaryInput.value = myEmployee.salary;

enregistrer.addEventListener('click', (e) => {
    e.preventDefault();
    myEmployee.firstname = firstnameInput.value;
    myEmployee.value = lastnameInput.value;
    myEmployee.value = birthdayInput.value;
    myEmployee.email = `${firstname.value.toLowerCase()}.${lastname.value.toLowerCase()}@example.com`;
    myEmployee.value = salaryInput.value;
console.log(tableau);

    afficher();
});

afficher();
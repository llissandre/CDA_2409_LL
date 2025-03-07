async function fetchUsers() {
    try {
        const response = await fetch('./assets/json/users.json');
        if (!response.ok) {
            throw new Error('La réponse n\'est pas OK');
        }
        return await response.json();
    }
    catch (error) {
        console.error('Un problème est survenu lors de la récupération :', error);
    }
}

const rowThead = document.createElement('tr');
const lastnameTh = document.createElement('th');
const firstnameTh = document.createElement('th');
const birthdayTh = document.createElement('th');
const emailTh = document.createElement('th');
const salaryTh = document.createElement('th');
const rowTbody = document.createElement('tr');

const form = document.querySelector('#form');
const identifiantInput = document.querySelector('#identifiantInput');
const username = document.querySelector('#divTabId #bonjour span')
const passwordInput = document.querySelector('#passwordInput');
const btnConnexion = document.querySelector('#btnConnexion');
const mdpIncorrect = document.querySelector('#mdpIncorrect');
const btnDeconnexion = document.querySelector('#btnDeconnexion');
const myTable = document.querySelector('#myTable');

const thead = myTable.createTHead();
const tbody = myTable.createTBody();

myTable.setAttribute('id', 'myTableId');

lastnameTh.textContent = 'Nom';
firstnameTh.textContent = 'Prénom';
birthdayTh.textContent = 'Date de naissance';
emailTh.textContent = 'Email';
salaryTh.textContent = 'Salaire';

thead.append(rowThead);
rowThead.append(lastnameTh);
rowThead.append(firstnameTh);
rowThead.append(birthdayTh);
rowThead.append(emailTh);
rowThead.append(salaryTh);

const connexion = (e) => {
    e.preventDefault();
    const lastname = identifiantInput.value.split('.')[1];
    const firstname = identifiantInput.value.split('.')[0];
    const password = passwordInput.value;

    fetchUsers().then(user => {
        if (user.some((e) =>
            e.firstname.toLowerCase() == firstname &&
            e.lastname.toLowerCase() == lastname &&
            e.password.toLowerCase() == password)) {

            form.style.display = 'none';
            divTabId.style.display = 'block';
            mdpIncorrect.style.display = 'none';

            username.textContent = String(firstname).charAt(0).toUpperCase() + firstname.slice(1) + ' ' + String(lastname).charAt(0).toUpperCase() + lastname.slice(1);

            tbody.textContent = '';

            user.forEach((element) => {
                const row = tbody.insertRow();
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
                if (element.firstname.toLowerCase() === firstname && element.lastname.toLowerCase() === lastname)
                    row.classList.add('surligne');
            });
        }
        else {
            mdpIncorrect.style.display = 'block';
            setTimeout(() => {
                mdpIncorrect.style.display = 'none';
            }, 5000);
        }
    });
};

const deconnexion = () => {
    form.style.display = 'block';
    divTabId.style.display = 'none';

    identifiantInput.value = '';
    passwordInput.value = '';
};

btnConnexion.addEventListener('click', connexion);
btnDeconnexion.addEventListener('click', deconnexion);
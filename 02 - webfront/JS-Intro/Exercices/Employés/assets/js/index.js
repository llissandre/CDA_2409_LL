let data = [];

const message = document.querySelector('.message');
const myTable = document.querySelector('#myTable');
const thead = myTable.createTHead();
const trTHead = document.createElement('tr');
const tbody = myTable.createTBody();

async function employees() {
    try {
        // const response = await fetch('./assets/json/employees vide.json');
        const response = await fetch('./assets/json/employees.json');
        if (!response.ok) {
            throw new Error('La réponse n\'est pas OK');
        }
        data = await response.json();
        display();
    }
    catch (error) {
        console.error('Un problème est survenu lors de la récupération :', error);
        data = [];
    }
}

const display = () => {
    const titleHead = ['EID', 'Full Name', 'Email', 'Monthly salary', 'Year of birth', 'Actions'];

    if (data.length > 0) {
        myTable.append(thead);
        thead.append(trTHead);

        titleHead.forEach((th) => {
            const thTHead = document.createElement('th');
            thTHead.innerText = th;
            trTHead.append(thTHead);
        });
    }
    else {
        message.innerHTML = 'Aucun employé est présent dans la liste';
    }

    data.forEach((element) => {
        const trTBody = tbody.insertRow();
        let cellId = trTBody.insertCell();
        cellId.innerText = element.id;
        let cellEmployee_name = trTBody.insertCell();
        cellEmployee_name.innerText = element.employee_name;
        let cellEmail = trTBody.insertCell();
        cellEmail.innerText = element.employee_name.split(' ')[0].charAt(0).toLowerCase() + '.' + element.employee_name.split(' ')[1].toLowerCase() + '@email.com';
        let cellMonthlySalary = trTBody.insertCell();
        cellMonthlySalary.innerText = (element.employee_salary / 12).toFixed(2) + '€';
        let cellYearOfBirth = trTBody.insertCell();
        cellYearOfBirth.innerText = new Date().getFullYear() - element.employee_age;
        let cellActions = trTBody.insertCell();
        cellActions.innerHTML = '<button class="btn"><i class="fa fa-home"></i> Home</button>';
        cellActions.innerHTML += '<input type="button" value="Delete" class="styled delete">';
    });
};

employees();
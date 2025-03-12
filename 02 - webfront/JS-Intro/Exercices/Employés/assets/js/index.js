let data = [];

const myTable = document.querySelector('#myTable');
const tbody = myTable.createTBody();

async function fetchEmmployees() {
    try {
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

    const trTHead = document.createElement('tr');

    const thead = myTable.createTHead();

    myTable.append(thead);
    thead.append(trTHead);

    titleHead.forEach((th) => {
        const thTHead = document.createElement('th');
        thTHead.innerText = th;
        trTHead.append(thTHead);
    });

    data.forEach((element) => {
        const trTBody = tbody.insertRow();
        let cellId = trTBody.insertCell();
        cellId.innerText = element.id;
        let cellEmployee_name = trTBody.insertCell();
        cellEmployee_name.innerText = element.employee_name;
        let cellEmail = trTBody.insertCell();
        cellEmail.innerText = element.employee_name;
        let cellMonthlySalary = trTBody.insertCell();
        cellMonthlySalary.innerText = element.employee_salary;
        let cellYearOfBirth = trTBody.insertCell();
        cellYearOfBirth.innerText = element.employee_age;
        let cellActions = trTBody.insertCell();
    });
};

fetchEmmployees();
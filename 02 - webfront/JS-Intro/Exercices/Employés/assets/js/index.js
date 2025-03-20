let data = [];

const message = document.querySelector('.message');
const myTable = document.querySelector('#myTable');
const btnIncreasing = document.querySelector('#btnIncreasing')
const btnDecreasing = document.querySelector('#btnDecreasing')
const tbody = myTable.createTBody();
const tfoot = myTable.createTFoot();

async function fetchEmployees() {
    try {
        // const response = await fetch('./assets/json/employees vide.json');
        const response = await fetch('./assets/json/employees.json');
        if (!response.ok) {
            throw new Error('La réponse n\'est pas OK');
        }
        data = await response.json();
        display();
    }
    catch (erreur) {
        console.error('Un problème est survenu lors de la récupération :', erreur);
        data = [];
    }
}

const display = () => {

    if (data.length > 0) {
        let numberEmployees = 0;
        let payroll = 0;

        myTable.append(tfoot);

        data.forEach((element) => {
            const trTBody = tbody.insertRow();
            let cellId = trTBody.insertCell();
            cellId.textContent = element.id;
            let cellEmployee_name = trTBody.insertCell();
            cellEmployee_name.textContent = element.employee_name;
            let cellEmail = trTBody.insertCell();
            cellEmail.textContent = element.employee_name.split(' ')[0].charAt(0).toLowerCase() + '.' + element.employee_name.split(' ')[1].toLowerCase() + '@email.com';
            let cellMonthlySalary = trTBody.insertCell();
            let monthlySalary = (element.employee_salary / 12).toFixed(2);
            cellMonthlySalary.textContent = monthlySalary + ' €';
            let cellYearOfBirth = trTBody.insertCell();
            cellYearOfBirth.textContent = new Date().getFullYear() - element.employee_age;
            let cellActions = trTBody.insertCell();
            cellActions.innerHTML = '<button class="styled duplicate" type="button"><i class="fa-regular fa-copy"></i>Duplicate</button>';
            cellActions.innerHTML += '<button class="styled delete" type=""button><i class="fa-regular fa-trash-can"></i>Delete</button>';

            numberEmployees++;
            payroll += Number(monthlySalary);
        });

        const trTFoot = tfoot.insertRow();
        let cellNumberEmployees = trTFoot.insertCell(0);
        cellNumberEmployees.textContent = numberEmployees;
        cellNumberEmployees.style.fontWeight = 'bold';
        let cellVides1 = trTFoot.insertCell(1);
        cellVides1.colSpan = 2;
        let cellPayroll = trTFoot.insertCell(2);
        cellPayroll.textContent = payroll.toFixed(2) + ' €';
        cellPayroll.style.fontWeight = 'bold';
        let cellVides2 = trTFoot.insertCell(3);
        cellVides2.colSpan = 3;
    }

    else {
        message.innerHTML = 'Aucun employé est présent dans la liste';
        myTable.style.display = 'none';
    }
};

btnIncreasing.addEventListener('click', () => {
    console.log('test');

});

fetchEmployees();
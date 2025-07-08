let data = [];

const message = document.querySelector('.message');
const myTable = document.querySelector('#myTable');
const btnIncreasing = document.querySelector('#btnIncreasing');
const btnDecreasing = document.querySelector('#btnDecreasing');
const btnDuplicate = document.querySelector('.btnDuplicate');
const tbody = myTable.createTBody();
const tfoot = myTable.createTFoot();

async function fetchEmployees() {
    try {
        // const response = await fetch('./assets/json/employees vide.json');
        // const response = await fetch('./assets/json/employees partiel.json');
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
    tbody.textContent = '';
    tfoot.textContent = '';

    if (data.length > 0) {
        // let payrollb = 0;

        myTable.append(tfoot);

        data.forEach((element, i) => {
            const trTBody = tbody.insertRow();
            const btnDuplicate = document.createElement('button');
            const btnDelete = document.createElement('button');
            let cellId = trTBody.insertCell();
            cellId.textContent = element.id;
            if (element.id%2 === 0) {
                trTBody.classList.add('even');
            }
            else {
                trTBody.classList.remove('even');
            }
            
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

            btnDuplicate.classList.add('styled', 'btnDuplicate');
            btnDelete.classList.add('styled', 'btnDelete');

            btnDuplicate.innerHTML = '<i class="fa-regular fa-copy"></i>Duplicate';
            btnDelete.innerHTML = '<i class="fa-regular fa-trash-can"></i>Delete';

            cellActions.append(btnDuplicate, btnDelete);

            btnDuplicate.addEventListener('click', () => {

                // const maxId = Math.max(...data.map(element => element.id));

                const maxId = data.reduce((a, b) => (a.id > b.id) ? a : b);
                const duplicate = { ...element };
                duplicate.id = maxId.id + 1;

                data.splice(data.length, 0, duplicate);
                display();
            });

            btnDelete.addEventListener('click', () => {
                data.splice(i, 1);
                display();
            });

            // payrollb += Number(monthlySalary);
        });
        // console.log(payrollb);

        let payroll = (data.reduce((a, b) => a + b.employee_salary, 0) / 12);

        const trTFoot = tfoot.insertRow();
        let cellNumberEmployees = trTFoot.insertCell(0);
        cellNumberEmployees.textContent = data.length;
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
}

const sortDecreasing = () => {
    data.sort((a, b) => b.employee_salary - a.employee_salary)
}

const sortIncreasing = () => {
    data.sort((a, b) => a.employee_salary - b.employee_salary)
}


btnIncreasing.addEventListener('click', () => {
    sortIncreasing();
    display();
});

btnDecreasing.addEventListener('click', () => {
    sortDecreasing();
    display();
});

fetchEmployees();
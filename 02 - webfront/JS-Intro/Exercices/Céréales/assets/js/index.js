let collectionCereals = [];
let nutriscoreChecked = [];

const inputSearchCereal = document.getElementById('inputSearchCereal').value.toLowerCase();
const myTable = document.getElementById('myTable');
const inputCheckboxes = document.querySelectorAll('.ns input');
const filters = document.querySelectorAll('.fieldsetF');
const all = document.getElementById('all').selected;
const withoutSugar = document.getElementById('withoutSugar').selected;
const lowSalt = document.getElementById('lowSalt').selected;
const boost = document.getElementById('boost').selected;
const arrow = document.querySelectorAll('.arrow');
const dataSort = document.querySelectorAll('th[data-sort]');

const removed = new Set();

const tbody = myTable.createTBody();
const tfoot = myTable.createTFoot();

let nutriscore = '';
let color = '';
let sortKey = '';
let sortInscrease = true;

async function fetchCereals() {
    try {
        const reponse = await fetch('./assets/json/cereals.json');
        if (!reponse.ok) {
            throw new Error('La réponse n\'est pas ok')
        }
        collectionCereals = await reponse.json();
        display();
    } catch (error) {
        console.error('Un problème est survenu lors de la récupération : ', error);
        collectionCereals = [];
    }
}

const display = () => {
    tbody.textContent = '';
    tfoot.textContent = '';
    let filtered = collectionCereals.filter(cereal => !removed.has(cereal.id));
filtered = filtered.filter(cereal => cereal.name.toLowerCase().includes(inputSearchCereal));

    if (filtered.length > 0) {
        myTable.append(tfoot);

        if (sortKey) {
            filtered = filtered.sort((a, b) => {
                const valA = a[sortKey];
                const valB = b[sortKey];
                const compare = valA > valB ? 1 : valA < valB ? -1 : 0;
                return sortInscrease ? compare : -compare;
            });
        }

        filtered.forEach(cereal => {
            const trTBody = tbody.insertRow();
            let cellId = trTBody.insertCell();
            cellId.textContent = cereal.id;
            let cellNom = trTBody.insertCell();
            cellNom.textContent = cereal.name;
            let cellCalories = trTBody.insertCell();
            cellCalories.textContent = cereal.calories;
            let cellProteine = trTBody.insertCell();
            cellProteine.textContent = cereal.protein;
            let cellSel = trTBody.insertCell();
            cellSel.textContent = cereal.sodium;
            let cellFibres = trTBody.insertCell();
            cellFibres.textContent = cereal.fiber;
            let cellGlucides = trTBody.insertCell();
            cellGlucides.textContent = cereal.carbo;
            let cellSucre = trTBody.insertCell();
            cellSucre.textContent = cereal.sugars;
            let cellPotassium = trTBody.insertCell();
            cellPotassium.textContent = cereal.potass;
            let cellVitamines = trTBody.insertCell();
            cellVitamines.textContent = cereal.vitamins;
            let cellEvaluation = trTBody.insertCell();
            cellEvaluation.textContent = cereal.rating;

            getNS(cereal.rating);
            let cellNS = trTBody.insertCell();
            cellNS.textContent = nutriscore;
            cellNS.style.backgroundColor = color;

            let cellDEL = trTBody.insertCell();
            cellDEL.innerHTML = '&#128938;';
            cellDEL.classList.add('pointer');
            cellDEL.style.color = 'red';

            cellDEL.addEventListener('click', () => {
                // const indexOfCereal = filtered.indexOf(cereal);
                // filtered.splice(indexOfCereal, 1)
                removed.add(cereal.id);
                display();
            })
        });
    }

    const trTFoot = tfoot.insertRow();
    const sum = filtered.reduce((a, b) => a + b.calories, 0);
    let avgCalories = Math.floor(sum / filtered.length);

    if (filtered.length === 0) {
        avgCalories = 0;
    }

    let cellIdVide = trTFoot.insertCell();
    cellIdVide.textContent = '';
    let cellNbElements = trTFoot.insertCell();
    cellNbElements.textContent = filtered.length + ' éléments';
    let cellAvgCalories = trTFoot.insertCell();
    cellAvgCalories.textContent = 'Moyenne calories : ' + avgCalories;
}

// const searchCereals = (e) => {
//     e.preventDefault();

//     let result = filtered.filter(cereal =>
//         cereal.name.trim().toLowerCase().includes(inputSearchCereal.value.trim().toLowerCase()));

//     if (result.length === 0) {
//         alert('Aucune correspondance n\'a été trouvée');
//     }
//     else {
//         display(result)
//     };
// };

const getNS = (rating) => {
    if (rating < 35) { { nutriscore = 'E', color = 'var(--E)' } }
    else if (rating < 55) { { nutriscore = 'D', color = 'var(--D)' } }
    else if (rating < 70) { { nutriscore = 'C', color = 'var(--C)' } }
    else if (rating < 80) { { nutriscore = 'B', color = 'var(--B)' } }
    else { { nutriscore = 'A', color = 'var(--A)' } }
}

inputSearchCereal.addEventListener('search', searchCereals);

inputCheckboxes.forEach(ns => ns.addEventListener('change', (e) => {
    if (e.target.checked) {
        nutriscoreChecked.push(e.target.id);
    }
    else {
        let myIndex = nutriscoreChecked.indexOf(e.target.id);
        nutriscoreChecked.splice(myIndex, 1);
    }

    // console.log(nutriscoreChecked);
}));

const sortTable = (key) => {
    console.log(key);

    if (sortKey === key)
        sortInscrease = !sortInscrease;
    else {
        sortKey = key;
        sortInscrease = true;
    }

    sortArrow();
    display();
}

const sortArrow = () => {
    arrow.forEach(e => e.textContent = '');

    if (sortKey) {
        const arrowIds = document.getElementById('arrow-' + sortKey);

        if (arrowIds)
            arrowIds.textContent = sortInscrease ? ' ▼' : ' ▲';
    }
}

dataSort.forEach(th => {
    th.addEventListener('click', () => {
        sortTable(th.dataset.sort);
    });
});

// filters.forEach(ns => ns.addEventListener('change', display));
// localCompare(a)
fetchCereals();
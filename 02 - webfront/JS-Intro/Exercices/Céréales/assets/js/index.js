let collectionCereals = [];
let nutriscoreChecked = [];

const inputSearchCereal = document.getElementById('inputSearchCereal');
const myTable = document.getElementById('myTable');
const inputCheckboxes = document.querySelector('input[type="checkbox"]');
const a = document.getElementById('a');
const b = document.getElementById('b');
const c = document.getElementById('c');
const d = document.getElementById('d');
const e = document.getElementById('e');

const tbody = myTable.createTBody();
const tfoot = myTable.createTFoot();

let nutriscore = '';
let color = '';

async function fetchCereals() {
    try {
        const reponse = await fetch('./assets/json/cereals.json');
        if (!reponse.ok) {
            throw new Error('La réponse n\'est pas ok')
        }
        collectionCereals = await reponse.json();
        display(collectionCereals);
    } catch (error) {
        console.error('Un problème est survenu lors de la récupération : ', error);
        collectionCereals = [];
    }
}

const display = (result) => {
    tbody.textContent = '';
    tfoot.textContent = '';

    if (result.length > 0) {
        myTable.append(tfoot);

        result.forEach((cereal) => {
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

            calculateNutriscore(cereal.rating);
            let cellNS = trTBody.insertCell();
            cellNS.textContent = nutriscore;
            cellNS.style.backgroundColor = color;

            let cellDEL = trTBody.insertCell();
            cellDEL.innerHTML = '&#128938;';
            cellDEL.classList.add('pointer');
            cellDEL.style.color = 'red';

            cellDEL.addEventListener('click', () => {
                const indexOfCereal = result.indexOf(cereal);
                result.splice(indexOfCereal, 1)
                display(result);
            })
        });
    }

    const trTFoot = tfoot.insertRow();
    const sum = result.reduce((a, b) => a + b.calories, 0);
    let avgCalories = Math.floor(sum / result.length);

    if (result.length === 0) {
        avgCalories = 0;
    }

    let cellIdVide = trTFoot.insertCell();
    cellIdVide.textContent = '';
    let cellNbElements = trTFoot.insertCell();
    cellNbElements.textContent = result.length + ' éléments';
    let cellAvgCalories = trTFoot.insertCell();
    cellAvgCalories.innerHTML = 'Moyenne calories : ' + avgCalories;

}

const searchCereals = (e) => {
    e.preventDefault();

    let resultCereals = collectionCereals.filter((cereal) =>
        cereal.name.trim().toLowerCase().includes(inputSearchCereal.value.trim().toLowerCase()));

    if (resultCereals.length === 0) {
        alert('Aucune correspondance n\'a été trouvée');
    }
    else {
        display(resultCereals)
    };
};

const calculateNutriscore = (rating) => {
    if (rating < 35) {
        nutriscore = 'E';
        color = 'var(--E)'
    }
    else if (rating < 55) {
        nutriscore = 'D';
        color = 'var(--D)'
    }
    else if (rating < 70) {
        nutriscore = 'C';
        color = 'var(--C)'
    }
    else if (rating < 80) {
        nutriscore = 'B';
        color = 'var(--B)'
    }
    else {
        nutriscore = 'A';
        color = 'var(--A)'
    }
}

inputSearchCereal.addEventListener('search', searchCereals);



d.addEventListener(('change'), (e) => {

    if (e.target.checked) {
        console.log('test');
    }

});

fetchCereals();
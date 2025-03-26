let collectionCereals = [];
let nutriscoreChecked = [];
let filtered = [];

const myTable = document.getElementById('myTable');
const filters = document.querySelectorAll('.fieldsetFilters input[type=checkbox], .fieldsetFilters select');
const all = document.getElementById('all');
const withoutSugar = document.getElementById('withoutSugar');
const lowSalt = document.getElementById('lowSalt');
const boost = document.getElementById('boost');
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
        // const reponse = await fetch('./assets/json/cereals tests.json');
        // const reponse = await fetch('./assets/json/cereals vide.json');

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

let filteredStorage = localStorage.getItem('filteredStorage');
filtered = JSON.parse(filteredStorage);
console.log(filteredStorage);
console.log(filtered);

const display = () => {
    // filteredStorage = localStorage.getItem('filteredStorage');
    filtered = JSON.parse(filteredStorage);
    // console.log(filtered);

    tbody.textContent = '';
    tfoot.textContent = '';
    
    const inputSearchCereal = document.getElementById('inputSearchCereal').value.toLowerCase();
    const inputNsChecked = [...document.querySelectorAll('.checkboxesNS:checked')].map(cereal => cereal.value);
    const selectCategory = document.getElementById('selectCategory').value;
    
    if (filteredStorage === null) {
        filtered = collectionCereals.filter(cereal => !removed.has(cereal.id));
    }
    else {
        filtered = filtered.filter(cereal => !removed.has(cereal.id));
    }

    filtered = filtered.filter(cereal => cereal.name.toLowerCase().includes(inputSearchCereal));

    console.log(filtered);
    
    filtered = filtered.filter(cereal => {
        const nsRating = getNSCheckbox(cereal.rating);
        const nsMatch = inputNsChecked.length === 0 || inputNsChecked.includes(nsRating);
        let selectMatch = true;

        if (selectCategory === 'withoutSugar')
            selectMatch = cereal.sugars < 1;
        else if (selectCategory === 'lowSalt')
            selectMatch = cereal.sodium < 50;
        else if (selectCategory === 'boost')
            selectMatch = cereal.vitamins >= 25 && cereal.fiber >= 10;
        
        return nsMatch && selectMatch;
    });

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

        localStorage.setItem('filteredStorage', JSON.stringify(filtered));
    });
    
    const trTFoot = tfoot.insertRow();
    const sum = filtered.reduce((a, b) => a + b.calories, 0);
    let avgCalories = Math.floor(sum / filtered.length);
    
    let cellIdVide = trTFoot.insertCell();
    
    if (filtered.length === 0) {
        avgCalories = 0;
        cellIdVide.style.backgroundColor = 'var(--color1)';
    }
    
    let cellNbElements = trTFoot.insertCell();
    cellNbElements.textContent = filtered.length + ' éléments';
    let cellAvgCalories = trTFoot.insertCell();
    cellAvgCalories.textContent = 'Moyenne calories : ' + avgCalories;
    
    
}

const getNS = (rating) => {
    if (rating < 35) { { nutriscore = 'E', color = 'var(--E)' } }
    else if (rating < 55) { { nutriscore = 'D', color = 'var(--D)' } }
    else if (rating < 70) { { nutriscore = 'C', color = 'var(--C)' } }
    else if (rating < 80) { { nutriscore = 'B', color = 'var(--B)' } }
    else { { nutriscore = 'A', color = 'var(--A)' } }
}

const getNSCheckbox = (rating) => {
    if (rating < 35) return 'E';
    if (rating < 55) return 'D';
    if (rating < 70) return 'C';
    if (rating < 80) return 'B';
    return 'A';
}

const sortTable = (key) => {
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

inputSearchCereal.addEventListener('input', display);

filters.forEach(e => e.addEventListener('change', display));

dataSort.forEach(th => {
    th.addEventListener('click', () => {
        sortTable(th.dataset.sort);
    });
});

// localStorage.setItem('test', 1);
// alert(localStorage.getItem('test')); // 1

const storeFiltered = () => {
    localStorage.setItem('filteredStorage', JSON.stringify(filtered));
}

fetchCereals();


// const inputCheckboxes = document.querySelectorAll('ns input[type=checkbox]');
// inputCheckboxes.forEach(ck => ck.addEventListener('change', (e) => {
    //     if (e.target.checked) {
        //         nutriscoreChecked.push(e.target.id);
        //     }
        //     else {
            //         let myIndex = nutriscoreChecked.indexOf(e.target.id);
            //         nutriscoreChecked.splice(myIndex, 1);
            //     }
            //     console.log(nutriscoreChecked);
            // }));
            
            
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
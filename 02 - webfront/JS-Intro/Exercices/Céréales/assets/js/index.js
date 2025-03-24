let data = [];

const searchCereal = document.getElementById('searchCereal');
const myTable = document.getElementById('myTable');
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
        data = await reponse.json();
        display();
    } catch (error) {
        console.error('Un problème est survenu lors de la récupération : ', error);
        data = [];
    }
}

const display = () => {
    tbody.textContent = '';
    tfoot.textContent = '';

    if (data.length > 0) {
        myTable.append(tfoot);

        data.forEach((cereal) => {
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

            if (cereal.rating >= 80) {
                nutriscore = 'A';
                color = 'var(--A)'
            }
            else if (cereal.rating >= 70 && cereal.rating < 80) {
                nutriscore = 'B';
                color = 'var(--B)'
            }
            else if (cereal.rating >= 55 && cereal.rating < 70) {
                nutriscore = 'C';
                color = 'var(--C)'
            }
            else if (cereal.rating >= 35 && cereal.rating < 55) {
                nutriscore = 'D';
                color = 'var(--D)'
            }
            else if (cereal.rating < 35) {
                nutriscore = 'E';
                color = 'var(--E)'
            }

            let cellNS = trTBody.insertCell();
            cellNS.textContent = nutriscore;
            cellNS.style.backgroundColor = color;
            let cellDEL = trTBody.insertCell();
            cellDEL.innerHTML = '&#128938;';
            cellDEL.style.color = 'red';
        });
    }
    else { }
}


fetchCereals();
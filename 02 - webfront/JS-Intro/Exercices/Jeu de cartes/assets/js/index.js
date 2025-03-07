async function fetchResultats() {
    try {
        const response = await fetch('./assets/json/cardgame.json');
        if (!response.ok) {
            throw new Error('La réponse n\'est pas OK');
        }
        return await response.json();
    }
    catch (error) {
        console.error('Un problème est survenu lors de la récupération :', error);
    }
}

const b = document.querySelector('document.body');
const myTable = document.querySelector('#myTable');

const information1 = document.querySelector('.information1');
const information2 = document.querySelector('.information2');

const tbody = myTable.createTBody();

fetchResultats().then(resultats => {
    tbody.textContent = ''

    resultats.forEach((element) => {
        const row = tbody.insertRow();
        let cellId = row.insertCell();
        cellId.textContent = element.id;
        if (element.id % 2) {
            row.classList.add('backgroungEven')
        }

        let cellName = row.insertCell();
        cellName.textContent = element.name;
        let cellLevel = row.insertCell();
        cellLevel.textContent = element.level;
        let cellDescription = row.insertCell();
        cellDescription.textContent = element.description;
        let cellPower = row.insertCell();
        cellPower.textContent = element.power;
        let cellAttack = row.insertCell();
        cellAttack.textContent = element.attack;
        let cellArmor = row.insertCell();
        cellArmor.textContent = element.armor;
        let cellDamage = row.insertCell();
        cellDamage.textContent = element.damage;
        let cellMitigation = row.insertCell();
        cellMitigation.textContent = element.mitigation;
        let cellPlayed = row.insertCell();
        cellPlayed.textContent = element.played;
        let cellVictory = row.insertCell();
        cellVictory.textContent = element.victory;
        let Defeat = row.insertCell();
        Defeat.textContent = element.defeat;
        let cellDraw = row.insertCell();
        cellDraw.textContent = element.draw;
    });

    const valuesPlayed = [];
    let maxPlayed;

    resultats.map((resultat) => {
        let valuePlayed = resultat.played;

        valuesPlayed.push(valuePlayed);
        
        maxPlayed = Math.max.apply(null, valuesPlayed);
    });

    
});

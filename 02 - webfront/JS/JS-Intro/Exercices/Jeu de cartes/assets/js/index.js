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

const titresTHead = ['id', 'name', 'level', 'description', 'power', 'attack', 'armor', 'damage', 'mitigation', 'played', 'victory', 'defeat', 'draw'];

const b = document.querySelector('document.body');
const myTable = document.querySelector('#myTable');
const information1 = document.querySelector('.information1');
const information2 = document.querySelector('.information2');

const trHead = document.createElement('tr');

const thead = myTable.createTHead();
const tbody = myTable.createTBody();

titresTHead.forEach((th) => {
    const thHead = document.createElement('th');
    thHead.textContent = th;
    trHead.append(thHead);
});

myTable.append(thead);
thead.append(trHead);

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

    let maxPlayed = resultats.reduce((x, y) => x.played > y.played ? x : y);

    // console.log('Le nom et le nombre de victoires de la carte ayant le plus de parties jouées sont respectivement ' + maxPlayed.name + ' et ' + maxPlayed.victory + ', avec ' + maxPlayed.played + ' parties jouées.');

    information1.innerHTML = 'Le nom et le nombre de victoires de la carte ayant le plus de parties jouées sont respectivement <b>' + maxPlayed.name + '</b> et <b>' + maxPlayed.victory + '</b>, avec <b>' + maxPlayed.played + '</b> parties jouées.';

    //  v/v+d
    let ratio = 0;
    let idRatio;
    let nameRatio;
    let playedRatio;
    let victoryRatio;

    resultats.map((resultat) => {
        const valueRatio = resultat.victory /
            (resultat.victory + resultat.defeat);

        if (valueRatio > ratio) {
            idRatio = resultat.id;
            nameRatio = resultat.name;
            playedRatio = resultat.played;
            victoryRatio = resultat.victory;
            ratio = valueRatio
        }
    });

    // console.log('Le nom, nombre de parties et nombre de victoires de la carte ayant le meilleur ratio victoires/défaites (en ignorant les machts nuls) sont respectivement ' + nameRatio + ', ' + playedRatio + ' et ' + victoryRatio + ', avec un ratio de ' + ratio.toFixed(4) * 100 + '%.');

    information2.innerHTML = 'Le nom, le nombre de parties et le nombre de victoires de la carte ayant le meilleur ratio victoires/défaites (en ignorant les machts nuls) sont respectivement <b>' + nameRatio + '</b>, <b>' + playedRatio + '</b> et <b>' + victoryRatio + '</b>, avec un ratio de <b>' + ratio.toFixed(4) * 100 + '%</b>.';
});
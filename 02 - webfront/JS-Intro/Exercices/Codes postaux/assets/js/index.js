async function recupererZipcodes() {
    try {
        const response = await fetch('./assets/json/zipcodes.json');
        if (!response.ok) {
            throw new Error('La réponse n\'est pas OK');
        }
        return await response.json();
    }
    catch (error) {
        console.error('Un problème est survenu lors de la récupération :', error);
    }
}

const b = document.querySelector('document.body')
const form = document.querySelector('form');
const searchInput = document.querySelector('#searchInput');
const listeVilles = document.querySelector('#listeVilles');
const btnValider = document.querySelector('#btnValider');
const informations = document.querySelector('#informations');



listeVilles.addEventListener('input', () => {
    recupererZipcodes().then(liste => {
        liste.forEach(element => {
            const option = document.createElement('option');
            option.value = element.codePostal;
            dataList.append(option);
        })
    });
});

btnValider.addEventListener('click', (e) => {
    e.preventDefault();
    informations.textContent = '';
    recupererZipcodes().then(liste => {
        liste.forEach(element => {
            if (searchInput.value == element.codePostal) {
                const ul = document.createElement('ul');

                ul.innerHTML = '<li>Code postal : ' + element.codePostal + '</li>';
                ul.innerHTML += '<li>Code de la commune : ' + element.codeCommune + '</li>';
                ul.innerHTML += '<li>Nom de la commune : ' + element.nomCommune + '</li>';
                ul.innerHTML += '<li>Libellé acheminement : ' + element.libelleAcheminement + '</li>';

                informations.append(ul);
            }
            // else if (element.codePostal.contains(searchInput.value)) {

            // }

        });
    });
});
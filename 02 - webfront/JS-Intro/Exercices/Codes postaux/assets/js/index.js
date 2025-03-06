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
            dataList.appendChild(option);
        })
    });
});

btnValider.addEventListener('click', (e) => {
    e.preventDefault();
});
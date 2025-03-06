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

const form = document.querySelector('form');
const searchInput = document.querySelector('#searchInput');
const listeVilles = document.querySelector('#listeVilles');
const btnValider = document.querySelector('#btnValider');
const informations = document.querySelector('#informations');



btnValider.addEventListener('click', (e) => {
    e.preventDefault();

    const codePostalSubstr = e.codePostal.substr(0, 2);

    recupererZipcodes().then(infos => {
        if (infos.filter(e) =>
            codePostalSubstr == searchInput)
    {
        infos.forEach((e) => {

        });
    }
});
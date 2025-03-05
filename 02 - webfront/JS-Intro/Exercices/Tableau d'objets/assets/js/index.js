async function recupererUsers() {
    try {
        const response = await fetch('./assets/json/users.json');
        if (!response.ok) {
            throw new Error('La réponse n\'est pas OK');
        }
        return await response.json();
    }
    catch (error) {
        console.error('Un problème est survenu lors de la récupération :', error);
    }
}

const form = document.querySelector('#form');
const identifiant = document.querySelector('#identifiant');
const password = document.querySelector('#password');
const btnConnexion = document.querySelector('#btnConnexion');

btnConnexion.addEventListener('click', (e) => {
    recupererUsers().then((users) => 
        console.log(users));
    console.log(identifiant.value);
    console.log(password.value);
    
});
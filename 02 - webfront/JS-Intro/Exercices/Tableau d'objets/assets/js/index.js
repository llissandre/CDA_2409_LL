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

const rowTBody = document.createElement('tbody');
const 

const form = document.querySelector('#form');
const identifiant = document.querySelector('#identifiantInput');
const password = document.querySelector('#passwordInput');
const btnConnexion = document.querySelector('#btnConnexion');
const myTable = document.querySelector('#MyTable');

const thead = myTable.createTHead();
const tbody = myTable.createTBody();


btnConnexion.addEventListener('click', () => {
    const lastname = identifiant.value.split('.')[1];
    const firstname = identifiant.value.split('.')[0];
    const password = passwordInput.value;

    recupererUsers().then(user => {
        if (user.some((e) =>
            e.firstname.toLowerCase() == firstname &&
            e.lastname.toLowerCase() == lastname &&
            e.password.toLowerCase() == password)) {
            
            console.log(e.firstname.toUpperCase());
            
            
            
        }
        else {
            alert('Identifiant ou mot de passe incorrect');
        }

    });
});
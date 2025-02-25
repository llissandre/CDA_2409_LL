const form = document.querySelector('#form');
const prenom = document.querySelector('#prenom');
const age = document.querySelector('#age');
const vider = document.querySelector('#reset');
const sentences = document.querySelector('#sentence');

// form.addEventListener('submit', (e) => {
const resultat = (e) => {
    if (prenom.value != '' && age.value > 0) {
        e.preventDefault();
        sentences.innerHTML = '<li>Bonjour ' + prenom.value + ', votre âge est : ' + age.value + ' ans.</li>';

        if (age.value >= 18) {
            sentences.innerHTML += '<li>Vous êtes majeur.</li>';
        }
        else {
            sentences.innerHTML += '<li>Vous êtes mineur.</li>';
        }

        if (age.value < 64) {
            let nbAnnees = 64 - age.value;
            sentences.innerHTML += '<li>Il vous reste ' + nbAnnees + ' année(s) avant la retraite.</li>';
        }
        else if (age.value > 64) {
            let nbAnnees = age.value - 64;
            sentences.innerHTML += '<li>Vous êtes à la retraite depuis ' + nbAnnees + ' année(s).</li>';
        }
        else if (age.value = 64) {
            sentences.innerHTML += '<li>Vous prenez votre retraite cette année !</li>';
        }
    }
    else {
        e.preventDefault();
        sentences.innerHTML = '<li>Compléter/corriger le formulaire</li>';
    }
};

// reset.addEventListener('click', () => {
const reseter = () => {
    sentences.remove();
};

form.addEventListener('submit', resultat);
reset.addEventListener('click', reseter)



// window.addEventListener('load', getSentences());

// function storeSentence() {
//     window.localStorage.sentences = sentences.textContent;
// }

// function getSentences() {
//     if (window.localStorage.sentences) {
//         sentences.textContent = window.localStorage.sentences;
//     }
// }
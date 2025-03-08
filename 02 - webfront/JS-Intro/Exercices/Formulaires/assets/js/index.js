const form = document.querySelector('#form');
const prenom = document.querySelector('#prenom');
const age = document.querySelector('#age');
const vider = document.querySelector('#reset');
const sentences = document.querySelector('#sentence');
sentences.innerHTML = '<li>Compléter/corriger le formulaire</li>';

age.value = '';
// form.addEventListener('submit', (e) => {
const resultat = (e) => {
    if (prenom.value != '' && age.value > 0) {
        e.preventDefault();
        sentences.innerHTML = `<li>Bonjour <span class="colorBlue">${prenom.value}</span>, votre âge est : <span class="colorBlue">${age.value}</span> ans.</li>`;
        // sentences.innerHTML = '<li>Bonjour ' + prenom.value + ', votre âge est : ' + age.value + ' ans.</li>';

        if (age.value >= 18) {
            sentences.innerHTML += '<li>Vous êtes <span class="colorBlue">majeur.</span></li>';
        }
        else {
            sentences.innerHTML += '<li>Vous êtes <span class="colorBlue">mineur.</span></li>';
        }

        if (age.value < 64) {
            let nbAnnees = 64 - age.value;
            sentences.innerHTML += '<li>Il vous reste <span class="colorBlue">' + nbAnnees + '</span> année(s) avant la retraite.</li>';
        }
        else if (age.value > 64) {
            let nbAnnees = age.value - 64;
            sentences.innerHTML += '<li>Vous êtes à la retraite depuis ' + '<span class="colorBlue">' + nbAnnees + '</span>' + ' année(s).</li>';
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
    sentences.innerHTML = '<li>Compléter/corriger le formulaire</li>';
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
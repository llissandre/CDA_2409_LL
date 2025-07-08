const btnaugmenter = document.querySelector('#btnaugmenter');
const btndiminuer = document.querySelector('#btndiminuer');
const texte = document.querySelector('p');
const inputTaille = document.querySelector('input[type="number"]');
const tailletextepardefaut = 16;
const tailletextemaximale = 48;
const tailletexteminimale = 8;
let tailleActuelle = document.querySelector('#tailleActuelle');

texte.style.fontSize = tailletextepardefaut + 'px';

btnaugmenter.addEventListener('click', () => {
    let tailledutexte = Number(tailleActuelle.textContent);

    if (tailledutexte < tailletextemaximale) {
        tailleActuelle.textContent = tailledutexte + 1;
        texte.style.fontSize = tailledutexte + 'px';
        inputTaille.value = tailleActuelle.textContent;
    }
    else {
        tailleActuelle.textContent = tailletextepardefaut;
        texte.style.fontSize = tailletextepardefaut + 'px';
        inputTaille.value = tailleActuelle.textContent;
    }
});

btndiminuer.addEventListener('click', () => {
    let tailledutexte = Number(tailleActuelle.textContent);

    if (tailledutexte > tailletexteminimale) {
        tailleActuelle.textContent = tailledutexte - 1;
        texte.style.fontSize = tailledutexte + 'px';
        inputTaille.value = tailleActuelle.textContent;
    }
    else {
        tailleActuelle.textContent = tailletextepardefaut;
        texte.style.fontSize = tailletextepardefaut + 'px';
        inputTaille.value = tailleActuelle.textContent;
    }
});

inputTaille.addEventListener('input', (e) => {
    let tailledutexte = e.target.value;

    if (tailledutexte >= 8 && tailledutexte <= 48) {
        tailleActuelle.textContent = tailledutexte;
        texte.style.fontSize = tailledutexte + 'px';
    }
    else {
        inputTaille.value = tailletextepardefaut;
        tailleActuelle.textContent = tailletextepardefaut;
        texte.style.fontSize = tailletextepardefaut + 'px';
    }
});
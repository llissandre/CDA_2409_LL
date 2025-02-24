const btnaugmenter = document.querySelector('#btnaugmenter');
const btndiminuer = document.querySelector('#btndiminuer');
const texte = document.querySelector('p');
const px = document.querySelector('#px');
const tailletextepardefaut = 16;
const tailletextemaximale = 48;
const tailletexteminimale = 8;

texte.style.fontSize = tailletextepardefaut + 'px';

btnaugmenter.addEventListener('click', () => {
    let tailledutexte = Number(document.querySelector('#px').textContent);

    if (tailledutexte < tailletextemaximale) {
        document.querySelector('#px').textContent = tailledutexte + 1;
        texte.style.fontSize = tailledutexte + 'px';
    }
    else {
        document.querySelector('#px').textContent = tailletextepardefaut;
        texte.style.fontSize = tailletextepardefaut + 'px';
    }
});

btndiminuer.addEventListener('click', () => {
    let tailledutexte = Number(document.querySelector('#px').textContent);

    if (tailledutexte > tailletexteminimale) {
        document.querySelector('#px').textContent = tailledutexte - 1;
        texte.style.fontSize = tailledutexte + 'px';
    }
    else {
        document.querySelector('#px').textContent = tailletextepardefaut;
        texte.style.fontSize = tailletextepardefaut + 'px';
    }
});
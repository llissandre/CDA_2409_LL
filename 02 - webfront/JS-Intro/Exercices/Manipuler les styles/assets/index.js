const btnaugmenter = document.querySelector('#btnaugmenter');
const btndiminuer = document.querySelector('#btndiminuer');
const px = document.querySelector('#px');
const tailletextepardefaut = 16;
const tailletextemaximale = 48;
const texte = document.querySelector('p');

texte.style.fontSize = tailletextepardefaut + 'px';
let tailledutexte = texte.style.fontSize;

btnaugmenter.addEventListener('click', () => {
    
    texte.style.fontSize = tailledutexte + 1 + 'px';
})
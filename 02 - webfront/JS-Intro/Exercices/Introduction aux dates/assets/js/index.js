const form = document.querySelector('form');
const dateN = document.querySelector('#dateN');
const calculer = document.querySelector('#calculer');
const sentences = document.querySelector('#sentence');
const dateT = new Date().toLocaleString();
const dateToday = new Date().toISOString().split('T')[0];
const anneeToday = new Date().toISOString().split('T')[0].split('-')[0];
const hourToday = new Date().toISOString().split('T')[1].split('.')[0];

sentences.innerHTML = '<li>Sélectionner un date dans le passé.</li>';

calculer.addEventListener('click', () => {
    const dateDeN = dateN.value;
    // const dateDeND = dateDeN.split('T')[0];
    // const dateDeNH = dateDeN.split('T')[1];
    // const dateDeNDAnnee = dateDeND.split('-')[0];
    // const dateDeNDMois = dateDeND.split('-')[1];
    // const dateDeNDJour = dateDeND.split('-')[2];
    const dateDeNA = new Date(dateDeN);
    const dateDeNT = new Date(dateDeN).toLocaleString();
    const dateND = new Date(dateDeN).toLocaleDateString();
    const dateNT = new Date(dateDeN).toLocaleTimeString();

    const anneeNaissance = dateDeNA.getFullYear();
    const moisNaissance = dateDeNA.getMonth() + 1;
    const jourNaissance = dateDeNA.getDate();
    
    let nbAnnees = anneeToday - anneeNaissance;
    let signeAtro = '';
    
    if (dateDeN > dateToday || dateDeN == '') {
        sentences.innerHTML = '<li>Vous devez sélectionner une date valide, ou une date dans le passé!</li>';
    }
    else {
        sentences.innerHTML = '<li>Vous êtes né le <span class="colorBlue">' + dateND + '</span> à <span class="colorBlue">' + dateNT + '</span>.</li>';
        sentences.innerHTML += '<li>Il s\'est écoulé ' + nbAnnees + ' année(s) depuis votre naissance.</li>';
        
        sentences.innerHTML += '<hr>';
        
        if ((jourNaissance >= 20 && moisNaissance == 1) || (jourNaissance <= 18 && moisNaissance == 2)) {
            signeAstro = "Verseau";
        }

        sentences.innerHTML += '<li>Votre signe astrologique : <span class:"colorBlue">' + signeAtro + '</span>.</li>';

    }
});

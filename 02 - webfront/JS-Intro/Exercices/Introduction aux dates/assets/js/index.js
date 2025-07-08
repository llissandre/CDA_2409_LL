const dateN = document.querySelector('#dateN');
const calculer = document.querySelector('#calculer');
const sentencesDateDuJour = document.querySelector('#sentence');
const dateToday = new Date().toISOString().split('T')[0];
const anneeToday = new Date().toISOString().split('T')[0].split('-')[0];

sentencesDateDuJour.innerHTML = '<li>Sélectionner un date dans le passé.</li>';

const astro = () => {
    const dateDeN = dateN.value;
    const dateDeNA = new Date(dateDeN);

    const dateND = new Date(dateDeN).toLocaleDateString();
    const dateNT = new Date(dateDeN).toLocaleTimeString();

    const anneeNaissance = dateDeNA.getFullYear();
    const moisNaissance = dateDeNA.getMonth() + 1;
    const jourNaissance = dateDeNA.getDate();

    let nbAnnees = anneeToday - anneeNaissance;
    let signeAstro = '';

    if (dateDeN > dateToday || dateDeN == '') {
        sentencesDateDuJour.innerHTML = '<li>Vous devez sélectionner une date valide, ou une date dans le passé!</li>';
    }
    else {
        sentencesDateDuJour.innerHTML = '<li>Vous êtes né le <span class="colorBlue">' + dateND + '</span> à <span class="colorBlue">' + dateNT + '</span>.</li>';
        sentencesDateDuJour.innerHTML += '<li>Il s\'est écoulé ' + nbAnnees + ' année(s) depuis votre naissance.</li>';

        sentencesDateDuJour.innerHTML += '<hr>';

        if ((jourNaissance >= 20 && moisNaissance == 1) || (jourNaissance <= 18 && moisNaissance == 2)) {
            signeAstro = "verseau";
        }
        else if ((jourNaissance >= 19 && moisNaissance == 2) || (jourNaissance <= 20 && moisNaissance == 3)) {
            signeAstro = "poisson";
        }
        else if ((jourNaissance >= 21 && moisNaissance == 3) || (jourNaissance <= 19 && moisNaissance == 4)) {
            signeAstro = "bélier";
        }
        else if ((jourNaissance >= 20 && moisNaissance == 4) || (jourNaissance <= 20 && moisNaissance == 5)) {
            signeAstro = "taureau";
        }
        else if ((jourNaissance >= 21 && moisNaissance == 5) || (jourNaissance <= 20 && moisNaissance == 6)) {
            signeAstro = "gémeau";
        }
        else if ((jourNaissance >= 21 && moisNaissance == 6) || (jourNaissance <= 22 && moisNaissance == 7)) {
            signeAstro = "cancer";
        }
        else if ((jourNaissance >= 23 && moisNaissance == 7) || (jourNaissance <= 22 && moisNaissance == 8)) {
            signeAstro = "lion";
        }
        else if ((jourNaissance >= 23 && moisNaissance == 8) || (jourNaissance <= 22 && moisNaissance == 9)) {
            signeAstro = "vierge";
        }
        else if ((jourNaissance >= 23 && moisNaissance == 9) || (jourNaissance <= 22 && moisNaissance == 10)) {
            signeAstro = "balance";
        }
        else if ((jourNaissance >= 23 && moisNaissance == 10) || (jourNaissance <= 21 && moisNaissance == 11)) {
            signeAstro = "scorpion";
        }
        else if ((jourNaissance >= 22 && moisNaissance == 11) || (jourNaissance <= 21 && moisNaissance == 12)) {
            signeAstro = "sagittaire";
        }
        else if ((jourNaissance >= 22 && moisNaissance == 12) || (jourNaissance <= 19 && moisNaissance == 1)) {
            signeAstro = "capricorne";
        }

        sentencesDateDuJour.innerHTML += '<li>Votre signe astrologique : <span class="colorBlue">' + signeAstro + '</span>.</li>';

    }
};


calculer.addEventListener('click', astro)

// Rappel des différents types de données
let string = 'Chaine'; /* typeof string */
let number = 25; /* typeof number */
let boolean = true; /* typeof boolean, true ou false */
let maVariable; /* typeof undefined */
let maVariable2 = null; /* typeof object */

let array = ['Bordeaux', 'Toulouse', 'Nantes'];
// console.log(array[0][3]);
let array2 = ['Bordeaux', 24, true, [1, 2], { nom: 'Denis' }];
// console.log(array2[4].nom);

let object = {
    pseudo: 'Denis',
    age: 33,
    technos: ['JavaScript', 'React', 'NodeJS'],
    admin: false
};
// object.adresse = '22 rue du code';
// console.log(object);

let data = [
    {
        pseudo: 'Denis',
        age: 33,
        technos: ['JavaScript', 'React', 'NodeJS'],
        admin: false
    },
    {
        pseudo: 'Samia',
        age: 24,
        technos: ['CSS', 'React', 'NodeJS'],
        admin: false
    },
    {
        pseudo: 'Nikola',
        age: 42,
        technos: ['PHP', 'React', 'NodeJS'],
        admin: true
    }
];
// console.log(data[2].pseudo[0]);


///----------------------------
/// Les structures de contrôle
///----------------------------

/* if, else */
if (data[0].age > data[1].age) {
    // console.log(data[0].pseudo + ' est plus âgé.e que ' + data[1].pseudo);
}
else {
    /* valeur si faux */
}

/* while */
let w = 0;

while (w < 10) {
    w++;
    // console.log('La valeur de w est ' + w);
}

/* do while */
let dw = 0;

do {
    dw++;
    // console.log('La valeur de dw est ' + dw);
} while (dw < 10);

/* for */
for (let user of data) {
    // document.body.innerHTML += `<li>${user.pseudo} - ${user.age} ans</li>`;
}

for (i = 0; i < data.length; i++) {
    // console.log(data[i].technos[0]);
    // document.body.innerHTML += `<h2>${data[i].pseudo} - ${data[i].age} ans</h2>`;
}

/* switch */
document.body.addEventListener('click', (e) => {
    // console.log(e.target.id);

    switch (e.target.id) {
        case 'javascript': document.body.style.background = 'yellow';
            break;
        case 'php': document.body.style.background = 'violet';
            break;
        case 'python': document.body.style.background = 'blue';
            break;
        default: null;
    }
});
///------------------------------------------------

///----------------
/// Méthodes string
///----------------
let string2 = 'JavaScript est un langage orienté objet';

/* typeof */
// console.log(typeof '42');
/* eval */
/* parseInt */
// console.log(eval(parseInt('1')) + 2);
/* isNaN */
// console.log(isNaN(48));
/* .length*/
// console.log(string2.length);
/* indexOf */
// console.log(string2.indexOf('langage'));
/* .slice */
// let newString = string2.slice(2, 17)
// console.log(newString);
/* split */
// console.log(string2.split(' '));
/* toLowerCase*/
/* toUpperCase*/
/* replace */
///------------------------------------------------

///----------------
/// Méthodes number
///----------------
let number2 = 42.1234;
let numberString = '42.12 est un string';

/* toFixed */
// console.log(number.toFixed(2));
/* parseInt */
// console.log(parseInt('43'));
// console.log(parseInt(numberString));
/* parseFloat */
// console.log(parseFloat(numberString));
/* Math */
// console.log(Math.round(4.5));
// console.log(Math.floor(4.9));
// console.log(Math.ceil(4.1));
// console.log(Math.pow(4, 2)); /* équivalent à */console.log(4 ** 2);
// console.log(Math.sqrt(16));
// console.log(Math.floor(Math.random() * 51)); /* aléatoire de 0 à 50 */
///------------------------------------------------

///---------------
/// Méthodes array
///---------------
let mArray1 = ['JavaScript', 'PHP', 'Python'];
let mArray2 = ['Ruby', 'Solidity'];

/* concat */
// let newArray = mArray2.concat(mArray1);
// console.log(newArray);
/* ... */
// let newArray = [...mArray1, ...mArray2];
// console.log(newArray);
/* join */
// console.log(mArray1.join(' & '));
/* join */
// console.log(mArray1.slice(1));
// console.log(newArray.slice(2, 4));
/* indexOf */
// console.log(mArray1.indexOf('Python'));
/* forEach*/
// mArray1.forEach((language) => console.log(language));
/* every */
// console.log(mArray1.every((language) => language === 'PHP'));
/* some */
// console.log(mArray1.some((language) => language === 'PHP'));
/* shift */ /* permet de retirer le premier élément */
// let shift = mArray1.shift();
// console.log(shift);
// console.log(mArray1);
/* pop */ /* permet de retirer le dernier élément */
// let pop = mArray1.pop();
// console.log(pop);
// console.log(mArray1);
/* splice */
// console.log(mArray1);
// const restArray = mArray1.splice(1, 1, 'C++');
// console.log(mArray1);

//-------------------------------/*\---------------
//---------IMPORTANT-----------/*!!*\--------------
//---------------------------/*******\-------------
let arrayNumbers = [4, 74, 28, 12, 1, 6];
/* reduce */
// console.log(arrayNumbers.reduce((x, y) => x + y));
/* push */
arrayNumbers
    .push('Coucou');
// console.log(arrayNumbers);
arrayNumbers
    .push(17);
arrayNumbers
    .push('171');
// console.log(arrayNumbers);
/* filter, sort et map */
// console.log(arrayNumbers
// .filter((number) => number > 10));
// console.log(
// .sort());
// console.log(
// .sort((a, b) => b - a));
// console.log(
// .sort((a, b) => a - b));
// console.log(arrayNumbers
// .filter((number) => number > 10).sort((a, b) => a - b));
// mArray1.map((number) => console.log(number));
// arrayNumbers
// .map((number) => console.log(number));
// arrayNumbers
// .map((number) => document.body.innerHTML += `<li>${number}</li>`);
// document.body.innerHTML = arrayNumbers
//     .map((number) => '<li>' + number + '</li>')
//     .join('');
///------------------------------------------------

///-----------------
/// Méthodes object
///-----------------
// document.body.innerHTML = data
//     .filter((user) => user.admin === false)
//     .filter((user) => user.pseudo.includes('i'))
//     .filter((user) => user.age > 30)
//     .sort((a, b) => b.age - a.age)
//     .map((user) =>
//         `
//     <div class='user-card'>
// <h2>${user.pseudo}</h2>
// <p>${user.age} ans</p>
// <p>Technologies maitrisées : ${user.technos}</p>
// <p>Statut : ${user.admin ? 'Modérateur' : 'Utilisateur'}</p>
// </div>
// `
//     )
//     .join('');
// `).join(' -------- ');
///------------------------------------------------

///-----------
/// Les dates
///-----------

/* Date classique */
let date = new Date();

/* Timestamp */
let timestamp = Date.parse(date);
// console.log(timestamp);

/* toISOString */
let iso = date.toISOString();
// console.log(date.toISOString());


function dateParsee(chaine) {
    let newDate = new Date(chaine).toLocaleDateString('fr-FR', {
        year: 'numeric',
        month: 'long',
        day: 'numeric',
        hour: 'numeric',
        minute: 'numeric'
    });

    return newDate;
}

// console.log(dateParsee(date));
// console.log(dateParsee(timestamp));
// console.log(dateParsee(iso));
///------------------------------------------------

///------------------
/// Le destructuting
///------------------
let moreData = {
    destVar: ['Element1', 'Element2']
};

const { destVar } = moreData;

// console.log(moreData.destVar);
// console.log(destVar);

let array5 = [10, 45, 85];
let [x, y, z] = array5;
// console.log(x);
// console.log(y);
// console.log(z);

// console.log(iso);

const dateDestructuring = (chaine) => {
    let newDate = chaine.split('T')[0];
    let [y, m, d] = newDate.split('-');
    return [d, m, y].join('/');
};

// console.log(dateDestructuring(iso));
///------------------------------------------------

///--------------
/// Les datasets
///--------------
const h3js = document.getElementById('javascript');
// console.log(h3js.dataset.lang);

const h3 = document.querySelectorAll('h3');
// h3.forEach((language) => console.log(language.dataset.lang));
///------------------------------------------------

///------------------------------------
/// Les regex - expressions régulières
///------------------------------------
let mail = 'llissandre123@ici.fr';
// console.log(mail.search('ici'));

// console.log(mail.replace('ici', 'neuf'));
// console.log(mail.replace(/ici/, 'neuf'));
// console.log(mail.match(/LISS/i));
// console.log(mail.match(/[123]/));

/* matcher tous les chiffres */
// console.log(mail.match(/\d/));

/* matcher toutes les lettres */
// console.log(mail.match(/[a-z]/));

/* matcher tous les caractères */
// console.log(mail.match(/\w/));

// console.log(mail.match(/^[\w_-]+@[\w-]+\.[a-z]{2,4}$/i));

// let separator = 265264849;
// console.log(separator.toString().replace(/\B(?=(\d{3})+(?!\d))/g, ' '));

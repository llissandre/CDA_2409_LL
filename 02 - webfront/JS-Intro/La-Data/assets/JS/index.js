// Rappel des différents types de données
let string = 'Chaine'; /* typeof string */
let number = 25; /* typeof number */
let boolean = true; /* typeof boolean, true ou false */
let maVariable; /* typeof undefined */
let maVariable2 = null; /* typeof object */

// Les tableaux
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


//---------------------------
// Les structures de contrôle
//---------------------------

/* if, else */
if (data[0].age > data[1].age) {
    // console.log(data[0].pseudo + ' est plus âgé.e que ' + data[1].pseudo);
}
else {
    // valeur si faux
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
    console.log(e.target.id);

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


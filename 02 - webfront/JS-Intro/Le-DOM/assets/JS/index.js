// Sélecteurs

// document.querySelector('h4').style.background = 'yellow';
// const balisehTML = document.querySelector('h4');
// console.log(balisehTML);
// balisehTML.style.background = 'yellow'


// Click event
const questionContainer = document.querySelector('.click-event');
const btn1 = document.querySelector('#btn1');
const btn2 = document.getElementById('btn2');
const response = document.querySelector('p');

questionContainer.addEventListener('click', () => {
    // questionContainer.classList.add('question-clicked')
    questionContainer.classList.toggle('question-clicked')
});

btn1.addEventListener('click', () => {
    response.classList.add('show-response');
    response.style.background = 'green'
});

btn2.addEventListener('click', () => {
    response.classList.add('show-response');
    response.style.background = 'red'
});

// ------------------------------------------------------------------------------------------------------


// Mouse events
const mousemove = document.querySelector('.mousemove');

window; addEventListener('mousemove', (e) => {
    // console.log(e);
    mousemove.style.left = e.pageX + 'px';
    mousemove.style.top = e.pageY + 'px';
});

window.addEventListener('mousedown', () => {
    // console.log('test');
    mousemove.style.transform = 'scale(2) translate(-25%, -25%)';
});

window.addEventListener('mouseup', () => {
    // console.log('test');
    mousemove.style.transform = 'scale(1) translate(-50%, -50%)';
    mousemove.style.border = '2px solid teal';
});

questionContainer.addEventListener('mouseenter', () => {
    questionContainer.style.background = 'rgba(0,0,0,0.6)';
});

questionContainer.addEventListener('mouseout', () => {
    questionContainer.style.background = '#2f2f2f';
});

response.addEventListener('mouseover', () => {
    response.style.transform = 'rotate(2deg)';
});

// ------------------------------------------------------------------------------------------------------


// Keypress event
const keypressContainer = document.querySelector('.keypress');
const key = document.getElementById('key');
const ring = (key) => {
    const audio = new Audio();
    // audio.src = './assets/sound/Enter.mp3';
    audio.src = './assets/sound/' + key + '.mp3';
    audio.play();
}

document.addEventListener('keypress', (e) => {
    key.textContent = e.key;

    if (e.key === 'j') {
        keypressContainer.style.background = 'green';
    }

    else if (e.key === 'h') {
        keypressContainer.style.background = 'teal';
    }

    else if (e.key === 'Enter') {
        keypressContainer.style.background = 'brown';
    }

    else {
        keypressContainer.style.background = 'black';
    }

    if (e.key === 'Enter') {
        ring(e.key);
    }
});

// ------------------------------------------------------------------------------------------------------


// Scroll event
const nav = document.querySelector('nav');

window.addEventListener('scroll', () => {
    if (window.scrollY > 120) {
        nav.style.top = 0;
    }
    else {
        nav.style.top = '-50px';
    }
});

// ------------------------------------------------------------------------------------------------------


// Form event
const inputName = document.querySelector('input[type="text"]');
const select = document.querySelector('select');
const form = document.querySelector('form');
let pseudo = "";
let language = "";

inputName.addEventListener('input', (e) => {
    pseudo = e.target.value;
})

select.addEventListener('input', (e) => {
    language = e.target.value;
});

form.addEventListener('submit', (e) => {
    e.preventDefault();

    if (cgv.checked) {
        document.querySelector('form > div').innerHTML = `
            <h3>Pseudo : ${pseudo}</h3>
            <h4>Langage préféré : ${language}</h4>
        `;
    }
    else {
        alert('Veuillez accepter les CGV')
    }
});

// ------------------------------------------------------------------------------------------------------


// Load event

window.addEventListener('load', () => {
    console.log('Document chargé !');

})

// ------------------------------------------------------------------------------------------------------


// Foreach
// const boxes = document.getElementsByClassName('box');
const boxes = document.querySelectorAll('.box');

boxes.forEach(box => {
    box.addEventListener('click', (e) => e.target.style.transform = 'scale(0.7)');
});

// ------------------------------------------------------------------------------------------------------


// addEventListener vs onclick 
// document.body.onclick = function () {
// console.log('scroll !');
// };

// bubling
document.body.addEventListener(
    'click',
    () => {
        console.log('click 1 !');
    },
    false
);

// Usecapture
document.body.addEventListener(
    'click',
    () => {
        console.log('click 2 !');
    },
    true
);

// ------------------------------------------------------------------------------------------------------


// stopPropagation, removeEventListener
// questionContainer.addEventListener('click', (e) => {
//     alert('Test !');
//     e.stopPropagation();
// });

// ------------------------------------------------------------------------------------------------------


// Le BOM

// console.log(window.innerHeight);
// console.log(window.scrollY);

// window.open("http://google.com", "Cours JS", "height=50", "width=50");
// window.close();

/* Evènement adossé à window */
// alert('Hello !');

/* confirm */
btn2.addEventListener('click', () => {
    confirm("Voulez-vous vraiment faire ce choix ?");
});

/* prompt */
btn1.addEventListener('click', () => {
    prompt("Entrez votre nom !");
});

/* Timer, compte à rebour*/
setTimeout(() => {
    /* logique à exécuter */
    questionContainer.style.borderRadius = '300px';
}, 2000);

// let interval = setInterval(() => {
//     document.body.innerHTML +=
//         "<div class='box'><h2>Nouvelle boite !</h2></div>";
// }, 1000);

// document.body.addEventListener('click', (e) => {
//     // e.target.remove();

//     clearInterval(interval);
// });

/* Location */
// console.log(location.href);
// console.log(location.host);
// console.log(location.pathname);
// console.log(location.search);
// location.replace('http://lequipe.fr')

// window.onload = () => {
//     location.href = 'http://twitter.fr';
// };

/* Navigator */
console.log(navigator.userAgent);
// https://developer.mozilla.org/fr/docs/Web/API/Geolocation/getCurrentPosition

/* History*/
console.log(history);
window.history.back();
history.go(-2);

// ------------------------------------------------------------------------------------------------------


// setProperty
window.addEventListener('mousemove', (e) => {
    nav.style.setProperty('--x', e.layerX + 'px');
    nav.style.setProperty('--y', e.layerY + 'px');
});


// ------------------------------------------------------------------------------------------------------
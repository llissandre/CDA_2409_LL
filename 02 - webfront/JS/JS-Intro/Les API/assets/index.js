// XMLHttpRequest
function reqListener() {
    // console.log(this.responseText);
}

let req = new XMLHttpRequest();
req.onload = reqListener
// req.open("get", "./assets/data.txt", true);
// req.open("get", "./assets/data.json", true);
req.open("get", "https://api.blablagues.net/?rub=blagues", true);
req.send();

//----------
// FETCH
//----------

/* fetch théorique */
// fetch("mon-url", "objet d'options")
//     .then((response) => {
//         //response
//         // console.log(response);

//     })
//     .catch((err) => console.log(err));

fetch('./assets/data.txt')
    .then((res) => res.text())
// .then((data) => console.log(data));

fetch('./assets/data.json')
    .then((res) => res.json())
// .then((data) => console.log(data));

const myHeader = new Headers();

const init = {
    method: 'GET',
    headers: myHeader,
    mode: 'cors',
    cache: 'default'
};

// fetch('./assets/data.json', init).then((res) => console.log(res));

// CRUD : Create(POST), Read(GET), Update(PUT), Delete(DELETE)
// API : Application Programming Interface
// CORS : Cross-Origin Resource Sharing

const init2 = {
    method: 'POST',
    headers: {
        'Content-Type': 'application/json'
    },
    body: JSON.stringify({
        pseudo: 'toto',
        age: 25
    }),
    mode: 'cors',
    cache: 'default',
    credentials: 'same-origin'
};

// const init3 = {
//     method: 'DELETE',
//     headers: {
//         'Content-Type': 'application/json'
//     },
// body: JSON.stringify({
//     pseudo: 'toto',
//     age: 25
// }),
//     mode: 'cors',
//     cache: 'default',
//     credentials: 'same-origin'
// };


document.querySelector('form').addEventListener('submit', () => {
    // fetch('http://localhost:3000/posts', init2).then(() => {
    fetch('http://localhost:3000/users', init2).then(() => {
        // console.log('POST OK');
    });
});


// --------------
// Asynchrone
// --------------

setTimeout(() => {
    //     console.log('Je suis un setTimeout');
}, 2000);

// Promise
fetch('lien').then((res) => {
    // console.log('Je suis une promesse');
});
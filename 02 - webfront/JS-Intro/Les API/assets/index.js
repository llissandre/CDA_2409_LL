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
    .then((data) => console.log(data));


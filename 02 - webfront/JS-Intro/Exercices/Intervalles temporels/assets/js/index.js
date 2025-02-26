const dateInput = document.querySelector('#date');
const timeInput = document.querySelector('#time');
const afficher = document.querySelector('#afficher');
const dateToday = new Date().toISOString().split('T')[0];
const timeToday = new Date().toISOString().split('T')[1].split('.')[0];
const sentences = document.querySelector('#sentence');

afficher.addEventListener('click', () => {
    dateInput.value = dateToday;
    let dateAujourdhui = new Date(dateToday).toLocaleDateString();
    timeInput.value = timeToday;
    console.log(dateInput.value);
    sentences.innerHTML += '<hr>';
    sentences.innerHTML += '<li>Aujourd\'hui, nous sommes le <span class="colorBlue">' + dateAujourdhui + '</span>, l\'heure courante est : <span class="colorBlue">' + timeToday + '</span> .</li>';
    sentences.innerHTML += '<hr>';
});
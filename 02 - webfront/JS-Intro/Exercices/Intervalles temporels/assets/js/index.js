const currentdateInput = document.querySelector('#currentdate');
const intervalledate = document.querySelector('#intervalledate');
const currenttimeInput = document.querySelector('#currenttime');
const afficher = document.querySelector('#afficher');
const calculerIntervalle = document.querySelector('#calculerIntervalle');
const dateTodayLongue = new Date();
const dateToday = new Date().toISOString().split('T')[0];
const timeToday = new Date().toISOString().split('T')[1].split('.')[0];
const sentencesCurrentdate = document.querySelector('#sentenceCurrentdate');
const sentencesIntervalledate = document.querySelector('#sentenceIntervalledate');

const dateDuJour = () => {
    currentdateInput.value = dateToday;
    let currentdate = new Date(dateToday).toLocaleDateString();
    // console.log(currentdateInput.value);
    // console.log(dateToday);
    currenttimeInput.value = timeToday;
    sentencesCurrentdate.innerHTML += '<hr>';
    sentencesCurrentdate.innerHTML += '<li>Aujourd\'hui, nous sommes le <span class="colorBlue">' + currentdate + '</span>, l\'heure courante est : <span class="colorBlue">' + timeToday + '</span> .</li>';
};


calculerIntervalle.addEventListener('click', () => {
    const intervalledateValue = intervalledate.value;
    const intervalledateLongue = new Date(intervalledateValue);
    const intervalledateD = new Date(intervalledateValue).toLocaleDateString();
    const intervalledateT = new Date(intervalledateValue).toLocaleTimeString();
    const annee = intervalledateLongue.getFullYear();
    const mois = intervalledateLongue.getMonth() + 1;
    const jour = intervalledateLongue.getDate();
    const heure = intervalledateLongue.getHours();
    const minute = intervalledateLongue.getMinutes();

    let difference = Math.abs(intervalledateLongue - dateTodayLongue);
    let intervalle = Math.round(difference / (1000 * 60 * 60 * 24));

    sentencesIntervalledate.innerHTML = '<li>Il y a ' + intervalle + ' jour(s) entre aujourd\'hui et le <span class="colorBlue">' + intervalledateD + ' à ' + intervalledateT + '</span> .</li>';
});

afficher.addEventListener('click', dateDuJour);

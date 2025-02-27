const currentdateInput = document.querySelector('#currentdate');
const currenttimeInput = document.querySelector('#currenttime');
const intervalledate = document.querySelector('#intervalledate');
const afficher = document.querySelector('#afficher');
const calculerIntervalle = document.querySelector('#calculerIntervalle');
const sentencesCurrentdate = document.querySelector('#sentenceCurrentdate');
const sentencesIntervalledate = document.querySelector('#sentenceIntervalledate');
// const dateToday = new Date().toISOString().split('T')[0];
// const timeToday = new Date().toISOString().split('T')[1].split('.')[0];

const dateDuJour = () => {
    const currentdate = new Date().toLocaleDateString();
    const dateToday = currentdate.replace(/(\d+)\/(\d+)\/(\d+)/, "$3-$2-$1");
    const currenttime = new Date().toLocaleTimeString();

    currentdateInput.value = dateToday;
    currenttimeInput.value = currenttime;

    sentencesCurrentdate.innerHTML = '';

    // sentencesCurrentdate.innerHTML = '<hr>';
    let hr = document.createElement('hr');
    sentencesCurrentdate.append(hr);

    let monitem = document.createElement("li");
    monitem.setAttribute('id', 'display');
    monitem.innerHTML += 'Aujourd\'hui, nous sommes le <span class="colorBlue">' + currentdate + '</span>, l\'heure courante est : <span class="colorBlue">' + currenttime + '</span>.';
    sentencesCurrentdate.append(monitem);
};

const lintervalle = () => {
    const intervalledateV = intervalledate.value;
    const intervalledateL = new Date(intervalledateV);
    const intervalledateD = new Date(intervalledateV).toLocaleDateString();
    const dateToday = intervalledateD.replace(/(\d+)\/(\d+)\/(\d+)/, "$3-$2-$1");
    console.log(dateToday);
    
    const intervalledateT = new Date(intervalledateV).toLocaleTimeString();

    const mois = ['janvier', 'février', 'mars', 'avril', 'mai', 'juin', 'juillet', 'août', 'septembre', 'octobre', 'novembre', 'décembre'];

    let difference = Math.abs(intervalledateL - (new Date()));
    let jours = Math.floor(difference / (1000 * 60 * 60 * 24));
    difference -= (jours * 1000 * 60 * 60 * 24);
    let heures = Math.floor(difference / 3600000);
    difference -= (heures * 1000 * 60 * 60);
    let minutes = Math.floor(difference / 60000);

    sentencesIntervalledate.innerHTML = '';

    const monitem = document.createElement("li");
    monitem.setAttribute('id', 'display');
    monitem.innerHTML = 'Il y a ' + jours + ' jour(s) entre aujourd\'hui et le <span class="colorBlue">' + intervalledateD + ' à ' + intervalledateT + '</span>.';
    sentencesIntervalledate.append(monitem);

    // sentencesIntervalledate.innerHTML = '<li>Il y a ' + jours + ' jour(s) entre aujourd\'hui et le <span class="colorBlue">' + intervalledateD + ' à ' + intervalledateT + '</span>.</li>';

    if (intervalledateV == '') {
        sentencesIntervalledate.innerHTML = '';
    }
    else if (intervalledateL < (new Date())) {
        sentencesIntervalledate.innerHTML += '<li>Dans ' + jours + ' jour(s), ' + heures + ' heures et ' + minutes + ' minutes, nous seront le ' + intervalledateD + ' à ' + intervalledateT + '.</li>';
    }
    else if (intervalledateL > (new Date())) {
        sentencesIntervalledate.innerHTML += '<li>Il y a ' + jours + ' jour(s), ' + heures + ' heures et ' + minutes + ' minutes, nous serons le ' + intervalledateD + ' à ' + intervalledateT + '.</li>';
    }
};

afficher.addEventListener('click', dateDuJour);
calculerIntervalle.addEventListener('click', lintervalle);

let totalSeconds;
let interval;

form = document.getElementById('form');
choice = document.getElementById('choice');
countdownDisplay = document.getElementById('countdownDisplay');

function countDown() {
    const minutes = Math.floor(totalSeconds / 60);
    const seconds = totalSeconds % 60;

    let second = seconds < 10 ? '0' + seconds : seconds

    countdownDisplay.textContent = `${minutes} : ${second}`;
    // countdownDisplay.textContent = minutes + ' : ' + seconds;

    if (totalSeconds > 0) {
        totalSeconds--;
    }
    else {
        countdownDisplay.textContent = 'C\'est terminé !';
        clearInterval(interval);
    }
}

form.addEventListener(('submit'), (e) => {
    e.preventDefault();

    if (isNaN(choice.value)) {
        alert('Veuillez ne pas saisir de lettre')
    }
    else if (choice.value === '') {
        alert('Veuillez saisir un nombre !')
    }
    else {
        totalSeconds = choice.value * 60;
        choice.value = '';
        clearInterval(interval);
        interval = setInterval(countDown, 1000);
    }
});
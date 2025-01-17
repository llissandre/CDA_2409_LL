const inputs = document.querySelectorAll(
    'input[type="text"], input[type="email"], input[type="password"]'
);
const form = document.querySelector('form');
const progressBar = document.getElementById('progress-bar');
let pseudo, email, password, confirmPassword;

const errorDisplay = (tag, message, valid) => {
    const container = document.querySelector("." + tag + "-container");
    const span = document.querySelector("." + tag + "-container > span");

    if (!valid) {
        container.classList.add("error");
        span.textContent = message;
    }
    else {
        container.classList.remove("error");
        span.textContent = message;
    }
}

const pseudoChecker = (value) => {
    if (value.length > 0 && (value.length < 3 || value.length > 20)) {
        errorDisplay('pseudo', 'Le pseudo doit faire entre 3 et 20 caractères');
        pseudo = null;
    }
    else if (!value.match(/^[a-zA-Z0-9_.-]*$/)) {
        errorDisplay('pseudo', 'Le pseudo ne doit pas contenir de caractères spéciaux');
        pseudo = null;
    }
    else {
        errorDisplay('pseudo', '', true);
        pseudo = value;
    }
};

const emailChecker = (value) => {
    if (!value.match(/^[\w_-]+@[\w-]+\.[a-z]{2,4}$/i)) {
        errorDisplay('email', 'Le mail n\'est pas valide');
        email = null;
    }
    else {
        errorDisplay('email', '', true);
        email = value;
    }
};

const passwordChecker = (value) => {
    progressBar.classList = '';

    if (!value.match(/^(?=.*?[A-Z])(?=(.*[a-z]){1,})(?=(.*[\d]){1,})(?=(.*[\W]){1,})(?!.*\s).{8,}$/)) {
        errorDisplay('password', 'Le mot de passe n\'est pas valide');
        progressBar.classList.add('progressRed')
        password = null;
    }
    else if (value.length < 12) {
        errorDisplay('password', '', true);
        progressBar.classList.add('progressBlue')
        password = value;
    }
    else {
        errorDisplay('password', '', true);
        progressBar.classList.add('progressGreen')
        password = value;
    }

    if (confirmPassword) {
        confirmChecker(confirmPassword)
    }
};

const confirmChecker = (value) => {
    if (value != password) {
        errorDisplay('confirm', 'Les mots de passe ne sont pas identiques');
        confirmPassword = false;
    }
    else {
        errorDisplay('confirm', '', true);
        confirmPassword = true;
    }
};

inputs.forEach((input) => {
    input.addEventListener(('input'), (e) => {
        switch (e.target.id) {
            case "pseudo": pseudoChecker(e.target.value);
                break;

            case "email": emailChecker(e.target.value);
                break;

            case "password": passwordChecker(e.target.value);
                break;

            case "confirm": confirmChecker(e.target.value);
                break;
            default: null;
        }
    })
});

form.addEventListener('submit', (e) => {
    e.preventDefault();

    if (pseudo && email && password && confirmPassword) {
        const data = {
            pseudo,
            email,
            password
        }

        inputs.forEach((input) => input.value = '');
        progressBar.classList.remove('progressBlue');
        progressBar.classList.remove('progressgreen');

        pseudo = null;
        email = null;
        password = null;
        confirmPassword = null;

        alert('Inscription validée !')
    }
    else {
        alert('Veuillez remplir tous les champs')
    }
});
generateButton = document.getElementById('generateButton');
const dataLowercase = 'abcdefghijklmnopqrstuvwxyz';
const dataUppercase = dataLowercase.toLocaleUpperCase();
const dataNumbers = '0123456789';
const dataSymbols = '$^ù*"\'&=*.?;:*+-()';
const rangeValue = document.getElementById('password-length');
const passwordOutput = document.getElementById('password-output');

function generatePassword() {
    let data = [];
    let password = '';

    if (lowercase.checked) data.push(...dataLowercase);
    if (uppercase.checked) data.push(...dataUppercase);
    if (numbers.checked) data.push(...dataNumbers);
    if (symbols.checked) data.push(...dataSymbols);

    if (data.length === 0) {
        alert('Veuillez sélectionner des critères !');
        return;
    }

    for (i = 0; i < rangeValue.value; i++) {
        password += data[Math.floor(Math.random() * data.length)];
    }

    passwordOutput.value = password;
    passwordOutput.select();
    navigator.clipboard.writeText(passwordOutput.value);

    generateButton.textContent = 'mot de passe copié !';

    setTimeout(() => {
        generateButton.textContent = 'Générer le mot de passe';
    }, 2000);
}

generateButton.addEventListener('click', () => {
    generatePassword();
});

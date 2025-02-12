const target = document.getElementById('target');
let array = ['développeur', 'photographe', 'créatif'];
let wordIndex = 0;
let letterIndex = 0;

const createLetter = () => {
    const letter = document.createElement('span');
    target.appendChild(letter);

    letter.textContent = array[wordIndex][letterIndex];

    setTimeout(() => {
        letter.remove();
    }, 2800);
};

const loop = () => {
    setTimeout(() => {
        if (wordIndex >= array.length) {
            wordIndex = 0;
        }

        if (letterIndex < array[wordIndex].length) {
            createLetter();
            letterIndex++;
            loop();
        }
        else {
            wordIndex++;
            letterIndex = 0;
            setTimeout(() => {
                loop();
            }, 2800);
        }
    }, 100);
};

loop();


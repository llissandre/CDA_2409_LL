// https://api.blablagues.net/?rub=blagues

const header = document.getElementById('header');
const content = document.getElementById('content');

function getJoke() {
    fetch('https://api.blablagues.net/?rub=blagues')
        .then((res) => res.json())
        .then((data) => {
            const donnee = data.data.content;

            header.textContent = donnee.text_head;
            content.textContent = donnee.text !== ""
                ? donnee.text
                : donnee.text_hidden;
        });
}

getJoke();

document.body.addEventListener('click', () => getJoke());
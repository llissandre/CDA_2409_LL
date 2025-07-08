// https://api.blablagues.net/?rub=blagues

const header = document.getElementById('header');
const text = document.getElementById('text');

function getJoke() {
    fetch('https://api.blablagues.net/?rub=blagues')
        .then((res) => res.json())
        // { data } destructuring de data.data
        .then(({ data }) => {
            // { content } destructuring de content.data.data
            const { content } = data;

            header.textContent = content.text_head;
            text.textContent = content.text !== ""
                ? content.text
                : content.text_hidden;
        });
}

getJoke();

document.body.addEventListener('click', getJoke);
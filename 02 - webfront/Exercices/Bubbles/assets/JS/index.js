const counterDisplay = document.querySelector('h3');
let counter = 0;

const bubblemaker = () => {
    const bubble = document.createElement('span');
    const size = Math.random() * 200 + 50 + 'px';
    const plusMinus = Math.random() > 0.5 ? 1 : 1;

    bubble.classList.add('bubble');
    document.body.appendChild(bubble);

    bubble.style.height = size;
    bubble.style.width = size;

    bubble.style.top = Math.random() * 100 + 50 + '%';
    bubble.style.left = Math.random() * 100 * plusMinus + '%';
    bubble.style.setProperty('--left', Math.random() * 100 * plusMinus + '%');

    bubble.addEventListener('click', () => {
        counter++;
        counterDisplay.textContent = counter;
        bubble.remove();
    });

    setTimeout(() => bubble.remove(), 8000);
};

setInterval(bubblemaker, 1000);
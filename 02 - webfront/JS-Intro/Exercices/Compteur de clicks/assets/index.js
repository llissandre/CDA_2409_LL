const btnajout = document.querySelector('#btnajout');
const btnreinitialiser = document.querySelector('#btnreinitialiser');
const span = document.querySelector('span');


btnajout.addEventListener('click', function () {
    let nbclick = Number(span.textContent);
    nbclick += 1;
    span.textContent = nbclick;
});

btnreinitialiser.addEventListener('click', () => {
    span.textContent = 0;
});
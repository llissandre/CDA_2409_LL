const btnajout = document.querySelector('#btnajout');
const btnreinitialiser = document.querySelector('#btnreinitialiser');
const span = document.querySelector('span');


btnajout.addEventListener('click', function () {
    let nbclick = Number(document.querySelector('span').textContent);
    span.textContent = nbclick + 1;
    document.querySelector('span').textContent = nbclick + 1;
});

btnreinitialiser.addEventListener('click', function () {
    document.querySelector('span').textContent = 0;
});
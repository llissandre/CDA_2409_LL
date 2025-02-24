const btnajout = document.querySelector('#btnajout');
const btnreinitialiser = document.querySelector('#btnreinitialiser');
const span = document.getElementsByTagName('span');

btnajout.addEventListener('click', function () {
    let nbclick = Number(document.querySelector('span').textContent);
    document.querySelector('span').textContent = nbclick + 1;
});

btnreinitialiser.addEventListener('click', function () {
    let nbclick = Number(document.querySelector('span').textContent);
    document.querySelector('span').textContent = 0;
});
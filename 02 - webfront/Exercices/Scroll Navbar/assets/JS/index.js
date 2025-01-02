const nav = document.querySelector('nav');
let levelScroll = 0;

window.addEventListener('scroll', () => {

    if (window.scrollY > levelScroll) {
        nav.style.top = '-60px';
    }
    else {
        nav.style.top = 0;
    }

    levelScroll = window.scrollY;
});
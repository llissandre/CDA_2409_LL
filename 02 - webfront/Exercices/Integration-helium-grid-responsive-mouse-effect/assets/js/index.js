// Créer 3 ronds de tailles différentes (dont un qui remplacera la souris)
// const circle1 = document.createElement('span');
// const circle2 = document.createElement('span');
// const circle3 = document.createElement('span');
const circles = document.querySelectorAll('.circle');

// circle1.classList.add('circle');
// circle2.classList.add('circle');
// circle3.classList.add('circle');

// circle1.id = 'circle1';
// circle2.id = 'circle2';
// circle3.id = 'circle3';

// document.body.appendChild(circle1);
// document.body.appendChild(circle2);
// document.body.appendChild(circle3);

// Ajouter un événement sur la fenetre(window) puis animer la position de ces ronds(top, left injecter "e")

// window.addEventListener('mousemove', (e) => {
//     circle1.style.top = e.pageY + 'px';
//     circle1.style.left = e.pageX + 'px';

//     circle2.style.top = e.pageY + 'px';
//     circle2.style.left = e.pageX + 'px';

//     circle3.style.top = e.pageY + 'px';
//     circle3.style.left = e.pageX + 'px';
// });

window.addEventListener('mousemove', (e) => {
    circles.forEach((circle) => {
        circle.style.top = e.pageY + 'px';
        circle.style.left = e.pageX + 'px';
    });
});

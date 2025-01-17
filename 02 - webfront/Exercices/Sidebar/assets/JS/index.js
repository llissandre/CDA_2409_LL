const btn = document.getElementById('btn');
const sidebar = document.getElementById('side-bar');
const content = document.querySelector('.content');

// Créer un événement au click sur le hamburger menu pour sortir la sidebar, ranger la sidebar si on reclique dessus
btn.addEventListener('click', () => {
    sidebar.classList.toggle('toggle-side-bar');
})

// Ranger la sidebar si on clique sur le contenu principal
content.addEventListener('click', () => {
    sidebar.classList.remove('toggle-side-bar');
})
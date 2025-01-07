let playOnce = true;

// Créer un événement au scroll
window.addEventListener('scroll', () => {

    // Réduire la navbar quand on descend, la remettre à sa taille initiale si on remonte tout en haut
    if (window.scrollY > 0) {
        navbar.style.height = 45 + 'px';
        navbar.style.transition = '0.5s'
    }

    else {
        navbar.style.height = 90 + 'px';
    }

    let scrollvalue = (window.scrollY + window.innerHeight) / document.body.offsetHeight;

    // Faire apparaitre l'image de la partie improvise
    if (scrollvalue > 0.45) {
        imgImprovise.style.transform = 'translateX(0)';
        imgImprovise.style.opacity = 1;
    }

    // Faire apparaitre la pop-up quand on est en-bas du site
    if (scrollvalue > 0.95 && playOnce) {
        popup.style.transform = 'translateX(0)';
        popup.style.opacity = 1;
        playOnce = false;
    }

    console.log(window.scrollY);

});

// Bonus : quand on clique sur la pop-up elle disparait pour toujours
closeBtn.addEventListener('click', () => {
    popup.style.transform = 'translateX(400px)';
    popup.style.opacity = 0;
})




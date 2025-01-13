function colorGenerator() {
    // Créer 3 variables pour stocker 3 chiffres aléatoires
    const r = Math.floor(Math.random() * 255);
    const g = Math.floor(Math.random() * 255);
    const b = Math.floor(Math.random() * 255);
    const color = `rgb(${r}, ${g}, ${b})`;

    // Donner au body la couleur de fond en rgb()
    document.body.style.backgroundColor = color;

    // Montrer sur le body la couleur rgb()
    // document.body.innerHTML = '<h2>' + color + '</h2>'
    document.body.innerHTML = `<h2>${color}</h2>`;

};

setInterval(colorGenerator, 2000);

// Ajouter sur DOM ce qui est tapé dans le form à la validation du form
const form = document.querySelector('form');

function storeTodoList() {
    window.localStorage.todoList = todolist.innerHTML;
}

function getTodos() {
    if (window.localStorage.todoList) {
        todolist.innerHTML = window.localStorage.todoList;
    }
    else {
        todolist.innerHTML = `<li>Cliquez sur un todo pour le supprimer</li>`;
    }
}

// Consulter le local storage au lancement de l'application pour rajouter les todos
window.addEventListener('load', getTodos());

form.addEventListener('submit', (e) => {
    e.preventDefault();
    todolist.innerHTML += `<li>${aFaire.value}</li>`;
    aFaire.value = '';
    // Stocker la liste dans le local storage
    storeTodoList();
})

todolist.addEventListener('click', (e) => {
    if (e.target.classList.contains('checked')) {
        // Supprimer un todo lorsque que l'on clique dessus
        e.target.remove();
        // Stocker la liste dans le local storage
        storeTodoList();
    }
    else {
        e.target.classList.add('checked');
    }
});




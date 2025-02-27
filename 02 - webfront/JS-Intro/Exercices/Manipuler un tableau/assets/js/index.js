const people = ['Mike Dev', 'John Makenzie', 'Léa Grande'];


for (let i = 0; i < people.length; i++) {

    let monItem = document.createElement("li");
    monItem.textContent = people[i];
    liste.appendChild(monItem);
}
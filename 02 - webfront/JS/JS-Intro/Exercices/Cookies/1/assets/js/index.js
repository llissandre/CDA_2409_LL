const people = ['Mike Dev', 'John Makenzie', 'Léa Grande'];

const liste = document.querySelector("#inscrit");

liste.setAttribute("style", "list-style:none; color:#ACCBE1");

document.body.style.backgroundColor = "#536B78";
document.body.style.color = "#ACCBE1";
document.querySelector("h1").setAttribute("style", "margin-left:50px; font-family:tahoma;text-transform:uppercase");

document.querySelector("#filet").setAttribute("style", "border:2px dashed #ACCBE1");

for (let i = 0; i < people.length; i++) {

    let monItem = document.createElement("li");
    monItem.setAttribute("style", "font-family:tahoma; font-size:1.6rem");
    monItem.textContent = people[i];
    liste.appendChild(monItem);

}

function CreerCookie(nomCookie, valeurCookie) {
    let datejour = new Date();

    let dateExpire = new Date(datejour.getFullYear(), datejour.getMonth(), datejour.getDate(), (datejour.getHours() + 2), datejour.getMinutes(), datejour.getSeconds())

    let dateExpireTest = dateExpire.toUTCString();
    document.cookie = nomCookie + "=" + valeurCookie + ";expires=" + dateExpireTest + ";SameSite=Strict";

}

const btnC = document.querySelector("#btnCookie");
btnC.addEventListener("click", function () {
    let user = document.querySelector("#username").value;
    CreerCookie("Nom", user);
    window.location.href = "./destination.html";

})
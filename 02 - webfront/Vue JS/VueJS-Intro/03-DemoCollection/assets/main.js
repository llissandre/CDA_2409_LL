// Présentation de VueJS : https://worldline.github.io/vuejs-training/fr/presentation/
// Prise en main de VueJS : https://cours.brosseau.ovh/tp/vuejs3/tp0.html

/**
 * Exercice "Tableau d'objets" VueJS
 * https://arfp.github.io/tp/web/javascript/01-intro/objects-2
 */

const appToto = {
    data() {
        return {
            listEmployees: []
        }
    },
    async created() {
        let response = await fetch('./data/Employees.json');
        let json = await response.json();
        console.log(json);
        this.listEmployees = json;
        console.log(this.listEmployees);

        for(let employee of this.listEmployees) {
            console.log(employee.firstname);
        }

        for(let employee in this.listEmployees) {
            console.log(employee);
        }
    }
}

Vue.createApp(appToto).mount('#app');
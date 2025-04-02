// Présentation de VueJS : https://worldline.github.io/vuejs-training/fr/presentation/
// Prise en main de VueJS : https://cours.brosseau.ovh/tp/vuejs3/tp0.html

/**
 * Exercice "Manipuler un Objet" VueJS
 * https://arfp.github.io/tp/web/javascript/01-intro/objects-1
 */

import { myEmployee } from './Employee.js';

const myApp = {
    data() {
        return {
            employee: myEmployee,
            newSalary: myEmployee.salary
        }
    },
    computed: {
        email() {
            return this.employee.firstname + '.' + this.employee.lastname + '@example.com';
        }
    },
    methods: {
        save() {
            if(this.newSalary > this.employee.salary) {
                this.employee.salary = this.newSalary;
            } else {
                alert('Le nouveau salaire doit être supérieur au salaire actuel');
            }
        }
    }
}

Vue.createApp(myApp).mount('#app');
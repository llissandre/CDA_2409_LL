// Présentation de VueJS : https://worldline.github.io/vuejs-training/fr/presentation/
// Prise en main de VueJS : https://cours.brosseau.ovh/tp/vuejs3/tp0.html

/**
 * Exercice "Compteur de clics" VueJS
 * https://arfp.github.io/tp/web/javascript/01-intro/
 */

const myApp = {
    data() {
        return {
            nbClics: 0
        }
    },
    methods: {
        incrementer() {
            this.nbClics++;
        },
        reinitialiser() {
            this.nbClics = 0;
        }
    }
}

Vue.createApp(myApp).mount('#app');
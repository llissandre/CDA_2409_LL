const appEvaluation = {
    data() {
        return {
            listEvaluations: [],
            failingGrade: 12,
            nbEtudiants: 0,
            avgClasse: 0,
            overAvg: 0,
            overAvgGrades: 0,
            usernameInput: '',
            grade: 0,
            fullname: '',
            regexUsername: /^[a-zA-Z-]{2,}$/
        }
    },
    async created() {
        try {
            let response = await fetch('./assets/json/eval.json');
            let json = await response.json();
            this.listEvaluations = json;
        }
        catch (error) {
            console.error('Un problème est survenu lors de la récupération :', error);
        }
    },
    computed: {
    },
    methods: {
        getLastname(fullname) {
            return fullname.split(' ')[0];
        },
        getFirstname(fullname) {
            return fullname.split(' ')[1];
        }
    }
}
Vue.createApp(appEvaluation).mount('#app');
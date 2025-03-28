const appEvaluation = {
    data() {
        return {
            listEvaluations: [],
            failingGrade: 12,
            nbEtudiants: 0,
            avgClasse: 0,
            overAvg: 0,
            overAvgGrades: 0,
            lastnameFirstnameInput: '',
            gradeInput: '',
            fullname: ''
        }
    },
    async created() {
        try {
            const response = await fetch('./assets/json/eval.json');
            const json = await response.json();
            this.listEvaluations = json;
        }
        catch (error) {
            console.error('Un problème est survenu lors de la récupération :', error);
        }
    },
    computed: {
        getNbEtudiants() {
            return this.nbEtudiants = this.listEvaluations.length;
        },
        getAvgClasse() {
            let sum = this.listEvaluations.reduce((sum, a) => sum + a.grade, 0);
            return this.avgClasse = (sum / this.listEvaluations.length).toFixed(2);
        },
        getNbStOverAvg() {
            return this.overAvg = this.listEvaluations.filter(a => a.grade >= 10).length;
        },
        getNbStOverAvgClasse() {
            return this.overAvgGrades = this.listEvaluations.filter(a => a.grade >= this.failingGrade).length;
        },
        getGradesSorted() {
            return this.listEvaluations.sort((a, b) => b.grade - a.grade);
        },
        setNewStudent() {
            const regexUsername = /^[a-zA-Z-]{2,}$/;
            const usernameInput = this.lastnameFirstnameInput.value.trim;
            const lastname = usernameInput.split(' ')[0];
            const firstname = usernameInput.split(' ')[1];
            const grade = this.gradeInput.value;
            const fullname = `${lastname} ${firstname}`;

            if (regexUsername.test(lastname) && lastname !== undefined && regexUsername.test(firstname) && firstname !== undefined && grade >= 0 && grade <= 20)
            return this.listEvaluations.push({
                fullname: this.fullname,
                grade: this.grade
            });
        }
    },
        methods: {
        getLastname(fullname) {
            return fullname.split(' ')[0];
        },
        getFirstname(fullname) {
            return fullname.split(' ')[1];
        },
        getObtenu(grade) {
            return grade >= this.failingGrade ? 'Oui' : 'Non';
        }
    }
}
Vue.createApp(appEvaluation).mount('#app');
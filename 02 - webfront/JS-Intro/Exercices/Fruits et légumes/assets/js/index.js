const appCollectionVegetables = {
    data() {
        return {
            collectionVegetables: [],
            collectionSales: [],
            sortKey: '',
            sortIncrease: true
        }
    },
    async created() {
        try {
            const response = await fetch('./assets/json/legumos.json');

            const json = await response.json();
            if (Array.isArray(json)) {
                this.collectionVegetables = json;
            } else {
                console.error('Les données récupérées ne sont pas un tableau');
            }
        } catch (error) {
            console.error('Un problème est survenu lors de la récupération :', error);
        }
    }, async created() {
        try {
            const response = await fetch('./assets/json/legumos-sales.json');

            const json = await response.json();
            if (Array.isArray(json)) {
                this.collectionSales = json;
            } else {
                console.error('Les données récupérées ne sont pas un tableau');
            }
        } catch (error) {
            console.error('Un problème est survenu lors de la récupération :', error);
        }
    },
    computed: {

    },
    methods: {
        setStatusFresh(Fresh) {
            return Fresh === 1 ? 'oui' : 'non';
        },
        sortTable(key) {
            console.log('key', key);

            if (this.sortKey === key)
                this.sortIncrease = !this.sortIncrease;
            else {
                this.sortKey = key;
                this.sortIncrease = true;
            }

            if (this.sortKey) {
                this.collectionVegetables = this.collectionVegetables.sort((a, b) => {
                    const valA = a[this.sortKey];
                    const valB = b[this.sortKey];
                    let compare = 0;

                    if (typeof valA === 'string' && typeof valB === 'string') {
                        compare = valA.localeCompare(valB);
                    }
                    else if (typeof valA === 'number' && typeof valB === 'number') {
                        compare = valA - valB;
                    } else {
                        console.warn('Les valeurs ne sont pas comparables :', valA, valB);
                    }

                    // Si compare est 0, cela signifie que les valeurs sont égales
                    // Dans ce cas, nous devons décider comment les trier
                    return this.sortIncrease ? compare : -compare;
                });
            }
        }
    }
}
Vue.createApp(appCollectionVegetables).mount('#app');
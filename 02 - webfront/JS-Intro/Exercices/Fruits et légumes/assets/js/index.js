const appCollectionVegetables = {
    data() {
        return {
            collectionVegetables: [],
            sortKey: '',
            sortIncrease: true
        }
    },
    async created() {
        try {
            const response = await fetch('./assets/json/legumos.json');
            const json = await response.json();
            this.collectionVegetables = json;
        } catch (error) {
            console.error('Un problème est survenu lors de la récupération :', error);
        }
    },
    computed: {

    },
    methods: {
        setStatusFresh(Fresh) {
            if (Fresh === 1)
                return Fresh = 'oui';
            else if (Fresh === 0)
                return Fresh = 'non';
        },
        sortArrow() {
            arrow.forEach(e => e.textContent = '');

            if (sortKey) {
                const arrowIds = '#arrow-' + sortKey;

                if (arrowIds)
                    arrowIds.textContent = sortInscrease ? ' ▼' : ' ▲';
            }
        },
        sortTable(key) {
            if (sortKey === key)
                sortInscrease = !sortInscrease;
            else {
                sortKey = key;
                sortInscrease = true;
            }

            this.sortArrow();

            if (sortKey) {
                collectionCereals = collectionCereals.sort((a, b) => {
                    const valA = a[sortKey];
                    const valB = b[sortKey];
                    const compare = valA > valB ? 1 : valA < valB ? -1 : 0;
                    return sortInscrease ? compare : -compare;
                });

            }
        }
    }
}
Vue.createApp(appCollectionVegetables).mount('#app');
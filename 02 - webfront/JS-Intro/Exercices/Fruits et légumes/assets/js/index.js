const appCollectionVegetables = {
    data() {
        return {
            collectionVegetables: []
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
        setStatusFresh() {
            this.collectionVegetables.forEach(element => {
                if (element.Fresh === 1)
                    return element.Fresh = 'oui';
                else if (element.Fresh === 0)
                    return element.Fresh = 'non';
            });
        }
    }
}
Vue.createApp(appCollectionVegetables).mount('#app');
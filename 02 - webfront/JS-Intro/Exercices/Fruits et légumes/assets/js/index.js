const appCollectionVegetables = {
    data() {
        return {
            collectionVegetables: [],
            collectionSales: [],
            sortKey: '',
            sortIncrease: true,

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
    mounted() {
        this.load();
    },
    methods: {
        getFrenchDate(date) {
            const saleDate = new Date(date);
            // const options = { year: 'numeric', month: 'long', day: 'numeric' };
            // const dateFr = saleDate.toLocaleDateString("fr-FR", options);
            const dateFr = String(saleDate.getDate()).padStart(2, '0') + '/' + String(saleDate.toLocaleString('fr-FR', { month: 'numeric' })).padStart(2, '0') + '/' + saleDate.getFullYear();

            return dateFr;
        },
        setStatusFresh(Fresh) {
            return Fresh === 1 ? 'oui' : 'non';
        },
        sortTable(key) {
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

                    return this.sortIncrease ? compare : -compare;
                });
            }
        },
        save() {
            console.log('save', this.collectionVegetables);
            
            localStorage.setItem('collectionVegetables', JSON.stringify(this.collectionVegetables));
        },
        load() {
            const storage = localStorage.getItem('collectionVegetables');
            if (storage) {
                this.collectionVegetables = JSON.parse(storage);
            }
        },
        resetSave() {
            localStorage.removeItem('collectionVegetables');
        },
        downloadJSON() {
            const json = JSON.stringify(this.collectionVegetables, null, 2);
            const blob = new Blob([json], { type: 'application/json' });
            const url = URL.createObjectURL(blob);
            const a = document.createElement('a');
            a.href = url;
            a.download = 'collectionVegetables.json';
            document.body.appendChild(a);
            a.click();
            document.body.removeChild(a);
            URL.revokeObjectURL(url);
        },
        addFruit() {
            this.collectionVegetables.push({

            });
            this.save();
        },
        deleteFruit(index) {
            console.log('deleteFruit', index);

            this.collectionVegetables.splice(index, 1);
            this.save();
        },
        editFruit(index) {
            console.log('editFruit', index);

            if (index >= 0 && index < this.collectionVegetables.length) {
                const vege = this.collectionVegetables[index];
                const newName = prompt('Modifier le nom du vege:', vege.Name);
                const newPrice = prompt('Modifier le prix du fruit:', vege.Price);
                const newFresh = prompt('Le fruit est-il frais:', vege.Fresh);

                if (newName !== null) {
                    vege.Name = newName;
                }
                if (newPrice !== null) {
                    vege.Price = parseFloat(newPrice);
                }
                if (newFresh !== null) {
                    vege.Fresh = parseInt(newFresh);
                }

                this.save();
            } else {
                console.log('Index invalide');
            }
        },
    }
}
Vue.createApp(appCollectionVegetables).mount('#app');
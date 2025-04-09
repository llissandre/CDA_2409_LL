const appCollectionVegetables = {
    data() {
        return {
            collectionVegetables: [],
            collectionVegetablesStorage: [],
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
                this.loadVegetables();
            } else {
                console.error('Les données récupérées ne sont pas un tableau');
            }
        } catch (error) {
            console.error('Un problème est survenu lors de la récupération :', error);
            this.collectionVegetables = [];
        }

        try {
            const response = await fetch('./assets/json/legumos-sales.json');

            const json = await response.json();
            if (Array.isArray(json)) {
                this.collectionSales = json;
                this.loadSales();
            } else {
                console.error('Les données récupérées ne sont pas un tableau');
            }
        } catch (error) {
            console.error('Un problème est survenu lors de la récupération :', error);
            this.collectionSales = [];
        }
    },
    computed: {


    },
    mounted() {
        this.loadVegetables();
        this.loadSales();
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
                this.collectionVegetablesStorage = this.collectionVegetablesStorage.sort((a, b) => {
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
        saveVegetables() {
            window.localStorage.setItem('collectionVegetables', JSON.stringify(this.collectionVegetablesStorage));
        },
        saveSales() {
            window.localStorage.setItem('collectionSales', JSON.stringify(this.collectionSalesStorage));
        },
        loadVegetables() {
            const storage = localStorage.getItem('collectionVegetables');

            if (storage === null) {
                this.collectionVegetablesStorage = this.collectionVegetables;
            }
            else if (storage) {
                this.collectionVegetablesStorage = JSON.parse(storage);
            }
        },
        loadSales() {
            const storage = localStorage.getItem('collectionSales');

            if (storage === null) {
                this.collectionSalesStorage = this.collectionSales;
            }
            else if (storage) {
                this.collectionSalesStorage = JSON.parse(storage);
            }
        },
        resetSaveVegetables() {
            window.localStorage.removeItem('collectionVegetables');
            location.reload();
        },
        resetSaveSales() {
            window.localStorage.removeItem('collectionSales');
            winlocationow.reload();
        },
        downloadJSONVegetables() {
            const json = JSON.stringify(this.collectionVegetablesStorage, null, 2);
            const blob = new Blob([json]);
            const url = URL.createObjectURL(blob);
            const a = document.createElement('a');
            a.href = url;
            a.download = 'collectionVegetables.json';
            document.body.appendChild(a);
            a.click();
            document.body.removeChild(a);
            URL.revokeObjectURL(url);
        }, downloadJSONSales() {
            const json = JSON.stringify(this.collectionSalesStorage, null, 2);
            const blob = new Blob([json]);
            const url = URL.createObjectURL(blob);
            const a = document.createElement('a');
            a.href = url;
            a.download = 'collectionSales.json';
            document.body.appendChild(a);
            a.click();
            document.body.removeChild(a);
            URL.revokeObjectURL(url);
        },
        addVegetable() {

            this.collectionVegetablesStorage.push({

            });
            this.saveVegetables();
        },
        deleteVegetable(index) {
            if (confirm('Supprimer ce légume ?')) {
                this.collectionVegetablesStorage.splice(index, 1);
                this.saveVegetables();
            }
        },
        editVegetable(index) {

            if (index >= 0 && index < this.collectionVegetablesStorage.length) {
                const vege = this.collectionVegetablesStorage[index];
                const newName = prompt('Modifier le nom du légume :', vege.Name);
                const newVariety = prompt('Modifier la variété du légume :', vege.Variety);
                const newPrimaryColor = prompt('Modifier la couleur primaire du légume :', vege.PrimaryColor);
                const newLifeTime = prompt('Modifier la durée de conservation du légume :', vege.LifeTime);
                const newPrice = prompt('Modifier le prix du légume :', vege.Price);
                const newFresh = prompt('Le légume est-il frais:', vege.Fresh);

                if (newName !== null) {
                    vege.Name = newName;
                }
                if (newVariety !== null) {
                    vege.Variety = newVariety;
                }
                if (newPrimaryColor !== null) {
                    vege.PrimaryColor = newPrimaryColor;
                }
                if (newLifeTime !== null) {
                    vege.LifeTime = newLifeTime;
                }
                if (newPrice !== null) {
                    vege.Price = parseFloat(newPrice);
                }
                if (newFresh !== null) {
                    vege.Fresh = parseInt(newFresh);
                }
            } else {
                alert('Index invalide');
            }

            this.saveVegetables();
        },
    }
}
Vue.createApp(appCollectionVegetables).mount('#app');
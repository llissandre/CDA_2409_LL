import { getLocalData, saveLocalData } from './assets/js/storageManager.js';

const appCollectionVegetables = {
    data() {
        return {
            collectionVegetables: [],
            collectionVegetablesStorage: [],
            collectionSales: [],
            collectionSalesStorage: [],
            sortKey: '',
            sortIncrease: true,
            newVegetable: {
                Id: null,
                Name: '',
                Variety: '',
                PrimaryColor: '',
                LifeTime: 0,
                Fresh: 1,
                Price: 0
            },
            newSale: {
                Id: null,
                SaleDate: '',
                SaleWeight: 0,
                SaleUnitPrice: 0,
                SaleActive: '',
                VegetableId: ''
            }
        }
    },
    async created() {
        try {
            const response = await fetch('./assets/json/legumos.json');

            const json = await response.json();
            if (Array.isArray(json)) {
                this.collectionVegetables = json;
                this.loadTo('collectionVegetablesStorage', 'collectionVegetables', this.collectionVegetables);
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
                this.loadTo('collectionSalesStorage', 'collectionSales', this.collectionSales);
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
        this.loadTo('collectionVegetablesStorage', 'collectionVegetables', this.collectionVegetables);
        this.loadTo('collectionSalesStorage', 'collectionSales', this.collectionSales);
        // this.loadVegetables();
        // this.loadSales();
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
                    const valeurA = a[this.sortKey];
                    const valeurB = b[this.sortKey];
                    let compare = 0;

                    if (typeof valeurA === 'string' && typeof valeurB === 'string') {
                        compare = valeurA.localeCompare(valeurB);
                    }
                    else if (typeof valeurA === 'number' && typeof valeurB === 'number') {
                        compare = valeurA - valeurB;
                    } else {
                        console.warn('Les valeurs ne sont pas comparables :', valeurA, valeurB);
                    }

                    return this.sortIncrease ? compare : -compare;
                });
            }
        },
        getLastId(data) {
            if (data.length === 0) {
                return 1;
            } else {
                const lastItem = data.length;
                return lastItem.Id + 1;
            }
        },
        deleteVegetable(index) {
            if (confirm('Supprimer ce légume ?')) {
                this.collectionVegetablesStorage.splice(index, 1);
                // this.saveVegetables();
                this.save('collectionVegetablesStorage', this.collectionVegetablesStorage);
            }
        },
        editVegetable(index) {

            if (index >= 0 && index < this.collectionVegetablesStorage.length) {
                const vegetable = this.collectionVegetabletablesStorage[index];
                const newName = prompt('Modifier le nom du légume :', vegetable.Name);
                const newVariety = prompt('Modifier la variété du légume :', vegetable.Variety);
                const newPrimaryColor = prompt('Modifier la couleur primaire du légume :', vegetable.PrimaryColor);
                const newLifeTime = prompt('Modifier la durée de conservation du légume :', vegetable.LifeTime);
                const newPrice = prompt('Modifier le prix du légume :', vegetable.Price);
                const newFresh = prompt('Le légume est-il frais:', vegetable.Fresh);

                if (newName !== null) {
                    vegetable.Name = newName;
                }
                if (newVariety !== null) {
                    vegetable.Variety = newVariety;
                }
                if (newPrimaryColor !== null) {
                    vegetable.PrimaryColor = newPrimaryColor;
                }
                if (newLifeTime !== null) {
                    vegetable.LifeTime = newLifeTime;
                }
                if (newPrice !== null) {
                    vegetable.Price = parseFloat(newPrice);
                }
                if (newFresh !== null) {
                    vegetable.Fresh = parseInt(newFresh);
                }
            } else {
                alert('Index invalide');
            }

            // this.saveVegetables();
            this.save('collectionVegetablesStorage', this.collectionVegetablesStorage);
        },
    }
}
Vue.createApp(appCollectionVegetables).mount('#app');
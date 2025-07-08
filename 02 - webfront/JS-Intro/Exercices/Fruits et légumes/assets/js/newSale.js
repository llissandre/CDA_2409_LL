import { getLocalData, saveLocalData } from './assets/js/storageManager.js';

const appNewSale = {
    data() {
        return {
            sale: {
                SaleId: DgetLastId(collectionSalesStorage),
                SaleDate: Date.now(),
                saleWeight: 0,
                VegetableId: '',
                saleActive: 1,
            }
        }
    },
    methods: {
        newSale() {
            const collectionSalesStorage = this.loadTo('collectionSalesStorage', 'collectionSales', this.collectionSales);
            collectionSalesStorage.push(this.sale);
            this.save('collectionSalesStorage', this.collectionSalesStorage);
            alert('Achat ajouté avec succès !');
            window.location.href = 'index.html';
        }
    }
}
Vue.createApp(appNewSale).mount('#app');

import { getLocalData, saveLocalData } from './assets/js/storageManager.js';

const appNewVegetable = {
    data() {
        return {
            vegetable: {
                Id: getLastId(collectionVegetablesStorage),
                Name: '',
                Variety: '',
                PrimaryColor: '',
                LifeTime: 0,
                Fresh: 1,
                Price: 0
            }
        }
    },
    methods: {
        newVegetable() {
            const collectionVegetablesStorage = this.loadTo('collectionVegetablesStorage', 'collectionVegetables', this.collectionVegetables);
            collectionVegetablesStorage.push(this.vegetable);
            this.save('collectionVegetablesStorage', this.collectionVegetablesStorage);
            alert('Légume ajouté avec succès !');
            window.location.href = 'index.html';
        }
    }
}
Vue.createApp(appNewVegetable).mount('#app');

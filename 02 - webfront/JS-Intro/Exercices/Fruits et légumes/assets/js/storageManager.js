


// saveVegetables() {
//     window.localStorage.setItem('collectionVegetables', JSON.stringify(this.collectionVegetablesStorage));
// },
// saveSales() {
//     window.localStorage.setItem('collectionSales', JSON.stringify(this.collectionSalesStorage));
// },
// loadVegetables() {
//     const storage = localStorage.getItem('collectionVegetables');
//     if (storage === null) {
//         this.collectionVegetablesStorage = this.collectionVegetables;
//     }
//     else if (storage) {
//         this.collectionVegetablesStorage = JSON.parse(storage);
//     }
// },
// loadSales() {
//     const storage = localStorage.getItem('collectionSales');
//     if (storage === null) {
//         this.collectionSalesStorage = this.collectionSales;
//     }
//     else if (storage) {
//         this.collectionSalesStorage = JSON.parse(storage);
//     }
// },
// resetSaveVegetables() {
//     window.localStorage.removeItem('collectionVegetables');
//     location.reload();
// },
// resetSaveSales() {
//     window.localStorage.removeItem('collectionSales');
//     location.reload();
// },
// downloadJSONVegetables() {
//     const json = JSON.stringify(this.collectionVegetablesStorage, null, 2);
//     const blob = new Blob([json]);
//     const url = URL.createObjectURL(blob);
//     const a = document.createElement('a');
//     a.href = url;
//     a.download = 'collectionVegetables.json';
//     document.body.appendChild(a);
//     a.click();
//     document.body.removeChild(a);
//     URL.revokeObjectURL(url);
// },
// downloadJSONSales() {
//     const json = JSON.stringify(this.collectionSalesStorage, null, 2);
//     const blob = new Blob([json]);
//     const url = URL.createObjectURL(blob);
//     const a = document.createElement('a');
//     a.href = url;
//     a.download = 'collectionSales.json';
//     document.body.appendChild(a);
//     a.click();
//     document.body.removeChild(a);
//     URL.revokeObjectURL(url);
// },
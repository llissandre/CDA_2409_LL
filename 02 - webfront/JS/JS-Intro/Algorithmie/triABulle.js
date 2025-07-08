function bubbleSort(array) {
    for (let i = 0; i < array.length - 1; i++) {
        for (let j = 0; j < array.length - 1; j++) {
            if (array[j] > array[j + 1]) {
                // let temp = array[j];
                // array[j] = array[j + 1]
                // array[j + 1] = temp;
                /* array[j], array[j + 1]] = [array[j + 1], array[j]] */
            }
        }
    }
    // console.log(array);
}



// function bubbleSort(array) {
//     console.log(array.sort((a, b) => a - b));
// }

bubbleSort([451, 62, 60, 666, 4, 7, 98, 2, 3, 1]);
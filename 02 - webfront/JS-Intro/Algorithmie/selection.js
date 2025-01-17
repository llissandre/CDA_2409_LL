function selectionSort(array) {
    for (let i = 0; i < array.length - 1; i++) {
        let indexMin = i;

        for (let j = i + 1; j < array.length; j++) {
            if (array[j] < array[indexMin]) {
                indexMin = j;
            }
        }

        [array[i], array[indexMin]] = [array[indexMin], array[i]]
    }
    console.log(array);
}

selectionSort([451, 62, 60, 666, 4, 7, 98, 2, 3, 1]);
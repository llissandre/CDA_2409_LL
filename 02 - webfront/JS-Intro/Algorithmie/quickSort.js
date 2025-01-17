function quickSort(array) {
    if (array.length === 1) {
        return array;
    }

    const pivot = array[array.length - 1];
    let arrayLeft = [];
    let arrayRight = [];

    for (i = 0; i < array.length - 1; i++) {
        array[i] < pivot ? arrayLeft.push(array[i]) : arrayRight.push(array[i]);
    }

    if (arrayLeft.length > 0 && arrayRight.length > 0) {
        return [...quickSort(arrayLeft), pivot, ...quickSort(arrayRight)];
    }
    else if (arrayLeft.length > 0) {
        return [...quickSort(arrayLeft), pivot]
    }
    else {
        return [pivot, ...quickSort(arrayRight)]
    }
}

quickSort([451, 62, 60, 666, 4, 7, 98, 2, 3, 1]);
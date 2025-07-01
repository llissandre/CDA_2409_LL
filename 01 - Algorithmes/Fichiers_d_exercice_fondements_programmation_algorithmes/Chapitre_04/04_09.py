# Algorithme du tri rapide (Quicksort)


def QuickSort(dataset, index1, index2):
    if index1 < index2:
        # Chercher le point de séparation
        ctr = Split(dataset, index1, index2)

        # Appelles récurssifs pour trier les deux sous-tableaux 
        QuickSort(dataset, index1, ctr-1)
        QuickSort(dataset, ctr+1, index2)


def Split(dataset, index1, index2):
    
    pivot = dataset[index1]
    
    # Positionnement des deux indices Inf et Sup
    Inf = index1 + 1
    Sup = index2

    end = False
    while not end:
        # Avancer l'indice Inf d'une position
        while Inf <= Sup and dataset[Inf] <= pivot:
            Inf += 1

        # Reculer l'indice Sup d'une position
        while dataset[Sup] >= pivot and Sup >= Inf:
            Sup -= 1

        if Sup < Inf:
            end = True
        else:
            temp = dataset[Inf]
            dataset[Inf] = dataset[Sup]
            dataset[Sup] = temp

    # Positionnement du point pivot
    temp = dataset[index1]
    dataset[index1] = dataset[Sup]
    dataset[Sup] = temp

    # Retourner la valeur de l'indice Sup
    return Sup

myList = [5, 2, 0, 8, 3, 9, 1, 6, 4, 7]

 
print("Le tableau à trier : " , myList)
QuickSort(myList, 0, len(myList)-1)
print("Le tableau résultat: ", myList)

# Algorithme de tri diviser pour régner

def MergeSort(dataset):
    if len(dataset) > 1:
        ctr = len(dataset) // 2
        leftarray = dataset[:ctr]
        rightarray = dataset[ctr:]

        # Appelles récursifs pour la division des tableaux
        MergeSort(leftarray)
        MergeSort(rightarray)

        # La procédure de fusion 
        i=0 # indice utilisé avec le tablau leftarray
        j=0 # indice utilisé avec le tableau rightarray
        k=0 # indice utilisé pour le tableau dataset résultat de la fusion

        # Extraction des valeurs des deux tableaux
        while i < len(leftarray) and j < len(rightarray):
            if leftarray[i] < rightarray[j]:
                dataset[k] = leftarray[i]
                i += 1
            else:
                dataset[k] = rightarray[j]
                j += 1
            k += 1

        # Traitement des données restantes dans le tableau leftarray
        while i < len(leftarray):
            dataset[k] = leftarray[i]
            i += 1
            k += 1

        # Traitement des données restantes dans le tableau rightarray 
        while j < len(rightarray):
            dataset[k] = rightarray[j]
            j += 1
            k += 1


myList = [5, 2, 0, 8, 3, 9, 1, 6, 4, 7]
print("Début de la procédure de tri sur la liste : ", myList)
MergeSort(myList)
print("Résultat du tri: ", myList)




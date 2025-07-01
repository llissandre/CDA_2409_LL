# Algorithme de tri à bulles


def BubbleSort(dataset):
    print("Début de la procédure de tri sur la liste : ", dataset)
    for i in range(len(dataset)-1, 0, -1):
        # Remonter le maximum à la dernière position de la liste
        for j in range(i):
            if dataset[j] > dataset[j+1]:
                temp = dataset[j]
                dataset[j] = dataset[j+1]
                dataset[j+1] = temp

        print("l'état de tri à l'étape {} est {}".format(len(dataset)-i,dataset))


myList = [9, 8, 7, 6, 5, 4, 3, 2, 1, 0] 


BubbleSort(myList)
 













































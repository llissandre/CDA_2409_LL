# Algorithme de tri par les minimums successifs


def MIN_SORT(dataset):
    print("Début de la procédure de tri sur la liste : ", dataset)
    for i in range(len(dataset)-1):
        # recherche du minimum entre l'indice i et la fin du tableau
        for j in range(i+1,len(dataset)):
            if dataset[i] > dataset[j]:
                temp = dataset[j]
                dataset[j] = dataset[i]
                dataset[i] = temp

        print("L'état de tri à l'étape {} est {}".format(i,dataset))


 
myList = [5, 2, 0, 8, 3, 9, 1, 6, 4, 7]
   
MIN_SORT(myList)

 




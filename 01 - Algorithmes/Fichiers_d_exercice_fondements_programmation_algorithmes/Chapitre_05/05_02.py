# Algorithme de recherche dichotomique
 

def DichoSearch(value, dataset):
   
    itemlist_size = len(dataset) - 1
    # Les deux indices de recherche
    Inf = 0
    Sup = itemlist_size

    while Inf <= Sup:
        # le centre du tableau
        ctr = (Inf + Sup)// 2
                 
        if dataset[ctr] == value:
            return ctr
        
        if value > dataset[ctr]:
            Inf = ctr + 1
        else:
            Sup = ctr - 1

    if Inf > Sup:
        return None
 

myList = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9]
print(DichoSearch(5, myList))
print(DichoSearch(10, myList))
 

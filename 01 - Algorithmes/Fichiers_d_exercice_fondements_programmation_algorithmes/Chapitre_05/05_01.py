# Recherche d'une valeur dans un tableau 
   
def Search_Value(value, dataset):
    # Recherche de la valeur "value" dans le tableau dataset
    for i in range(0, len(dataset)):
        if value == dataset[i]:
            return i
    
    return None

myList = [5, 2, 0, 8, 3, 9, 1, 6, 4, 7]
print(Search_Value(6, myList))
print(Search_Value(10, myList))

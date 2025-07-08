# Algorithme de recherche de la valeur minimale et de la valeur maximale dans une liste

def GetMinMax(items):
    # Initialisation de la valeur minimale et de la valeur maximale à la première valeur de la liste items
    max = items[0] 
    min = items[0]
    for i in range(1,len(items)):
        if(max < items[i]):
            max = items[i]
        if(min > items[i]):
            min = items[i]
    return (min, max)



myList = [5, -2, 0, 18, 13, 1000, -14, 6, -1000, 67]

min,max = GetMinMax(myList)
print("Min = {}, Max ={}".format(min, max))

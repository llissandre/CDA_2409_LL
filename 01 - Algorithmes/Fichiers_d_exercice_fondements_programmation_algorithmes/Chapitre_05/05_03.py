# Déterminer si une liste est triée ou non


def IsSorted(dataset): 
    
   return all(dataset[i] <= dataset[i+1] for i in range(len(dataset)-1))


myList1 = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9]
myList2 = [5, 2, 0, 8, 3, 9, 1, 6, 4, 7]

print(IsSorted(myList1))
print(IsSorted(myList2))
















































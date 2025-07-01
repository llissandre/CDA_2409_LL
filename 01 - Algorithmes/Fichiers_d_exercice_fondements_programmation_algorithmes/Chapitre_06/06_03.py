# Calcul du nombre d'occurrences de chaque valeur d'une liste

# La liste myList contient  les valeurs suivantes :
#    - Trois occurrences de la valeur "Rouge"
#    - Une occurence de la valeur "Vert"    
#    - Deux occurrences de la valeur "Orange"
#    - Trois occurrences de la valeur "Bleu"
#    - Une seule occurrence de la valeur "Jaune"

myList = ["Rouge", "Vert", "Orange", "Bleu", "Bleu","Rouge", "Jaune", "Orange", "Bleu", "Rouge"]

# Création d'un dictionnaire
myDict = dict()

# Calcul du nombre d'occurrences de chaque valeur de la liste myList en utilisant les clés de la table de hachage myDict 
for elem in myList:
    if elem in myDict.keys():
        myDict[elem] += 1
    else:
        myDict[elem] = 1

 
print(myDict)

# Détectin et élimination des doublons dans une liste

# La liste myList contient  les valeurs suivantes :
#    - Trois occurrences de la valeur "Rouge"
#    - Une occurence de la valeur "Vert"    
#    - Deux occurrences de la valeur "Orange"
#    - Trois occurrences de la valeur "Bleu"
#    - Une seule occurrence de la valeur "Jaune"

myList = ["Rouge", "Vert", "Orange", "Bleu", "Bleu","Rouge", "Jaune", "Orange", "Bleu", "Rouge"]

# Création d'un dictionnaire
myDict = dict()

# Ajout de toutes les valeurs de la liste myLidt dans le dictionnaire myDict
for elem in myList:
    myDict[elem] = 0

# Création d'un ensemble contenant les valeurs du dictionnaire myDict sans répétition d'occurrences
mySet = set(myDict.keys())


print(mySet)

# Exemple de file avec Python
from collections import deque

# Création d'une file
queue = deque()

# Ajouter des valeurs dans une file
queue.append(1)
queue.append(2)
queue.append(3)
queue.append(4)
queue.append(5)

# Affichage des éléments de la file
print(queue)

# suppression d'un élément de la file
item = queue.popleft()
print("La valeur supprimée est :",item)

# Affichage des éléments de la file 
print(queue)

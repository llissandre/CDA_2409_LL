# Exemple de Liste chaînée


# Une classe pour la représentation des noeuds

class Node(object):
    def __init__(self, value):
        self.value = value
        self.next_node = None

    def get_value(self):
        return self.value

    def set_value(self, value):
        self.value = value

    def get_next_node(self):
        return self.next_node

    def set_next_node(self, next_node):
        self.next_node = next_node


# Une classe pour la représentation des listes chaînées
class LinkedList(object):
    def __init__(self, head=None):
        self.head = head
        self.count = 0

    def Get_count(self):
        return self.count

    def Insert(self, value):
        new_node = Node(value)
        new_node.set_next_node(self.head)
        self.head = new_node
        self.count = self.count + 1 

    def Print_list_item(self):
        print("Affichage des éléments de la liste: ")
        tempnode = self.head
        while (tempnode != None):
            print("Noeud : ", tempnode.get_value())
            tempnode = tempnode.get_next_node()


# Création de la liste chaînée
mylist = LinkedList()

# Insertion de nouveaux éléments dans la liste chaînée
for i in range(10):
    mylist.Insert(i)
 

#Affichage de tous les éléments de la liste chaînée
mylist.Print_list_item()

#  Recherche du nombre d'éléments dans la liste chaînée
print("Le nombre d'éléments dans la liste: ", mylist.Get_count())
 
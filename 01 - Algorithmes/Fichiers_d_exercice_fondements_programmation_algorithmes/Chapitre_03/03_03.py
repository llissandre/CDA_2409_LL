 
def myFunction():
    global n
    n=2
    return n

n=10
res = myFunction()

print("Résultat de l'exécution de la fonction 'myFunction' : ", res)

print("la valeur de la variable 'n' dans le programme appelant est :", n) 
 

 
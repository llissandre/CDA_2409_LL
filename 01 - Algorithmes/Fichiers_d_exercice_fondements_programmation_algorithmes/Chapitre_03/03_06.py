# Calcul de la suite de Fibonacci
# Fibonacci_0 = 0; Fibonacci_1= 1 ; Fibonacci_2 = 1; Fibonacci_3= 2 ... Fibonacci_10=55

def Fibonacci(n):
    if (n == 0):
        return 0
    elif n==1:
        return 1
    else:
        return Fibonacci(n-1)+Fibonacci(n-2) 

term= 10
result = Fibonacci(term)
print("La valeur du terme d'indice {} de la suite de Fibonacci est : {}".format(term, result))


str_n = input('Veuillez entrer un nombre : ')
n = int(str_n)
factorielle = 1
for i in range(2, n+1):
    print(i)
    factorielle = factorielle * i
print (n,'! = ',factorielle)
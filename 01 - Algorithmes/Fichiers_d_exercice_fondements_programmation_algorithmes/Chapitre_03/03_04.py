import time

def countdown(x):
    if x == 0:
        print("Décollage !")
        return
    else:
        time.sleep(1)
        print(x)
        countdown(x-1)
       
        

print("Allumage...")
print("Démarrage du compte à rebours...")
time.sleep(1)
countdown(5)

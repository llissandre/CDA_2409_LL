MyList = [11,28,12,5,64,23,87,12,23]
print(MyList)
item0 = MyList[0]
print(item0)
MyList[1] = 100
print(MyList[1])
sum_0=0
for i in range(len(MyList)):
    sum_0=sum_0+MyList[i]
print(sum_0)
print(MyList) 
j=0 
sum_1 =0
while j < (len(MyList)//2):
    sum_1 = sum_1 + MyList[j]
    j=j+1
print(sum_1)
    
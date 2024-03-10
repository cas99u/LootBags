
import csv
 
with open('5.csv', mode ='r')as file:
   
    csvFile = csv.reader(file, delimiter = ',')
    lootList = list(csvFile)
 
    print("bag", end="")
    for r in range(len(lootList)):
        print(".Add(ItemID." + lootList[r][0] + ", ", end="")
        if (lootList[r][2] != "1"):
            print(lootList[r][1] + ", " + lootList[r][2] + ", ", end ="")
        print("Amounts.", end ="")
        if lootList[r][3] == "C":
            print("common)")
        elif lootList[r][3] == "U":
            print("uncommon)")
        elif lootList[r][3] == "R":
            print("rare)")
        elif lootList[r][3] == "V":
            print("veryRare)")
    
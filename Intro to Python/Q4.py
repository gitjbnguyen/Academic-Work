from math import *
LitersOfMilk = eval(input("How much milk was produced this morning in 
liters? "))
NumberOfCartons = int(LitersOfMilk//3.78)
total = floor(LitersOfMilk/NumberOfCartons)
production = LitersOfMilk * 0.38
profit = NumberOfCartons * 0.27
print("Cartons made: ", NumberOfCartons)
print('Production costs: ${:,.2f}'.format(production))
print('Profit: ${:,.2f}'.format(profit))
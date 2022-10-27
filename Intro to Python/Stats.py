from math import sqrt # tools in a toolbox
def average(listOfnumbers):
avg = listOfnumbers / 10
return avg
def standardDeviation(total, totalSquared):
standardDeviation = (totalSquared - pow(total, 2)/10)/(10 - 1) 
#referenced by C# code
return sqrt(standardDeviation)
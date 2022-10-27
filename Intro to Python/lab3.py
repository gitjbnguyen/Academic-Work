days = ["Monday", "Tuesday", "Wednesday", "Thursday", "Friday", 
"Saturday", "Sunday"]
#print(days)
temperature = [] #starts off empty
print(temperature)
for i in range(0, len(days)):
item = eval(input("Enter the temperature for " + days[i] + ": "))
temperature.append(item)
print()
min = 0
max = 0
for i in range(0, len(temperature)):
if temperature[i] > temperature[max]:
max = i
if temperature[i] < temperature[min]:
min = i
print(days[min], "was the coldest day.")
print()
print(days[max], "was the warmest day.")
print()
print(days)
print()
print(temperature)
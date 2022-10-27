days = ['Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 
'Saturday', 'Sunday'] #days are keys, temps are values
temperatures = {}
for i in range(0, len(days)):
item = eval(input("Enter the temperature for " + days[i] + ": "))
temperatures[days[i]] = item
print()
min = 'Monday'
max = 'Sunday'
for i in range(0, len(days)):
key = days[i]
if temperatures[key] > temperatures[max]:
max = key
if temperatures[key] < temperatures[min]:
min = key
print(min, "was the coldest day.")
print()
print(max, "was the warmest day.")
print()
print(temperatures)
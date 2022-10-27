centimeters = eval(input("What is your length in centimeters? "))
constant = 2.54
inches = int(centimeters // constant)
yards = int(inches//36)
feet = int(inches % 36/12)
print(yards, "yards", feet, "feet and", (inches % 12), "inches ")
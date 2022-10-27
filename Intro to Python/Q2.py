# Write a program that prompts the capacity,
# in gallons, of an automobile fuel tank and the miles per gallons the 
automobile can be driven.
# The program outputs the number of miles the automobile can be driven 
without refueling.
gallons = eval(input("How many gallons can you have in your vehicle? "))
MPG = eval(input("How much gasoline does your vehicle contain? "))
miles = gallons * MPG;
print("miles to go without refueling: ", miles)
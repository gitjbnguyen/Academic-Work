# Julie Nguyen
# a. Prompts the user to input five decimal numbers.
#
# b. Prints the five decimal numbers.
#
# c. Adds the five numbers.
#
# d. Prints the sum and average of the five integers.
num1 = eval(input("first value: "))
num2 = eval(input("second value: "))
num3 = eval(input("third value: "))
num4 = eval(input("fourth value: "))
num5 = eval(input("fifth value: "))
print(num1)
print(num2)
print(num3)
print(num4)
print(num5)
total = num1 + num2 + num3 + num4 + num5
print("total: ", total)
average = total/5
print("average: ", average)
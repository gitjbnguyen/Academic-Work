from Stats import average, standardDeviation
print("Enter ten numbers:")
numbers = []
Sum = 0
SquareSum = 0
for i in range (0,10,1):
item = eval(input())
numbers.append(item)
Sum += item
SquareSum += item * item
mean = average(Sum)
deviation = standardDeviation(Sum, SquareSum)
print()
print("The mean is ", mean)
print()
print("The standard deviation is", format(deviation, '.6'))
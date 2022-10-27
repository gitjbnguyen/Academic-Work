import math
number = eval(input("Will the number you input be a prime number? "))
isPrime = 1;
if number < 0:
print("please try again, but please input a positive integer")
elif number > 0:
n = int (math.sqrt(number))
for i in range(2,n,1):
if number % i == 0 or number == 0 or number == 1:
isPrime = 0
break
if isPrime == 0 :
print(number, " is not a prime number because it can't be 
divided by itself")
else:
print(number, " is a prime number.")
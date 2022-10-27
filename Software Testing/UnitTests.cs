using FindPrimeNumbers;
using NUnit.Framework;
using System.Reflection;
namespace FindPrimeNumbersTester
{
[TestFixture]
public class UnitTests
{
PrimeNumber pn;
[TestFixtureSetUp]
public void TestSetup()
{
pn = new PrimeNumber();
}
[TestCase(1)]
public void OneShouldNotBePrime1(int num)
{
pn.Number = num;
Assert.IsFalse(pn.IsPrime(), $"{num} should not be prime");
}
[TestCase(1, Result = false)]
public bool OneShouldNotBePrime2(int num)
{
pn.Number = num;
return pn.IsPrime();
}
[Test]
public void EvenNumbersShouldNotBePrime(
[Range(4, 100, 2)] int num)
{
pn.Number = num;
Assert.IsFalse(pn.IsPrime(), $"{num} should not be prime");
}
// TODO 1: Change from Values to TestCaseSource
static int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 
37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
[Test, TestCaseSource("primes")]
public void ShouldFindPrimeNumbers(int num)
{
pn.Number = num;
Assert.IsTrue(pn.IsPrime(), $"{num} should be prime");
}
// TODO 2: Verify that the application has PrimeNumber class
//         and that the class has a Number property
[Test]
public void ClassShouldHaveNumberProperty()
{
var assembly = 
Assembly.ReflectionOnlyLoadFrom("FindPrimeNumbers.exe");
bool foundPN = false; //prime number
bool foundN = false; //number
var types = assembly.GetTypes();
foreach (var type in types)
{
if(type.Name == "PrimeNumber")
{
foundPN = true;
PropertyInfo[] properties = type.GetProperties();
foreach(PropertyInfo item in properties)
{
if(item.Name == "Number")
{
foundN = true;
break;
}
}
break;
}
Assert.IsTrue(foundPN, "The build is missing the 
PrimeNumber class");
Assert.IsTrue(foundN, "The build is missing the Number 
property in the PrimeNumber class");
}
}
[TestFixtureTearDown]
public void TestTearDown()
{
pn = null;
}
}
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace sorting_Algorithms
{
public partial class Form1 : Form
{
int[] array = new int[12];
public Form1()
{
InitializeComponent();
}
//bubble sort
private void BubbleSort (int [] array)
{
int n = array.Length;
for(int i = 1; i < n; i++)
{
for(int j = 0; j < n-i; j++)
{
if(array[j] > array[j + 1])
{
//swap
int temp = array[j];
array[j] = array[j + 1];
array[j + 1] = temp;
}
}
//for observation
//Display(array);
}
}
//Assignment
private void SelectionSort(int [] array)
{
//given the array: 15,8,19,12,4,10,6,19
//start i at 0 look for the index of the smallest value 
starting at i
//swap smallest value with value at i
//value 4 is the smallest value at index 4 so we
//swap 4 and 15
//4,8,19,12,8,10,6,19
//move i to 1 and look for the index of the smallest value 
again starting at i = 1
//value 6 at index 6 is the smallest value. swap it with the 
value 8
//4,6,19,12,10,8,19
//and so on until i reaches the end of the array
int n = array.Length;
for(int i=0; i < n-1; i++) //1 + n + n
{
//complete the code to get the index of the smallest value 
starting at i
//call that index minIndex or just min
//swap values at i and min
int min = i; //n
for(int j = i+1; j < n; j++) //n n^2 n^2
{
if (array[min] > array[j]) //n^2
min = j; //n^2
//swap the found element with first element
//have a temp to hold the value
}
int temp = array[min]; //n
array[min] = array[i]; //n
array[i] = temp; //n
}
//go to the comparing sorts and time the selection sort as 
well
//Time complexity: T(n) = 4n^2 + 7n + 1
//BIG O Notation: O(n^2) Quadratic
}
private void Display(int [] array)
{
foreach(int x in array)
{
richTextBox1.AppendText($"{x} ");
}
richTextBox1.AppendText("\n");
}
private void Display(int sv, int index)
{
richTextBox1.Clear();
richTextBox1.AppendText("the search value is: " + sv
+ " found at: " + index);
}
//Insertion sort
private void InsertionSort(int [] array)
{
//the concept of insertion sort is to divide the array into 2 
parts
//the left: initially containing a single element (first 
element at index 0)
//the right part: initially starts at index 1 containing the 
rest
//of the elements
//the left part is considered sorted
//the algorithm is to pick each element from the right part 
and
//insert it into the left part at its sorted position
int n = array.Length;
for (int i = 1; i < n; i++) //1 + n + n
{
//set j to i - 1
//j is an index that marches backwards looking for the
//insertion point j is the index that marches across the
//sorted left part deciding where to insert the new 
element
int temp = array[i]; //save the element to insert in a 
temp variable //n
int j = i - 1; //initialize j to the end of the left part 
//n
while (j >= 0 && temp < array[j]) //n  n^2 n^2
{
//copy the value at j to j+1 that is move the element 
at
//j over (one hop)
array[j + 1] = array[j]; //n^2
//march j towards the start of the left part
j--; //n^2
}
//now insert the temp element into j+1
array[j + 1] = temp; //n
}
//write time efficiency T(n) = 4n^2 + 5n + 1
//convert that to Big O notation =  O(n^2) quadratic
}
private void btnBubbleSort_Click(object sender, EventArgs e)
{
//create a random array
Random rand = new Random();
for (int i = 0; i <array.Length;)
{
int checkDuplicates = rand.Next(1, 50);
if(!array.Contains(checkDuplicates))
{
array[i] = checkDuplicates;
i++;
}
else
{
continue;
}
}
//display array before bubble sort
richTextBox1.Text = "array before bubble sort: \n";
Display(array);
//bubble sort it
BubbleSort(array);
richTextBox1.AppendText("\narray after bubble sort: \n");
Display(array);
}
//Search algorithms
//Sequential search:
//return an index of the searched value if it exits or -1 
otherwise
//such method is usually called indexOf in .NET and JS
//or return a boolean: true if the search value exists, false 
otherwise.
//such method is called Contains
private int IndexOf(int[] array, int sv)
{
int n = array.Length;
for(int i = 0; i < n; i++) //1 + n + n
{
if(sv == array[i]) //n
{
return i; //return the index where found //1
}
}
//if the code gets to this point then all the value have
//been searched no match was detected by the if statement
return -1;
//Time efficiency T(n) = 3n + 2
//eliminate the 2 for very large values of n
//drop the coefficient 3 to focus on the linear growth factor
//big O notation: O(n)
}
private int binarySearch(int [] array, int search)
{
int start = 0;
int end = array.Length - 1;
while(start <= end)
{
int midpoint = (start + end) / 2;
if (search == array[midpoint])
{
return midpoint;
}
else if (search < array[midpoint])
{
end = midpoint;
}
else
{
start = midpoint + 1;
}
}
return -1;
}
private int BinarySearch(int [] array, int value)
{
int n = array.Length;
int first = 0;
int last = array.Length - 1;
while (first <= last)
{
//compute mid index
int mid = (first + last) / 2;
//check if value is at mid
if (value == array[mid])
return mid;
//check if mid is the upper/right section
else if (value > array[mid])
//move first to mid + 1
first = mid + 1;
else //imply value could be in lower/left section
last = mid - 1;
}
return -1;
}
private void btnBinarySearch_Click(object sender, EventArgs e)
{
////create a random array
//Random rand = new Random();
//int[] array = new int[12];
//for (int i = 0; i < array.Length; i++)
//{
//    array[i] = rand.Next(10, 50);
//}
int value = 0;
try
{
value = int.Parse(textBox1.Text);
}
catch (FormatException fe)
{
MessageBox.Show(fe.Message);
}
int bs =  binarySearch(array, value);
Display(value,bs);
}
private void btnInsertionSort_Click(object sender, EventArgs e)
{
//test insertion sort
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
array[i] = rand.Next(10, 50);
}
//display array before insertion sort
richTextBox1.Text = "array before insertion sort: \n";
Display(array);
//insertion sort
InsertionSort(array);
richTextBox1.AppendText("\narray after insertion sort: \n");
Display(array);
}
int[] givenArray = { 15, 8, 19, 12, 4, 10, 6, 19 }; //the given 
array with 8 values
private void btnCompare_Click(object sender, EventArgs e)
{
richTextBox1.Clear();
try
{
//get array size
int n = int.Parse(txtArraySize.Text);
//create 2 arrays, one for each sort method
//populate them with same data (random)
int[] array1 = new int[n];
InitializeArray(array1);
int[] array2 = new int[n];
int[] array3 = new int[n];
//new array for
//copy array1 to array2 so they hold same values
Array.Copy(array1, array2, n);
Array.Copy(array1, array3, n);
//---------------------------------------------
//time both the bubblesort and the insertion
//use a stopwatch defined in System.Diagnostics
Stopwatch sw = new Stopwatch(); //for bubble sort
Stopwatch sw2 = new Stopwatch(); //for insertion sort
Stopwatch sw3 = new Stopwatch(); //selection sort
//start the stopwatch
sw.Start();
//run code
BubbleSort(array1);
//stop the stopwatch
sw.Stop();
//same for insertion sort
//--------------------------------
//start the stopwatch
sw2.Start();
//run code
InsertionSort(array2);
//stop the stopwatch
sw2.Stop();
//------------------------------
//start sw3
sw3.Start();
//run code
SelectionSort(array3);
//stop the stopwatch
sw3.Stop();
//display elapsed time
richTextBox1.Text =
$"Bubble sort elapse time: {sw.Elapsed} \n" +
$"Insertion sort elapsed time: {sw2.Elapsed} \n"+
$"Selection sort elapsed time: {sw3.Elapsed}";
}
catch(FormatException fe)
{
MessageBox.Show(fe.Message);
}
}
//method to initialize array with random numbers
private void InitializeArray(int [] array)
{
Random rand = new Random();
int n = array.Length;
for(int i = 0; i < array.Length; i++)
{
array[i] = rand.Next(10,10*n);
}
}
private void btnSelectionSort_Click(object sender, EventArgs e)
{
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
array[i] = rand.Next(10, 50);
}
//display array before insertion sort
richTextBox1.Text = "array before selection sort: \n";
Display(array);
//selection sort
SelectionSort(array);
richTextBox1.AppendText("\narray after selection sort: \n");
Display(array);
}
private void btnSelectionSortGivenArray_Click(object sender, 
EventArgs e)
{
richTextBox1.Text = "given array before selection sort: \n";
Display(givenArray);
Stopwatch sw = new Stopwatch();
sw.Start();
SelectionSort(givenArray);
sw.Stop();
richTextBox1.AppendText("\ngiven array after selection sort: 
");
Display(givenArray);
richTextBox1.AppendText($"\n time elapsed: {sw.Elapsed}");
}
//investigate and apply the binary search
//determine its big O notation
//worst case: O(log n)
//best case: O(1)
//condition for the binary search: array must be sorted
}
}
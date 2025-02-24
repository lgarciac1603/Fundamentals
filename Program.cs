// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Basic data types
int valueI = 5;
double valueD = 3.66;
string valueS = "summer";
bool valueB = false;

Console.Write(valueI.ToString(), valueD, valueS, valueB);

object myVariable = 123;

if ( myVariable.GetType() == typeof(int) ) {
    Console.Write($"The variable {myVariable} is an int");
} else {
    Console.Write($"The variable {myVariable} is not an int");
}

// casting
double piVar = 3.14159;
int piInt = (int)piVar;
Console.Write(piInt);

// parsing
string numberString = "123";
int numberInt = int.Parse(numberString);
Console.Write(numberInt);

// excercise #1
// Initialize an array of integers
int[] numbers = { 5, 8, 3, 4, 2 };
int largest = numbers[0];


//// Loop through each number in the array
//foreach ( int number in numbers )
//{
//    // Check if the current number is greater than the largest
//    if ( number > largest )
//    {
//        largest = number;
//    }
//}


// Output the largest number
Console.WriteLine("The largest number is: " + largest);


// excercise #2
// Declare and initialize a number
int number = 42;


// Check if the number is even or odd
if ( number % 2 == 0 )
{
    Console.WriteLine("The number is even.");
}
else
{
    Console.WriteLine("The number is odd.");
}

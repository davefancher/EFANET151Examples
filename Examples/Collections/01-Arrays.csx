using System;

// Demo: Arrays

// Array elements are mutable
// Arrays are fixed size

var myArray = new int[2];
myArray[0] = 1;
myArray[1] = 2;

Console.WriteLine($"myArray[0] = {myArray[0]}");

// Demo: Array Initializers

var myArray2 = new int[] { 1, 2, 3 };

Console.WriteLine($"myArray2[0] = {myArray2[0]}");

// Demo: Implicitly Typed Arrays

var myArray3 = new[] { 1, 2, 3 };

Console.WriteLine($"myArray3[0] = {myArray3[0]}");

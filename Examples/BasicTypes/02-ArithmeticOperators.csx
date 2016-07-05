// Demo: Assignment Operator

var x = 0;			// Assignment (not equality!)

// Demo: Arithmetic Operators

var sum = 32 + 10;	// Addition
var diff = 52 - 10; // Subtraction
var prod = 21 * 2;	// Multiplication
var quot = 168 / 4; // Division
var mod = 42 % 5;	// Modulo (remainder)

// Demo: Increment & Decrement Operators

x++;    // Increment (Postfix)
x--;    // Decrement (Postfix)
++x;    // Increment (Prefix)
--x;    // Decrement (Prefix)

// Demo: Compound Assignment

x += 42;
x -= 42;
x *= 42;
x /= 42;

// Demo: Boolean Operators

var eq = 10 == 5;
var ne = 10 != 5;
var gt = 10 > 5;
var lt = 10 < 5;
var gte = 10 >= 5;
var lte = 10 <= 5;

// Demo: Comparative Operators

var condition1 = true;
var condition2 = false;

var both = condition1 && condition2; 	// Short-circuited
var either = condition1 || condition2;	// Short-circuited
var oneOf = condition1 ^ condition2;

Console.WriteLine(both);
Console.WriteLine(either);
Console.WriteLine(oneOf);

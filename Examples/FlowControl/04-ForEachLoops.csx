using System;
using System.Linq;

// Demo: Foreach Loop
// Anything that implements the IEnumerable interface

var a = new[] { 1, 2, 3, 4, 5 };
foreach (var x in a) Console.WriteLine(x);

var a2 = Enumerable.Range(0, 100);
foreach (var x in a2) Console.WriteLine(x);

foreach (var c in "Hello World!") Console.WriteLine(c);

var doctors = new List<string> { "Eccleston", "Tennant", "Smith", "Capaldi" };
foreach(var doctor in doctors)
{
    Console.WriteLine($"Doctor: {doctor}");
}

// Demo: How ForEach works
var enumerator = Enumerable.Range(0, 10).GetEnumerator();
while(enumerator.MoveNext())
{
    Console.WriteLine($"Current = {enumerator.Current}");
}
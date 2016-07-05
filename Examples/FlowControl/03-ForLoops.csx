using System;

// Demo: For Loop

for(var x = 0; x < 100; x++)
{
    Console.WriteLine(x);
}

// Demo: Looping over a collection with for

var doctors = new List<string> { "Eccleston", "Tennant", "Smith", "Capaldi" };
for (var x = 0; x < doctors.Count; x++)
{
    Console.WriteLine("Doctor: {0}", doctors[x]);
}

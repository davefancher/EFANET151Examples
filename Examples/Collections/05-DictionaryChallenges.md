# SILVER:
Create a Dictionary that has all of the academy award winners for best picture from 2000-2005.

<!--
using System.Collections.Generic;

var bestPictureWinners =
    new Dictionary<int, string>
    {
        { 2000, "Gladiator" },
        { 2001, "A Beautiful Mind" },
        { 2002, "Chicago" },
        { 2003, "The Lord of the Rings: The Return of the King" },
        { 2004, "Million Dollar Baby" },
        { 2005, "Crash" }
    };
-->

# GOLD: 
1. Create a Dictionary of Best Picture Nominees that has the year as the key and an array of movies as the values for the same years.
2. Iterate over that Dictionary and print the values to the console.
3. Filter the dictionary to only the nominees between a pair of years

<!--
var bestPictureNominees =
    new Dictionary<int, string[]>
    {
        { 2000, new [] { "Gladiator", "Chocolat", "Crouching Tiger, Hidden Dragon", "Erin Brockovich", "Traffic" } },
        { 2001, new [] { "A Beautiful Mind", "Gosford Park", "In the Bedroom", "The Lord of the Rings: The Fellowship of the Ring", "Moulin Rouge!" } }
        // ...and so on    
    };

foreach(var kvp in bestPictureNominees)
{
    Console.WriteLine(kvp.Key);

    foreach(var nominee in kvp.Value)
    {
        Console.WriteLine($"\t{nominee}");
    }
}
-->

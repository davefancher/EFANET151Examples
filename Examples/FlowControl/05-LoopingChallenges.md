# BRONZE:
Use the ch type to print "Hello World" going vertically down the page.

<!--
foreach (var ch in "Hello World")
{
	Console.WriteLine(ch);
}    
-->

# SILVER: 
Do the same thing in a single line.

<!--
foreach (var ch in "Hello World")
{
	Console.Write(ch);
}

Console.WriteLine();
-->

# GOLD: 
1. Print your name using an array built with chars.

<!--
var chars = new[] { 'D', 'a', 'v', 'e' };
foreach(var ch in chars) Console.Write(ch);
-->

2. Use Unicode characters to print your name.

<!--
// http://unicode.org/charts/PDF/U0000.pdf

var chars = new[] { '\u0044', '\u0061', '\u0076', '\u0065' };
foreach(var ch in chars) Console.Write(ch);
-->

3. Use the hexadecimal char array with a foreach loop to print your name going down the console.

<!--
// http://www.asciitable.com/

var chars = new[] { '\x44', '\x61', '\x76', '\x65' };
foreach(var ch in chars) Console.Write(ch);
-->

# References
* [char](https://msdn.microsoft.com/en-us/library/x9h8tsay.aspx)
* [foreach](https://msdn.microsoft.com/en-us/library/ttw7t8t6.aspx)

using System;

// Demo: Detecting Types
var t1 = 123.GetType();
var t2 = "123".GetType();
var x = new StringBuilder();
var t3 = x.GetType();

// Demo: Converting Strings to Numbers
var s1 = int.Parse("123");

int s2;
var pr = int.TryParse("123", out s2);

// Demo: Converting arbitrary values to strings
var s0 = 123.ToString();

// Demo: Casting

short sh = 32767;
byte by = 255;

// You can cast types to other types, as long as they can be converted. For example, a string cannot be converted 
// to a number implicitly. Values must also be in range, so an int can't always be cast to a short. You can cast DOWN the list, not UP.

//by = (short)sh; // doesn't work
sh = (short)by; // does work

// Demo: Convert class

var b = Convert.ToByte("123");
var i = Convert.ToInt32(12.34f);
var s = Convert.ChangeType(123, typeof(Single));

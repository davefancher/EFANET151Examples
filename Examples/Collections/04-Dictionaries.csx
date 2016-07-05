using System;
using System.Collections.Generic;

// Demo: Dictionaries

// Dictionaries are key/value pairs

var myDict = new Dictionary<string, int>();
myDict.Add("Sunday", 1);
myDict.Add("Monday", 2);

Console.WriteLine("myDict[\"Monday\"] = {0}", myDict["Monday"]);

// Demo: Object Initializer Syntax - Dictionaries

var myDict2 = new Dictionary<string, int> {
    { "Sunday", 1 },
    { "Monday", 2 }
};

Console.WriteLine("myDict2[\"Monday\"] = {0}", myDict2["Monday"]);

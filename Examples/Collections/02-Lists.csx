using System;
using System.Collections.Generic;

// Demo: Lists

// Lists elements are mutable
// Lists resize as needed
// Internally lists are arrays that the list type automatically copies to new arrays as more space is needed

var myList = new List<int>();
myList.Add(1);
myList.Add(2);

Console.WriteLine($"myList[1] = {myList[1]}");

// Demo: List Initializer Syntax

var myList2 =
    new List<int>
    {
        1,
        2
    };

Console.WriteLine($"myList2[1] = {myList2[1]}");
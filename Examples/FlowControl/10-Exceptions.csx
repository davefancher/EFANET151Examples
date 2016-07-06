using System;

public string Reverse(string str)
{
    if (str == null) throw new ArgumentNullException("Input string was null");
    if (str.Length == 0) throw new ArgumentException("Nothing to reverse");

    var reversed = new StringBuilder();

    for (var p = str.Length - 1; p >= 0; p--)
    {
        reversed.Append(str[p]);
    }

    return reversed.ToString();
}

var reversed = Reverse("Hello World!");
Console.WriteLine(reversed);

// TODO: Catch the general exception
// TODO: Catch both exception types independently
// TODO: Show exception filters?
// TODO: Show the finally block

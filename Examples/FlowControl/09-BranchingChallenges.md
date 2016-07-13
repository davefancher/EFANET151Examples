# BRONZE
Given a number from 1-5 display a message indicating how you're feeling.

For instance, given 5, you might print a response that says something like:

    Great to hear that you're feeling so well!

<!--
var feeling = 6;

switch (feeling)
{
    case 1:
        Console.WriteLine("Dang. We hope your day gets better!");
        break;
        
    case 2:
        Console.WriteLine("Oh. Sorry to hear that.");
        break;
        
    case 3:
        Console.WriteLine("Hope things get better!");
        break;
        
    case 4:
        Console.WriteLine("Good stuff!");
        break;
        
    case 5:
        Console.WriteLine("Great to hear that you're feeling so well!");
        break;
        
    default:
        Console.WriteLine("Sorry, we don't understand. Come back later.");
        break;	
}
-->

# SILVER
Create a sequence of names and print out only those names that begin with a certain character

<!--
var names = new[] { "Dave", "Kevin", "D'Arcy", "Esther", "Heath", "Dilbert" };

foreach (var name in names)
{
    if(name.StartsWith("D")) Console.WriteLine(name);
}
-->

# GOLD
Create a sequence of names and print out only those names that begin with a certain character. If the name is your name, display it in all caps.

<!--
var names = new[] { "Dave", "Kevin", "D'Arcy", "Esther", "Heath", "Dilbert" };

foreach (var name in names)
{
    if (name.StartsWith("D"))
    {
        Console.WriteLine(name.Equals("Dave") ? name.ToUpper() : name);
    }
}
-->
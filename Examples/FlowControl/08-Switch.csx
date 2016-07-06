var x = 10;

// Demo: Switch

switch (x)
{
    case 10:
        Console.WriteLine("x is 10");
        break;  // Flow cannot fall through to another branch. Break or return required

    case 20:
        Console.WriteLine("x is 20");
        break;

    default:
        Console.WriteLine("x is neither 10 nor 20");
        break;
}

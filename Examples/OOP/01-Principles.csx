// Encapsulation
// bundling data and behavior into a single entity
// data-hiding through access modifiers

public class MyClass
{
	private string _value = "";
	
	public string Value
	{
		get { return _value; }
		set { _value = value; }
	}
}

var mc = new MyClass();

// Error
// mc._value = "abc";

// Valid
mc.Value = "abc";

// Inheritance
// Using data and methods from one type from another as if they were defined on the second

// ToString - there's no ToString on MyClass; it comes from Object
Console.WriteLine(mc.ToString());

// Polymorphism
// An object can be treated as both itself and any of its base types

string WhatIsIt(object o)
{
	if (o is MyClass) return "MyClass";
	if (o is string) return "String";
	
	return "Object";
}

Console.WriteLine(WhatIsIt(mc));
Console.WriteLine(WhatIsIt("Hello"));
Console.WriteLine(WhatIsIt(new object()));
Console.WriteLine(WhatIsIt(null));

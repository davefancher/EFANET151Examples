# BRONZE 

1. Create a MobilePhone class for mobile devices.
2. Add two properties:
    * Make
    * Model
2. Create a constructor that allows these two arguments to be passed in for a new instance.
3. Override the ToString method to return the make and model
4. Create a new phone object that identifies what kind of phone you have, and print to the console.

**Example**

    iPhone 6.

<!--
using System;

public class MobilePhone
{
	public MobilePhone(string make, string model)
	{
		Make = make;
		Model = model;
	}
	
	public string Make { get; set; }
	public string Model { get; set; }
	
	public override string ToString() => $"{Make} {Model}";
}

var myPhone = new MobilePhone("Galaxy", "Note 5");
Console.WriteLine(myPhone);
-->
	
# SILVER

1. Print a list of five friends and the phone each owns. 

**Example**

    Larissa: iPhone 6.
    Ava: iPhone 5.
    Ken: Galaxy Note 5.
    ...

<!--
var phones = new Dictionary<string, MobilePhone>
{
	{ "Kevin", new MobilePhone("iPhone", "6") },
	{ "Esther", new MobilePhone("Lumia", "920") }
	// ...
};

foreach(var kvp in phones) Console.WriteLine("{0}: {1}", kvp.Key, kvp.Value);
-->

# GOLD

1. Make the MobilePhone class abstract
2. Add a Manufacturer property
3. Extend the constructor to accept the Manufacturer as well as the Make and Model
4. Create derived classes for various manufacturers (Samsung, Apple)
5. Chain the derived class constructors to the base constructor passing the manufacturer name along with user-specified Make and Model

<!--
using System;

public abstract class MobilePhone
{
	public MobilePhone(string manufacturer, string make, string model)
	{
		Manufacturer = manufacturer;
		Make = make;
		Model = model;
	}
	
	public string Manufacturer { get; set; }
	public string Make { get; set; }
	public string Model { get; set; }
	
	public override string ToString() 
	{
		return String.Format("{0} {1} {2}", Manufacturer, Make, Model);
	}
}

public class MicrosoftPhone
	: MobilePhone
{
	public MicrosoftPhone(string make, string model)
		: base("Microsoft", make, model)
	{
	}
}

var esthersPhone = new MicrosoftPhone("Lumia", "920");
Console.WriteLine(esthersPhone);
-->

# PLATINUM

Add validation to ensure that the Make and Model are valid for each manufacturer

<!--
public class MicrosoftPhone
	: MobilePhone
{
	public MicrosoftPhone(string make, string model)
		: base("Microsoft", make, model)
	{
		if(make != "Lumia") throw new ArgumentException("Unrecognized make");
	}
}
-->

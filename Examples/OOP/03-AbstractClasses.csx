using System;

public abstract class Person
{
	private readonly string _firstName;
	private readonly string _lastName;
	
	public Person(string firstName, string lastName)
	{
		_firstName = firstName;
		_lastName = lastName;
	}
	
	public string FirstName { get { return _firstName; } }
	public string LastName { get { return _lastName; } }
	
	public override string ToString()
	{
		return String.Format("{0}, {1}", _lastName, _firstName);
	}
}

// Error: cannot instantiate abstract class
// var one = new Person("William", "Hartnell");

// Uncomment sealed to prevent further inheritance

public /* sealed */ class Doctor
	: Person // Single inheritance
{
	private readonly int _generation;
	
	public Doctor(string firstName, string lastName, int generation)
		: base(firstName, lastName)
	{
		_generation = generation;
	}
	
	public int Generation { get { return _generation; } }
	
	public override string ToString()
	{
		// Overriding Person.ToString(); note how first name and last name are accessed
		return String.Format("{0}. {1}, {2}", _generation, base.FirstName, this.LastName);
	}
}

var one = new Doctor("William", "Hartnell", 1);
Console.WriteLine(one);

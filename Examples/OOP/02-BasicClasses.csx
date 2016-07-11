using System;

// Access Modifiers:
// - Public
// - Private
// - Internal
// - Protected Internal

public class Person
	// Note that Person implicitly inherits from Object
{
	private string _firstName; // private field has a default value of Empty String; private is default but I like to be explicit
	private string _lastName;
	
	public Person()
		//: this("", "") /* Uncomment for constructor chaining */
	{
		// Default constructor.
	}
	
	public Person(String f, String l)
	{
		_firstName = f;	// Note that above rule isn't being enforced because we're not calling the setter!
		_lastName = l;
	}

	public string FirstName // public property, ENFORCING BUSINESS RULES
	{
		get {
			return _firstName;
		}
		set {
			_firstName = value.Trim(); // clean up values before we store them - this is a "business rule"
		}
	}
	
	public string LastName
	{
		get { return _lastName; }
		set { _lastName = value; /* Not enforcing rule */ }
	}
	
	public char MiddleInitial { get; set; } // Auto-implemented property; note that C# 6 extends this
	
	// Override
	public override string ToString()
	{
		return String.Format("{0}, {1}", _lastName, _firstName);
	}
}

// Instantiate w/ default constructor
// Classes define the type, a blueprint of sorts
// Objects are instances of a class that exist in memory
// - Don't confuse an object with the Object type from which all things derive

var one = new Person();
one.FirstName = "William";
one.LastName = "Hartnell";
Console.WriteLine(one);

// Instantiate w/ alternate constructor
var two = new Person("Patrick", "Troughton");
Console.WriteLine(two);

// Object initializer syntax
var three = new Person { FirstName = "John", LastName = "Pertwee" };
Console.WriteLine(three);


public class Student
	: Person // Single Inheritance
{
	public Student()
		: base()
	{
	}
	
	public Student(int id, string firstName, string lastName)
		: base(firstName, lastName)
	{
		StudentId = id;
	}
	
	public int StudentId { get; set; }

    // C# 6 Immutable Auto-property
    // Shortcut for property with readonly backing field.
    //public int StudentId { get; }
	
	public override string ToString()
	{
		return String.Format("{0}, {1} ({2})", LastName, FirstName, StudentId);
	}
}

var rose = new Student(1, "Rose", "Tyler");
Console.WriteLine(rose);

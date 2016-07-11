using System;

// Common interfaces in .NET
// - IEnumerable<T>
// - IQueryable<T>
// - IComparable<T>

// Implement, not inherit

public interface IPerson
{
	string FirstName { get; set; }
	string LastName { get; set; }
}

// Implicit implementation

public class Person
	: IPerson
{
	public string FirstName { get; set; }
	public string LastName { get; set; }
}

var one = new Person { FirstName = "William", LastName = "Hartnell" };
ShowPerson(one);
Console.WriteLine();


// Explicit implementation

public class Doctor
	: IPerson
{
	string IPerson.FirstName { get; set; }
	string IPerson.LastName { get; set; }
}

// Error: Explicit implementation hides members
//var twelve = new Doctor { FirstName = "Peter", LastName = "Capaldi" }; 
IPerson twelve = new Doctor(); // Polymorphic behavior
twelve.FirstName = "Peter";
twelve.LastName = "Capaldi";

ShowPerson(twelve);


// Helper function

public void ShowPerson(IPerson p)
{
	Console.WriteLine("{0}, {1}", p.LastName, p.FirstName);
}



public interface IDateTimeService
{
	DateTime GetCurrent();
}

public class DateTimeService
	: IDateTimeService
{
	public DateTime GetCurrent()
	{
		return DateTime.Now;
	}
}

public class MockDateTimeService
	: IDateTimeService
{
	public DateTime GetCurrent()
	{
		return DateTime.Parse("2015-10-11T16:00:00Z");
	}
}

var dts = new MockDateTimeService();
dts.GetCurrent().ToString("O").Dump();

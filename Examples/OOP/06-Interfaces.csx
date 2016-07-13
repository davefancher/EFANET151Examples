#r "System.Windows.Forms.dll"

// Common interfaces in .NET
// - IEnumerable<T>
// - IQueryable<T>
// - IComparable<T>

// Implement, not inherit

using System;
using System.Windows.Forms;

public interface IGreeter
{
    void SayHello(string name);
}

// Implicit Implementation

public class ConsoleGreeter
    : IGreeter
{
    public void SayHello(string name)
    {
        Console.WriteLine($"Hello, {name}");
    }
}

// Explicit Implementation

public class WindowsGreeter
    : IGreeter
{
    void IGreeter.SayHello(string name)
    {
        MessageBox.Show($"Hello, {name}", "Greetings");
    }
}

// Dependency Injection (DI)

public class Person
{
    private readonly IGreeter _greeter;

    public Person(IGreeter greeter)
    {
        _greeter = greeter;
    }

    public string Name { get; set; }

    public void Greet()
    {
        _greeter.SayHello(Name);
    }
}

var me = new Person(new WindowsGreeter()) { Name = "Dave" };
me.Greet();

// ----------

public interface IDateTimeService
{
    DateTime GetCurrent();
}

public class RealDateTimeService
    : IDateTimeService
{
    public DateTime GetCurrent()
    {
        return DateTime.Now;
    }
}

public class FakeDateTimeService
    : IDateTimeService
{
    private readonly DateTime _testDate;

    public FakeDateTimeService(DateTime date)
    {
        _testDate = date;
    }

    public DateTime GetCurrent()
    {
        return _testDate;
    }
}

var svc = new MockDateTimeService();
Console.WriteLine($"{svc.GetCurrent():O}");


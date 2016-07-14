using System;
using System.Collections.Generic;
using System.Text;

// Part 1

// 1

int yearsMarried = 14;
bool isTrue = false;
string spouseName = "Esther";
double dbl = 0.5;
decimal dec = 0.5m;

// 2

string BuildMessage(string spouseName, int yearsMarried)
{
    return $"I have been happily married to {spouseName} for {yearsMarried} years.";
}

// 3
var message = BuildMessage(spouseName, yearsMarried);
Console.WriteLine(message);

// 4
var names =
    new[]
    {
        "Esther",
        "Nadia",
        "Kevin",
        "D'Arcy",
        "Adam"
    };

// 5
foreach (var name in names) Console.WriteLine(name);

// Part 2

// 1
public enum Gender
{
    Unknown,
    Male,
    Female
}

// 1
public class Customer
{
    // 2
    public Customer(string name, Gender gender, string product)
    {
        Name = name;
        Gender = gender;
        Product = product;
    }

    public string Name { get; set; }
    public Gender Gender { get; set; }
    public string Product { get; set; } 

    // 3
    public void SayThanks()
    {
        Console.WriteLine($"Hello {Name}, thank you for purchasing the {Product}. We hope you enjoy it!");
    }

    // 4
    public void SendSaleNotice(DateTime saleDate)
    {
        Console.WriteLine($"Hello {Name}, We wanted to let you know there's a sale coming up on {saleDate:yyyy-MM-dd}");
    }

    public void SendSaleNotice(string product, DateTime saleDate)
    {
        Console.WriteLine($"Hello {Name}, We wanted to let you know there's a sale on {product} coming up on {saleDate:yyyy-MM-dd}");
    }

    // 9
    public virtual void PrintCustomerInfo()
    {
        Console.WriteLine($"{Name} - {Gender} - {Product}");
    }
}

// 5
public sealed class InactiveCustomer
    : Customer
{
    // 10
    public enum InactiveReason
    {
        Unknown,
        Irate,
        Moved,
        Uninterested
    }

    // 6
    public InactiveCustomer(string name, Gender gender, string product, int monthsInactive)
        : base(name, gender, product)
    {
        MonthsInactive = monthsInactive;
    }

    public int MonthsInactive { get; set; }

    // 11
    public InactiveReason Reason { get; set; }

    // 7
    public void SendRetargetMessage()
    {
        var message =
            new StringBuilder($"Thanks for shopping with us, {Name}. ")
                .Append($"We saw that you purchased a {Product} from us {MonthsInactive} months ago. ")
                .Append("We'd like to know if you'd like to take a look at some of our current deals.")
                .ToString();
        Console.WriteLine(message);
    }

    // 12
    public override void PrintCustomerInfo()
    {
        Console.WriteLine($"{Name} - {Gender} - {Product} - {Reason}");
    }
}

// 8
var customer = new Customer("Dave", Gender.Male, "Macbook Pro");
customer.SayThanks();
customer.SendSaleNotice(DateTime.Parse("2016-08-01"));
customer.SendSaleNotice("LEGO", DateTime.Parse("2016-08-01"));
customer.PrintCustomerInfo();

var inactiveCustomer =
    new InactiveCustomer("Esther", Gender.Female, "Scrapbook", 4)
    {
        Reason = InactiveCustomer.InactiveReason.Uninterested
    };
inactiveCustomer.SayThanks();
inactiveCustomer.SendRetargetMessage();
inactiveCustomer.PrintCustomerInfo();

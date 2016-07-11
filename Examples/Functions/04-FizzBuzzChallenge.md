# Bronze Challenge

Write a function that prints the integers from 1 to 100.
* For multiples of three print "Fizz" instead of the number
* For the multiples of five print "Buzz". 
* For numbers which are multiples of both three and five print "FizzBuzz".

<!--
using System;

void FizzBuzz()
{
	for(var i = 1; i <= 100; i++)
	{
		if(i % 15 == 0)
		{
			Console.WriteLine("FizzBuzz");
		}
		else if(i % 3 == 0)
		{
			Console.WriteLine("Fizz");
		}
		else if(i % 5 == 0)
		{
			Console.WriteLine("Buzz");
		}
		else
		{
			Console.WriteLine(i);
		}
	}
}

FizzBuzz();
-->

# Silver Challenge

1. Extract the FizzBuzz logic to a separate function that returns the appropriate string for a given integer.
2. Revise the original function to invoke the new function.

<!--
using System;

string GetFizzBuzzValue(int value)
{
	if(value % 15 == 0)
	{
		return "FizzBuzz";
	}
	
	if(value % 3 == 0)
	{
		return "Fizz";
	}
	
	if(value % 5 == 0)
	{
		return "Buzz";
	}

	return value.ToString();
}

void FizzBuzz()
{
	for(var i = 1; i <= 100; i++)
	{
		var v = GetFizzBuzzValue(i);
		Console.WriteLine(v);
	}
}

FizzBuzz();
-->

# Gold Challenge

1. Use LINQ to transform the sequence of integers from 1 to 100 to a sequence of FizzBuzz values using the function from the previous challenge.
2. Print the resulting sequence to the console.

## References

* [Enumerable.Range](https://msdn.microsoft.com/en-us/library/system.linq.enumerable.range(v=vs.110).aspx)
* [Select method](https://msdn.microsoft.com/en-us/library/bb548891(v=vs.110).aspx)

<!--
Enumerable
	.Range(1, 100)
	.Select(GetFizzBuzzValue)
	.ToList()
	.ForEach(Console.WriteLine);
-->
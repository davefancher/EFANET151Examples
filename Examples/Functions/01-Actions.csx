using System;

void SayHello()
{
	Console.WriteLine("Hello, world");
}

void SayHello(string name)
{
	Console.WriteLine($"Hello, {name}");
}

SayHello();

SayHello("Dave");

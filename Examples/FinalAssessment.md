# C# Summative Assessment

The Final Challenge

* Do your best on this assessment. Get as far as you can in 120 minutes. 
* Note that we will consider partial answers, so if your code is close and not working, feel free to comment out your answer.
* Feel free to reference any other work you've done or refer to online resources to complete your answers. 
* Please PUT A NUMBERED COMMENT in the general vicinity of your answer so that we know where you're answering the question. 

# Part One: The Basics

1. Declare and initialize 5 different types. Int, Boolean, String, Double, Decimal

2. Write a function that takes two of your variables from #1 and combines two or more of them into a string. For instance:

    > I have been happily married to Esther for 14 years.

3. Print the string to the console.

4. Create an array of strings, a simple array of 3-5 names of your closest friends or family will suffice.

5. Loop over the array and print it to the console.

# Part Two: OOP

1. Create a class called Customer. The class should have three properties: Name, Gender, and Purchase. You should also create an Enum called Gender. The 0 spot should be Unknown, the 1 spot should be Male, and the 2 spot should be Female.

2. Create a constructor for the Customer class that allows you to more easily create Customer objects. The constructor should have parameters for name, gender, and purchase. Remember that gender will be an enum, so the enum name will be its type.

3. Create a method in your Customer class that simulates sending a thank you to the customer after their purchase by writing the message to the console. Your console message might read something like this:

    > Hello {Name}, thank you for purchasing the {product}. We hope you enjoy it! 

4. Create two more methods. They should both be called SendSaleNotice. One should accept only a date as a parameter and the other one is an overload of that same method which should accept both a date and a string as parameters. Use these methods to announce sales. Your methods should print something similar to these messages:

    > Hello Dave, We wanted to let you know there's a sale coming up on 4/1/2016.

    > Hello Dave, We wanted to let you know there's a sale on Apple iPhones coming up on 4/1/2016.

5. Create a subclass of Customer called InactiveCutomer. The class should have an int property called MonthsInactive, and other programmers SHOULD NOT be able to create subclasses from it. (*hint: [Sealed Modifier](http://bit.ly/29Rb2mZ)*)

6. In the InactiveCustomer subclass, create a constructor that uses the base keyword that adds a monthsInactive parameter.

7. In the InactiveCustomer subclass create a method that sends a message to a customer who has been inactive for over four months. The console would read something like this:

	> Thanks for shopping with us {name}. We saw that you purchased an {product} from us {monthsInactive} MONTHS AGO. We'd like to know if you'd like to take a look at some of our current deals.

8. You should, of course, create instances of these classes, set the properties via the constructors, and test the methods on those objects.

9. Add an overridable method to the Customer class called PrintCustomerInfo. (*hint: [Virtual Modifier](http://bit.ly/29RbbXI)*) The method should print the name purchase, and gender of the customer. It could go like this:

    > Paul - Fender Jazz Bass Guitar - Male. 

10. Add an enum to the InactiveCustomer class that gives a couple reasons why a customer might not be purchasing. The reasons might be Irate, Moved, Uninterested

11. Add a method called PrintCustomerInfo that overrides the one from the Customer class. You should print Name, product purchased, gender, months inactive, and reason for inactivity. For example:

	> Michael - desk - Male - 4 - Moved
